#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25a36c14b42f4b4c313df52c58ef24fe932b5405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form1_4_Form1_4PDF), @"mvc.1.0.view", @"/Views/Form1_4/Form1_4PDF.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a36c14b42f4b4c313df52c58ef24fe932b5405", @"/Views/Form1_4/Form1_4PDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330bfff8c7c5f9dba2758406de113abfa6a13415", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Form1_4_Form1_4PDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.PhieuDieuTra>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/bootstrap-4.5.3-dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form1 p-0 col-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
  
    Layout = null;
    FormCosisContext context = new FormCosisContext();
    string getTinh(string ma)
    {
        return context.TinhTp.Find(ma).Name;
    }
    string getHuyen(string ma)
    {
        return context.QuanHuyen.Find(ma).Name;
    }
    string getXa(string ma)
    {
        return context.PhuongXa.Find(ma).Name;
    }
    NganhHoatDongKinhDoanh getNganhHoatDongKinhDoanh(string ma)
    {
        return context.NganhHoatDongKinhDoanh.Find(ma);
    }
    NhanToAnhHuong nhanToAnhHuong(string ma)
    {
        return context.NhanToAnhHuong.Find(ma);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a36c14b42f4b4c313df52c58ef24fe932b54056898", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Document</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25a36c14b42f4b4c313df52c58ef24fe932b54057376", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25a36c14b42f4b4c313df52c58ef24fe932b54058554", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a36c14b42f4b4c313df52c58ef24fe932b540510440", async() => {
                WriteLiteral("\r\n    <!--Form -->\r\n    <div class=\"container\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a36c14b42f4b4c313df52c58ef24fe932b540510760", async() => {
                    WriteLiteral(@"
            <div class=""form-group text-center"">
                <label> <b>ĐIỀU TRA HOẠT ĐỘNG THƯƠNG MẠI VÀ DỊCH VỤ </b> </label>
            </div>
            <div class=""form-group MSTP-info"">
                <label class=""P-name""><b>Phiếu 1.4/DN-DVK-T</b></label>
                <div class=""mstp"">
                    <label");
                    BeginWriteAttribute("for", " for=\"", 1491, "\"", 1497, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Mã số thuế</label>\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 50 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                         for (int i = 0; i < 10; i++)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <input type=\"text\" id=\"n0\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\"");
                    BeginWriteAttribute("value", "\r\n                            value=\"", 1759, "\"", 1833, 1);
#nullable restore
#line 53 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
WriteAttributeValue("", 1796, Model.Master.MaSoThue.Substring(i,1), 1796, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly />\r\n");
#nullable restore
#line 54 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </div>\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 57 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                         for (int i = 0; i < 3; i++)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <input type=\"text\" id=\"n10\" maxlength=\"1\" size=\"1\" class=\"text-center MS\" autocomplete=\"off\"");
                    BeginWriteAttribute("value", "\r\n                            value=\"", 2143, "\"", 2218, 1);
#nullable restore
#line 60 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
WriteAttributeValue("", 2180, Model.Master.MaSoThue2.Substring(i,1), 2180, 38, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" readonly />\r\n");
#nullable restore
#line 61 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""form-group text-center"">
                <label class=""text-center"">
                    <b>PHIẾU THU THẬP THÔNG TIN ĐỐI VỚI DOANH NGHIỆP/HỢP TÁC XÃ</b>
                </label>
                <label>
                    <b>
                        <i>
                            (Áp dụng đối với doanh nghiệp/chi nhánh doanh nghiệp, hợp tác xã
                            có hoạt động dịch vụ kinh doanh bất động sản và một số dịch vụ
                            khác)
                        </i>
                    </b>
                </label>
            </div>

            <div class=""form-group text-center"">
                <div class=""row""></div>
                <div>
                    <label> <b>Tháng ");
#nullable restore
#line 83 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                Write(Model.Master.NgayTao.Value.Month);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" Năm ");
#nullable restore
#line 83 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                                      Write(Model.Master.NgayTao.Value.Year);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</b> </label>
                </div>
                <div class=""row""></div>
            </div>
            <div class=""form-group m-title text-center"">
                <h5 style=""margin-top: .5rem;""><b>A. THÔNG TIN CHUNG</b></h5>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <label class=""lb-info""><b>1. Tên doanh nghiệp/HTX: </b></label>
                    <label>");
#nullable restore
#line 93 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                      Write(Model.Master.Ten);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"adress\">\r\n                    <label");
                    BeginWriteAttribute("for", " for=\"", 3720, "\"", 3726, 0);
                    EndWriteAttribute();
                    WriteLiteral("><b>2. Địa chỉ doanh nghiệp </b></label>\r\n                    <div class=\"adress-detail\">\r\n                        <div class=\"row\">\r\n                            <label class=\"lb-info\">Tỉnh/TP trực thuộc TW: </label>\r\n                            <label>");
#nullable restore
#line 100 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                              Write(getTinh(Model.Master.MaTinhTp));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</label>
                        </div>
                        <div class=""row"">
                            <label class=""lb-info"">
                                Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:
                            </label>
                            <label>");
#nullable restore
#line 106 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                              Write(getHuyen(Model.Master.MaQuanHuyen));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <label class=\"lb-info\">Xã/phường/thị trấn: </label>\r\n                            <label>");
#nullable restore
#line 110 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                              Write(getXa(Model.Master.MaPhuongXa));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</label>
                        </div>
                        <div class=""row"">
                            <label class=""lb-info"">
                                Thôn, ấp<i>(số nhà, đường phố)</i>:
                            </label>
                            <label>");
#nullable restore
#line 116 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                              Write(Model.Master.DiaChiCuThe);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <label class=\"lb-info\"><b>3. Số điện thoại: </b></label>\r\n                    <label>");
#nullable restore
#line 122 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                      Write(Model.Master.Sdt);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <label class=\"lb-info\"><b>4. Email: </b></label>\r\n                    <label>");
#nullable restore
#line 126 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                      Write(Model.Master.Email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 129 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                     if (Model.Master.MaLh.Trim() == "01")
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <label class=\"lb-info\"><b>5. Loại hình kinh tế: </b></label>\r\n                        <label>Kinh tế nhà nước</label>\r\n");
#nullable restore
#line 133 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                    }
                    else if (Model.Master.MaLh.Trim() == "02")
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <label class=\"lb-info\"><b>5. Loại hình kinh tế: </b></label>\r\n                        <label>Kinh tế ngoài nhà nước</label>\r\n");
#nullable restore
#line 138 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                    }
                    else if (Model.Master.MaLh.Trim() == "03")
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <label class=\"lb-info\"><b>5. Loại hình kinh tế: </b></label>\r\n                        <label>Kinh tế có vốn đầu tư trực tiếp nước ngoài</label>\r\n");
#nullable restore
#line 143 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                </div>\r\n                <div class=\"row m-0\">\r\n                    <div class=\"col-3\">\r\n                    <label class=\"pl-1\"");
                    BeginWriteAttribute("for", " for=\"", 6305, "\"", 6311, 0);
                    EndWriteAttribute();
                    WriteLiteral("><b>6. Ngành hoạt động kinh doanh</b></label>\r\n                    </div>\r\n                    <div class=\"col-9 m-0\">\r\n");
#nullable restore
#line 150 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                     foreach(NganhKinhDoanh a in ViewBag.NganhKinhDoanh)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <div class=\"row m-0 pl-0\">\r\n                        <div class=\"col-5 pl-0\">\r\n");
#nullable restore
#line 154 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                             for (int i =0; i<5;i++)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                       <input type=\"text\"maxlength=\"1\"size=\"1\" readonly class=\"text-center MN\"");
                    BeginWriteAttribute("value", " value = \"", 6834, "\"", 6869, 1);
#nullable restore
#line 156 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
WriteAttributeValue("", 6844, a.MaNganh.Substring(i,1), 6844, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("/>\r\n");
#nullable restore
#line 157 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        </div>\r\n                        <div class=\"col-7 pl-0 pr-0\">\r\n                            <label");
                    BeginWriteAttribute("for", " for=\"", 7034, "\"", 7040, 0);
                    EndWriteAttribute();
                    WriteLiteral(">Tên ngành HĐKD:  ");
#nullable restore
#line 160 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                      Write(getNganhHoatDongKinhDoanh(a.MaNganh).TenNganh);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                        </div>\r\n                        </div>\r\n");
#nullable restore
#line 163 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""form-group m-title text-center"">
                <h5 style=""margin-top: .5rem;""><b>B. KẾT QUẢ HOẠT ĐỘNG KINH DOANH</b></h5>
            </div>
            <table class=""table table-striped table-hover table-bordered"">
                <thead>
                    <tr class=""text-center"">
                        <th style=""width:30%;""><b>Tên chỉ tiêu</b></th>
                        <th style=""width:25%;"" class=""NganhCM""><b>Ngành chọn mẫu</b></th>
                        <th style=""width:15%;""><b>Tháng thực hiện ");
#nullable restore
#line 175 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                             Write(Model.Master.ThangThucHien);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b></th>\r\n                        <th style=\"width:15%;\"><b>Dự tính ");
#nullable restore
#line 176 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                     Write(Model.Master.ThangDuTinh);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</b></th>\r\n                        <th style=\"width:15%;\" class=\"text-uppercase\">\r\n                            <b>CỘNG DỒN TỪ ĐẦU NĂM ĐẾN CUỐI THÁNG ");
#nullable restore
#line 178 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                             Write(Model.Master.ThangDuTinh);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" / ");
#nullable restore
#line 178 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                                                         Write(Model.Master.Nam);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</b>
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr class=""text-center"">
                        <td></td>
                        <td></td>
                        <td colspan=""3"">Đơn vị tính: Triệu đồng</td>
                    </tr>
                    <tr class=""text-center"">
                        <td>A</td>
                        <td>1</td>
                        <td>2</td>
                        <td>3</td>
                        <td>4</td>
                    </tr>
");
#nullable restore
#line 195 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                      
                        foreach (var dt in Model.Detail)
                        {
                            if (dt.Stt.Trim() == "1.")
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\r\n                                    <td");
                    BeginWriteAttribute("class", " class=\"", 8990, "\"", 8998, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 201 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                            Write(dt.Stt);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 201 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                    Write(dt.TenCt);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\"></td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 203 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(string.Format("{0:#,##0.00}",dt.ThthangTruoc));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 204 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(string.Format("{0:#,##0.00}",dt.DuTinh));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 205 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(string.Format("{0:#,##0.00}",dt.TongCongDon));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 207 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                            }
                            else
                            {
                                string cutSTT = dt.Stt.Substring(0, dt.Stt.IndexOf("_"));
                                string cutNGanh = dt.Stt.Substring(dt.Stt.IndexOf("_") + 1);
                                var a = context.NganhHoatDongKinhDoanh.Where(x => x.MaNganh == cutNGanh.Trim()).FirstOrDefault();
                                string tenNganh = a.TenNganh;

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <tr>\r\n                                    <td");
                    BeginWriteAttribute("class", " class=\"", 10014, "\"", 10022, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 215 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                            Write(cutSTT);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 215 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                    Write(dt.TenCt);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 216 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(tenNganh);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 217 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(string.Format("{0:#,##0.00}",dt.ThthangTruoc));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 218 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(string.Format("{0:#,##0.00}",dt.DuTinh));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 219 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                                       Write(string.Format("{0:#,##0.00}",dt.TongCongDon));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 221 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                </tbody>
            </table>
            <div class=""form-group m-title text-center"">
                <h5 style=""margin-top: .5rem;""><b>C. CÁC YẾU TỔ ẢNH HƯỞNG ĐẾN HOẠT ĐỘNG KINH DOANH</b></h5>
            </div>
            <div class=""form-group"">
                <label");
                    BeginWriteAttribute("for", " for=\"", 10871, "\"", 10877, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    Yếu tố nào sau đây ảnh hưởng đến hoạt động kinh doanh của đơn vị\r\n                    trong tháng ");
#nullable restore
#line 232 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                           Write(Model.Master.ThangThucHien);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </label>\r\n                <div class=\"YTAH\">\r\n                    <div class=\"YTAH-tt\">\r\n");
#nullable restore
#line 236 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                         for (int i = 0; i < Model.DanhSachNhanToAnhHuong.Count; i++)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <label");
                    BeginWriteAttribute("for", " for=\"", 11281, "\"", 11287, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 238 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                     Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral(". ");
#nullable restore
#line 238 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                         Write(nhanToAnhHuong(@Model.DanhSachNhanToAnhHuong[i].MaAh).NoiDungAh);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n");
#nullable restore
#line 239 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 242 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                 if (Model.NhanToThu9 != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div class=\"YTAH9\" style=\"margin-left:20px;\">\r\n                        <label>Yếu tố khác: ");
#nullable restore
#line 245 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                                       Write(Model.NhanToThu9.NoiDung);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 247 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("            </div>\r\n            <div class=\"uname-info\">\r\n                <div class=\"row\">\r\n                    <label class=\"uname-lb\">Họ tên người trả lời:</label>\r\n                    <label>");
#nullable restore
#line 252 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                      Write(Model.Master.TenNguoiTraLoi);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <label class=\"uname-lb\">Số điện thoại:</label>\r\n                    <label>");
#nullable restore
#line 256 "D:\ProjectC#\Cosis\Cosis\Views\Form1_4\Form1_4PDF.cshtml"
                      Write(Model.Master.SdtnguoiTraLoi);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

    <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/axios/0.21.1/axios.min.js""></script>

    <script type=""text/javascript"">
        $("".MS"").keyup(function (e) {
            if (this.value.length === this.maxLength) {
                var next = $(this).data(""next"");
                if (next === 13) {
                } else {
                    var check = document.getElementById(""n"" + next).value;
                    if (check !== """") {
                    } else {
                        document.getElementById(""n"" + next).focus();
                    }
                }
            }
        });
        $(""#YT");
                WriteLiteral(@"9"").change(function () {
            if (this.checked) {
                document.getElementById(""comment"").disabled = false;
            } else {
                document.getElementById(""comment"").disabled = true;
            }
        });
        $(""#3"").click(function () {
            $("".changed3"").toggle(this.checked);
        });
        $(""#3-1"").click(function () {
            $("".changed3"").hide(this.check);
        });
        $(""#3-2"").click(function () {
            $("".changed3"").hide(this.check);
        });
        $(""#5"").click(function () {
            $("".changed1"").toggle(this.checked);
        });
        $(""#5-1"").click(function () {
            $("".changed1"").hide(this.check);
        });
        $(""#13"").click(function () {
            $("".changed2"").toggle(this.checked);
        });
        $(""#13-1"").click(function () {
            $("".changed2"").hide(this.check);
        });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosis.Models.PhieuDieuTra> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
