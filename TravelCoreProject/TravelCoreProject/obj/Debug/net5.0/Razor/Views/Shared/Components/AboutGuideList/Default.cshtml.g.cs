#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7831a758e173ac52a6ddf9998a73045bcc604c8d13f932af6933b47a70ba1cf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutGuideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutGuideList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7831a758e173ac52a6ddf9998a73045bcc604c8d13f932af6933b47a70ba1cf2", @"/Views/Shared/Components/AboutGuideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d177fcce0150f5d2151792eb9420f8db74e6fe9103e5dee6f0726503dbffb76e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutGuideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"

<section class=""w3l-team"" id=""team"">
    <div class=""team-block py-5"">
        <div class=""container py-lg-5"">
            <div class=""title-content text-center mb-lg-3 mb-4"">
                <h6 class=""sub-title"">Bizim Takım</h6>
                <h3 class=""hny-title"">En Popular Rehberlerimiz</h3>
            </div>
            <div class=""row"">
");
#nullable restore
#line 17 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
                 foreach(var x in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n                    <div class=\"box16\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 710, "\"", 729, 1);
#nullable restore
#line 20 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
WriteAttributeValue("", 716, x.GuideImage, 716, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 730, "\"", 736, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" style=\"object-fit: cover; width: 400px; height: 600px;\" />\r\n                        <div class=\"box-content\">\r\n                            <h3 class=\"title\"><a href=\"#url\">");
#nullable restore
#line 22 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
                                                        Write(x.GuideName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <span class=\"post\">");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
                                          Write(x.GuideDescripton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <ul class=\"social\">\r\n                                <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1154, "\"", 1181, 1);
#nullable restore
#line 26 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
WriteAttributeValue("", 1161, x.GuideInstagramURL, 1161, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >
                                            <span class=""fa fa-instagram"" style=""position: relative; display: inline-block; width: 25px; height: 25px; background: linear-gradient(45deg, #f09433, #e6683c, #dc2743, #cc2366, #bc1888); border-radius: 50%; text-align: center; line-height: 25px; color: white; font-size: 14px;""></span>
                                    </a>
                                </li>
                                <li>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1675, "\"", 1694, 1);
#nullable restore
#line 31 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
WriteAttributeValue("", 1682, x.GuideXURL, 1682, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" >
                                            <span class=""fa fa-twitter"" style=""color: #1DA1F2; font-size: 25px;""></span>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 39 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Views\Shared\Components\AboutGuideList\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
