#pragma checksum "C:\Users\kiedr\source\repos\Blog_project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1db3e9238907bfed793a5bbd78ce0747f0dbd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\kiedr\source\repos\Blog_project\Views\_ViewImports.cshtml"
using Blog_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kiedr\source\repos\Blog_project\Views\_ViewImports.cshtml"
using Blog_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1db3e9238907bfed793a5bbd78ce0747f0dbd1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4eb3e0b6cc1a405f412a215abc387465e56fd6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog_project.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\kiedr\source\repos\Blog_project\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""section"">
    <div class=""container"">
        <div class=""columns"">
            <div class=""column is-4"">
                <h1 class=""is-size-1 title"">Blog AiB</h1>
                <h2 class=""is-size-2 subtitle"">Log in to add posts</h2>
                <p>
                    Pierwszy raz termin „blog” został użyty w 1999 r. przez Petera Merholza[7], redaktora jednego z najwcześniejszych internetowych dzienników,
                    znanego pod nazwą „Robot Wisdom”[8]. Od dwóch lat funkcjonowało już jednak określenie „weblog” autorstwa Jorna Bargera, oznaczające strony,
                    na których umieszczane były jedynie linki do innych stron z danej dziedziny,
                    ewentualnie komentarze/wpisy ułożone w porządku odwrotnym do chronologicznego
                </p>
            </div>
            <div class=""column is-5"">

            </div>
            <div class=""column is-3"">
");
            WriteLiteral("            </div>\n        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog_project.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
