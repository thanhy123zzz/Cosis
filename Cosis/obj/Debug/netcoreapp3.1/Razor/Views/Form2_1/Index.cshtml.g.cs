#pragma checksum "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb9281b93142c8f27d023214986ff8fa7267ab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form2_1_Index), @"mvc.1.0.view", @"/Views/Form2_1/Index.cshtml")]
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
#line 2 "D:\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Cosis\Cosis\Views\_ViewImports.cshtml"
using Cosis.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb9281b93142c8f27d023214986ff8fa7267ab4", @"/Views/Form2_1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b88521a2e1eba7c1c948980452ed678c2226406", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Form2_1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosis.Models.PhieuDieuTra>
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
#line 2 "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml"
  
    int getThang(){
        return DateTime.Now.Month;
    }
    int getNam(){
        return DateTime.Now.Year;
    }
    string getThangNamTruoc(){
        if (getThang()==1)
            return "12/"+(getNam()-1);else{
            return (getThang()-1) +"/" + getNam();
        }
    }
    string getThangNam(){
        return getThang() + "/" + getNam();
    }
    int getTest(int a){
        return a;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbb9281b93142c8f27d023214986ff8fa7267ab44979", async() => {
                WriteLiteral(@"
        <div class=""form-group text-center"">
          <label> <b>ĐIỀU TRA HOẠT ĐỘNG THƯƠNG MẠI VÀ DỊCH VỤ </b> </label>
        </div>
        <div class=""form-group row"">
          <label class=""P-name""><b>Phiếu 2.1/CT-TM-T</b></label>
        </div>
        <div class=""form-group text-center"">
          <label class=""text-center"">
            <b>PHIẾU THU THẬP THÔNG TIN ĐỐI VỚI CƠ SỞ KINH DOANH CÁ THỂ</b>
          </label>
          <label>
            <b>
              <i>
                (Áp dụng đối với cơ sở kinh doanh cá thể có hoạt động bán buôn,
                bán lẻ hàng hóa)
              </i>
            </b>
          </label>
        </div>

        <div class=""form-group text-center"">
          <div class=""row""></div>
          <div>
            <label> <b>Tháng ");
#nullable restore
#line 46 "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml"
                        Write(getThang());

#line default
#line hidden
#nullable disable
                WriteLiteral(" Năm ");
#nullable restore
#line 46 "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml"
                                        Write(getNam());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b> </label>
          </div>
          <div class=""row""></div>
        </div>
        <div class=""form-group bg-primary"">
          <h5><b>A. THÔNG TIN CHUNG</b></h5>
        </div>
        <div id=""ThongTinDoanhNghiepGroup"" class=""form-group"">
          <div class=""row"">
            <label class=""lb-info"">Tên doanh nghiệp/HTX: </label>
            <input type=""text"" class=""infoma"" />
          </div>

          <div class=""row"">
            <label class=""lb-info"">Tỉnh/TP trực thuộc TW: </label>
            <select");
                BeginWriteAttribute("name", " name=\"", 1884, "\"", 1891, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1892, "\"", 1897, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbb9281b93142c8f27d023214986ff8fa7267ab47346", async() => {
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
                WriteLiteral("\r\n            </select>\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\"\r\n              >Huyện/quận <i>(thị xã, TP thuộc tỉnh)</i>:\r\n            </label>\r\n            <select");
                BeginWriteAttribute("name", " name=\"", 2184, "\"", 2191, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2192, "\"", 2197, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbb9281b93142c8f27d023214986ff8fa7267ab49106", async() => {
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
                WriteLiteral("\r\n            </select>\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"lb-info\">Xã/phường/thị trấn: </label>\r\n            <select");
                BeginWriteAttribute("name", " name=\"", 2435, "\"", 2442, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 2443, "\"", 2448, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\">\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbb9281b93142c8f27d023214986ff8fa7267ab410813", async() => {
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
            <label class=""lb-info"">Địa bàn: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div class=""row"">
            <label class=""lb-info"">Mã cơ sở: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div class=""row"">
            <label class=""lb-info"">Tên cơ sở: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div class=""row"">
            <label class=""lb-info"">Mã số thuế</label>
            <input
              type=""text""
              id=""n0""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off"" autofocus
              data-next=""1""
            />
            <input
              type=""text""
              id=""n1""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""of");
                WriteLiteral(@"f""
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
            />
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
            <in");
                WriteLiteral(@"put
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
              id=""n8""
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

            <input
              type=""text""
              id=""n10""
     ");
                WriteLiteral(@"         maxlength=""1""
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
              id=""n12""
              maxlength=""1""
              size=""1""
              class=""text-center MS""
              autocomplete=""off""
              data-next=""13""
            />
          </div>
          <div class=""row"">
            <label class=""lb-info"">Thôn, ấp<i>(số nhà, đường phố)</i>: </label>
            <input type=""text"" class=""infoma"" />
          </div>

          <div class=""row"">
            <label class=""lb-info"">Số điện thoại: </label>
            <input type=""text"" class=""infoma"" />
          </div>
          <div clas");
                WriteLiteral(@"s=""row"">
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
              <input type=""radio"" name=""loaihinhkt"" value=""Kinh tế nhà nước"" />
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
                BeginWriteAttribute("for", " for=\"", 7652, "\"", 7658, 0);
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
                BeginWriteAttribute("for", " for=\"", 8666, "\"", 8672, 0);
                EndWriteAttribute();
                WriteLiteral(@">Tên ngành HĐKD:</label>
              <input type=""text"" class=""infoma-nganh"" />
            </div>
          </div>
        </div>
        <div class=""form-group bg-primary"">
          <h5><b>B. KẾT QUẢ HOẠT ĐỘNG KINH DOANH</b></h5>
        </div>
        <table class=""table table-bordered"">
          <thead>
            <tr class=""text-center"">
              <th>Chi tiết</th>
              <th>Ngành chọn mẫu</th>
              <th>Đơn vị tính</th>
              <th>Thực hiện ");
#nullable restore
#line 296 "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml"
                       Write(getThangNamTruoc());

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n              <th>Dự tính ");
#nullable restore
#line 297 "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml"
                     Write(getThang());

#line default
#line hidden
#nullable disable
                WriteLiteral("/");
#nullable restore
#line 297 "D:\Cosis\Cosis\Views\Form2_1\Index.cshtml"
                                 Write(getNam());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</th>
              <th>
                CỘNG DỒN TỪ ĐẦU NĂM ĐẾN CUỐI THÁNG BÁO CÁO (Chương trình tự động
                tính)
              </th>
            </tr>
          </thead>
          <tbody id=""table-data"">
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
              </td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td class=""text-center"">Triệu đồng</td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
            </tr>

            <tr>
              <td>
          ");
                WriteLiteral(@"      2. Trong tổng số tiền thu về của cơ sở, số tiền thu về (bao gồm
                cả vốn lẫn lãi) của [NGÀNH CHỌN MẪU] [tháng trước] và dự tính
                [tháng báo cáo]
              </td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td class=""text-center"">Triệu đồng</td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td><input type=""text"" class=""infoma"" /></td>
            </tr>
            <tr>
              <td>3. Cơ sở bán [NGÀNH CHỌN MẪU] tại đâu?</td>
              <td></td>
              <td></td>
              <td>
                1. Bán tại siêu thị mini, cửa hàng tiện ích
                <input type=""radio"" name=""chose3"" id=""3-1"" />
              </td>
              <td>
                2. Bán tại các địa điểm khác
                <input type=""radio"" name=""chose3"" id=""3-2"" />
              </td>
              <td>
                3. Bán tại siêu thị ");
                WriteLiteral(@"mini, cửa hàng tiện ích và các địa điểm khác
                <input type=""radio"" name=""chose3"" id=""3"" />
              </td>
            </tr>
            <tr class=""changed3"">
              <td>
                3.1 Số tiền thu về (bao gồm cả vốn và lãi) từ bán [NGÀNH CHỌN
                MẪU] [tháng trước] và dự tính [tháng báo cáo] tại siêu thị mini,
                cửa hàng tiện ích?
              </td>
              <td><input type=""text"" class=""infoma"" /></td>
              <td class=""text-center"">Triệu đồng</td>
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
                BeginWriteAttribute("for", " for=\"", 12254, "\"", 12260, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n            >Yếu tố nào sau đây ảnh hưởng đến hoạt động kinh doanh của đơn vị\r\n            trong tháng ...</label\r\n          >\r\n          <div class=\"YTAH\">\r\n            <div class=\"YTAH-tt\">\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12476, "\"", 12482, 0);
                EndWriteAttribute();
                WriteLiteral(">1. Nhu cầu thị trường</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12535, "\"", 12541, 0);
                EndWriteAttribute();
                WriteLiteral(">2. Dịch bệnh</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12585, "\"", 12591, 0);
                EndWriteAttribute();
                WriteLiteral(">3. Thời tiết</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12635, "\"", 12641, 0);
                EndWriteAttribute();
                WriteLiteral(">4. Ảnh hưởng mùa vụ</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12692, "\"", 12698, 0);
                EndWriteAttribute();
                WriteLiteral(">5. Thay đổi nhân sự</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12749, "\"", 12755, 0);
                EndWriteAttribute();
                WriteLiteral(">6. Thay đổi kĩ thuật/công nghệ/phương tiện</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12829, "\"", 12835, 0);
                EndWriteAttribute();
                WriteLiteral(">7. Nguồn vốn kinh doanh</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12890, "\"", 12896, 0);
                EndWriteAttribute();
                WriteLiteral(">8. Thay đổi địa điểm/thị trường kinh doanh</label>\r\n              <label");
                BeginWriteAttribute("for", " for=\"", 12970, "\"", 12976, 0);
                EndWriteAttribute();
                WriteLiteral(@">9. Lý do khác: ghi rõ</label>
            </div>
            <div class=""YTAH-check"">
              <input type=""checkbox"" name=""DanhSachNhanToAnhHuong0"" value=""01"" />
              <input type=""checkbox"" name=""DanhSachNhanToAnhHuong1"" value=""02"" />
              <input type=""checkbox"" name=""DanhSachNhanToAnhHuong2"" value=""03"" />
              <input type=""checkbox"" name=""DanhSachNhanToAnhHuong3"" value=""04"" />
              <input type=""checkbox"" name=""DanhSachNhanToAnhHuong4"" value=""05"" />
              <input
                type=""checkbox""
                name=""DanhSachNhanToAnhHuong5""
                value=""06""
              />
              <input type=""checkbox"" name=""DanhSachNhanToAnhHuong6"" value=""07"" />
              <input
                type=""checkbox""
                name=""DanhSachNhanToAnhHuong7""
                value=""08""
              />
              <input type=""checkbox"" id=""YT9""");
                BeginWriteAttribute("value", " value=\"", 13908, "\"", 13916, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
          </div>
          <div class=""YTAH9"">
            <textarea
              class=""form-control""
              rows=""1""
              id=""comment""
              name=""NhanToThu9.NoiDung""
              disabled
            ></textarea>
          </div>
        </div>
        <div class=""form-group uname-info"">
          <div class=""row"">
            <label class=""uname-lb"">Họ tên người trả lời:</label>
            <input type=""text"" name=""Master.TenNguoiTraLoi""");
                BeginWriteAttribute("id", " id=\"", 14427, "\"", 14432, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"infoma\" />\r\n          </div>\r\n          <div class=\"row\">\r\n            <label class=\"uname-lb\">Số điện thoại:</label>\r\n            <input type=\"text\" name=\"Master.SdtnguoiTraLoi\"");
                BeginWriteAttribute("id", " id=\"", 14619, "\"", 14624, 0);
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
