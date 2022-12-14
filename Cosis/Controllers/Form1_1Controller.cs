using Cosis.Models;
using Cosis.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelectPdf;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Cosis.Controllers
{
    public class Form1_1Controller : Controller
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/loadTable1-1")]
        public IActionResult LoadTable(string ms)
        {
            ViewBag.MaSoThue1 = ms.Substring(0, 10);
            ViewBag.MaSoThue2 = ms.Substring(10);
            return PartialView("_Table1_3");
        }

        [HttpPost("/form1_1")]
        public IActionResult InsertForm1_3(PhieuDieuTra phieu, IFormCollection form, int loai)
        {
            FormCosisContext context = new FormCosisContext();
            List<DanhSachNhanToAnhHuong> list = new List<DanhSachNhanToAnhHuong>();
            for (int i = 0; i < 8; i++)
            {
                string name = "DanhSachNhanToAnhHuong" + i;
                string value = form[name];
                if (value != null)
                {
                    list.Add(new DanhSachNhanToAnhHuong(value));
                }

            }
            phieu.DanhSachNhanToAnhHuong = list;

            while (true)
            {
                string maPhieu = RandomString(5);
                if (context.Master.Find(maPhieu) == null)
                {
                    phieu.Master.MaPhieu = maPhieu;
                    break;
                }
            }
            phieu.Master.NgayTao = DateTime.Now;
            phieu.Master.Nam = DateTime.Now.Year.ToString();
            phieu.Master.ThangThucHien = (DateTime.Now.Month - 1).ToString();
            phieu.Master.ThangDuTinh = DateTime.Now.Month.ToString();
            phieu.Master.MaSoThue2 = phieu.Master.MaSoThue.Substring(10);
            phieu.Master.MaSoThue = phieu.Master.MaSoThue.Substring(0, 10);
            phieu.Master.MaCoSo = "00000";
            var check = context.Master.FromSqlRaw("select*from Master where MaSoThue = '" + phieu.Master.MaSoThue + "' and MaSoThue2 = '" + phieu.Master.MaSoThue2 + "'and ThangThucHien = '" + phieu.Master.ThangThucHien + "' and ThangDuTinh = '" + phieu.Master.ThangDuTinh + "' and Nam = '" + phieu.Master.Nam + "'").ToList();
            if (check.Count > 0)
            {
                TempData["ThongBao"] = "Thất bại! Đã điều tra doanh nghiệp trong tháng này!";
                return RedirectToAction("Index");
            }

            context.Master.Add(phieu.Master);
            context.SaveChanges();
            if (phieu.NhanToThu9 != null)
            {
                context.Database.ExecuteSqlRaw("insert into NhanToThu9 values({0},{1})", phieu.Master.MaPhieu, phieu.NhanToThu9.NoiDung);
            }
            foreach (DanhSachNhanToAnhHuong ds in phieu.DanhSachNhanToAnhHuong)
            {
                context.Database.ExecuteSqlRaw("insert into DanhSachNhanToAnhHuong values({0},{1})", phieu.Master.MaPhieu, ds.MaAh);
            }
            foreach (Detail dt in phieu.Detail)
            {
                context.Database.ExecuteSqlRaw("INSERT INTO [dbo].[Detail]([MaPhieu],[STT],[TenCT],[DVT],[THThangTruoc],[DuTinh],[TongCongDon]) values({0},{1},{2},{3},{4},{5},{6})", phieu.Master.MaPhieu, dt.Stt, dt.TenCt, dt.Dvt, dt.ThthangTruoc, dt.DuTinh, dt.TongCongDon);
            }
            TempData["ThongBao"] = "Thành công!";
            if (loai == 1)
            {
                var fullView = new HtmlToPdf();
                fullView.Options.WebPageWidth = 1280;
                fullView.Options.PdfPageSize = PdfPageSize.A4;
                fullView.Options.MarginTop = 40;
                fullView.Options.MarginBottom = 40;
                fullView.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

                var pdf = fullView.ConvertUrl("https://localhost:44358/form1_1PDF/" + phieu.Master.MaPhieu);

                var pdfBytes = pdf.Save();
                return File(pdfBytes, "application/pdf", phieu.Master.MaPhieu + ".pdf");
            }
            if (loai == 2)
            {

            }
            if (loai == 3)
            {

            }
            return RedirectToAction("Index");
        }
        [HttpPost("/form1_1/get-tong")]
        public decimal? getTongDauNam(string mast, string stt, decimal thangTrc, decimal duTinh)
        {
            if (mast == null) { return thangTrc + duTinh; }
            string mast1 = mast.Substring(0, 10);
            string mast2 = mast.Substring(10);
            string thangDuTinh = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            FormCosisContext context = new FormCosisContext();
            SqlParameter[] parameters =
                    {
                        new SqlParameter("@MaSoThue",mast1),
                        new SqlParameter("@MaSoThue2",mast2),
                        new SqlParameter("@MaCoSo","00000"),
                        new SqlParameter("@NgayThucHien",nam),
                        new SqlParameter("@Stt",stt),
                    };
            var a = context.Detail.FromSqlRaw("exec TongCongDon @MaSoThue, @MaSoThue2, @MaCoSo, @NgayThucHien, @Stt", parameters.ToArray()).ToList().FirstOrDefault();
            if (a.ThthangTruoc != null)
                return a.ThthangTruoc + thangTrc + duTinh;
            else
            {
                return thangTrc + duTinh;
            }
        }
        [Route("/form1_1PDF/{maPhieu}")]
        public IActionResult Form1_1PDF(string maPhieu)
        {
            PhieuDieuTra phieu = GetPhieu(maPhieu);
            ViewBag.NganhKinhDoanh = GetNganhKinhDoanhs(phieu.Master.MaSoThue, phieu.Master.MaSoThue2);

            return View(phieu);
        }

        public PhieuDieuTra GetPhieu(string maPhieu)
        {
            FormCosisContext context = new FormCosisContext();
            Master master = context.Master.Find(maPhieu);
            PhieuDieuTra phieu = new PhieuDieuTra();
            phieu.Master = master;
            phieu.NhanToThu9 = context.NhanToThu9.FromSqlRaw("select*from NhanToThu9 where MaPhieu = '" + maPhieu + "'").ToList().FirstOrDefault();
            phieu.DanhSachNhanToAnhHuong = context.DanhSachNhanToAnhHuong.FromSqlRaw("select*from DanhSachNhanToAnhHuong where MaPhieu = '" + maPhieu + "'").ToList();
            phieu.Detail = context.Detail.FromSqlRaw("select*from Detail where MaPhieu = '" + maPhieu + "'").ToList();
            return phieu;
        }

        public List<NganhKinhDoanh> GetNganhKinhDoanhs(string MaSoThue, string MaSoThue2)
        {
            FormCosisContext context = new FormCosisContext();
            return
            context.NganhKinhDoanh.FromSqlRaw("select*from NganhKinhDoanh where MaSoThue ='" + MaSoThue + "' and MaSoThue2='" + MaSoThue2 + "'").ToList();
        }
        string getTinh(string ma)
        {
            FormCosisContext context = new FormCosisContext();
            return context.TinhTp.Find(ma).Name;
        }
        string getHuyen(string ma)
        {
            FormCosisContext context = new FormCosisContext();
            return context.QuanHuyen.Find(ma).Name;
        }
        string getXa(string ma)
        {
            FormCosisContext context = new FormCosisContext();
            return context.PhuongXa.Find(ma).Name;
        }
        NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
        {
            FormCosisContext context = new FormCosisContext();
            return context.NganhHoatDongKinhDoanh.Find(ma);
        }
        NhanToAnhHuong nhanToAnhHuong(string ma)
        {
            FormCosisContext context = new FormCosisContext();
            return context.NhanToAnhHuong.Find(ma);
        }
    }
}
