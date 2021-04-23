#pragma checksum "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4db60691f2d48d581eaa03965e6371191eb469"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Directors_Update), @"mvc.1.0.view", @"/Views/Directors/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4db60691f2d48d581eaa03965e6371191eb469", @"/Views/Directors/Update.cshtml")]
    public class Views_Directors_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF_LAb.Models.Director>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
  
    ViewData["Title"] = "Редактирование режиссера " + Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h2>Редактирование режиссера: ");
#nullable restore
#line 8 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n");
#nullable restore
#line 14 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
         using (Html.BeginForm("Update", "Directors", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 403, "\"", 420, 1);
#nullable restore
#line 16 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
WriteAttributeValue("", 411, Model.Id, 411, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label>Имя</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Иван Иванов\" name=\"Name\"");
            BeginWriteAttribute("value", " value=\"", 595, "\"", 614, 1);
#nullable restore
#line 20 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
WriteAttributeValue("", 603, Model.Name, 603, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label>Дата рождения</label>\r\n                <input type=\"date\" class=\"form-control\" name=\"Birthday\"");
            BeginWriteAttribute("value", " value=\"", 802, "\"", 887, 1);
            WriteAttributeValue("", 810, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 24 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                                                                  if (Model.Birthday.Year != 1) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                                                                                             Write(Model.Birthday.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                                                                                                                                        }; 

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 810, 77, false);
            EndWriteAttribute();
            WriteLiteral(" required>\r\n            </div>\r\n");
            WriteLiteral("<div class=\"form-group\">\r\n                <label>Страна рождения</label>\r\n                <input type=\"text\" class=\"form-control\" placeholder=\"Россия\" name=\"CountryName\"");
            BeginWriteAttribute("value", " value=\"", 1093, "\"", 1157, 1);
            WriteAttributeValue("", 1101, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 30 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                                                                                          if (Model.Country != null) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                                                                                                                  Write(Model.Country.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
                                                                                                                                                           }; 

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1101, 56, false);
            EndWriteAttribute();
            WriteLiteral(" required>\r\n            </div>\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-primary\">Отправить</button>\r\n");
#nullable restore
#line 35 "C:\Users\User\source\repos\EF_LAb\Views\Directors\Update.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF_LAb.Models.Director> Html { get; private set; }
    }
}
#pragma warning restore 1591