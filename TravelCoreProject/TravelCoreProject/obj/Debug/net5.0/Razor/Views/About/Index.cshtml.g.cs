#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52b7a59566c8898ba4e04f7677b86a48225359fcc0ae35829d24eb7d6ef5d6e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"52b7a59566c8898ba4e04f7677b86a48225359fcc0ae35829d24eb7d6ef5d6e6", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d177fcce0150f5d2151792eb9420f8db74e6fe9103e5dee6f0726503dbffb76e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Hakkımızda</h2>
            <ul class=""breadcrumbs-custom-path mt-2"">
                <li><a href=""/Home/Index"">Ana Sayfa</a></li>
                <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Hakkımızda </li>
            </ul>
        </div>
    </div>
</section>



<section class=""w3l-cta4 py-5"">
    <div class=""container py-lg-5"">
");
#nullable restore
#line 27 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
         foreach(var x in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"ab-section text-center\">\r\n            <h6 class=\"sub-title\">Hakkımızda</h6>\r\n            <h3 class=\"hny-title\">");
#nullable restore
#line 30 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
                             Write(x.AboutTitle1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p class=\"py-3 mb-3\">\r\n                ");
#nullable restore
#line 32 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
           Write(x.AboutDetails1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"row mt-5\">\r\n            <div class=\"col-md-9 mx-auto\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1107, "\"", 1127, 1);
#nullable restore
#line 37 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
WriteAttributeValue("", 1113, x.AboutImage1, 1113, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 1146, "\"", 1152, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n\r\n\r\n<section class=\"w3l-content-6 py-5\">\r\n    <div class=\"container py-lg-5\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 49 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
             foreach(var x in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-6 content-6-left pr-lg-5\">\r\n                    <h6 class=\"sub-title\">NEDEN BİZİ SEÇMELİSİNİZ</h6>\r\n                <h3 class=\"hny-title\">");
#nullable restore
#line 52 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
                                 Write(x.AboutTitle2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-lg-6 content-6-right mt-lg-0 mt-4\">\r\n                <p class=\"mb-3\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
               Write(x.AboutDetails2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n              \r\n            </div>\r\n");
#nullable restore
#line 60 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n\r\n");
#nullable restore
#line 65 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("AboutPopularDestination"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
#nullable restore
#line 67 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("AboutStatistics"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
#nullable restore
#line 69 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("AboutGuideList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
