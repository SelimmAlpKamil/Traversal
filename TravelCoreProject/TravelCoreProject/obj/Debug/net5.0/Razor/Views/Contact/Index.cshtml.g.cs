#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Contact\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3e344df3e1b887258f6df0a347a2f28fd4d4a3e21c5bd8a16f64e45c9f350dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3e344df3e1b887258f6df0a347a2f28fd4d4a3e21c5bd8a16f64e45c9f350dd7", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d177fcce0150f5d2151792eb9420f8db74e6fe9103e5dee6f0726503dbffb76e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Contact Us</h2>
            <ul class=""breadcrumbs-custom-path mt-2"">
                <li><a href=""Home/Index"">Ana Sayfa</a></li>
                <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> İletişim </li>
            </ul>
        </div>
    </div>
</section>

<section class=""w3l-contact"" id=""contact"">
    <div class=""contact-infubd py-5"">
        <div class=""container py-lg-3"">
            <div class=""contact-grids row"">

                ");
#nullable restore
#line 25 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Contact\Index.cshtml"
           Write(await Component.InvokeAsync("ContactInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n\r\n                ");
#nullable restore
#line 28 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Contact\Index.cshtml"
           Write(await Component.InvokeAsync("ContactAdd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


            </div>
            <div class=""map mt-5 pt-md-5"">
                <h5>Map</h5>
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3011.443399639845!2d29.022155975513133!3d40.993667320325265!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab86820431e31%3A0xf0ddcfd9dbf6fc2c!2zUsSxaHTEsW0gQ2QuLCBLYWTEsWvDtnkvxLBzdGFuYnVs!5e0!3m2!1str!2str!4v1719595443058!5m2!1str!2str"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1386, "\"", 1404, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n                        \r\n            </div>\r\n            </div>\r\n    \r\n    </div>\r\n</section>\r\n");
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
