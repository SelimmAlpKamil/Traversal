#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "be86ba94fe5e6f59ddfdf0631e2e8c5db0104cebef8947d16697bf4e00b327be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Commnet_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Commnet/Index.cshtml")]
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
#line 1 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TravelCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TravelCoreProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"be86ba94fe5e6f59ddfdf0631e2e8c5db0104cebef8947d16697bf4e00b327be", @"/Areas/Admin/Views/Commnet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d225df37aa55582a8926ab57709b0dfcf71b5aaed7081afcd51144970c4eccee", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Commnet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Yorum</th>\r\n        <th>Rota</th>\r\n        <th>Tarih</th>\r\n        <th>Sil</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
           Write(x.CommentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
           Write(x.CommentMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
           Write(x.Destination.DestinationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
           Write(x.CommentDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 625, "\"", 673, 2);
            WriteAttributeValue("", 632, "/Admin/Commnet/DeleteCommnet/", 632, 29, true);
#nullable restore
#line 26 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"
WriteAttributeValue("", 661, x.CommentId, 661, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Commnet\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
