#pragma checksum "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743b17c672f6b0fd4638564ce0d1b32ee1073dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Master2_1CN), @"mvc.1.0.view", @"/Views/Shared/_Master2_1CN.cshtml")]
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
#line 1 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743b17c672f6b0fd4638564ce0d1b32ee1073dd8", @"/Views/Shared/_Master2_1CN.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Master2_1CN : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.Entities.ThongTinCaThe>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
  
  FormCosisContext context = new FormCosisContext();
  TinhTp getTinh(string idTinh){
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
  List<NganhKinhDoanh> getNganhKinhDoanh(string macs)
  {
    return context.NganhKinhDoanh.Where(x => x.MaCoSo == macs).ToList();
  }

  NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
  {
    return context.NganhHoatDongKinhDoanh.Where(x => x.MaNganh == ma).FirstOrDefault();
  }
  Boolean ExistMSTInTTCT(string m1,string m2){
    var check = context.ThongTinCaThe.Where(x => x.MaSoThue == m1 && x.MaSoThue2 == m2).FirstOrDefault();
      if(check != null && m2.Trim() != "00000"){
            return true;
      }else{
          return false;
      }
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"ThongTinDoanhNghiepGroup\" class=\"form-group\">\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Tỉnh/TP trực thuộc TW: </label>\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1152, "\"", 1189, 1);
#nullable restore
#line 40 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 1160, getTinh(Model.MaTinhTp).Name, 1160, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly id=\"city\"  class=\"infoma\"/>\r\n    <input name=\"Master.MaTinhTp\"");
            BeginWriteAttribute("value", " value=\"", 1262, "\"", 1285, 1);
#nullable restore
#line 41 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 1270, Model.MaTinhTp, 1270, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden readonly  id=\"district\" class=\"infoma\"/>\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:\r\n    </label>\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1462, "\"", 1503, 1);
#nullable restore
#line 46 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 1470, getHuyen(Model.MaQuanHuyen).Name, 1470, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly  id=\"district\" class=\"infoma\"/>\r\n    <input name=\"Master.MaQuanHuyen\"");
            BeginWriteAttribute("value", " value=\"", 1583, "\"", 1609, 1);
#nullable restore
#line 47 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 1591, Model.MaQuanHuyen, 1591, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden readonly  id=\"district\" class=\"infoma\"/>\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Xã/phường/thị trấn: </label>\r\n    <input readonly");
            BeginWriteAttribute("value", " value=\"", 1767, "\"", 1804, 1);
#nullable restore
#line 51 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 1775, getXa(Model.MaPhuongXa).Name, 1775, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  id=\"ward\" class=\"infoma\"/>\r\n    <input name=\"Master.MaPhuongXa\"");
            BeginWriteAttribute("value", " value=\"", 1870, "\"", 1895, 1);
#nullable restore
#line 52 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 1878, Model.MaPhuongXa, 1878, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden readonly  id=\"district\" class=\"infoma\"/>\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Địa bàn: </label>\r\n    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2054, "\"", 2180, 7);
#nullable restore
#line 56 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 2062, Model.DiaChiCuThe, 2062, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2080, "-", 2081, 2, true);
#nullable restore
#line 56 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue(" ", 2082, getXa(Model.MaPhuongXa).Name, 2083, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2112, "-", 2113, 2, true);
#nullable restore
#line 56 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue(" ", 2114, getHuyen(Model.MaQuanHuyen).Name, 2115, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2148, "-", 2149, 2, true);
#nullable restore
#line 56 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue(" ", 2150, getTinh(Model.MaTinhTp).Name, 2151, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n  </div>\r\n    <div class=\"row\">\r\n    <label class=\"lb-info\">Mã cơ sở: </label>\r\n    <input autofocus type=\"text\" id=\"macoso\" maxlength=\"5\" name=\"Master.MaCoSo\"");
            BeginWriteAttribute("value", " value=\"", 2360, "\"", 2381, 1);
#nullable restore
#line 60 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 2368, Model.MaCoSo, 2368, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />  \r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Tên cơ sở: </label>\r\n    <input readonly type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2514, "\"", 2536, 1);
#nullable restore
#line 64 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 2522, Model.TenCoSo, 2522, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n    </div>\r\n");
#nullable restore
#line 66 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
     if(ExistMSTInTTCT(Model.MaSoThue,Model.MaSoThue2) == false){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n    <label class=\"lb-info\">Mã số thuế</label>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2732, "\"", 2740, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n0\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"1\" autofocus/>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2864, "\"", 2872, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n1\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"2\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2987, "\"", 2995, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n2\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"3\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3110, "\"", 3118, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n3\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"4\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3233, "\"", 3241, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n4\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"5\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3356, "\"", 3364, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n5\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"6\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3479, "\"", 3487, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n6\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"7\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3602, "\"", 3610, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n7\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"8\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3725, "\"", 3733, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n8\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"9\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3848, "\"", 3856, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n9\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"10\" />\r\n\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3974, "\"", 3982, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n10\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"11\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4099, "\"", 4107, 0);
            EndWriteAttribute();
            WriteLiteral("  id=\"n11\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"12\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4225, "\"", 4233, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"n12\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"13\" />\r\n    <input type=\"hidden\" id=\"MST1\" name=\"Master.MaSoThue\"");
            BeginWriteAttribute("value", " value=\"", 4385, "\"", 4393, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n  </div>\r\n");
#nullable restore
#line 85 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n    <label class=\"lb-info\">Mã số thuế</label>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4517, "\"", 4555, 1);
#nullable restore
#line 88 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 4525, Model.MaSoThue.Substring(0,1), 4525, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n0\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"1\" autofocus/>\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4679, "\"", 4717, 1);
#nullable restore
#line 89 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 4687, Model.MaSoThue.Substring(1,1), 4687, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n1\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"2\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4832, "\"", 4870, 1);
#nullable restore
#line 90 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 4840, Model.MaSoThue.Substring(2,1), 4840, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n2\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"3\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 4985, "\"", 5023, 1);
#nullable restore
#line 91 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 4993, Model.MaSoThue.Substring(3,1), 4993, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n3\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"4\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5138, "\"", 5176, 1);
#nullable restore
#line 92 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 5146, Model.MaSoThue.Substring(4,1), 5146, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n4\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"5\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5291, "\"", 5329, 1);
#nullable restore
#line 93 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 5299, Model.MaSoThue.Substring(5,1), 5299, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n5\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"6\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5444, "\"", 5482, 1);
#nullable restore
#line 94 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 5452, Model.MaSoThue.Substring(6,1), 5452, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n6\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"7\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5597, "\"", 5635, 1);
#nullable restore
#line 95 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 5605, Model.MaSoThue.Substring(7,1), 5605, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n7\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"8\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5750, "\"", 5788, 1);
#nullable restore
#line 96 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 5758, Model.MaSoThue.Substring(8,1), 5758, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n8\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"9\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5903, "\"", 5941, 1);
#nullable restore
#line 97 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 5911, Model.MaSoThue.Substring(9,1), 5911, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n9\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"10\" />\r\n\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 6059, "\"", 6098, 1);
#nullable restore
#line 99 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6067, Model.MaSoThue2.Substring(0,1), 6067, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n10\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"11\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 6215, "\"", 6254, 1);
#nullable restore
#line 100 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6223, Model.MaSoThue2.Substring(1,1), 6223, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  id=\"n11\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"12\" />\r\n    <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 6372, "\"", 6411, 1);
#nullable restore
#line 101 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6380, Model.MaSoThue2.Substring(2,1), 6380, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"n12\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\" data-next=\"13\" />\r\n    <input type=\"hidden\" id=\"MST1\" name=\"Master.MaSoThue\"");
            BeginWriteAttribute("value", " value=\"", 6563, "\"", 6603, 3);
#nullable restore
#line 102 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6571, Model.MaSoThue, 6571, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6586, "+", 6586, 1, true);
#nullable restore
#line 102 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6587, Model.MaSoThue2, 6587, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n  </div>\r\n");
#nullable restore
#line 104 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"row\">\r\n    <label class=\"lb-info\">Thôn, ấp<i>(số nhà, đường phố)</i>: </label>\r\n    <input readonly type=\"text\" name=\"Master.DiaChiCuThe\"");
            BeginWriteAttribute("value", " value=\"", 6777, "\"", 6803, 1);
#nullable restore
#line 107 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6785, Model.DiaChiCuThe, 6785, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n  </div>\r\n\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Số điện thoại: </label>\r\n    <input readonly name=\"Master.Sdt\"");
            BeginWriteAttribute("value", " value=\"", 6946, "\"", 6968, 1);
#nullable restore
#line 112 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 6954, Model.SdtcoSo, 6954, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"infoma\" />\r\n  </div>\r\n  <div class=\"row\">\r\n    <label class=\"lb-info\">Email: </label>\r\n    <input readonly name=\"Master.Email\"");
            BeginWriteAttribute("value", " value=\"", 7115, "\"", 7135, 1);
#nullable restore
#line 116 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 7123, Model.Email, 7123, 12, false);

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
#line 127 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
       if (Model.MaLh.Trim() == "01")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"radio\" checked name=\"Master.MaLh\" value=\"01\" />\r\n");
#nullable restore
#line 130 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input disabled type=\"radio\" name=\"Master.MaLh\" value=\"01\" />\r\n");
#nullable restore
#line 134 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
       if (Model.MaLh.Trim() == "02")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"radio\" checked name=\"Master.MaLh\" value=\"02\" />\r\n");
#nullable restore
#line 138 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input disabled type=\"radio\" name=\"Master.MaLh\" value=\"02\" />\r\n");
#nullable restore
#line 142 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 144 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
       if (Model.MaLh.Trim() == "03")
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"radio\" checked name=\"Master.MaLh\" value=\"03\" />\r\n");
#nullable restore
#line 147 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input disabled type=\"radio\" name=\"Master.MaLh\" value=\"03\" />\r\n");
#nullable restore
#line 151 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n  </div>\r\n  <div class=\"nganhKD row\">\r\n    <label class=\"nganh-lb\"");
            BeginWriteAttribute("for", " for=\"", 8237, "\"", 8243, 0);
            EndWriteAttribute();
            WriteLiteral(">Ngành hoạt động kinh doanh</label>\r\n");
#nullable restore
#line 156 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
     foreach (NganhKinhDoanh nganh in getNganhKinhDoanh(Model.MaCoSo))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"nganh-ct\">\r\n        <div class=\"row\">\r\n          <div class=\"MNHD row\">\r\n            <input readonly");
            BeginWriteAttribute("value", " value=\"", 8478, "\"", 8515, 1);
#nullable restore
#line 161 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 8486, nganh.MaNganh.Substring(0,1), 8486, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n            <input readonly");
            BeginWriteAttribute("value", " value=\"", 8606, "\"", 8643, 1);
#nullable restore
#line 162 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 8614, nganh.MaNganh.Substring(1,1), 8614, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n            <input readonly");
            BeginWriteAttribute("value", " value=\"", 8734, "\"", 8771, 1);
#nullable restore
#line 163 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 8742, nganh.MaNganh.Substring(2,1), 8742, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n            <input readonly");
            BeginWriteAttribute("value", " value=\"", 8862, "\"", 8899, 1);
#nullable restore
#line 164 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 8870, nganh.MaNganh.Substring(3,1), 8870, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n            <input readonly");
            BeginWriteAttribute("value", " value=\"", 8990, "\"", 9027, 1);
#nullable restore
#line 165 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 8998, nganh.MaNganh.Substring(4,1), 8998, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" maxlength=\"1\" size=\"1\" class=\"text-center MN\" />\r\n          </div>\r\n          <label");
            BeginWriteAttribute("for", " for=\"", 9125, "\"", 9131, 0);
            EndWriteAttribute();
            WriteLiteral(">Tên ngành HĐKD:</label>\r\n          <input readonly");
            BeginWriteAttribute("value", " value=\"", 9183, "\"", 9241, 1);
#nullable restore
#line 168 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
WriteAttributeValue("", 9191, getNganhHoatDongKinhDoanh(nganh.MaNganh).TenNganh, 9191, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"infoma-nganh\" />\r\n        </div>\r\n      </div>\r\n");
#nullable restore
#line 171 "D:\Cosis\Cosis\Views\Shared\_Master2_1CN.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/axios/0.21.1/axios.min.js""></script>
<script>
  var pattern = /^\d{5}$/;
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
              if ($('label.P-name b').text().includes('2.1')) {
                  $.ajax({
                    type: 'POST',
                    url: '/loaddata_21B',
                    data: ""ms="" +str,
                    success: function (result) {
                      $('#table-data').replaceWith(result);
                    },
                    error: function (result) ");
            WriteLiteral(@"{
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
            type: 'POST',
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
         ");
            WriteLiteral(@"   url: '/loadMaster2',
            data: ""ms="" + strMS,
            success: function (result) {
              $('#ThongTinDoanhNghiepGroup').replaceWith(result);
              $('#MST1').val(strMS);
              if ($('label.P-name b').text().includes('2.1')) {
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
          var c");
            WriteLiteral(@"heck = document.getElementById(""n"" + next).value;
          if (check !== """") {
            document.getElementById(""n"" + next).focus();
          } else {
            document.getElementById(""n"" + next).focus();
          }
        }
      }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosis.Models.Entities.ThongTinCaThe> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
