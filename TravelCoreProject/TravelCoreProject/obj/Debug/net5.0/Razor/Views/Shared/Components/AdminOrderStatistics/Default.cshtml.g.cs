#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AdminOrderStatistics\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8f7b1d052f1bd7949f5cc938e7d0c9113f127909340a05f8c57c9a6c6dba1096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminOrderStatistics_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminOrderStatistics/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8f7b1d052f1bd7949f5cc938e7d0c9113f127909340a05f8c57c9a6c6dba1096", @"/Views/Shared/Components/AdminOrderStatistics/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d177fcce0150f5d2151792eb9420f8db74e6fe9103e5dee6f0726503dbffb76e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AdminOrderStatistics_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""col-md-6 col-lg-4 order-2 mb-4"">
    <div class=""card h-100"">
        
        <div class=""card-body"">
            
            <ul class=""p-0 m-0"">
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-primary"">
                            <i class=""bx bx-mobile-alt""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Toplam Rezervasyon Sayısı</h6>
                            
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">");
#nullable restore
#line 24 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AdminOrderStatistics\Default.cshtml"
                                                  Write(ViewBag.CountRecervation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Onaylanan Rezervasyon Aderi</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">");
#nullable restore
#line 37 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AdminOrderStatistics\Default.cshtml"
                                                  Write(ViewBag.countCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-info""><i class=""bx bx-home-alt""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Onay Bekleyen Rezervasyon Adeti</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">");
#nullable restore
#line 50 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AdminOrderStatistics\Default.cshtml"
                                                  Write(ViewBag.countApproval);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-secondary"">
                            <i class=""bx bx-football""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">İptal Edilen Rezervasyon Adeti</h6>

                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">");
#nullable restore
#line 66 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AdminOrderStatistics\Default.cshtml"
                                                  Write(ViewBag.countOld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
