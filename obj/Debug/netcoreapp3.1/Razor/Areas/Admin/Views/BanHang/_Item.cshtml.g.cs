#pragma checksum "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4ae448e286414e7d5c02d32c0d8c7d6ba363872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BanHang__Item), @"mvc.1.0.view", @"/Areas/Admin/Views/BanHang/_Item.cshtml")]
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
#line 1 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\_ViewImports.cshtml"
using DienTu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\_ViewImports.cshtml"
using DienTu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ae448e286414e7d5c02d32c0d8c7d6ba363872", @"/Areas/Admin/Views/BanHang/_Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3683c5369ad3abdfbc6aa32150b005af0866464f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BanHang__Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DienTu.Models.MenuItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
  
    //ViewData["Title"] = "Index";
    //Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<div class=\"border backgroundWhite\">\r\n");
#nullable restore
#line 9 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>Hình ảnh</th>
                        <th>Tên</th>
                        <th>Giá</th>
                        <th>Số Lượng</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 22 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr data-id=\"");
#nullable restore
#line 24 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 24 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <td><img");
            BeginWriteAttribute("src", " src=\"", 766, "\"", 783, 1);
#nullable restore
#line 25 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
WriteAttributeValue("", 772, item.Image, 772, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:5px;border: 1px solid #bbb9b9; width: 75px\" /></td>\r\n                            <td>");
#nullable restore
#line 26 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><input value=\"0\" min=\"0\" max=\"99\" type=\"number\" class=\"put-pro\" onchange=\"addItems()\" /></td>\r\n                        </tr>\r\n");
#nullable restore
#line 30 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <th colspan=""3"" style=""text-align: right"">Tổng</th>
                        <th></th>
                    </tr>
                    <tr>
                        <th colspan=""3"" style=""text-align: right""></th>
                        <th><span class=""total"">0</span></th>
                    </tr>
                </tbody>
            </table>
            <div style=""text-align: right"">
                <div><button class=""btn btn-success"">Lưu</button></div>
            </div>
        </div>
");
#nullable restore
#line 45 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Chưa có sản phẩm nào được tạo</p>\r\n");
#nullable restore
#line 50 "D:\web\Web Asp\DienTu\DienTu\Areas\Admin\Views\BanHang\_Item.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DienTu.Models.MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
