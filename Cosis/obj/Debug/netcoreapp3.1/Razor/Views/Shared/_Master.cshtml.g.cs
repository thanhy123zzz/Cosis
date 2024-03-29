#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b11b45f8149a9ba3a2a778911e10fb2dd42ac35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Master), @"mvc.1.0.view", @"/Views/Shared/_Master.cshtml")]
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
#line 4 "D:\ProjectC#\Cosis\Cosis\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b11b45f8149a9ba3a2a778911e10fb2dd42ac35", @"/Views/Shared/_Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330bfff8c7c5f9dba2758406de113abfa6a13415", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.Entities.ThongTinDoanhNghiep>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
  
    FormCosisContext context = new FormCosisContext();
   /* TinhTp getTinh(string idTinh){
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
    */
    List<NganhKinhDoanh> getNganhKinhDoanh(string mast1, string mast2){
        return context.NganhKinhDoanh.Where(x => x.MaSoThue == mast1 && x.MaSoThue2 == mast2).ToList();
    }

    NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma){
        return context.NganhHoatDongKinhDoanh.Where(x=>x.MaNganh == ma).FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"ThongTinDoanhNghiepGroup\" class=\"form-group\">\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\"><b>1. Tên doanh nghiệp/HTX: </b></label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 974, "\"", 1003, 1);
#nullable restore
#line 30 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 982, Model.TenDoanhNghiep, 982, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Master.Ten\" class=\"infoma\" />\r\n          </div>\r\n          <div class=\"adress\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 1110, "\"", 1116, 0);
            EndWriteAttribute();
            WriteLiteral(@"><b>2. Địa chỉ doanh nghiệp: </b></label>
            <div class=""adress-detail"">
              <div class=""row"">
                <label class=""lb-info"">Tỉnh/TP trực thuộc TW: </label>
                <select name=""Master.MaTinhTp"" id=""city"" class=""infoma"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b11b45f8149a9ba3a2a778911e10fb2dd42ac355627", async() => {
                WriteLiteral("--- Chọn Tỉnh/TP ---");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
              </div>
              <div class=""row"">
                <label class=""lb-info""
                  >Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:
                </label>
                <select name=""Master.MaQuanHuyen"" id=""district"" class=""infoma"">
");
            WriteLiteral("                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b11b45f8149a9ba3a2a778911e10fb2dd42ac357460", async() => {
                WriteLiteral("--- Chọn Huyện/quận ---");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n              </div>\r\n              <div class=\"row\">\r\n                <label class=\"lb-info\">Xã/phường/thị trấn: </label>\r\n                <select name=\"Master.MaPhuongXa\" id=\"ward\" class=\"infoma\">\r\n");
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b11b45f8149a9ba3a2a778911e10fb2dd42ac359243", async() => {
                WriteLiteral("--- Chọn Xã/phường/thị trấn ---");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
              </div>
              <div class=""row"">
                <label class=""lb-info""
                  >Thôn, ấp<i>(số nhà, đường phố)</i>:
                </label>
                <input name=""Master.DiaChiCuThe"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 2600, "\"", 2626, 1);
#nullable restore
#line 61 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 2608, Model.DiaChiCuThe, 2608, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\"><b>3. Số điện thoại: </b></label>\r\n            <input name=\"Master.Sdt\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2854, "\"", 2883, 1);
#nullable restore
#line 67 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 2862, Model.SdtdoanhNghiep, 2862, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\"><b>4. Email: </b></label>\r\n            <input name=\"Master.Email\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3063, "\"", 3083, 1);
#nullable restore
#line 71 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 3071, Model.Email, 3071, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""infoma"" />
          </div>
          <div class=""loaihinh"">
            <label><b>5. Loại hình kinh tế: </b></label>

            <div class=""checkbox-tt"">
              <label> 1.Kinh tế nhà nước</label>
              <label> 2.Kinh tế ngoài nhà nước</label>
              <label> 3.Kinh tế có vốn đầu tư trực tiếp nước ngoài</label>
            </div>
            <div class=""checkbox"">
");
#nullable restore
#line 82 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
                 if(Model.MaLh.Trim()=="01"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"radio\" checked name=\"Master.MaLh\" value=\"01\"/>\r\n");
#nullable restore
#line 84 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"radio\" name=\"Master.MaLh\" value=\"01\"/>\r\n");
#nullable restore
#line 87 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
             if (Model.MaLh.Trim() == "02")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"radio\" checked name=\"Master.MaLh\" value=\"02\"/>\r\n");
#nullable restore
#line 91 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"radio\" name=\"Master.MaLh\" value=\"02\"/>\r\n");
#nullable restore
#line 94 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n");
#nullable restore
#line 96 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
             if (Model.MaLh.Trim() == "03") {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <input type=\"radio\" checked name=\"Master.MaLh\" value=\"03\"/>\r\n");
#nullable restore
#line 98 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"radio\" name=\"Master.MaLh\" value=\"03\"/>\r\n");
#nullable restore
#line 100 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n          </div>\r\n      <div class=\"nganhKD row\">\r\n              <label class=\"nganh-lb\"");
            BeginWriteAttribute("for", " for=\"", 4377, "\"", 4383, 0);
            EndWriteAttribute();
            WriteLiteral("><b>6. Ngành hoạt động kinh doanh</b></label>\r\n    <div class=\"nganh-ct\">\r\n");
#nullable restore
#line 106 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
          
            int i= 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
         foreach (NganhKinhDoanh nganh in getNganhKinhDoanh(Model.MaSoThue, Model.MaSoThue2))
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                   <div class=\"MNHD row\">\r\n                      <input");
            BeginWriteAttribute("value", " value=\"", 4731, "\"", 4768, 1);
#nullable restore
#line 114 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 4739, nganh.MaNganh.Substring(0,1), 4739, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"\r\n                         maxlength=\"1\"\r\n                         size=\"1\"\r\n                         class=\"text-center MN\"/>\r\n                        <input");
            BeginWriteAttribute("value", " value=\"", 4939, "\"", 4976, 1);
#nullable restore
#line 118 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 4947, nganh.MaNganh.Substring(1,1), 4947, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                    />\r\n                        <input");
            BeginWriteAttribute("value", " value=\"", 5183, "\"", 5220, 1);
#nullable restore
#line 124 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 5191, nganh.MaNganh.Substring(2,1), 5191, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                    />\r\n                    <input");
            BeginWriteAttribute("value", " value=\"", 5423, "\"", 5460, 1);
#nullable restore
#line 130 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 5431, nganh.MaNganh.Substring(3,1), 5431, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                          type=\"text\"\r\n                          maxlength=\"1\"\r\n                          size=\"1\"\r\n                          class=\"text-center MN\"\r\n                    />\r\n                        <input");
            BeginWriteAttribute("value", " value=\"", 5683, "\"", 5720, 1);
#nullable restore
#line 136 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
WriteAttributeValue("", 5691, nganh.MaNganh.Substring(4,1), 5691, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                    />\r\n                  </div>\r\n                      <label");
            BeginWriteAttribute("for", " for=\"", 5951, "\"", 5957, 0);
            EndWriteAttribute();
            WriteLiteral(">Tên ngành HĐKD: ");
#nullable restore
#line 143 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
                                               Write(getNganhHoatDongKinhDoanh(nganh.MaNganh).TenNganh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                  \r\n                </div>\r\n");
#nullable restore
#line 146 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"             </div>
      </div>
</div>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/axios/0.21.1/axios.min.js""></script>
<script>
    var citis = document.getElementById(""city"");
var districts = document.getElementById(""district"");
var wards = document.getElementById(""ward"");

var Parameter = {
  url: ""https://localhost:44358/assets/DiaChi.json"", 
  method: ""GET"", 
  responseType: ""application/json"", 
};
var promise = axios(Parameter);
promise.then(
    function (result) {
        renderCity(result.data);
});
function renderCity(data) {
  for (const x of data) {
      if(x.Id == ");
#nullable restore
#line 168 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
            Write(Html.Raw(Model.MaTinhTp.Trim()));

#line default
#line hidden
#nullable disable
            WriteLiteral("){\r\n            citis.options[citis.options.length] = new Option(x.Name, x.Id,true,true);\r\n            const result = data.filter(n => n.Id === x.Id);\r\n\r\n            for (const k of result[0].Districts) {\r\n                if(k.Id == ");
#nullable restore
#line 173 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
                      Write(Html.Raw(Model.MaQuanHuyen.Trim()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"){
                    district.options[district.options.length] = new Option(k.Name, k.Id,true,true);
                    const dataCity = data.filter((n) => n.Id === citis.value);
                    const dataWards = dataCity[0].Districts.filter(n => n.Id === k.Id)[0].Wards;
                      for (const w of dataWards) {
                          if(w.Id==");
#nullable restore
#line 178 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master.cshtml"
                              Write(Html.Raw(Model.MaPhuongXa.Trim()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"){
                            wards.options[wards.options.length] = new Option(w.Name, w.Id,true,true);
                          }else{
                              wards.options[wards.options.length] = new Option(w.Name, w.Id);
                          }
                      }
                }else{
                    district.options[district.options.length] = new Option(k.Name, k.Id);
                }
            }
      }else{
          citis.options[citis.options.length] = new Option(x.Name, x.Id);
      }
  }
citis.onchange = function () {
    district.length = 1;
    ward.length = 1;
    if(this.value != """"){
      const result = data.filter(n => n.Id === this.value);

      for (const k of result[0].Districts) {
        district.options[district.options.length] = new Option(k.Name, k.Id);
      }
    }
  };
  district.onchange = function () {
    ward.length = 1;
    const dataCity = data.filter((n) => n.Id === citis.value);
    if (this.value != """") {
      const d");
            WriteLiteral("ataWards = dataCity[0].Districts.filter(n => n.Id === this.value)[0].Wards;\r\n\r\n      for (const w of dataWards) {\r\n            wards.options[wards.options.length] = new Option(w.Name, w.Id);\r\n      }\r\n    }\r\n  };\r\n}\r\n    </script>");
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
