#pragma checksum "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6bb46c729d31ebfbfe75010b44a158c46089176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form1_1_Index), @"mvc.1.0.view", @"/Views/Form1_1/Index.cshtml")]
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
#line 1 "D:\ProjectCosis\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjectCosis\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProjectCosis\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb46c729d31ebfbfe75010b44a158c46089176", @"/Views/Form1_1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Form1_1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.PhieuDieuTra>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml"
  
    int getThang()
    {
        return DateTime.Now.Month;
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
            WriteLiteral("      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6bb46c729d31ebfbfe75010b44a158c460891764961", async() => {
                WriteLiteral(@"
        <div class=""form-group text-center"">
          <label> <b>ĐIỀU TRA HOẠT ĐỘNG THƯƠNG MẠI VÀ DỊCH VỤ </b> </label>
        </div>
        <div class=""form-group row"">
          <label class=""P-name""><b>Phiếu 1.1/DN-TM-T</b></label>
          <label");
                BeginWriteAttribute("for", " for=\"", 684, "\"", 690, 0);
                EndWriteAttribute();
                WriteLiteral(@">Mã số thuế</label>
          <div class=""row"">
            <input
              type=""text""
              id=""n0""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              autofocus
              data-next=""1""
            />
            <input
              type=""text""
              id=""n1""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""2""
            />
            <input
              type=""text""
              id=""n2""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""3""
            />
            <input
              type=""text""
              id=""n3""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""4""
     ");
                WriteLiteral(@"       />
            <input
              type=""text""
              id=""n4""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""5""
            />
            <input
              type=""text""
              id=""n5""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""6""
            />
            <input
              type=""text""
              id=""n6""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""7""
            />
            <input
              type=""text""
              id=""n7""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""8""
            />
            <input
              type=""text""
      ");
                WriteLiteral(@"        id=""n8""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""9""
            />
            <input
              type=""text""
              id=""n9""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""10""
            />
          </div>
          <div class=""row"">
            <input
              type=""text""
              id=""n10""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""11""
            />
            <input
              type=""text""
              id=""n11""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""12""
            />
            <input
              type=""text""
              id=""");
                WriteLiteral(@"n12""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""13""
            />
            <input type=""hidden"" id=""MST1"" name=""Master.MaSoThue"" />
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
                có hoạt động bán buôn, bán lẻ hàng hóa)
              </i>
            </b>
          </label>
        </div>

        <div class=""form-group text-center"">
          <div class=""row""></div>
          <div>
            <label> <b>Tháng ");
#nullable restore
#line 169 "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml"
                        Write(getThang());

#line default
#line hidden
#nullable disable
                WriteLiteral(" Năm ");
#nullable restore
#line 169 "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml"
                                        Write(getNam());

#line default
#line hidden
#nullable disable
                WriteLiteral(@".</b> </label>
          </div>
          <div class=""row""></div>
        </div>
        <div class=""form-group bg-primary"">
          <h5><b>A. THÔNG TIN CHUNG</b></h5>
        </div>
    <div id=""ThongTinDoanhNghiepGroup""  class=""form-group"">
          <div class=""row"">
            <label class=""lb-info"">Tên doanh nghiệp/HTX: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div class=""adress"">
            <label");
                BeginWriteAttribute("for", " for=\"", 5115, "\"", 5121, 0);
                EndWriteAttribute();
                WriteLiteral(">Địa chỉ doanh nghiệp </label>\r\n            <div class=\"adress-detail\">\r\n              <div class=\"row\">\r\n                <label class=\"lb-info\">Tỉnh/TP trực thuộc TW: </label>\r\n                <select");
                BeginWriteAttribute("name", " name=\"", 5323, "\"", 5330, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 5331, "\"", 5336, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\">\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6bb46c729d31ebfbfe75010b44a158c4608917611479", async() => {
                    WriteLiteral("--- Chọn Tỉnh/TP ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n              </div>\r\n              <div class=\"row\">\r\n                <label class=\"lb-info\"\r\n                  >Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:\r\n                </label>\r\n                <select");
                BeginWriteAttribute("name", " name=\"", 5655, "\"", 5662, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 5663, "\"", 5668, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\">\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6bb46c729d31ebfbfe75010b44a158c4608917613272", async() => {
                    WriteLiteral("--- Chọn Huyện/quận ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n              </div>\r\n              <div class=\"row\">\r\n                <label class=\"lb-info\">Xã/phường/thị trấn: </label>\r\n                <select");
                BeginWriteAttribute("name", " name=\"", 5930, "\"", 5937, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 5938, "\"", 5943, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\">\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6bb46c729d31ebfbfe75010b44a158c4608917615004", async() => {
                    WriteLiteral("--- Chọn Xã/phường/thị trấn ---");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                <input type=""text"" class=""infoma"" />
              </div>
            </div>
          </div>
          <div class=""row"">
            <label class=""lb-info"">Số điện thoại: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div class=""row"">
            <label class=""lb-info"">Email: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div class=""loaihinh"">
            <label>Loại hình kinh tế</label>

            <div class=""checkbox-tt"">
              <label> 1.Kinh tế nhà nước</label>
              <label> 2.Kinh tế ngoài nhà nước</label>
              <label> 3.Kinh tế có vốn đầu tư trực tiếp nước ngoài</label>
            </div>
            <div class=""checkbox"">
              <input type=""radio"" name=");
                WriteLiteral(@"""loaihinhkt"" value=""Kinh tế nhà nước"" />
              <input
                type=""radio""
                name=""loaihinhkt""
                value=""Kinh tế ngoài nhà nước""
              />
              <input
                type=""radio""
                name=""loaihinhkt""
                value=""Kinh tế có vốn đầu tư trực tiếp nước ngoài""
              />
            </div>
          </div>
          <div class=""nganhKD"">
            <div class=""row"">
              <label");
                BeginWriteAttribute("for", " for=\"", 7551, "\"", 7557, 0);
                EndWriteAttribute();
                WriteLiteral(@">Ngành hoạt động kinh doanh</label>
              <div class=""MNHD row"">
                <input
                  type=""text""
                  maxlength=""1""
                  size=""1""
                  class=""text-center MN""
                />
                <input
                  type=""text""
                  maxlength=""1""
                  size=""1""
                  class=""text-center MN""
                />
                <input
                  type=""text""
                  maxlength=""1""
                  size=""1""
                  class=""text-center MN""
                />
                <input
                  type=""text""
                  maxlength=""1""
                  size=""1""
                  class=""text-center MN""
                />
                <input
                  type=""text""
                  maxlength=""1""
                  size=""1""
                  class=""text-center MN""
                />
              </div>
              <label");
                BeginWriteAttribute("for", " for=\"", 8565, "\"", 8571, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tên ngành HĐKD:</label>
              <input type=""text"" class=""infoma-nganh"" />
            </div>
          </div>
        </div>
        <div class=""form-group bg-primary"">
          <h5><b>B. KẾT QUẢ HOẠT ĐỘNG KINH DOANH</b></h5>
        </div>
        <table class=""table table-bordered"" id=""tab-KQ"">
          <thead>
            <tr class=""text-center"">
              <th class=""Chitieu"">Chỉ tiêu</th>
              <th class=""NganhCM"">Ngành chọn mẫu</th>
              <th class=""DVT"">Đơn vị tính</th>
              <th colspan=""2"" class=""Money""><b>Tháng thực hiện ");
#nullable restore
#line 291 "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml"
                                                          Write(getThangNamTruoc());

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></th>\r\n              <th colspan=\"2\" class=\"Money\"><b>Tháng dự tính ");
#nullable restore
#line 292 "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml"
                                                        Write(getThang());

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 292 "D:\ProjectCosis\Cosis\Cosis\Views\Form1_1\Index.cshtml"
                                                                    Write(getNam());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </b></th>
              <th colspan=""2"" class=""Money"">
                CỘNG DỒN TỪ ĐẦU NĂM ĐẾN CUỐI THÁNG BÁO CÁO
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
            <tr>
              <td class=""DMNganh"">1.Tổng doanh thu</td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td class=""text-center"">Triệu đồng</td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><inp");
                WriteLiteral(@"ut type=""text"" class=""infoma"" /></td>
            </tr>
            <tr>
              <td class=""DMNganh"">2.Doanh thu thuần</td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td class=""text-center"">Triệu đồng</td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
            </tr>
          </tbody>
        </table>
        <div class=""form-group bg-primary"">
          <h5><b>C. CÁC YẾU TỔ ẢNH HƯỞNG ĐẾN HOẠT ĐỘNG KINH DOANH</b></h5>
        </div>
        <div class=""form-group"">
          <label");
                BeginWriteAttribute("for", " for=\"", 11156, "\"", 11162, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n            >Yếu tố nào sau đây ảnh hưởng đến hoạt động kinh doanh của đơn vị\r\n            trong tháng ...</label\r\n          >\r\n          <div class=\"YTAH\">\r\n            <div class=\"YTAH-tt\">\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11378, "\"", 11384, 0);
                EndWriteAttribute();
                WriteLiteral(">1. Nhu cầu thị trường</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11437, "\"", 11443, 0);
                EndWriteAttribute();
                WriteLiteral(">2. Dịch bệnh</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11487, "\"", 11493, 0);
                EndWriteAttribute();
                WriteLiteral(">3. Thời tiết</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11537, "\"", 11543, 0);
                EndWriteAttribute();
                WriteLiteral(">4. Ảnh hưởng mùa vụ</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11594, "\"", 11600, 0);
                EndWriteAttribute();
                WriteLiteral(">5. Thay đổi nhân sự</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11651, "\"", 11657, 0);
                EndWriteAttribute();
                WriteLiteral(">6. Thay đổi kĩ thuật/công nghệ/phương tiện</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11731, "\"", 11737, 0);
                EndWriteAttribute();
                WriteLiteral(">7. Nguồn vốn kinh doanh</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11792, "\"", 11798, 0);
                EndWriteAttribute();
                WriteLiteral(">8. Thay đổi địa điểm/thị trường kinh doanh</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 11872, "\"", 11878, 0);
                EndWriteAttribute();
                WriteLiteral(">9. Lý do khác: ghi rõ</label>\r\n            </div>\r\n            <div class=\"YTAH-check\">\r\n              <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 12005, "\"", 12012, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Nhu cầu thị trường\" />\r\n              <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 12081, "\"", 12088, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Dịch bệnh\" />\r\n              <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 12148, "\"", 12155, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Thời tiết\" />\r\n              <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 12215, "\"", 12222, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Ảnh hưởng mùa vụ\" />\r\n              <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 12289, "\"", 12296, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Thay đổi nhân sự\" />\r\n              <input\r\n                type=\"checkbox\"");
                BeginWriteAttribute("name", "\r\n                name=\"", 12380, "\"", 12404, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                value=\"Thay đổi kĩ thuật/công nghệ/phương tiện\"\r\n              />\r\n              <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 12526, "\"", 12533, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Nguồn vốn kinh doanh\" />\r\n              <input\r\n                type=\"checkbox\"");
                BeginWriteAttribute("name", "\r\n                name=\"", 12621, "\"", 12645, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                value=\"Thay đổi địa điểm/thị trường kinh doanh\"\r\n              />\r\n              <input type=\"checkbox\" name=\"YT9\" id=\"YT9\"");
                BeginWriteAttribute("value", " value=\"", 12787, "\"", 12795, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
          </div>
          <div class=""YTAH9"">
            <textarea
              class=""form-control""
              rows=""1""
              id=""comment""
              name=""comment""
              disabled
            ></textarea>
          </div>
        </div>
        <div class=""form-group uname-info"">
          <div class=""row"">
            <label class=""uname-lb"">Họ tên người trả lời:</label>
            <input type=""text""");
                BeginWriteAttribute("name", " name=\"", 13266, "\"", 13273, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 13274, "\"", 13279, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\" />\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"uname-lb\">Số điện thoại:</label>\r\n            <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 13437, "\"", 13444, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 13445, "\"", 13450, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\" />\r\n          </div>\r\n        </div>\r\n        <div class=\"group-btn\">\r\n          <button class=\"btn btn-success\">Lưu và xuất file PDF</button>\r\n          <button class=\"btn btn-primary\">Lưu</button>\r\n        </div>\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
