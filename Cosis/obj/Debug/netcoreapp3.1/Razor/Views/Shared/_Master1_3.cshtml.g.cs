#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16d915fd857ee0b9664bc2d700b1d47b404133ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Master1_3), @"mvc.1.0.view", @"/Views/Shared/_Master1_3.cshtml")]
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
#line 1 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16d915fd857ee0b9664bc2d700b1d47b404133ad", @"/Views/Shared/_Master1_3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Master1_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.Entities.Master>
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
#line 3 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
  
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
    List<NganhKinhDoanh> getNganhKinhDoanh(string mast1, string mast2)
    {
        return context.NganhKinhDoanh.Where(x => x.MaSoThue == mast1 && x.MaSoThue2 == mast2).ToList();
    }

    NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
    {
        return context.NganhHoatDongKinhDoanh.Where(x => x.MaNganh == ma).FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"ThongTinDoanhNghiepGroup\" class=\"form-group\">\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\">Tên doanh nghiệp/HTX: </label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 977, "\"", 995, 1);
#nullable restore
#line 32 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 985, Model.Ten, 985, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Master.Ten\" class=\"infoma\" />\r\n          </div>\r\n          <div class=\"adress\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 1102, "\"", 1108, 0);
            EndWriteAttribute();
            WriteLiteral(@">Địa chỉ doanh nghiệp </label>
            <div class=""adress-detail"">
              <div class=""row"">
                <label class=""lb-info"">Tỉnh/TP trực thuộc TW: </label>
                <select name=""Master.MaTinhTp"" id=""city"" class=""infoma"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d915fd857ee0b9664bc2d700b1d47b404133ad5462", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d915fd857ee0b9664bc2d700b1d47b404133ad7295", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16d915fd857ee0b9664bc2d700b1d47b404133ad9078", async() => {
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
            BeginWriteAttribute("value", " value=\"", 2586, "\"", 2612, 1);
#nullable restore
#line 63 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 2594, Model.DiaChiCuThe, 2594, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\">Số điện thoại: </label>\r\n            <input name=\"Master.Sdt\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2830, "\"", 2848, 1);
#nullable restore
#line 69 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 2838, Model.Sdt, 2838, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"infoma\" />\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\">Email: </label>\r\n            <input name=\"Master.Email\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3018, "\"", 3038, 1);
#nullable restore
#line 73 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 3026, Model.Email, 3026, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""infoma"" />
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
#line 84 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
             if (Model.MaLh.Trim() == "01")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"radio\" checked name=\"Master.MaLh\" value=\"01\"/>\r\n");
#nullable restore
#line 87 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"radio\" name=\"Master.MaLh\" value=\"01\"/>\r\n");
#nullable restore
#line 91 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
             if (Model.MaLh.Trim() == "02")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"radio\" checked name=\"Master.MaLh\" value=\"02\"/>\r\n");
#nullable restore
#line 95 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"radio\" name=\"Master.MaLh\" value=\"02\"/>\r\n");
#nullable restore
#line 99 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 101 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
             if (Model.MaLh.Trim() == "03")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <input type=\"radio\" checked name=\"Master.MaLh\" value=\"03\"/>\r\n");
#nullable restore
#line 104 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"radio\" name=\"Master.MaLh\" value=\"03\"/>\r\n");
#nullable restore
#line 108 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n          </div>\r\n      <div class=\"nganhKD row\">\r\n              <label class=\"nganh-lb\"");
            BeginWriteAttribute("for", " for=\"", 4414, "\"", 4420, 0);
            EndWriteAttribute();
            WriteLiteral(">Ngành hoạt động kinh doanh</label>\r\n    <div class=\"nganh-ct\">\r\n");
#nullable restore
#line 114 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
              
                int i = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
             foreach (NganhKinhDoanh nganh in getNganhKinhDoanh(Model.MaSoThue, Model.MaSoThue2))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                       <div class=\"MNHD row\">\r\n                          <input");
            BeginWriteAttribute("value", " value=\"", 4779, "\"", 4816, 1);
#nullable restore
#line 122 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 4787, nganh.MaNganh.Substring(0,1), 4787, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"\r\n                         maxlength=\"1\"\r\n                         size=\"1\"\r\n                         class=\"text-center MN\"/>\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 4991, "\"", 5028, 1);
#nullable restore
#line 126 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 4999, nganh.MaNganh.Substring(1,1), 4999, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                    />\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 5239, "\"", 5276, 1);
#nullable restore
#line 132 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 5247, nganh.MaNganh.Substring(2,1), 5247, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                    />\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 5487, "\"", 5524, 1);
#nullable restore
#line 138 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 5495, nganh.MaNganh.Substring(3,1), 5495, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                        />\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 5739, "\"", 5776, 1);
#nullable restore
#line 144 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
WriteAttributeValue("", 5747, nganh.MaNganh.Substring(4,1), 5747, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                      type=\"text\"\r\n                      maxlength=\"1\"\r\n                      size=\"1\"\r\n                      class=\"text-center MN\"\r\n                    />\r\n                      </div>\r\n                          <label");
            BeginWriteAttribute("for", " for=\"", 6015, "\"", 6021, 0);
            EndWriteAttribute();
            WriteLiteral(">Tên ngành HĐKD: ");
#nullable restore
#line 151 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
                                                   Write(getNganhHoatDongKinhDoanh(nganh.MaNganh).TenNganh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 154 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
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
#line 176 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
            Write(Html.Raw(Model.MaTinhTp.Trim()));

#line default
#line hidden
#nullable disable
            WriteLiteral("){\r\n            citis.options[citis.options.length] = new Option(x.Name, x.Id,true,true);\r\n            const result = data.filter(n => n.Id === x.Id);\r\n\r\n            for (const k of result[0].Districts) {\r\n                if(k.Id == ");
#nullable restore
#line 181 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
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
#line 186 "D:\ProjectC#\Cosis\Cosis\Views\Shared\_Master1_3.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosis.Models.Entities.Master> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
