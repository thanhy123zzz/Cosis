#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a53418f42bd314a5dd4153b39b520091bcddbe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__2_1B), @"mvc.1.0.view", @"/Views/Shared/_2_1B.cshtml")]
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
#line 3 "D:\ProjectC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a53418f42bd314a5dd4153b39b520091bcddbe0", @"/Views/Shared/_2_1B.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__2_1B : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
  
    var context = new FormCosisContext();
    NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
    {
        return context.NganhHoatDongKinhDoanh.Where(x => x.MaNganh == ma).FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<tbody id=""table-data"">
    <tr class=""text-center"">
        <td>A</td>
        <td>B</td>
        <td>C</td>
        <td>1</td>
        <td>2</td>
        <td>3</td>
    </tr>
    <tr>
        <td>
            1. Ông/bà vui lòng cho biết tổng số tiền thu về (bao gồm cả vốn
            và lãi) của cơ sở [tháng trước] và dự tính [tháng báo cáo]
            <input type=""hidden"" id=""stt0"" name=""Detail[0].Stt"" value=""1."" />
            <input type=""hidden"" name=""Detail[0].TenCt""
                value=""Ông/bà vui lòng cho biết tổng số tiền thu về (bao gồm cả vốn và lãi) của cơ sở [tháng trước] và dự tính [tháng báo cáo]"" />
        </td>
        <td></td>
        <td class=""text-center"">Triệu đồng</td>
        <input type=""hidden"" name=""Detail[0].Dvt"" value=""Triệu đồng"" />
        <td><input type=""text"" pattern=""[0-9,.\-$]+"" id=""ThthangTruoc0"" oninput=""changeThthangTruoc(0)"" name=""Detail[0].ThthangTruoc""
                class=""infoma infomal"" readonly /></td>
        <td><input type=""text"" pa");
            WriteLiteral(@"ttern=""[0-9,.\-$]+"" id=""DuTinh0"" oninput=""changeDuTinh(0)"" name=""Detail[0].DuTinh"" class=""infoma infomal""
                readonly /></td>
        <td><input type=""text"" pattern=""[0-9,.\-$]+"" id=""TongCongDon0"" name=""Detail[0].TongCongDon"" class=""infoma infomal"" readonly /></td>
    </tr>
");
#nullable restore
#line 36 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
      
        int i = 0;
        int countDetails = 1;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
     foreach (var item in @ViewBag.ListNghanh)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <tr>
            <td>
                2. Trong tổng số tiền thu về của cơ sở, số tiền thu về (bao gồm
                cả vốn lẫn lãi) của [NGÀNH CHỌN MẪU] [tháng trước] và dự tính
                [tháng báo cáo]
                <input type=""hidden""");
            BeginWriteAttribute("id", " id=\'", 1993, "\'", 2016, 2);
            WriteAttributeValue("", 1998, "stt", 1998, 3, true);
#nullable restore
#line 47 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2001, countDetails, 2001, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2017, "\"", 2049, 3);
            WriteAttributeValue("", 2024, "Detail[", 2024, 7, true);
#nullable restore
#line 47 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2031, countDetails, 2031, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2044, "].Stt", 2044, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2050, "\"", 2074, 2);
            WriteAttributeValue("", 2058, "2._", 2058, 3, true);
#nullable restore
#line 47 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2061, item.MaNganh, 2061, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2116, "\"", 2150, 3);
            WriteAttributeValue("", 2123, "Detail[", 2123, 7, true);
#nullable restore
#line 48 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2130, countDetails, 2130, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2143, "].TenCt", 2143, 7, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                value=\"Trong tổng số tiền thu về của cơ sở, số tiền thu về (bao gồm cả vốn lẫn lãi) của [NGÀNH CHỌN MẪU] [tháng trước] và dự tính [tháng báo cáo]\" />\r\n            </td>\r\n            <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2373, "\"", 2431, 1);
#nullable restore
#line 51 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2381, getNganhHoatDongKinhDoanh(@item.MaNganh).TenNganh, 2381, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2432, "\"", 2460, 2);
            WriteAttributeValue("", 2437, "tennghanh_", 2437, 10, true);
#nullable restore
#line 51 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2447, countDetails, 2447, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                class=\"infoma\" /></td>\r\n            <td class=\"text-center\">Triệu đồng</td>\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 2588, "\"", 2620, 3);
            WriteAttributeValue("", 2595, "Detail[", 2595, 7, true);
#nullable restore
#line 54 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2602, countDetails, 2602, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2615, "].Dvt", 2615, 5, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Triệu đồng\" />\r\n            <td><input type=\"text\" pattern=\"[0-9,.\\-$]+\" required");
            BeginWriteAttribute("name", "  name=\"", 2710, "\"", 2752, 3);
            WriteAttributeValue("", 2718, "Detail[", 2718, 7, true);
#nullable restore
#line 55 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2725, countDetails, 2725, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2738, "].ThthangTruoc", 2738, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                id=\'", 2753, "\'", 2802, 2);
            WriteAttributeValue("", 2775, "ThthangTruoc", 2775, 12, true);
#nullable restore
#line 56 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2787, countDetails, 2787, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 2803, "\"", 2846, 3);
            WriteAttributeValue("", 2813, "changeThthangTruoc(", 2813, 19, true);
#nullable restore
#line 56 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2832, countDetails, 2832, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2845, ")", 2845, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma infomal\" /></td>\r\n            <td><input type=\"text\" pattern=\"[0-9,.\\-$]+\" required");
            BeginWriteAttribute("name", "  name=\"", 2945, "\"", 2981, 3);
            WriteAttributeValue("", 2953, "Detail[", 2953, 7, true);
#nullable restore
#line 57 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2960, countDetails, 2960, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2973, "].DuTinh", 2973, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2982, "\"", 3008, 2);
            WriteAttributeValue("", 2987, "DuTinh", 2987, 6, true);
#nullable restore
#line 57 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 2993, countDetails, 2993, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", "\r\n                oninput=\"", 3009, "\"", 3063, 3);
            WriteAttributeValue("", 3036, "changeDuTinh(", 3036, 13, true);
#nullable restore
#line 58 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3049, countDetails, 3049, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3062, ")", 3062, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma infomal\" /></td>\r\n            <td><input type=\"text\" pattern=\"[0-9,.\\-$]+\" readonly");
            BeginWriteAttribute("name", "  name=\"", 3162, "\"", 3203, 3);
            WriteAttributeValue("", 3170, "Detail[", 3170, 7, true);
#nullable restore
#line 59 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3177, countDetails, 3177, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3190, "].TongCongDon", 3190, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                id=\"", 3204, "\"", 3252, 2);
            WriteAttributeValue("", 3226, "TongCongDon", 3226, 11, true);
#nullable restore
#line 60 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3237, countDetails, 3237, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 3253, "\"", 3291, 3);
            WriteAttributeValue("", 3263, "changeCongDon(", 3263, 14, true);
#nullable restore
#line 60 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3277, countDetails, 3277, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3290, ")", 3290, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma infomal\" /></td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
        countDetails++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr id=\"checkRadio\">\r\n            <td>3. Cơ sở bán [NGÀNH CHỌN MẪU] tại đâu?\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3487, "\"", 3510, 2);
            WriteAttributeValue("", 3492, "stt", 3492, 3, true);
#nullable restore
#line 65 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3495, countDetails, 3495, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3511, "\"", 3543, 3);
            WriteAttributeValue("", 3518, "Detail[", 3518, 7, true);
#nullable restore
#line 65 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3525, countDetails, 3525, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3538, "].Stt", 3538, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3544, "\"", 3568, 2);
            WriteAttributeValue("", 3552, "3._", 3552, 3, true);
#nullable restore
#line 65 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3555, item.MaNganh, 3555, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 3610, "\"", 3639, 2);
            WriteAttributeValue("", 3615, "inputText", 3615, 9, true);
#nullable restore
#line 66 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3624, countDetails, 3624, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3640, "\"", 3674, 3);
            WriteAttributeValue("", 3647, "Detail[", 3647, 7, true);
#nullable restore
#line 66 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3654, countDetails, 3654, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3667, "].TenCt", 3667, 7, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                value=\"Cơ sở bán [NGÀNH CHỌN MẪU] tại đâu?\" />\r\n                <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 3775, "\"", 3802, 2);
            WriteAttributeValue("", 3780, "manghanh_", 3780, 9, true);
#nullable restore
#line 68 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3789, countDetails, 3789, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3803, "\"", 3824, 1);
#nullable restore
#line 68 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 3811, item.MaNganh, 3811, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden>\r\n            </td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>\r\n                1. Bán tại siêu thị mini, cửa hàng tiện ích\r\n                <input required type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 4023, "\"", 4050, 2);
            WriteAttributeValue("", 4030, "chose3_", 4030, 7, true);
#nullable restore
#line 74 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4037, countDetails, 4037, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4051, "\"", 4073, 2);
            WriteAttributeValue("", 4056, "3-1_", 4056, 4, true);
#nullable restore
#line 74 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4060, countDetails, 4060, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                2. Bán tại các địa điểm khác\r\n                <input type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 4197, "\"", 4224, 2);
            WriteAttributeValue("", 4204, "chose3_", 4204, 7, true);
#nullable restore
#line 78 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4211, countDetails, 4211, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4225, "\"", 4247, 2);
            WriteAttributeValue("", 4230, "3-2_", 4230, 4, true);
#nullable restore
#line 78 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4234, countDetails, 4234, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                3. Bán tại siêu thị mini, cửa hàng tiện ích và các địa điểm khác\r\n                <input type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 4407, "\"", 4434, 2);
            WriteAttributeValue("", 4414, "chose3_", 4414, 7, true);
#nullable restore
#line 82 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4421, countDetails, 4421, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4435, "\"", 4455, 2);
            WriteAttributeValue("", 4440, "3_", 4440, 2, true);
#nullable restore
#line 82 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4442, countDetails, 4442, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 85 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
        countDetails++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr id=\"checkRadio\"");
            BeginWriteAttribute("class", " class=\"", 4547, "\"", 4581, 2);
            WriteAttributeValue("", 4555, "changed3_", 4555, 9, true);
#nullable restore
#line 86 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4564, countDetails-1, 4564, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>\r\n                3.1 Số tiền thu về (bao gồm cả vốn và lãi) từ bán [NGÀNH CHỌN\r\n                MẪU] [tháng trước] và dự tính [tháng báo cáo] tại siêu thị mini,\r\n                cửa hàng tiện ích?\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 4836, "\"", 4859, 2);
            WriteAttributeValue("", 4841, "stt", 4841, 3, true);
#nullable restore
#line 91 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4844, countDetails, 4844, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 4860, "\"", 4892, 3);
            WriteAttributeValue("", 4867, "Detail[", 4867, 7, true);
#nullable restore
#line 91 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4874, countDetails, 4874, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4887, "].Stt", 4887, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4893, "\"", 4919, 2);
            WriteAttributeValue("", 4901, "3.1._", 4901, 5, true);
#nullable restore
#line 91 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4906, item.MaNganh, 4906, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 4961, "\"", 4995, 3);
            WriteAttributeValue("", 4968, "Detail[", 4968, 7, true);
#nullable restore
#line 92 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 4975, countDetails, 4975, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4988, "].TenCt", 4988, 7, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                value=\"Số tiền thu về (bao gồm cả vốn và lãi) từ bán [NGÀNH CHỌN MẪU] [tháng trước] và dự tính [tháng báo cáo] tại siêu thị mini, cửa hàng tiện ích?\" />\r\n            </td>\r\n            <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 5221, "\"", 5279, 1);
#nullable restore
#line 95 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5229, getNganhHoatDongKinhDoanh(@item.MaNganh).TenNganh, 5229, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" /></td>\r\n            <td class=\"text-center\">Triệu đồng</td>\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 5390, "\"", 5422, 3);
            WriteAttributeValue("", 5397, "Detail[", 5397, 7, true);
#nullable restore
#line 97 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5404, countDetails, 5404, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5417, "].Dvt", 5417, 5, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"Triệu đồng\" />\r\n            <td><input type=\"text\" required pattern=\"[0-9,.\\-$]+\" value=\"999,999,999.00\"");
            BeginWriteAttribute("name", "  name=\"", 5535, "\"", 5577, 3);
            WriteAttributeValue("", 5543, "Detail[", 5543, 7, true);
#nullable restore
#line 98 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5550, countDetails, 5550, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5563, "].ThthangTruoc", 5563, 14, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                id=\"", 5578, "\"", 5631, 3);
            WriteAttributeValue("", 5600, "ThthangTruoc", 5600, 12, true);
#nullable restore
#line 99 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5612, countDetails-2, 5612, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5629, "_1", 5629, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 5632, "\"", 5683, 3);
            WriteAttributeValue("", 5642, "changeThthangTruoc(\'", 5642, 20, true);
#nullable restore
#line 99 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5662, countDetails-2, 5662, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5679, "_1\')", 5679, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma infomal\" /></td>\r\n            <td><input type=\"text\" required pattern=\"[0-9,.\\-$]+\" value=\"999,999,999.00\"");
            BeginWriteAttribute("name", "  name=\"", 5805, "\"", 5841, 3);
            WriteAttributeValue("", 5813, "Detail[", 5813, 7, true);
#nullable restore
#line 100 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5820, countDetails, 5820, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5833, "].DuTinh", 5833, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                id=\"", 5842, "\"", 5889, 3);
            WriteAttributeValue("", 5864, "DuTinh", 5864, 6, true);
#nullable restore
#line 101 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5870, countDetails-2, 5870, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5887, "_1", 5887, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 5890, "\"", 5935, 3);
            WriteAttributeValue("", 5900, "changeDuTinh(\'", 5900, 14, true);
#nullable restore
#line 101 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 5914, countDetails-2, 5914, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5931, "_1\')", 5931, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma infomal\" /></td>\r\n            <td><input readonly");
            BeginWriteAttribute("value", " value=\"", 6000, "\"", 6008, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("name", "  name=\"", 6021, "\"", 6062, 3);
            WriteAttributeValue("", 6029, "Detail[", 6029, 7, true);
#nullable restore
#line 102 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 6036, countDetails, 6036, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6049, "].TongCongDon", 6049, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                id=\"", 6063, "\"", 6115, 3);
            WriteAttributeValue("", 6085, "TongCongDon", 6085, 11, true);
#nullable restore
#line 103 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 6096, countDetails-2, 6096, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6113, "_1", 6113, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("oninput", " oninput=\"", 6116, "\"", 6162, 3);
            WriteAttributeValue("", 6126, "changeCongDon(\'", 6126, 15, true);
#nullable restore
#line 103 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
WriteAttributeValue("", 6141, countDetails-2, 6141, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6158, "_1\')", 6158, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma infomal\" /></td>\r\n        </tr>\r\n");
#nullable restore
#line 105 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_2_1B.cshtml"
        i++;
        countDetails++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</tbody>
<script>
    $('.infomal').on('blur', function () {
    if (checkNumber(this.value)) {
      const value = this.value.replace(/,/g, '');
      this.value = parseFloat(value).toLocaleString('en-US', {
        style: 'decimal',
        maximumFractionDigits: 2,
        minimumFractionDigits: 2
      })
    }
  }); 
    $(document).ready(function () {
        $('tr[class*=""changed3_""').hide(this.check);
    });
    $('input[id*=""3_""]:radio').click(function () {
        var idInput = $(this).attr('id');
        var y = idInput.substring(2, idInput.length);
        $('input#inputText' + y).val('Cơ sở bán [NGÀNH CHỌN MẪU] tại đâu?Bán tại siêu thị mini, cửa hàng tiện ích và các địa điểm khác');
        var myNewValue = """";
        $('#TongCongDon'+(y-1)+'_1').val("""");
        $('#DuTinh'+(y-1)+'_1').val("""");
        $('#ThthangTruoc'+(y-1)+'_1').val("""");
        //
        $('#TongCongDon'+(y-1)+'_1').prop('required',true);
        $('#DuTinh'+(y-1)+'_1').prop('required',true);
   ");
            WriteLiteral(@"     $('#ThthangTruoc'+(y-1)+'_1').prop('required',true);
        //
        $('#DuTinh' +(y-1)+ '_1').attr({ ""max"": $('#DuTinh' + (y-1)).val() });
        $('#ThthangTruoc' +(y-1)+ '_1').attr({ ""max"": $('#ThthangTruoc' + (y-1)).val() });
        $('.changed3_' + y).show();
    });
    $('input[id*=""3-1_""]:radio').click(function () {
        var idInput = $(this).attr('id');
        var y = idInput.substring(4, idInput.length);
        $('input#inputText' + y).val('Cơ sở bán [NGÀNH CHỌN MẪU] tại đâu?Bán tại siêu thị mini, cửa hàng tiện ích');
        var myNewValue = ""999,999,999.00"";
        $('#TongCongDon'+(y-1)+'_1').attr('value',myNewValue);
        $('#DuTinh'+(y-1)+'_1').attr('value',myNewValue);
        $('#ThthangTruoc'+(y-1)+'_1').attr('value',myNewValue);  
        //
        $('#TongCongDon'+(y-1)+'_1').removeAttr('required');
        $('#DuTinh'+(y-1)+'_1').removeAttr('required');
        $('#ThthangTruoc'+(y-1)+'_1').removeAttr('required');
         $('#DuTinh' + (y-1) + '_1').");
            WriteLiteral(@"attr({ ""max"": """"});
         $('#ThthangTruoc' + (y-1) + '_1').attr({ ""max"": """"});
        $('.changed3_' + y).hide();

    });

    $('input[id*=""3-2_""]:radio').click(function () {
        var idInput = $(this).attr('id');
        var y = parseInt(idInput.substring(4, idInput.length));
        $('input#inputText' + y).val('Cơ sở bán [NGÀNH CHỌN MẪU] tại đâu?Bán tại các địa điểm khác');
        var myNewValue = ""999,999,999.00"";
        $('#TongCongDon'+(y-1)+'_1').attr('value',myNewValue);
        $('#DuTinh'+(y-1)+'_1').attr('value',myNewValue);
        $('#ThthangTruoc'+(y-1)+'_1').attr('value',myNewValue);
        //
        $('#TongCongDon'+(y-1)+'_1').removeAttr('required');
        $('#DuTinh'+(y-1)+'_1').removeAttr('required');
        $('#ThthangTruoc'+(y-1)+'_1').removeAttr('required');
        $('#DuTinh' + (y-1) + '_1').attr({ ""max"": """"});
        $('#ThthangTruoc' + (y-1) + '_1').attr({ ""max"": """"});
        $('.changed3_' + y).hide();
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