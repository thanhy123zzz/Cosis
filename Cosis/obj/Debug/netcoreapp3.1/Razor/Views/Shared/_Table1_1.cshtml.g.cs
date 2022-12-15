#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66772f6566789401d4af02b06c38c2600f3883cb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66772f6566789401d4af02b06c38c2600f3883cb", @"/Views/Shared/_Table1_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Table1_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
  
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
#line 48 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                                       Write(getThangNamTruoc());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th colspan=\"2\" class=\"Money\">Dự tính ");
#nullable restore
#line 49 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                               Write(getThang());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 49 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                                           Write(getNam());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n              <th colspan=\"2\" class=\"Money\">\r\n                Cộng dồn từ đầu năm đến cuối tháng ");
#nullable restore
#line 51 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                              Write(getThang());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 51 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
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
#line 67 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
          
            list = getNganhKinhDoanh(ViewBag.MaSoThue1, ViewBag.MaSoThue2);
            int z = 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n              <td class=\"DMNganh\">1.Tổng doanh thu\r\n                  <input type=\"hidden\" id=\"SLRow\"");
            BeginWriteAttribute("value", " value=\"", 2172, "\"", 2191, 1);
#nullable restore
#line 74 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
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
              <td><input readonly type=""text"" class=""infoma"" id=""ThangTruoc0"" name=""Detail[0].ThthangTruoc""/>
              </td>
              <td><input readonly type=""text"" class=""infoma"" id=""ThangTruocTT0"" name=""Detail[1].ThthangTruoc"" /></td>
              <td><input readonly type=""text"" class=""infoma"" id=""DuTinh0"" name=""Detail[0].DuTinh""/></td>
             ");
            WriteLiteral(@" <td><input readonly type=""text"" class=""infoma"" id=""DuTinhTT0"" name=""Detail[1].DuTinh"" /></td>
              <td><input readonly type=""text"" class=""infoma"" id=""TongCongDon0"" name=""Detail[0].TongCongDon""/></td>
              <td><input readonly type=""text"" class=""infoma"" id=""TongCongDonTT0"" name=""Detail[1].TongCongDon""/></td>
            </tr>
            
");
#nullable restore
#line 94 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
             for(int i =2; i<(list.Count+2);i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 96 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                  
                    int j = z + 1;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <td class=\"DMNganh\">");
#nullable restore
#line 99 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(". Doanh thu thuần\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3824, "\"", 3835, 2);
            WriteAttributeValue("", 3829, "stt_", 3829, 4, true);
#nullable restore
#line 100 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3833, i, 3833, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3836, "\"", 3857, 3);
            WriteAttributeValue("", 3843, "Detail[", 3843, 7, true);
#nullable restore
#line 100 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3850, z, 3850, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3852, "].Stt", 3852, 5, true);
            EndWriteAttribute();
            WriteLiteral("p");
            BeginWriteAttribute("value", " value=\"", 3859, "\"", 3870, 2);
#nullable restore
#line 100 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3867, i, 3867, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3869, ".", 3869, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3917, "\"", 3930, 2);
            WriteAttributeValue("", 3922, "sttTT_", 3922, 6, true);
#nullable restore
#line 101 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3928, i, 3928, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3931, "\"", 3952, 3);
            WriteAttributeValue("", 3938, "Detail[", 3938, 7, true);
#nullable restore
#line 101 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3945, j, 3945, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3947, "].Stt", 3947, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3953, "\"", 3966, 2);
#nullable restore
#line 101 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 3961, i, 3961, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3963, ".1.", 3963, 3, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4013, "\"", 4036, 3);
            WriteAttributeValue("", 4020, "Detail[", 4020, 7, true);
#nullable restore
#line 102 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4027, z, 4027, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4029, "].TenCt", 4029, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4037, "\"", 4115, 4);
            WriteAttributeValue("", 4045, "Doanh", 4045, 5, true);
            WriteAttributeValue(" ", 4050, "thu", 4051, 4, true);
            WriteAttributeValue(" ", 4054, "thuần", 4055, 6, true);
#nullable restore
#line 102 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue(" ", 4060, getNganhHoatDongKinhDoanh(list[i-2].MaNganh).TenNganh, 4061, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4162, "\"", 4185, 3);
            WriteAttributeValue("", 4169, "Detail[", 4169, 7, true);
#nullable restore
#line 103 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4176, j, 4176, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4178, "].TenCt", 4178, 7, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Trong đó: Bán trong siêu thị trung tâm thương mại\"/>\r\n                  </td>\r\n                  <td class=\"text-center\">");
#nullable restore
#line 105 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                                     Write(getNganhHoatDongKinhDoanh(list[i-2].MaNganh).TenNganh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td class=\"text-center\">Triệu đồng\r\n                          <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4476, "\"", 4497, 3);
            WriteAttributeValue("", 4483, "Detail[", 4483, 7, true);
#nullable restore
#line 107 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4490, z, 4490, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4492, "].Dvt", 4492, 5, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Triệu đồng\"/>\r\n                      <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4563, "\"", 4584, 3);
            WriteAttributeValue("", 4570, "Detail[", 4570, 7, true);
#nullable restore
#line 108 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4577, j, 4577, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4579, "].Dvt", 4579, 5, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Triệu đồng\"/>\r\n                  </td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 4689, "\"", 4707, 2);
            WriteAttributeValue("", 4694, "ThangTruoc_", 4694, 11, true);
#nullable restore
#line 110 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4705, i, 4705, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 4708, "\"", 4742, 3);
            WriteAttributeValue("", 4718, "changeThthangTruoc(\'", 4718, 20, true);
#nullable restore
#line 110 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4738, i, 4738, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4740, "\')", 4740, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4743, "\"", 4773, 3);
            WriteAttributeValue("", 4750, "Detail[", 4750, 7, true);
#nullable restore
#line 110 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4757, z, 4757, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4759, "].ThthangTruoc", 4759, 14, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 4840, "\"", 4860, 2);
            WriteAttributeValue("", 4845, "ThangTruocTT_", 4845, 13, true);
#nullable restore
#line 111 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4858, i, 4858, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 4861, "\"", 4897, 3);
            WriteAttributeValue("", 4871, "changeThthangTruocTT(\'", 4871, 22, true);
#nullable restore
#line 111 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4893, i, 4893, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4895, "\')", 4895, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4898, "\"", 4928, 3);
            WriteAttributeValue("", 4905, "Detail[", 4905, 7, true);
#nullable restore
#line 111 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 4912, j, 4912, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4914, "].ThthangTruoc", 4914, 14, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 4995, "\"", 5009, 2);
            WriteAttributeValue("", 5000, "DuTinh_", 5000, 7, true);
#nullable restore
#line 112 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5007, i, 5007, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 5010, "\"", 5038, 3);
            WriteAttributeValue("", 5020, "changeDuTinh(\'", 5020, 14, true);
#nullable restore
#line 112 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5034, i, 5034, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5036, "\')", 5036, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5039, "\"", 5063, 3);
            WriteAttributeValue("", 5046, "Detail[", 5046, 7, true);
#nullable restore
#line 112 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5053, z, 5053, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5055, "].DuTinh", 5055, 8, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input type=\"text\" class=\"infomal\"");
            BeginWriteAttribute("id", " id=\"", 5130, "\"", 5146, 2);
            WriteAttributeValue("", 5135, "DuTinhTT_", 5135, 9, true);
#nullable restore
#line 113 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5144, i, 5144, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 5147, "\"", 5177, 3);
            WriteAttributeValue("", 5157, "changeDuTinhTT(\'", 5157, 16, true);
#nullable restore
#line 113 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5173, i, 5173, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5175, "\')", 5175, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 5178, "\"", 5202, 3);
            WriteAttributeValue("", 5185, "Detail[", 5185, 7, true);
#nullable restore
#line 113 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5192, j, 5192, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5194, "].DuTinh", 5194, 8, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input readonly type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 5262, "\"", 5281, 2);
            WriteAttributeValue("", 5267, "TongCongDon_", 5267, 12, true);
#nullable restore
#line 114 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5279, i, 5279, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" oninput=\"changeTongCongDon()\" class=\"infomal\"");
            BeginWriteAttribute("name", " name=\"", 5328, "\"", 5357, 3);
            WriteAttributeValue("", 5335, "Detail[", 5335, 7, true);
#nullable restore
#line 114 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5342, z, 5342, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5344, "].TongCongDon", 5344, 13, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                  <td><input readonly type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 5417, "\"", 5438, 2);
            WriteAttributeValue("", 5422, "TongCongDonTT_", 5422, 14, true);
#nullable restore
#line 115 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5436, i, 5436, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infomal\"");
            BeginWriteAttribute("name", " name=\"", 5455, "\"", 5484, 3);
            WriteAttributeValue("", 5462, "Detail[", 5462, 7, true);
#nullable restore
#line 115 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
WriteAttributeValue("", 5469, j, 5469, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5471, "].TongCongDon", 5471, 13, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 116 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
                  
                    z += 2;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 120 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Table1_1.cshtml"
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
