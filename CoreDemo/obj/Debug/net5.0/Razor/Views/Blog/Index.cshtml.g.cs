#pragma checksum "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7afa58ceb0263f87e7184cea2b6679d165e5ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7afa58ceb0263f87e7184cea2b6679d165e5ff1", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card\">\r\n                        <a href=\"single.html\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 629, "\"", 650, 1);
#nullable restore
#line 18 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 635, item.BlogImage, 635, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 682, "\"", 688, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-4"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 24 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                                       Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 0
                                    </a>
                                </li>
                                <li>
                                    <a href=""#""><!--Kulanılan tabloyla ilişkili tabloya include metodu ile ulaşabiliyoruz-->
                                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 34 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n\r\n                            </ul>\r\n                            <h5 class=\"card-title\">\r\n                                <a href=\"single.html\">");
#nullable restore
#line 40 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p class=\"card-text mb-3\">");
#nullable restore
#line 42 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                                                 Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2069, "\"", 2106, 2);
            WriteAttributeValue("", 2076, "/Blog/BlogReadAll/", 2076, 18, true);
#nullable restore
#line 44 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2094, item.BlogID, 2094, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                        </div>\r\n                        <br />\r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\yazilim.park10\source\repos\CoreDemo\CoreDemo\Views\Blog\Index.cshtml"
                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
