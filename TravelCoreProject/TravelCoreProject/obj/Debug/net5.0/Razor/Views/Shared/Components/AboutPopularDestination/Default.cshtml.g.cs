#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94603afbdf61f09bdec8afbc56c208adf4b4500c7d1dcf76c71bf84b221a7434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutPopularDestination_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutPopularDestination/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"94603afbdf61f09bdec8afbc56c208adf4b4500c7d1dcf76c71bf84b221a7434", @"/Views/Shared/Components/AboutPopularDestination/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d177fcce0150f5d2151792eb9420f8db74e6fe9103e5dee6f0726503dbffb76e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutPopularDestination_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<section class=\"w3l-grids1\">\r\n    <div class=\"hny-three-grids py-5\">\r\n        <div class=\"container py-lg-5\">\r\n            <h2>Refarans Turlarımız</h2>\r\n            <br />\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml"
                 foreach(var x in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 mt-0 grids5-info\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 580, 2);
            WriteAttributeValue("", 533, "/Destination/DestinationDetail/", 533, 31, true);
#nullable restore
#line 18 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml"
WriteAttributeValue("", 564, x.DestinationId, 564, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 586, "\"", 617, 1);
#nullable restore
#line 18 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml"
WriteAttributeValue("", 592, x.DestinationImageDetail, 592, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"  class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 655, "\"", 661, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"object-fit: cover; width: 400px; height: 600px;\"></a>\r\n                    <h5>");
#nullable restore
#line 19 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml"
                   Write(x.DestinationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>");
#nullable restore
#line 20 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml"
                  Write(x.DestinationDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutPopularDestination\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
