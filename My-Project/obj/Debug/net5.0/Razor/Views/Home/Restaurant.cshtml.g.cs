#pragma checksum "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa391b1f140638401e4a21402950cdfa0597320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Restaurant), @"mvc.1.0.view", @"/Views/Home/Restaurant.cshtml")]
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
#line 1 "C:\Users\test\Desktop\My-Project\My-Project\Views\_ViewImports.cshtml"
using My_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\test\Desktop\My-Project\My-Project\Views\_ViewImports.cshtml"
using My_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\test\Desktop\My-Project\My-Project\Views\_ViewImports.cshtml"
using My_Project.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa391b1f140638401e4a21402950cdfa0597320", @"/Views/Home/Restaurant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e10db8d528050e2c661819b125ce0d657a1fb97", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Restaurant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""about-side"" class=""text-center"">
    <div class=""container"">
        <h1 class=""fw-bolder"">Discover Our Menus</h1>
    </div>
</section>

<section id=""dining"">
    <div class=""container"" data-aos=""zoom-out-down"" data-aos-duration=""900"" data-aos-offset=""300""
         data-aos-easing=""ease-in-sine"">
        <div class=""top-text text-center mb-5"">
            <span class=""top"">Our Menu</span>
        </div>
        <h2 class=""text-center mb-5 text-light"">Restaurant</h2>
        <div class=""dining-category mb-5 text-center text-light"">
            <ul>
                <li class=""list"" data-filter=""main"">All</li>
");
#nullable restore
#line 19 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                 foreach (RestaurantCategory item in Model.restaurantCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list\" data-filter=\"");
#nullable restore
#line 21 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                             Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 21 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"row justify-content-between me-3 ms-3 text-light\">\r\n");
#nullable restore
#line 26 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
             foreach (RestaurantService item2 in Model.restaurantServices)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 1096, "\"", 1167, 4);
            WriteAttributeValue("", 1104, "col-lg-6", 1104, 8, true);
            WriteAttributeValue(" ", 1112, "col-12", 1113, 7, true);
#nullable restore
#line 28 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
WriteAttributeValue(" ", 1119, item2.RestaurantCategory.Name.ToLower(), 1120, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1160, "filter", 1161, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"menu\">\r\n                        <div class=\"menu-item d-flex justify-content-between align-items-center align-content-center\">\r\n                            <div class=\"menu-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9aa391b1f140638401e4a21402950cdfa05973206698", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1425, "~/images/meal/", 1425, 14, true);
#nullable restore
#line 32 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
AddHtmlAttributeValue("", 1439, item2.Image, 1439, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                <h5>");
#nullable restore
#line 35 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                               Write(item2.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 36 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                              Write(item2.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div>\r\n                                <span class=\"float-end fs-3 text-center\">$");
#nullable restore
#line 39 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                                                     Write(item2.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</section>

<section id=""service"">
    <div class=""container"">
        <div class=""top-text text-center mb-5"" data-aos=""zoom-out-down"" data-aos-duration=""1000"" data-aos-offset=""300""
             data-aos-easing=""ease-in-sine"">
            <span class=""top"">Service</span>
        </div>
        <div class=""row"">
            <div class=""col-lg-5 col-12 p-0"">
                <div class=""categories text-lg-start text-center"" data-aos=""fade-right"">
");
#nullable restore
#line 60 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                     foreach (Category item in Model.categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"tabs-toggle\"><i");
            BeginWriteAttribute("class", " class=\"", 2566, "\"", 2593, 3);
            WriteAttributeValue("", 2574, "uil", 2574, 3, true);
#nullable restore
#line 62 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
WriteAttributeValue(" ", 2577, item.Icon, 2578, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2588, "me-2", 2589, 5, true);
            EndWriteAttribute();
            WriteLiteral("></i>");
#nullable restore
#line 62 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 63 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-7 col-12 p-0\">\r\n");
#nullable restore
#line 67 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                 foreach (Service item in Model.services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2834, "\"", 2911, 3);
            WriteAttributeValue("", 2842, "services", 2842, 8, true);
#nullable restore
#line 69 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
WriteAttributeValue(" ", 2850, Model.services.IndexOf(item)==0?"is-active":"", 2851, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2900, "text-light", 2901, 11, true);
            EndWriteAttribute();
            WriteLiteral(" data-aos=\"fade-left\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 2962, "\"", 2984, 2);
            WriteAttributeValue("", 2970, "uil", 2970, 3, true);
#nullable restore
#line 70 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
WriteAttributeValue(" ", 2973, item.Icon, 2974, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        <h2 class=\"mb-4 fs-1\">");
#nullable restore
#line 71 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"mb-4\">");
#nullable restore
#line 72 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <span>");
#nullable restore
#line 73 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                         Write(item.Subtext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n");
#nullable restore
#line 75 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</section>

<section id=""guest"">
    <div class=""container"" data-aos=""zoom-in-down"" data-aos-duration=""2000"">
        <div class=""top-text text-center mb-5"">
            <span class=""top"">Guests says</span>
        </div>
        <h2 class=""text-center mb-5"">Our Satisfied Guests says</h2>
        <div class=""swiper mySwiper"">
            <div class=""swiper-wrapper"">
");
#nullable restore
#line 89 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                 foreach (Guest item in Model.guests)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide text-center mb-5\">\r\n                        <div class=\"img-wrapper\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9aa391b1f140638401e4a21402950cdfa059732014789", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3866, "~/images/person/", 3866, 16, true);
#nullable restore
#line 93 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
AddHtmlAttributeValue("", 3882, item.Image, 3882, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br>\r\n                        </div>\r\n                        <div class=\"stars\">\r\n");
#nullable restore
#line 96 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                             for (int i = 0; i < item.startCount; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"bi bi-star-fill\"></i>\r\n");
#nullable restore
#line 99 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"text mt-2\">\r\n                            <p class=\"opacity-75\">\r\n                                ");
#nullable restore
#line 103 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"properties mt-5\">\r\n                            <p class=\"fw-semibold\">");
#nullable restore
#line 107 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <span>Guest from ");
#nullable restore
#line 108 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                                        Write(item.Where);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 111 "C:\Users\test\Desktop\My-Project\My-Project\Views\Home\Restaurant.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"swiper-pagination\"></div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
