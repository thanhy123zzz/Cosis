#pragma checksum "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368ed8dbb6b908174f913800db614fd7566bd0fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Table1_1), @"mvc.1.0.view", @"/Views/Shared/_Table1_1.cshtml")]
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
#line 1 "D:\ProC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368ed8dbb6b908174f913800db614fd7566bd0fc", @"/Views/Shared/_Table1_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Table1_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
  
    FormCosisContext context = new FormCosisContext();
    List<NganhKinhDoanh> getNganhKinhDoanh(string mast1, string mast2)
    {
        return context.NganhKinhDoanh.Where(x => x.MaSoThue == mast1 && x.MaSoThue2 == mast2).ToList();
    }
    List<NganhKinhDoanh> list;
    NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
    {
        return context.NganhHoatDongKinhDoanh.Where(x => x.MaNganh == ma).FirstOrDefault();
    }

    int getThang()
    {
        return DateTime.Now.Month;
    }
    int getThangTruoc()
    {
        if (getThang() == 1)
        {
            return 12;
        }
        else
        {
            return getThang() - 1;
        }
    }
    int getNam()
    {
        return DateTime.Now.Year;
    }
    string getThangNamTruoc()
    {
        if (getThang() == 1)
            return "12/" + (getNam() - 1);
        else
        {
            return (getThang() - 1) + "/" + getNam();
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered"" id=""tab-KQ"">
          <thead>
            <tr class=""text-center"">
              <th class=""Chitieu"">Chỉ tiêu</th>
              <th class=""NganhCM"">Ngành chọn mẫu</th>
              <th class=""DVT"">Đơn vị tính</th>
              <th colspan=""2"" class=""Money"">Tháng thực hiện ");
#nullable restore
#line 48 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                                       Write(getThangNamTruoc());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th colspan=\"2\" class=\"Money\">Dự tính ");
#nullable restore
#line 49 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                               Write(getThang());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 49 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                                           Write(getNam());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th colspan=\"2\" class=\"Money\">\r\n                Cộng dồn từ đầu năm đến cuối tháng ");
#nullable restore
#line 51 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                              Write(getThang());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 51 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                                          Write(getNam());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
              </th>
            </tr>
          </thead>
          <tbody>
            <tr class=""text-center"">
              <td>A</td>
              <td>B</td>
              <td>1</td>
              <td>Tổng</td>
              <td>TTTM</td>
              <td>Tổng</td>
              <td>TTTM</td>
              <td>Tổng</td>
              <td>TTTM</td>
            </tr>
");
#nullable restore
#line 67 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
          
            list = getNganhKinhDoanh(ViewBag.MaSoThue1, ViewBag.MaSoThue2);
            int z = 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n              <td class=\"DMNganh\">1.Tổng doanh thu\r\n                  <input type=\"hidden\" id=\"SLRow\"");
            BeginWriteAttribute("value", " value=\"", 2172, "\"", 2191, 1);
#nullable restore
#line 74 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 2180, list.Count, 2180, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                  <input type=""hidden"" name=""Detail[0].Stt"" value=""1.""/>
                  <input type=""hidden"" name=""Detail[1].Stt"" value=""1.1.""/>
                  <input type=""hidden"" name=""Detail[0].TenCt"" value=""Tổng doanh thu""/>
                  <input type=""hidden"" name=""Detail[1].TenCt"" value=""Tổng doanh thu bán được trong TTTM""/>
              </td>
              <td class=""text-center"">...</td>
              <td class=""text-center"">Triệu đồng
                  <input type=""hidden"" name=""Detail[0].Dvt"" value=""Triệu đồng""/>
                  <input type=""hidden"" name=""Detail[1].Dvt"" value=""Triệu đồng""/>
              </td>
              <td><input readonly type=""text"" class=""infomal"" id=""ThangTruoc0"" name=""Detail[0].ThthangTruoc""/>
              </td>
              <td><input readonly type=""text"" class=""infomal"" id=""ThangTruocTT0"" name=""Detail[1].ThthangTruoc"" /></td>
              <td><input readonly type=""text"" class=""infomal"" id=""DuTinh0"" name=""Detail[0].DuTinh""/></td>
          ");
            WriteLiteral(@"    <td><input readonly type=""text"" class=""infomal"" id=""DuTinhTT0"" name=""Detail[1].DuTinh"" /></td>
              <td><input readonly type=""text"" class=""infomal"" id=""TongCongDon0"" name=""Detail[0].TongCongDon""/></td>
              <td><input readonly type=""text"" class=""infomal"" id=""TongCongDonTT0"" name=""Detail[1].TongCongDon""/></td>
            </tr>
            
");
#nullable restore
#line 94 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
             for(int i =2; i<(list.Count+2);i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 96 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                  
                    int j = z + 1;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <td class=\"DMNganh\">");
#nullable restore
#line 99 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(". Doanh thu thuần\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3830, "\"", 3841, 2);
            WriteAttributeValue("", 3835, "stt_", 3835, 4, true);
#nullable restore
#line 100 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3839, i, 3839, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3842, "\"", 3863, 3);
            WriteAttributeValue("", 3849, "Detail[", 3849, 7, true);
#nullable restore
#line 100 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3856, z, 3856, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3858, "].Stt", 3858, 5, true);
            EndWriteAttribute();
            WriteLiteral("p");
            BeginWriteAttribute("value", " value=\"", 3865, "\"", 3876, 2);
#nullable restore
#line 100 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3873, i, 3873, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3875, ".", 3875, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3923, "\"", 3936, 2);
            WriteAttributeValue("", 3928, "sttTT_", 3928, 6, true);
#nullable restore
#line 101 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3934, i, 3934, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3937, "\"", 3958, 3);
            WriteAttributeValue("", 3944, "Detail[", 3944, 7, true);
#nullable restore
#line 101 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3951, j, 3951, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3953, "].Stt", 3953, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3959, "\"", 3972, 2);
#nullable restore
#line 101 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3967, i, 3967, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3969, ".1.", 3969, 3, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4019, "\"", 4042, 3);
            WriteAttributeValue("", 4026, "Detail[", 4026, 7, true);
#nullable restore
#line 102 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4033, z, 4033, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4035, "].TenCt", 4035, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4043, "\"", 4121, 4);
            WriteAttributeValue("", 4051, "Doanh", 4051, 5, true);
            WriteAttributeValue(" ", 4056, "thu", 4057, 4, true);
            WriteAttributeValue(" ", 4060, "thuần", 4061, 6, true);
#nullable restore
#line 102 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue(" ", 4066, getNganhHoatDongKinhDoanh(list[i-2].MaNganh).TenNganh, 4067, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4168, "\"", 4191, 3);
            WriteAttributeValue("", 4175, "Detail[", 4175, 7, true);
#nullable restore
#line 103 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4182, j, 4182, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4184, "].TenCt", 4184, 7, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Trong đó: Bán trong siêu thị trung tâm thương mại\"/>\r\n                  </td>\r\n                  <td class=\"text-center\">");
#nullable restore
#line 105 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                     Write(getNganhHoatDongKinhDoanh(list[i-2].MaNganh).MaNganh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td class=\"text-center\">Triệu đồng\r\n                          <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4481, "\"", 4502, 3);
            WriteAttributeValue("", 4488, "Detail[", 4488, 7, true);
#nullable restore
#line 107 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4495, z, 4495, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4497, "].Dvt", 4497, 5, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Triệu đồng\"/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4568, "\"", 4589, 3);
            WriteAttributeValue("", 4575, "Detail[", 4575, 7, true);
#nullable restore
#line 108 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4582, j, 4582, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4584, "].Dvt", 4584, 5, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Triệu đồng\"/>\r\n                  </td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 4694, "\"", 4712, 2);
            WriteAttributeValue("", 4699, "ThangTruoc_", 4699, 11, true);
#nullable restore
#line 110 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4710, i, 4710, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 4713, "\"", 4747, 3);
            WriteAttributeValue("", 4723, "changeThthangTruoc(\'", 4723, 20, true);
#nullable restore
#line 110 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4743, i, 4743, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4745, "\')", 4745, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4748, "\"", 4778, 3);
            WriteAttributeValue("", 4755, "Detail[", 4755, 7, true);
#nullable restore
#line 110 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4762, z, 4762, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4764, "].ThthangTruoc", 4764, 14, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 4845, "\"", 4865, 2);
            WriteAttributeValue("", 4850, "ThangTruocTT_", 4850, 13, true);
#nullable restore
#line 111 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4863, i, 4863, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 4866, "\"", 4902, 3);
            WriteAttributeValue("", 4876, "changeThthangTruocTT(\'", 4876, 22, true);
#nullable restore
#line 111 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4898, i, 4898, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4900, "\')", 4900, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4903, "\"", 4933, 3);
            WriteAttributeValue("", 4910, "Detail[", 4910, 7, true);
#nullable restore
#line 111 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4917, j, 4917, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4919, "].ThthangTruoc", 4919, 14, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 5000, "\"", 5014, 2);
            WriteAttributeValue("", 5005, "DuTinh_", 5005, 7, true);
#nullable restore
#line 112 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5012, i, 5012, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 5015, "\"", 5043, 3);
            WriteAttributeValue("", 5025, "changeDuTinh(\'", 5025, 14, true);
#nullable restore
#line 112 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5039, i, 5039, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5041, "\')", 5041, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5044, "\"", 5068, 3);
            WriteAttributeValue("", 5051, "Detail[", 5051, 7, true);
#nullable restore
#line 112 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5058, z, 5058, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5060, "].DuTinh", 5060, 8, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 5135, "\"", 5151, 2);
            WriteAttributeValue("", 5140, "DuTinhTT_", 5140, 9, true);
#nullable restore
#line 113 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5149, i, 5149, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 5152, "\"", 5182, 3);
            WriteAttributeValue("", 5162, "changeDuTinhTT(\'", 5162, 16, true);
#nullable restore
#line 113 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5178, i, 5178, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5180, "\')", 5180, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5183, "\"", 5207, 3);
            WriteAttributeValue("", 5190, "Detail[", 5190, 7, true);
#nullable restore
#line 113 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5197, j, 5197, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5199, "].DuTinh", 5199, 8, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input readonly type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 5267, "\"", 5286, 2);
            WriteAttributeValue("", 5272, "TongCongDon_", 5272, 12, true);
#nullable restore
#line 114 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5284, i, 5284, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" oninput=\"changeTongCongDon()\" class=\"infomal\"");
            BeginWriteAttribute("name", " name=\"", 5333, "\"", 5362, 3);
            WriteAttributeValue("", 5340, "Detail[", 5340, 7, true);
#nullable restore
#line 114 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5347, z, 5347, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5349, "].TongCongDon", 5349, 13, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input readonly type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 5422, "\"", 5443, 2);
            WriteAttributeValue("", 5427, "TongCongDonTT_", 5427, 14, true);
#nullable restore
#line 115 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5441, i, 5441, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infomal\"");
            BeginWriteAttribute("name", " name=\"", 5460, "\"", 5489, 3);
            WriteAttributeValue("", 5467, "Detail[", 5467, 7, true);
#nullable restore
#line 115 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5474, j, 5474, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5476, "].TongCongDon", 5476, 13, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 116 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                  
                    z += 2;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 120 "D:\ProC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          </tbody>
        </table>
<script>
        $('.infomal').on('blur', function() {
    if(checkNumber(this.value)){
        const value = this.value.replace(/,/g, '');
        this.value = parseFloat(value).toLocaleString('en-US', {
        style: 'decimal',
            maximumFractionDigits: 2,
            minimumFractionDigits: 2
            })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
