#pragma checksum "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307d3408967dab0456e226c150be37a1c456ec4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Master2_1), @"mvc.1.0.view", @"/Views/Shared/_Master2_1.cshtml")]
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
#line 1 "D:\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"307d3408967dab0456e226c150be37a1c456ec4d", @"/Views/Shared/_Master2_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Master2_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.Entities.ThongTinDoanhNghiep>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
  
  FormCosisContext context = new FormCosisContext();
  TinhTp getTinh(string idTinh)
  {
    return context.TinhTp.Find(idTinh);
  }

  QuanHuyen getHuyen(string idHuyen)
  {
    return context.QuanHuyen.Find(idHuyen);
  }

  PhuongXa getXa(string idXa)
  {
    return context.PhuongXa.Find(idXa);
  }
  List<NganhKinhDoanh> getNganhKinhDoanh(string mast1, string mast2)
  {
    return context.NganhKinhDoanh.Where(x => x.MaSoThue == mast1 && x.MaSoThue2 == mast2).ToList();
  }

  NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
  {
    return context.NganhHoatDongKinhDoanh.Where(x => x.MaNganh == ma).FirstOrDefault();
  }
  ThongTinCaThe getThongTinCaTheByMST(string mst1, string mst2)
  {
    return context.ThongTinCaThe.Where(x => x.MaSoThue == mst1 && x.MaSoThue2 == mst2).FirstOrDefault();
  }


#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"ThongTinDoanhNghiepGroup\" class=\"form-group\">\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Tỉnh/TP trực thuộc TW: </label>\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1108, "\"", 1145, 1);
#nullable restore
#line 38 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 1116, getTinh(Model.MaTinhTp).Name, 1116, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly id=\"city\"  class=\"infoma\"/>\r\n    <input name=\"Master.MaTinhTp\"");
            BeginWriteAttribute("value", " value=\"", 1218, "\"", 1241, 1);
#nullable restore
#line 39 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 1226, Model.MaTinhTp, 1226, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden readonly  id=\"district\" class=\"infoma\"/>\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:\r\n    </label>\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1418, "\"", 1459, 1);
#nullable restore
#line 44 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 1426, getHuyen(Model.MaQuanHuyen).Name, 1426, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly  id=\"district\" class=\"infoma\"/>\r\n    <input name=\"Master.MaQuanHuyen\"");
            BeginWriteAttribute("value", " value=\"", 1539, "\"", 1565, 1);
#nullable restore
#line 45 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 1547, Model.MaQuanHuyen, 1547, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden readonly  id=\"district\" class=\"infoma\"/>\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Xã/phường/thị trấn: </label>\r\n    <input readonly");
            BeginWriteAttribute("value", " value=\"", 1723, "\"", 1760, 1);
#nullable restore
#line 49 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 1731, getXa(Model.MaPhuongXa).Name, 1731, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  id=\"ward\" class=\"infoma\"/>\r\n    <input name=\"Master.MaPhuongXa\"");
            BeginWriteAttribute("value", " value=\"", 1826, "\"", 1851, 1);
#nullable restore
#line 50 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 1834, Model.MaPhuongXa, 1834, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden readonly  id=\"district\" class=\"infoma\"/>\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Địa bàn: </label>\r\n    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2010, "\"", 2136, 7);
#nullable restore
#line 54 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 2018, Model.DiaChiCuThe, 2018, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2036, "-", 2037, 2, true);
#nullable restore
#line 54 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue(" ", 2038, getXa(Model.MaPhuongXa).Name, 2039, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2068, "-", 2069, 2, true);
#nullable restore
#line 54 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue(" ", 2070, getHuyen(Model.MaQuanHuyen).Name, 2071, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2104, "-", 2105, 2, true);
#nullable restore
#line 54 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue(" ", 2106, getTinh(Model.MaTinhTp).Name, 2107, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n  </div>\r\n");
#nullable restore
#line 56 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
   if (getThongTinCaTheByMST(Model.MaSoThue.Trim(), Model.MaSoThue2.Trim()) != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n        <label class=\"lb-info\">Mã cơ sở: </label>\r\n        <input type=\"text\" id=\"macoso\" maxlength=\"5\" name=\"Master.MaCoSo\"");
            BeginWriteAttribute("value", " value=\"", 2409, "\"", 2478, 1);
#nullable restore
#line 60 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 2417, getThongTinCaTheByMST(Model.MaSoThue,Model.MaSoThue2).MaCoSo, 2417, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />  \r\n      </div>\r\n      <div class=\"row\">\r\n        <label class=\"lb-info\">Tên cơ sở: </label>\r\n        <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2627, "\"", 2697, 1);
#nullable restore
#line 64 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 2635, getThongTinCaTheByMST(Model.MaSoThue,Model.MaSoThue2).TenCoSo, 2635, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n        </div>\r\n");
#nullable restore
#line 66 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
  }
  else
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n        <label class=\"lb-info\">Mã cơ sở: </label>\r\n        <input type=\"text\" id=\"macoso\" maxlength=\"5\" name=\"Master.MaCoSo\"");
            BeginWriteAttribute("value", " value=\"", 2903, "\"", 2911, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />  \r\n      </div>\r\n      <div class=\"row\">\r\n        <label class=\"lb-info\">Tên cơ sở: </label>\r\n        <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3060, "\"", 3068, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n        <input readonly hidden type=\"text\" name=\"Master.Ten\"");
            BeginWriteAttribute("value", " value=\"", 3149, "\"", 3178, 1);
#nullable restore
#line 76 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 3157, Model.TenDoanhNghiep, 3157, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n        </div>\r\n");
#nullable restore
#line 78 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Mã số thuế</label>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3312, "\"", 3350, 1);
#nullable restore
#line 82 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 3320, Model.MaSoThue.Substring(0,1), 3320, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n0\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"1\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3465, "\"", 3503, 1);
#nullable restore
#line 83 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 3473, Model.MaSoThue.Substring(1,1), 3473, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n1\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"2\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3618, "\"", 3656, 1);
#nullable restore
#line 84 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 3626, Model.MaSoThue.Substring(2,1), 3626, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n2\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"3\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3771, "\"", 3809, 1);
#nullable restore
#line 85 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 3779, Model.MaSoThue.Substring(3,1), 3779, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n3\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"4\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3924, "\"", 3962, 1);
#nullable restore
#line 86 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 3932, Model.MaSoThue.Substring(4,1), 3932, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n4\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"5\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4077, "\"", 4115, 1);
#nullable restore
#line 87 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 4085, Model.MaSoThue.Substring(5,1), 4085, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n5\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"6\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4230, "\"", 4268, 1);
#nullable restore
#line 88 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 4238, Model.MaSoThue.Substring(6,1), 4238, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n6\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"7\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4383, "\"", 4421, 1);
#nullable restore
#line 89 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 4391, Model.MaSoThue.Substring(7,1), 4391, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n7\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"8\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4536, "\"", 4574, 1);
#nullable restore
#line 90 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 4544, Model.MaSoThue.Substring(8,1), 4544, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n8\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"9\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4689, "\"", 4727, 1);
#nullable restore
#line 91 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 4697, Model.MaSoThue.Substring(9,1), 4697, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n9\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"10\" />\r\n\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4845, "\"", 4884, 1);
#nullable restore
#line 93 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 4853, Model.MaSoThue2.Substring(0,1), 4853, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n10\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"11\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5001, "\"", 5040, 1);
#nullable restore
#line 94 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5009, Model.MaSoThue2.Substring(1,1), 5009, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  id=\"n11\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"12\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5158, "\"", 5197, 1);
#nullable restore
#line 95 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5166, Model.MaSoThue2.Substring(2,1), 5166, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n12\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"13\" />\r\n    <input type=\"hidden\" id=\"MST1\" name=\"Master.MaSoThue\"");
            BeginWriteAttribute("value", " value=\"", 5349, "\"", 5389, 3);
#nullable restore
#line 96 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5357, Model.MaSoThue, 5357, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5372, "+", 5372, 1, true);
#nullable restore
#line 96 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5373, Model.MaSoThue2, 5373, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Thôn, ấp<i>(số nhà, đường phố)</i>: </label>\r\n    <input readonly type=\"text\" name=\"Master.DiaChiCuThe\"");
            BeginWriteAttribute("value", " value=\"", 5556, "\"", 5582, 1);
#nullable restore
#line 100 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5564, Model.DiaChiCuThe, 5564, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n  </div>\r\n\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Số điện thoại: </label>\r\n    <input readonly name=\"Master.Sdt\"");
            BeginWriteAttribute("value", " value=\"", 5725, "\"", 5754, 1);
#nullable restore
#line 105 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5733, Model.SdtdoanhNghiep, 5733, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"infoma\" />\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Email: </label>\r\n    <input readonly name=\"Master.Email\"");
            BeginWriteAttribute("value", " value=\"", 5901, "\"", 5921, 1);
#nullable restore
#line 109 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 5909, Model.Email, 5909, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" class=""infoma"" />
  </div>
  <div class=""loaihinh"">
    <label>Loại hình kinh tế</label>

    <div class=""checkbox-tt"">
      <label> 1.Kinh tế nhà nước</label>
      <label> 2.Kinh tế ngoài nhà nước</label>
      <label> 3.Kinh tế có vốn đầu tư trực tiếp nước ngoài</label>
    </div>
    <div class=""checkbox"">
");
#nullable restore
#line 120 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
       if (Model.MaLh.Trim() == "01")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"radio\" checked name=\"Master.MaLh\" value=\"01\" />\r\n");
#nullable restore
#line 123 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input disabled type=\"radio\" name=\"Master.MaLh\" value=\"01\" />\r\n");
#nullable restore
#line 127 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
       if (Model.MaLh.Trim() == "02")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"radio\" checked name=\"Master.MaLh\" value=\"02\" />\r\n");
#nullable restore
#line 131 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input disabled type=\"radio\" name=\"Master.MaLh\" value=\"02\" />\r\n");
#nullable restore
#line 135 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 137 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
       if (Model.MaLh.Trim() == "03")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"radio\" checked name=\"Master.MaLh\" value=\"03\" />\r\n");
#nullable restore
#line 140 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input disabled type=\"radio\" name=\"Master.MaLh\" value=\"03\" />\r\n");
#nullable restore
#line 144 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n  </div>\r\n  <div class=\"nganhKD row\">\r\n    <label");
            BeginWriteAttribute("for", " for=\"", 7030, "\"", 7036, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"col-12\">Ngành hoạt động kinh doanh</label>\r\n");
#nullable restore
#line 149 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
     foreach (NganhKinhDoanh nganh in getNganhKinhDoanh(Model.MaSoThue, Model.MaSoThue2))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"nganh-ct\">\r\n            <div class=\"row\">\r\n              <div class=\"col-5\">\r\n                <input readonly");
            BeginWriteAttribute("value", " value=\"", 7318, "\"", 7355, 1);
#nullable restore
#line 154 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 7326, nganh.MaNganh.Substring(0,1), 7326, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n                <input readonly");
            BeginWriteAttribute("value", " value=\"", 7450, "\"", 7487, 1);
#nullable restore
#line 155 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 7458, nganh.MaNganh.Substring(1,1), 7458, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n                <input readonly");
            BeginWriteAttribute("value", " value=\"", 7582, "\"", 7619, 1);
#nullable restore
#line 156 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 7590, nganh.MaNganh.Substring(2,1), 7590, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n                <input readonly");
            BeginWriteAttribute("value", " value=\"", 7714, "\"", 7751, 1);
#nullable restore
#line 157 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 7722, nganh.MaNganh.Substring(3,1), 7722, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n                <input readonly");
            BeginWriteAttribute("value", " value=\"", 7846, "\"", 7883, 1);
#nullable restore
#line 158 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 7854, nganh.MaNganh.Substring(4,1), 7854, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n              </div>\r\n              <div class=\"col-7\">\r\n              <label");
            BeginWriteAttribute("for", " for=\"", 8024, "\"", 8030, 0);
            EndWriteAttribute();
            WriteLiteral(">Tên ngành HĐKD:</label>\r\n              <input readonly");
            BeginWriteAttribute("value", " value=\"", 8086, "\"", 8144, 1);
#nullable restore
#line 162 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
WriteAttributeValue("", 8094, getNganhHoatDongKinhDoanh(nganh.MaNganh).TenNganh, 8094, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"infoma-nganh\" />\r\n            </div>\r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 166 "D:\Cosis\Cosis\Views\Shared\_Master2_1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/axios/0.21.1/axios.min.js\"></script>\r\n<script>\r\n");
            WriteLiteral(@"  var pattern = /^\d{5}$/;
    $('input#macoso').keyup(function() {
        if ($('input#macoso').val().match(pattern)) {
         // $('input#n0').focus();
          $('input#macoso').focusout(function(){
          });
          var str = $('input#macoso').val();
          $.ajax({
            type: 'POST',
            url: '/loadMaster2CN',
            data: ""ms="" + $('input#macoso').val(),
            success: function (result) {
              $('#ThongTinDoanhNghiepGroup').replaceWith(result);
");
            WriteLiteral(@"              if ($('label.P-name b').text().includes('2.1')) {
                  $.ajax({
                    type: 'POST',
                    url: '/loaddata_21B',
                    data: ""ms="" +str,
                    success: function (result) {
                      $('#table-data').replaceWith(result);
                    },
                    error: function (result) {
                    }
                  });
                }
            },
            error: function (result) {
              alert('Mã cơ sở không tồn tại!');
            }
          });
        } else {
        }
    });
  $("".MS"").keyup(function () {

      var valueArr = [];
      document.querySelectorAll('.MS').forEach(function (el) {
        valueArr.push(el.value);
      });
      strMS = """";
      valueArr.forEach(AddMS)
      $('#MST1').val(strMS);
      if (strMS.length == 13) {
        if ($('label.P-name b').text().includes('2.') == false) {
          $.ajax({
            type: 'POST'");
            WriteLiteral(@",
            url: '/loadMaster',
            data: ""ms="" + strMS,
            success: function (result) {
              $('#ThongTinDoanhNghiepGroup').replaceWith(result);
            },
            error: function (result) {
              alert('Mã số thuế không tồn tại!');
            }
          });
        } else {
          $.ajax({
            type: 'POST',
            url: '/loadMaster2',
            data: ""ms="" + strMS,
            success: function (result) {
              $('#ThongTinDoanhNghiepGroup').replaceWith(result);
              $('#MST1').val(strMS);
");
            WriteLiteral(@"              if ($('label.P-name b').text().includes('2.1')) {
                  $.ajax({
                    type: 'POST',
                    url: '/loaddata_21B',
                    data: ""ms="" + strMS,
                    success: function (result) {
                      $('#table-data').replaceWith(result);
                    },
                    error: function (result) {
                    }
                  });
                }
            },
            error: function (result) {
              alert('Mã số thuế không tồn tại!');
            }
          });
        }
      }
    });

    $("".MS"").keyup(function (e) {
      if (this.value.length === this.maxLength) {
        var next = $(this).data(""next"");
        if (next === 13) {
        } else {
          var check = document.getElementById(""n"" + next).value;
          if (check !== """") {
            document.getElementById(""n"" + next).focus();
          } else {
            document.getElementById(""n"" + next");
            WriteLiteral(").focus();\r\n          }\r\n        }\r\n      }\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosis.Models.Entities.ThongTinDoanhNghiep> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
