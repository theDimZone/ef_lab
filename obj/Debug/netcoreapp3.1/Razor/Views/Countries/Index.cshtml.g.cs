#pragma checksum "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c212456445623d6ee146f8772f94899a2a1c745c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Index), @"mvc.1.0.view", @"/Views/Countries/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c212456445623d6ee146f8772f94899a2a1c745c", @"/Views/Countries/Index.cshtml")]
    public class Views_Countries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EF_LAb.Models.Country>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml"
  
    ViewData["Title"] = "Страны";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-9\">\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\">Страны</li>\r\n");
#nullable restore
#line 9 "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml"
                  
                    foreach (var country in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 373, "\"", 437, 1);
#nullable restore
#line 12 "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml"
WriteAttributeValue("", 380, Url.Action("Show", "Countries", new { Id = country.Id }), 380, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml"
                                                                                                                   Write(country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 13 "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 583, "\"", 624, 1);
#nullable restore
#line 18 "C:\Users\User\source\repos\EF_LAb\Views\Countries\Index.cshtml"
WriteAttributeValue("", 590, Url.Action("Create", "Countries"), 590, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-block btn-outline-success\">Добавить новую страну</a>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EF_LAb.Models.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
