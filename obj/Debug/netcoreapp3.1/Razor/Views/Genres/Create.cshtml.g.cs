#pragma checksum "C:\Users\User\source\repos\EF_LAb\Views\Genres\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6e687c57f1852efa61d60f3d14ddf0b50c494c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genres_Create), @"mvc.1.0.view", @"/Views/Genres/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6e687c57f1852efa61d60f3d14ddf0b50c494c", @"/Views/Genres/Create.cshtml")]
    public class Views_Genres_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Create.cshtml"
  
    ViewData["Title"] = "Добавление нового жанра";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h2>Добавление нового жанра</h2>\r\n    </div>\r\n</div>\r\n        <br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n");
#nullable restore
#line 13 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Create.cshtml"
         using (Html.BeginForm("Create", "Genres", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""form-group"">
                <label>Название</label>
                <input type=""text"" class=""form-control"" placeholder=""Боевик"" name=""Name"" required>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Отправить</button>
");
#nullable restore
#line 20 "C:\Users\User\source\repos\EF_LAb\Views\Genres\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
