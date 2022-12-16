using Cosis.Models;
using Cosis.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Cosis.Controllers
{
    public class Form2_1Controller : Controller
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
        [HttpPost("/form2_1")]
        public IActionResult InsertForm2_1(PhieuDieuTra phieu, IFormCollection form, int loai)
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
            Console.WriteLine(phieu.Master.MaCoSo);
            if (phieu.Master.MaSoThue != null)
            {
                phieu.Master.MaSoThue2 = phieu.Master.MaSoThue.Substring(10);
                phieu.Master.MaSoThue = phieu.Master.MaSoThue.Substring(0, 10);
                var checkMST = context.ThongTinDoanhNghiep.FromSqlRaw("select*from ThongTinDoanhNghiep where MaSoThue = {0} and MaSoThue2 = {1}", phieu.Master.MaSoThue, phieu.Master.MaSoThue2).FirstOrDefault();
                if(checkMST != null){

                }else{
                    phieu.Master.MaSoThue = null;
                    phieu.Master.MaSoThue2 = null;
                }
            }
            //
            var check = context.Master.FromSqlRaw("select*from Master where MaSoThue = '" + phieu.Master.MaSoThue + "' and MaSoThue2 = '" + phieu.Master.MaSoThue2 + "' and MaCoSo = '" + phieu.Master.MaCoSo + "' and ThangThucHien = '" + phieu.Master.ThangThucHien + "' and ThangDuTinh = '" + phieu.Master.ThangDuTinh + "' and Nam = '" + phieu.Master.Nam + "'").ToList();
            if (phieu.Master.MaSoThue != null && phieu.Master.MaCoSo != null)
            {
                Console.WriteLine("Da vao 1");
            }
            else if (phieu.Master.MaSoThue != null && phieu.Master.MaCoSo == null)
            {
                Console.WriteLine("Da vao 2");
                check = context.Master.FromSqlRaw("select*from Master where MaSoThue = '" + phieu.Master.MaSoThue + "' and MaCoSo = '" + phieu.Master.MaCoSo + "' and ThangThucHien = '" + phieu.Master.ThangThucHien + "' and ThangDuTinh = '" + phieu.Master.ThangDuTinh + "' and Nam = '" + phieu.Master.Nam + "'").ToList();
            }
            else if (phieu.Master.MaCoSo != null && phieu.Master.MaSoThue == null)
            {
                Console.WriteLine("Da vao 2");
                check = context.Master.FromSqlRaw("select*from Master where MaCoSo = '" + phieu.Master.MaCoSo + "' and ThangThucHien = '" + phieu.Master.ThangThucHien + "' and ThangDuTinh = '" + phieu.Master.ThangDuTinh + "' and Nam = '" + phieu.Master.Nam + "'").ToList();
            }
            //
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
                // Console.WriteLine(phieu.NhanToThu9.NoiDung);
            }
            foreach (DanhSachNhanToAnhHuong ds in phieu.DanhSachNhanToAnhHuong)
            {
                // Console.WriteLine(ds);
                context.Database.ExecuteSqlRaw("insert into DanhSachNhanToAnhHuong values({0},{1})",phieu.Master.MaPhieu,ds.MaAh);
            }
            int x = 0;
            foreach (Detail dt in phieu.Detail)
            {
                if (dt.ThthangTruoc != 999999999 && dt.DuTinh != 999999999)
                {
                context.Database.ExecuteSqlRaw("INSERT INTO [dbo].[Detail]([MaPhieu],[STT],[TenCT],[DVT],[THThangTruoc],[DuTinh],[TongCongDon]) values({0},{1},{2},{3},{4},{5},{6})", phieu.Master.MaPhieu,dt.Stt,dt.TenCt,dt.Dvt,dt.ThthangTruoc,dt.DuTinh,dt.TongCongDon);
                }
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
                var pdf = fullView.ConvertUrl("https://localhost:5001/form2_1PDF/"+phieu.Master.MaPhieu);
                var pdfBytes = pdf.Save();
                return File(pdfBytes, "application/pdf", phieu.Master.MaPhieu + ".pdf");
            }
            if(loai == 2){

            }
            if(loai == 3){

            }
            return RedirectToAction("Index");
        }

        [HttpPost("/get-tong2")]
        public decimal? getTongDauNam(string mast, string stt, decimal thangTrc, decimal duTinh, string mcs)
        {
            if (mast == null) { return thangTrc + duTinh; }
            string mast1 = mast.Substring(0, 10);
            string mast2 = mast.Substring(10);
            string thangDuTinh = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            if (mcs == null) { mcs = "00000"; }
            FormCosisContext context = new FormCosisContext();
            SqlParameter[] parameters =
                    {
                        new SqlParameter("@MaSoThue",mast1),
                        new SqlParameter("@MaSoThue2",mast2),
                        new SqlParameter("@MaCoSo",mcs),
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
        [Route("/In/{maPhieu}")]
        public IActionResult In(string maPhieu)
        { 
          var fullView = new HtmlToPdf();
                fullView.Options.WebPageWidth = 1280;
                fullView.Options.PdfPageSize = PdfPageSize.A4;
                fullView.Options.MarginTop = 40;
                fullView.Options.MarginBottom = 40;
                fullView.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
                var pdf = fullView.ConvertUrl("https://localhost:5001/form2_1PDF/"+maPhieu);
                var pdfBytes = pdf.Save();
                return File(pdfBytes, "application/pdf", maPhieu + ".pdf");  
        }

        [Route("/form2_1PDF/{maPhieu}")]
        public IActionResult Form2_1PDF(string maPhieu)
        { 
            var context = new FormCosisContext();
            // maPhieu = "  ";
            Master master = context.Master.Find(maPhieu);
            PhieuDieuTra phieu = new PhieuDieuTra();
            phieu.Master = master;
            if(master.MaCoSo == null){
            List<NganhKinhDoanh> listNganh =
            context.NganhKinhDoanh.FromSqlRaw("select*from NganhKinhDoanh where MaSoThue ='" + master.MaSoThue + "' and MaSoThue2='" + master.MaSoThue2 + "'").ToList();
            ViewBag.NganhKinhDoanh = listNganh;
            }else{
                 List<NganhKinhDoanh> listNganh =
            context.NganhKinhDoanh.FromSqlRaw("select*from NganhKinhDoanh where MaCoSo ='" + master.MaCoSo + "'").ToList();
            ViewBag.NganhKinhDoanh = listNganh;
            }
            var nt9 = context.NhanToThu9.FromSqlRaw("select*from NhanToThu9 where MaPhieu = '" + maPhieu + "'").ToList().FirstOrDefault();
            if(nt9 == null){
                ViewBag.checkNT9 = "False";
            }else{
                phieu.NhanToThu9 = nt9;
            }
            phieu.DanhSachNhanToAnhHuong = context.DanhSachNhanToAnhHuong.FromSqlRaw("select*from DanhSachNhanToAnhHuong where MaPhieu = '" + maPhieu + "'").ToList();
            phieu.Detail = context.Detail.FromSqlRaw("select*from Detail where MaPhieu = '" + maPhieu + "'").ToList();
           return View(phieu);
        }
    }
}
