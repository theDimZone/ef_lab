#pragma checksum "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d92cfb1b696af1bd57f46b7272e4532700f822b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genres_Index), @"mvc.1.0.view", @"/Views/Genres/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d92cfb1b696af1bd57f46b7272e4532700f822b", @"/Views/Genres/Index.cshtml")]
    public class Views_Genres_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EF_LAb.Models.Genre>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml"
  
    ViewData["Title"] = "Жанры";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-9\">\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item\">Жанры</li>\r\n");
#nullable restore
#line 9 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml"
              
                foreach (var genre in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 335, "\"", 394, 1);
#nullable restore
#line 12 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml"
WriteAttributeValue("", 342, Url.Action("Show", "Genres", new { Id = genre.Id }), 342, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml"
                                                                                                          Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 13 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 514, "\"", 552, 1);
#nullable restore
#line 18 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Index.cshtml"
WriteAttributeValue("", 521, Url.Action("Create", "Genres"), 521, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-block btn-outline-success\">Добавить новый жанр</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EF_LAb.Models.Genre>> Html { get; private set; }
    }
}
#pragma warning restore 1591
