#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutStatistics\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "745794b257cc5813d80c4a3479d44cf3e89afd0d8e54c02d79382c9ff54805bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutStatistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutStatistics/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\_ViewImports.cshtml"
using TravelCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\_ViewImports.cshtml"
using TravelCoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"745794b257cc5813d80c4a3479d44cf3e89afd0d8e54c02d79382c9ff54805bc", @"/Views/Shared/Components/AboutStatistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d177fcce0150f5d2151792eb9420f8db74e6fe9103e5dee6f0726503dbffb76e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutStatistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"

<section class=""w3l-statshny py-5"" id=""stats"">
    <div class=""container py-lg-5 py-md-4"">
        <div class=""w3-stats-inner-info"">
            <div class=""row"">
                <div class=""col-lg-4 col-6 stats_info counter_grid text-left"">
                    <span class=""fa fa-smile-o""></span>
                    <p class=""counter"">");
#nullable restore
#line 15 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutStatistics\Default.cshtml"
                                  Write(ViewBag.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <h4>Mutlu Müşteri Sayısı</h4>
                </div>
                <div class=""col-lg-4 col-6 stats_info counter_grid1 text-left"">
                    <span class=""fa fa-users""></span>
                    <p class=""counter"">");
#nullable restore
#line 20 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutStatistics\Default.cshtml"
                                  Write(ViewBag.GuideCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <h4>Rehber Sayımız</h4>
                </div>
                <div class=""col-lg-4 col-6 stats_info counter_grid mt-lg-0 mt-5 text-left"">
                    <span class=""fa fa-database""></span>
                    <p class=""counter"">");
#nullable restore
#line 25 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutStatistics\Default.cshtml"
                                  Write(ViewBag.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h4>Topram Yorum Sayısı</h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
