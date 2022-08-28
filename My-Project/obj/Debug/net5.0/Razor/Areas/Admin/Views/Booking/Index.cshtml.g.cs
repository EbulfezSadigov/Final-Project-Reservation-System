#pragma checksum "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de3281a75704a70930c943f35a06ffd320b09ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Booking_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Booking/Index.cshtml")]
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
#line 1 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\_ViewImports.cshtml"
using My_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de3281a75704a70930c943f35a06ffd320b09ac1", @"/Areas/Admin/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9381566702f9a9cf684669613e5b978cd2ce8f1d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<My_Project.Models.BookingModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h1 class=""mb-4 text-center text-black"">Bookings</h1>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Address</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Check In</th>
            <th>Check Out</th>
            <th>Number Of Members</th>
            <th>Settings</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
         foreach (My_Project.Models.BookingModel item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.BookingTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.BookingFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
           Write(item.NumberOfMembers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 872, "\"", 909, 2);
            WriteAttributeValue("", 879, "/admin/booking/delete/", 879, 22, true);
#nullable restore
#line 30 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
WriteAttributeValue("", 901, item.Id, 901, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n                    <i class=\"fas fa-trash\"></i>\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\test\Desktop\My-Project\My-Project\Areas\Admin\Views\Booking\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<My_Project.Models.BookingModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
