#pragma checksum "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "900697122fe3338c998a63b29f7bbcf3e376ebba124ee75d0635a08bbe4207cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_DestinationUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/DestinationUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"900697122fe3338c998a63b29f7bbcf3e376ebba124ee75d0635a08bbe4207cc", @"/Areas/Admin/Views/User/DestinationUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d225df37aa55582a8926ab57709b0dfcf71b5aaed7081afcd51144970c4eccee", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_DestinationUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concreate.Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
  
    ViewData["Title"] = "DestinationUser";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
  
    int sayi = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
 foreach (var x in Model)
{
    sayi += 1;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
 if (sayi<=0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Henüz bir tura katılmamış</h1>\r\n");
#nullable restore
#line 21 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Ad Soyad</th>\r\n            <th>Rota</th>\r\n            <th>Kişi Sayısı</th>\r\n            <th>Tarih</th>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
               Write(x.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
               Write(ViewBag.user);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
               Write(x.Destination.DestinationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
               Write(x.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
               Write(x.ReservationDate?.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 43 "C:\Users\selim\OneDrive\Masaüstü\C#\TravelCoreProject\TravelCoreProject\Areas\Admin\Views\User\DestinationUser.cshtml"

    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concreate.Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
