#pragma checksum "D:\ProjectC#\Cosis\Cosis\Views\Form1_3\Form1_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form1_3_Form1_3), @"mvc.1.0.view", @"/Views/Form1_3/Form1_3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a7", @"/Views/Form1_3/Form1_3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Form1_3_Form1_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.PhieuDieuTra>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/bootstrap-4.5.3-dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\ProjectC#\Cosis\Cosis\Views\Form1_3\Form1_3.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a75432", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Document</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a75910", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a77088", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a78970", async() => {
                WriteLiteral("\r\n    <!--Form -->\r\n    <div class=\"container\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cd73b3e3c3cd876d653a29ad75fd840b5c2d5a79289", async() => {
                    WriteLiteral(@"
            <div class=""form-group text-center"">
                <label> <b>ĐIỀU TRA HOẠT ĐỘNG THƯƠNG MẠI VÀ DỊCH VỤ </b> </label>
            </div>
            <div class=""form-group row"">
                <label class=""P-name""><b>Phiếu 1.3/DN-VT-T</b></label>
                <label");
                    BeginWriteAttribute("for", " for=\"", 838, "\"", 844, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Mã số thuế</label>
                <div class=""row"">
                    <input type=""text""
                           id=""n0""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           autofocus
                           data-next=""1"" />
                    <input type=""text""
                           id=""n1""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""2"" />
                    <input type=""text""
                           id=""n2""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""3"" />
                    <input type=""tex");
                    WriteLiteral(@"t""
                           id=""n3""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""4"" />
                    <input type=""text""
                           id=""n4""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""5"" />
                    <input type=""text""
                           id=""n5""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""6"" />
                    <input type=""text""
                           id=""n6""
                           maxlength=""1""
                           size=""1""
           ");
                    WriteLiteral(@"                class=""text-center MS""
                           autocomplete=""off""
                           data-next=""7"" />
                    <input type=""text""
                           id=""n7""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""8"" />
                    <input type=""text""
                           id=""n8""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""9"" />
                    <input type=""text""
                           id=""n9""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""10"" /");
                    WriteLiteral(@">
                </div>
                <div class=""row"">
                    <input type=""text""
                           id=""n10""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""11"" />
                    <input type=""text""
                           id=""n11""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""12"" />
                    <input type=""text""
                           id=""n12""
                           maxlength=""1""
                           size=""1""
                           class=""text-center MS""
                           autocomplete=""off""
                           data-next=""13"" />
                </div>
            </div>
            <div c");
                    WriteLiteral(@"lass=""form-group text-center"">
                <label class=""text-center"">
                    <b>PHIẾU THU THẬP THÔNG TIN ĐỐI VỚI DOANH NGHIỆP/HỢP TÁC XÃ</b>
                </label>
                <label>
                    <b>
                        <i>
                            (Áp dụng đối với doanh nghiệp/chi nhánh doanh nghiệp, hợp tác xã
                            có hoạt động vận tải, kho bãi)
                        </i>
                    </b>
                </label>
            </div>

            <div class=""form-group text-center"">
                <div class=""row""></div>
                <div>
                    <label> <b>Tháng ... Năm 202...</b> </label>
                </div>
                <div class=""row""></div>
            </div>
            <div class=""form-group bg-primary"">
                <h5><b>A. THÔNG TIN CHUNG</b></h5>
            </div>
            <div class=""form-group"">
                <div class=""row"">
                    <label class=""lb-inf");
                    WriteLiteral("o\">Tên doanh nghiệp/HTX: </label>\r\n                    <label>Tên doanh nghiệp</label>\r\n                </div>\r\n                <div class=\"adress\">\r\n                    <label");
                    BeginWriteAttribute("for", " for=\"", 6141, "\"", 6147, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Địa chỉ doanh nghiệp </label>
                    <div class=""adress-detail"">
                        <div class=""row"">
                            <label class=""lb-info"">Tỉnh/TP trực thuộc TW: </label>
                            <label>Tỉnh tp</label>
                        </div>
                        <div class=""row"">
                            <label class=""lb-info"">
                                Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:
                            </label>
                            <label>Quận huyện</label>
                        </div>
                        <div class=""row"">
                            <label class=""lb-info"">Xã/phường/thị trấn: </label>
                            <label>Xã phường thị trấn</label>
                        </div>
                        <div class=""row"">
                            <label class=""lb-info"">
                                Thôn, ấp<i>(số nhà, đường phố)</i>:
                            </label>
             ");
                    WriteLiteral(@"               <label>thôn ấp xã</label>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <label class=""lb-info"">Số điện thoại: </label>
                    <label>013681852</label>
                </div>
                <div class=""row"">
                    <label class=""lb-info"">Email: </label>
                    <label>anhkdl@gmail.com</label>
                </div>
                <div class=""loaihinh"">
                    <label>Loại hình kinh tế</label>

                    <div class=""checkbox-tt"">
                        <label> 1.Kinh tế nhà nước</label>
                        <label> 2.Kinh tế ngoài nhà nước</label>
                        <label> 3.Kinh tế có vốn đầu tư trực tiếp nước ngoài</label>
                    </div>
                    <div class=""checkbox"">
                        <input type=""radio"" name=""loaihinhkt"" value=""Kinh tế nhà nước"" />
                        <input type");
                    WriteLiteral(@"=""radio""
                               name=""loaihinhkt""
                               value=""Kinh tế ngoài nhà nước"" />
                        <input type=""radio""
                               name=""loaihinhkt""
                               value=""Kinh tế có vốn đầu tư trực tiếp nước ngoài"" />
                    </div>
                </div>
                <div class=""nganhKD row"">
                    <label class=""nganh-lb"">Ngành hoạt động kinh doanh</label>
                    <div class=""nganh-ct"">
                        <div class=""row"">
                            <div class=""MNHD row"">
                                <input type=""text""
                                       maxlength=""1""
                                       size=""1""
                                       class=""text-center MN"" />
                                <input type=""text""
                                       maxlength=""1""
                                       size=""1""
                           ");
                    WriteLiteral(@"            class=""text-center MN"" />
                                <input type=""text""
                                       maxlength=""1""
                                       size=""1""
                                       class=""text-center MN"" />
                                <input type=""text""
                                       maxlength=""1""
                                       size=""1""
                                       class=""text-center MN"" />
                                <input type=""text""
                                       maxlength=""1""
                                       size=""1""
                                       class=""text-center MN"" />
                            </div>
                            <label");
                    BeginWriteAttribute("for", " for=\"", 9992, "\"", 9998, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">Tên ngành HĐKD:</label>
                            <label>Ngành mua bán đất</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""form-group bg-primary"">
                <h5><b>B. KẾT QUẢ HOẠT ĐỘNG KINH DOANH</b></h5>
            </div>
            <table class=""table table-bordered"">
                <thead>
                    <tr class=""text-center"">
                        <th><b>Tên chỉ tiêu</b></th>
                        <th><b>Đơn vị tính</b></th>
                        <th><b>Thực hiện</b></th>
                        <th><b>Dự tính</b></th>
                        <th class=""col-lg-2"">
                            CỘNG DỒN TỪ ĐẦU NĂM ĐẾN CUỐI THÁNG BÁO CÁO
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr class=""text-center"">
                        <td>A</td>
                        <td>B</td>
                        ");
                    WriteLiteral(@"<td>1</td>
                        <td>2</td>
                        <td>3</td>
                    </tr>
                    <tr>
                        <td>1.Tổng doanh thu</td>
                        <td class=""text-center"">Triệu đồng</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <th attr colspan=""5"">I. Hoạt động vận tải hành khách</th>
                    </tr>
                    <tr>
                        <td>2.Doanh thu thuần</td>
                        <td class=""text-center"">Triệu đồng</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>3.Số lượt khách vận chuyển</td>
                        <td class=""text-center"">Lượ");
                    WriteLiteral(@"t khách</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td class=""p-1""><i>3.1.Trong đó: Ngoài nước</i></td>
                        <td class=""text-center"">Lượt khách</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>4.Số lượt hành khách luân chuyển</td>
                        <td class=""text-center"">HK Km</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td class=""p-1""><i>4.1.Trong đó: Ngoài nước</i></td>
                        <td class=""text-center"">HK Km");
                    WriteLiteral(@"</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>5.Đơn giá bình quân</td>
                        <td class=""text-center"">HK Km</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>6.Tổng số phương tiện đang hoạt động</td>
                        <td class=""text-center"">HK Km</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>7.Tổng tải trọng</td>
                        <td class=""text-center"">HK Km</td>
                        <td><label></label></td>
  ");
                    WriteLiteral(@"                      <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <th attr colspan=""5"">II.Hoạt động vận tải hàng hóa</th>
                    </tr>
                    <tr>
                        <td>8.Doanh thu thuần</td>
                        <td class=""text-center"">Triệu đồng</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>9.Khối lượng hàng hóa vận chuyển</td>
                        <td class=""text-center"">Tấn</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td class=""p-1""><i>9.1.Trong đó: Ngoài nước</i></td>
             ");
                    WriteLiteral(@"           <td class=""text-center"">Tấn</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>10.Khối lượng hàng hóa luân chuyển</td>
                        <td class=""text-center"">Tấn.Km</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td class=""p-1""><i>10.1.Trong đó: Ngoài nước</i></td>
                        <td class=""text-center"">Tấn.Km</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>11.Đơn giá bình quân</td>
                        <td class=""text-cente");
                    WriteLiteral(@"r"">Đồng/Tấn.Km</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>12.Khối lượng hàng hóa luân chuyển</td>
                        <td class=""text-center"">Cái</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <td>13.Tổng tải trọng</td>
                        <td class=""text-center"">Tấn</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <th attr colspan=""5"">
                            III.Hoạt động kho bãi, dịch vụ hỗ trợ vận tải của [tháng trước]
                 ");
                    WriteLiteral(@"           và [tháng báo cáo]
                        </th>
                    </tr>
                    <tr>
                        <td>14.Doanh thu thuần</td>
                        <td class=""text-center"">Triệu đồng</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                    <tr>
                        <th attr colspan=""5"">
                            IV.Hoạt động bưu chính, chuyển phát của [tháng trước] và [tháng
                            báo cáo] là bao nhiêu?
                        </th>
                    </tr>
                    <tr>
                        <td>14.Doanh thu thuần</td>
                        <td class=""text-center"">Triệu đồng</td>
                        <td><label></label></td>
                        <td><label></label></td>
                        <td><label></label></td>
                    </tr>
                <");
                    WriteLiteral("/tbody>\r\n            </table>\r\n            <div class=\"form-group bg-primary\">\r\n                <h5><b>C. CÁC YẾU TỔ ẢNH HƯỞNG ĐẾN HOẠT ĐỘNG KINH DOANH</b></h5>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label");
                    BeginWriteAttribute("for", " for=\"", 18433, "\"", 18439, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                    Yếu tố nào sau đây ảnh hưởng đến hoạt động kinh doanh của đơn vị
                    trong tháng ...
                </label>
                <div class=""YTAH"">
                    <div class=""YTAH-tt"">
                        <label");
                    BeginWriteAttribute("for", " for=\"", 18701, "\"", 18707, 0);
                    EndWriteAttribute();
                    WriteLiteral(">1. Nhu cầu thị trường</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 18770, "\"", 18776, 0);
                    EndWriteAttribute();
                    WriteLiteral(">2. Dịch bệnh</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 18830, "\"", 18836, 0);
                    EndWriteAttribute();
                    WriteLiteral(">3. Thời tiết</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 18890, "\"", 18896, 0);
                    EndWriteAttribute();
                    WriteLiteral(">4. Ảnh hưởng mùa vụ</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 18957, "\"", 18963, 0);
                    EndWriteAttribute();
                    WriteLiteral(">5. Thay đổi nhân sự</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 19024, "\"", 19030, 0);
                    EndWriteAttribute();
                    WriteLiteral(">6. Thay đổi kĩ thuật/công nghệ/phương tiện</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 19114, "\"", 19120, 0);
                    EndWriteAttribute();
                    WriteLiteral(">7. Nguồn vốn kinh doanh</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 19185, "\"", 19191, 0);
                    EndWriteAttribute();
                    WriteLiteral(">8. Thay đổi địa điểm/thị trường kinh doanh</label>\r\n                        <label");
                    BeginWriteAttribute("for", " for=\"", 19275, "\"", 19281, 0);
                    EndWriteAttribute();
                    WriteLiteral(">9. Lý do khác: ghi rõ</label>\r\n                    </div>\r\n                    <div class=\"YTAH-check\">\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", " name=\"", 19434, "\"", 19441, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Nhu cầu thị trường\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", " name=\"", 19520, "\"", 19527, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Dịch bệnh\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", " name=\"", 19597, "\"", 19604, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Thời tiết\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", " name=\"", 19674, "\"", 19681, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Ảnh hưởng mùa vụ\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", " name=\"", 19758, "\"", 19765, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Thay đổi nhân sự\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", "\r\n                               name=\"", 19842, "\"", 19881, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                               value=\"Thay đổi kĩ thuật/công nghệ/phương tiện\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", " name=\"", 20013, "\"", 20020, 0);
                    EndWriteAttribute();
                    WriteLiteral(" value=\"Nguồn vốn kinh doanh\" />\r\n                        <input type=\"checkbox\"");
                    BeginWriteAttribute("name", "\r\n                               name=\"", 20101, "\"", 20140, 0);
                    EndWriteAttribute();
                    WriteLiteral("\r\n                               value=\"Thay đổi địa điểm/thị trường kinh doanh\" />\r\n                        <input type=\"checkbox\" name=\"YT9\" id=\"YT9\"");
                    BeginWriteAttribute("value", " value=\"", 20292, "\"", 20300, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" />
                    </div>
                </div>
                <div class=""YTAH9"" style=""margin-left:20px;"">
                    <label>Thời tiết thất thường, nhân công nghỉ việc</label>
                </div>
            </div>
            <div class=""uname-info"">
                <div class=""row"">
                    <label class=""uname-lb"">Họ tên người trả lời:</label>
                    <label>mai anh lộc</label>
                </div>
                <div class=""row"">
                    <label class=""uname-lb"">Số điện thoại:</label>
                    <label>013245585</label>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\r\n</html>");
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
