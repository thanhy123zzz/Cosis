#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac564b214dc918c5665678400ae4523f10e7702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_openList), @"mvc.1.0.view", @"/Views/ThongKe/openList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ProjectC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProjectC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ProjectC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac564b214dc918c5665678400ae4523f10e7702", @"/Views/ThongKe/openList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330bfff8c7c5f9dba2758406de113abfa6a13415", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ThongKe_openList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
  
    FormCosisContext context = new FormCosisContext();
    string maX = ViewBag.ward;
    string maH = ViewBag.district;
    string maT = ViewBag.city;
    string nam = ViewBag.nam;
    string thang = ViewBag.thang;
    string maLoaiPhieu = ViewBag.loaiPhieu;

    string IDDiaChi;
    string name;
    getName();
    void getName()
    {
        TinhTp t = context.TinhTp.Find(ViewBag.city);
        PhuongXa px = context.PhuongXa.Find(ViewBag.ward);
        QuanHuyen h = context.QuanHuyen.Find(ViewBag.district);
        if(px==null){
            if (h == null){
                if (t==null)
                {
                    name = "Tất cả";
                    IDDiaChi = "0";
                }else{
                    name = t.Name;
                    IDDiaChi = t.Id;
                }
            }else{
                name = h.Name;
                IDDiaChi = h.Id;
            }
        }
        else{
            name = px.Name;
            IDDiaChi = px.Id;
        }
    }

    List<Tinh> getListDiaChi(){
        using (System.IO.StreamReader r = new System.IO.StreamReader("D:/ProjectC#/Cosis/Cosis/wwwroot/assets/DiaChi.json"))
        {
            string json = r.ReadToEnd();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tinh>>(json);
        }
    }
    List<Tinh> listDiaChi = getListDiaChi();
    

    string format(int a)
    {
        return a.ToString("N", System.Globalization.CultureInfo.InvariantCulture);
    }
    //----------------------------------------------------------------------
    int getTongDN(){
        if (maX == null || maX.Equals("0"))
        {
            if (maH == null || maH.Equals("0"))
            {
                if (maT == null || maT.Equals("0"))
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.ThongTinDoanhNghiep.ToList().Count();
                    }
                    else
                    {
                        return context.ThongTinDoanhNghiep.Where(x => x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
                    }
                }else{
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.ThongTinDoanhNghiep.Where(x => x.MaTinhTp == maT).ToList().Count();
                    }
                    else
                    {
                        return context.ThongTinDoanhNghiep.Where(x => x.MaTinhTp == maT && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
                    }
                }
            }
            else
            {
                if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                {
                    return context.ThongTinDoanhNghiep.Where(x => x.MaQuanHuyen == maH).ToList().Count();
                }
                else
                {
                    return context.ThongTinDoanhNghiep.Where(x => x.MaQuanHuyen == maH && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
                }
            }
        }else
        {
            if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
            {
                return context.ThongTinDoanhNghiep.Where(x => x.MaPhuongXa == maX).ToList().Count();
            }else{
                return context.ThongTinDoanhNghiep.Where(x => x.MaPhuongXa == maX && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
            }
        }
    }
    int getTongDNDL(string maTinh, string maHuyen, string maXa)
    {
        if (maXa == null || maXa.Equals("0"))
        {
            if (maHuyen == null || maHuyen.Equals("0"))
            {
                if (maTinh == null || maTinh.Equals("0"))
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "'").ToList().Count();
                    }
                    else
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu+"'").ToList().Count();
                    }
                }
                else
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and m.MaTinhTP = '" + maTinh + "'").ToList().Count();
                    }
                    else
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "' and m.MaTinhTP = '" + maTinh + "'").ToList().Count();
                    }
                }
            }
            else
            {
                if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                {
                    return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and m.MaQuanHuyen = '" + maHuyen + "'").ToList().Count();
                }
                else
                {
                    return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "' and m.MaQuanHuyen = '" + maHuyen + "'").ToList().Count();
                }
            }
        }
        else
        {
            if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
            {
                return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and m.MaPhuongXa = '" + maXa + "'").ToList().Count();
            }
            else
            {
                return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinDoanhNghiep t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "'and m.MaPhuongXa = '" + maXa + "'").ToList().Count();
            }
        }
    }
    int tongDN = getTongDN();
    int tongDNDL = getTongDNDL(maT, maH, maX);

    //Cơ sở --------------------------------------------------------------
    int getTongCS()
    {
        if (maX == null || maX.Equals("0"))
        {
            if (maH == null || maH.Equals("0"))
            {
                if (maT == null || maT.Equals("0"))
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.ThongTinCaThe.ToList().Count();
                    }
                    else
                    {
                        return context.ThongTinCaThe.Where(x => x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
                    }
                }
                else
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.ThongTinCaThe.Where(x => x.MaTinhTp == maT).ToList().Count();
                    }
                    else
                    {
                        return context.ThongTinCaThe.Where(x => x.MaTinhTp == maT && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
                    }
                }
            }
            else
            {
                if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                {
                    return context.ThongTinCaThe.Where(x => x.MaQuanHuyen == maH).ToList().Count();
                }
                else
                {
                    return context.ThongTinCaThe.Where(x => x.MaQuanHuyen == maH && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
                }
            }
        }
        else
        {
            if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
            {
                return context.ThongTinCaThe.Where(x => x.MaPhuongXa == maX).ToList().Count();
            }
            else
            {
                return context.ThongTinCaThe.Where(x => x.MaPhuongXa == maX && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
            }
        }
    }
    int getTongCSDL(string maTinh, string maHuyen, string maXa)
    {
        if (maXa == null || maXa.Equals("0"))
        {
            if (maHuyen == null || maHuyen.Equals("0"))
            {
                if (maTinh == null || maTinh.Equals("0"))
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "'").ToList().Count();
                    }
                    else
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "'").ToList().Count();
                    }
                }
                else
                {
                    if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and m.MaTinhTP = '" + maTinh + "'").ToList().Count();
                    }
                    else
                    {
                        return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "' and m.MaTinhTP = '" + maTinh + "'").ToList().Count();
                    }
                }
            }
            else
            {
                if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
                {
                    return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and m.MaQuanHuyen = '" + maHuyen + "'").ToList().Count();
                }
                else
                {
                    return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "' and m.MaQuanHuyen = '" + maHuyen + "'").ToList().Count();
                }
            }
        }
        else
        {
            if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
            {
                return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and m.MaPhuongXa = '" + maXa + "'").ToList().Count();
            }
            else
            {
                return context.Master.FromSqlRaw("select m.[MaSoThue],m.[MaSoThue2],m.[MaCoSo],m.[Ten],m.[MaTinhTP],m.[MaQuanHuyen],m.[MaPhuongXa],m.[DiaChiCuThe],m.[SDT],m.[Email],m.[MaLH],m.[MaPhieu],m.[NgayTao],m.[ThangThucHien],m.[ThangDuTinh],m.[TenNguoiTraLoi],m.[SDTNguoiTraLoi],m.[Nam] from Master m inner join ThongTinCaThe t on t.MaSoThue = m.MaSoThue and t.MaSoThue2 = m.MaSoThue2 and t.MaCoSo = m.MaCoSo where ThangDuTinh = '" + thang + "' and nam = '" + nam + "' and MaLoaiPhieu = '" + maLoaiPhieu + "'and m.MaPhuongXa = '" + maXa + "'").ToList().Count();
            }
        }
    }
    int tongCS = getTongCS();
    int tongCSDL = getTongCSDL(maT, maH, maX);
    float getTiLe(int tong, int b){
        if (tong == 0)
        {
            return 0;
        }
        else
        {
             return ((float)b / (float)tong) * 100;
        }
    }

    //----------------------------------------------------------------------
    int getTongDNT(string maTinh){
        if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
        {
            return context.ThongTinDoanhNghiep.Where(x => x.MaTinhTp == maTinh).ToList().Count();
        }
        else
        {
            return context.ThongTinDoanhNghiep.Where(x => x.MaTinhTp == maTinh && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
        }
    }
    int getTongDNH(string maHuyen){
        if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
        {
            return context.ThongTinDoanhNghiep.Where(x => x.MaQuanHuyen == maHuyen).ToList().Count();
        }
        else
        {
            return context.ThongTinDoanhNghiep.Where(x => x.MaQuanHuyen == maHuyen && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
        }
    }
    int getTongDNX(string maXa){
        if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
        {
            return context.ThongTinDoanhNghiep.Where(x => x.MaPhuongXa == maXa).ToList().Count();
        }
        else
        {
            return context.ThongTinDoanhNghiep.Where(x => x.MaPhuongXa == maXa && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
        }
    }

    int getTongCST(string maTinh)
    {
        if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
        {
            return context.ThongTinCaThe.Where(x => x.MaTinhTp == maTinh).ToList().Count();
        }
        else
        {
            return context.ThongTinCaThe.Where(x => x.MaTinhTp == maTinh && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
        }
    }
    int getTongCSH(string maHuyen)
    {
        if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
        {
            return context.ThongTinCaThe.Where(x => x.MaQuanHuyen == maHuyen).ToList().Count();
        }
        else
        {
            return context.ThongTinCaThe.Where(x => x.MaQuanHuyen == maHuyen && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
        }
    }
    int getTongCSX(string maXa)
    {
        if (maLoaiPhieu == null || maLoaiPhieu.Equals("0"))
        {
            return context.ThongTinCaThe.Where(x => x.MaPhuongXa == maXa).ToList().Count();
        }
        else
        {
            return context.ThongTinCaThe.Where(x => x.MaPhuongXa == maXa && x.MaLoaiPhieu == maLoaiPhieu).ToList().Count();
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""list"" class=""body-container"">
            <table class=""table-TK table table-bordered table-striped table-hover text-center"">
                <thead>
                    <tr>
                        <th colspan=""3""></th>
                        <th colspan=""4"">Doanh nghiệp</th>
                        <th colspan=""4"">Cơ sở</th>
                    </tr>
                    <tr>
                        <th>Stt</th>
                        <th>Mã</th>
                        <th>Tên</th>
                        <th>Tổng</th>
                        <th>Đã làm</th>
                        <th>Chưa làm</th>
                        <th>Tỉ lệ hoàn thành</th>
                        <th>Tổng</th>
                        <th>Đã làm</th>
                        <th>Chưa làm</th>
                        <th>Tỉ lệ hoàn thành</th>
                    </tr>
                </thead>
                <tbody>
                    <tr style=""background-color:#17a2b8"">
                       ");
            WriteLiteral(" <td>1</td>\r\n                        <td>");
#nullable restore
#line 370 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(IDDiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 371 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 372 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(format(tongDN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 373 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(format(tongDNDL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 374 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(format(tongDN-tongDNDL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 375 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(getTiLe(tongDN,tongDNDL).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        <td>");
#nullable restore
#line 376 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(format(tongCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 377 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(format(tongCSDL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 378 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(format(tongCS-tongCSDL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 379 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(getTiLe(tongCS,tongCSDL).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                    </tr>\r\n");
#nullable restore
#line 381 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
             if(maX.Equals("0")){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 382 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
             if (maT.Equals("0"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 384 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                 for(int i =0; i < listDiaChi.Count(); i++)
                {
                    int a = getTongDNT(listDiaChi[i].Id);
                    int b = getTongDNDL(listDiaChi[i].Id, null, null);
                    int c = getTongCST(listDiaChi[i].Id);
                    int d = getTongCSDL(listDiaChi[i].Id, null, null);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 391 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                        Write(i+2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 392 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(listDiaChi[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 393 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(listDiaChi[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 394 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 395 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 396 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                        Write(a-b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 397 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(getTiLe(a,b).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        <td>");
#nullable restore
#line 398 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 399 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 400 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                        Write(c-d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 401 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                       Write(getTiLe(c,d).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                    </tr>\r\n");
#nullable restore
#line 403 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 403 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                 
            }else{
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 405 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                 if (maH.Equals("0"))
                {
                    List<Districts> listH = listDiaChi.FirstOrDefault(x => x.Id == maT).Districts;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 408 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                     for (int i = 0; i < listH.Count(); i++)
                    {
                        int a = getTongDNH(listH[i].Id);
                        int b = getTongDNDL(maT, listH[i].Id, null);
                        int c = getTongCSH(listH[i].Id);
                        int d = getTongCSDL(maT, listH[i].Id, null);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 415 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                            Write(i + 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 416 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(listH[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 417 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(listH[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 418 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 419 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 420 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                            Write(a-b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 421 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(getTiLe(a,b).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                            <td>");
#nullable restore
#line 422 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 423 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 424 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                            Write(c-d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 425 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(getTiLe(c,d).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        </tr>\r\n");
#nullable restore
#line 427 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 427 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                     
                }
                else{
                    List<Wards> listX = listDiaChi.FirstOrDefault(x => x.Id == maT).Districts.FirstOrDefault(x=>x.Id==maH).Wards;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 431 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                     for (int i = 0; i < listX.Count(); i++)
                    {
                        int a = getTongDNX(listX[i].Id);
                        int b = getTongDNDL(maT, maH, listX[i].Id);
                        int c = getTongCSX(listX[i].Id);
                        int d = getTongCSDL(maT, maH, listX[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                           <td>");
#nullable restore
#line 438 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(i + 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td>");
#nullable restore
#line 439 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                          Write(listX[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           <td> ");
#nullable restore
#line 440 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(listX[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 441 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 442 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 443 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                            Write(a-b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 444 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(getTiLe(a,b).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                            <td>");
#nullable restore
#line 445 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 446 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 447 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                            Write(c-d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 448 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                           Write(getTiLe(c,d).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        </tr>\r\n");
#nullable restore
#line 450 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 450 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 451 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 452 "D:\ProjectC#\Cosis\Cosis\Views\ThongKe\openList.cshtml"
             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n            </table>\r\n        </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591