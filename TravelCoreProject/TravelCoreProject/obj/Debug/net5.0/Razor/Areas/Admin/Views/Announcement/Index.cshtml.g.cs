#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17036b2662be642f504225f2601540974b392f83eadb42eac527c7f9ddb569f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"17036b2662be642f504225f2601540974b392f83eadb42eac527c7f9ddb569f7", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d225df37aa55582a8926ab57709b0dfcf71b5aaed7081afcd51144970c4eccee", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DTOLayer.AnnouncementDTOs.AnnouncementListDTOs>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table table-bordred\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Başlık</th>\r\n        <th>İçerik</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
     foreach(var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(x.AnnouncementId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(x.AnnouncementTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
           Write(x.AnnouncementContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 601, "\"", 664, 2);
            WriteAttributeValue("", 608, "/Admin/Announcement/DeleteAnnouncement/", 608, 39, true);
#nullable restore
#line 26 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 647, x.AnnouncementId, 647, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 754, "\"", 818, 2);
            WriteAttributeValue("", 761, "/Admin/Announcement/UppdateAnnouncement/", 761, 40, true);
#nullable restore
#line 29 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 801, x.AnnouncementId, 801, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a class=\"btn btn-info\" href=\"/Admin/Announcement/AddAnnouncement\">Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DTOLayer.AnnouncementDTOs.AnnouncementListDTOs>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
