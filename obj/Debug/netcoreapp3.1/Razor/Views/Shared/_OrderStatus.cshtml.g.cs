#pragma checksum "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4fb09c4122465efb9c5ad5490dc2a17e5d96553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderStatus), @"mvc.1.0.view", @"/Views/Shared/_OrderStatus.cshtml")]
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
#line 1 "D:\web\Web Asp\DienTu\DienTu\Views\_ViewImports.cshtml"
using DienTu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\web\Web Asp\DienTu\DienTu\Views\_ViewImports.cshtml"
using DienTu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
using DienTu.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4fb09c4122465efb9c5ad5490dc2a17e5d96553", @"/Views/Shared/_OrderStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3683c5369ad3abdfbc6aa32150b005af0866464f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n");
#nullable restore
#line 7 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
     if (Model == SD.StatusSubmitted)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""progress"">
            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width:25%"">
                Chờ xác nhận
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Đang đóng gói
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Đang giao
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Hoàn Thành
            </div>
        </div>
");
#nullable restore
#line 23 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
     if (Model == SD.StatusInProcess)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""progress"">
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Chờ xác nhận
            </div>
            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width:25%"">
                Đang đóng gói
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Đang giao
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Hoàn Thành
            </div>
        </div>
");
#nullable restore
#line 40 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
     if (Model == SD.StatusShip)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""progress"">
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Chờ xác nhận
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Đang đóng gói
            </div>
            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width:25%"">
                Đang giao
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Hoàn Thành
            </div>
        </div>
");
#nullable restore
#line 57 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
     if (Model == SD.StatusCompleted)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""progress"">z
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Chờ xác nhận
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Đang đóng gói
            </div>
            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width:25%"">
                Đang giao
            </div>
            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width:25%"">
                Hoàn Thành
            </div>
        </div>
");
#nullable restore
#line 74 "D:\web\Web Asp\DienTu\DienTu\Views\Shared\_OrderStatus.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
