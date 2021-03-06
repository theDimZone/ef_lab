#pragma checksum "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6846794a9d0cdce69affff171a4b76d19755bba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Show), @"mvc.1.0.view", @"/Views/Movies/Show.cshtml")]
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
#line 1 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
using EF_LAb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6846794a9d0cdce69affff171a4b76d19755bba", @"/Views/Movies/Show.cshtml")]
    public class Views_Movies_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF_LAb.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>");
#nullable restore
#line 9 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"col-2\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 241, "\"", 302, 1);
#nullable restore
#line 12 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 248, Url.Action("Update", "Movies", new { Id = Model.Id }), 248, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-block btn-outline-success"">??????????????????????????</a>
        </div>

        <!-- delete button and modal -->
        <div class=""col-2"">
            <button type=""button"" class=""btn btn-block btn-outline-danger"" data-toggle=""modal"" data-target=""#deleteModal"">
                ??????????????
            </button>

            <div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""deleteModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""deleteModalLabel"">??????????????????</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
             ");
            WriteLiteral("               ...\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">????????????????</button>\r\n");
#nullable restore
#line 35 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                             using (Html.BeginForm("Delete", "Movies", FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 1730, "\"", 1747, 1);
#nullable restore
#line 37 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 1738, Model.Id, 1738, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                                <button type=\"submit\" class=\"btn btn-block btn-danger\">??????????????</button>\r\n");
#nullable restore
#line 40 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- add actor modal -->
        <div class=""modal fade"" id=""actorModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""actorModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""actorModalLabel"">???????????????? ????????????</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
");
#nullable restore
#line 57 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                     using (Html.BeginForm("AddActorToMovie", "Movies", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"modal-body\">\r\n                            <input type=\"hidden\" name=\"MovieId\"");
            BeginWriteAttribute("value", " value=\"", 2863, "\"", 2880, 1);
#nullable restore
#line 60 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 2871, Model.Id, 2871, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                            <div class=""form-group"">
                                <label>??????</label>
                                <input type=""text"" class=""form-control"" placeholder=""????????"" name=""ActorName"" required>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??????????????</button>
                            <button type=""submit"" class=""btn btn-primary"">??????????????????</button>
                        </div>
");
#nullable restore
#line 71 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

            </div>
        </div>

        <!-- add genre modal -->
        <div class=""modal fade"" id=""genreModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""genreModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""genreModalLabel"">???????????????? ????????</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
");
#nullable restore
#line 87 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                     using (Html.BeginForm("AddGenreToMovie", "Movies", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"modal-body\">\r\n                            <input type=\"hidden\" name=\"MovieId\"");
            BeginWriteAttribute("value", " value=\"", 4407, "\"", 4424, 1);
#nullable restore
#line 90 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 4415, Model.Id, 4415, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                            <div class=""form-group"">
                                <label>????????????????</label>
                                <input type=""text"" class=""form-control"" placeholder=""????????????"" name=""GenreName"" required>
                            </div>
                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">??????????????</button>
                            <button type=""submit"" class=""btn btn-primary"">??????????????????</button>
                        </div>
");
#nullable restore
#line 101 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n<div class=\"row\">\r\n    <div class=\"col-8\">\r\n        ??????: ");
#nullable restore
#line 110 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
        Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 113 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
   if (Model.Details != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-8\">\r\n                ????????????????: <p>");
#nullable restore
#line 117 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                        Write(Model.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 120 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
   if (Model.Country != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-8\">\r\n                ????????????: <a");
            BeginWriteAttribute("href", " href=\"", 5529, "\"", 5599, 1);
#nullable restore
#line 126 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 5536, Url.Action("Show", "Countries", new { Id = Model.Country.Id }), 5536, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 126 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                                                             Write(Model.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 129 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
   if (Model.Director != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-8\">\r\n                ????????????????: <a");
            BeginWriteAttribute("href", " href=\"", 5799, "\"", 5870, 1);
#nullable restore
#line 135 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 5806, Url.Action("Show", "Directors", new { Id = Model.Director.Id }), 5806, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 135 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                                                                Write(Model.Director.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 138 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""row"">
            <div class=""col-4"">
                <div class=""card"">
                    <div class=""card-header"">
                        ??????????:
                    </div>
                    <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 148 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                          
                            if (Model.GenreMovies.Count > 0)
                            {
                                foreach (GenreMovie genre_movie in Model.GenreMovies)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <li class=""list-group-item"">
                                                    <div class=""row"">
                                                        <div class=""col-10"">
                                                           <a");
            BeginWriteAttribute("href", " href=\"", 6740, "\"", 6811, 1);
#nullable restore
#line 156 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 6747, Url.Action("Show", "Genres", new { Id = genre_movie.Genre.Id }), 6747, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 156 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                                                                                                 Write(genre_movie.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </div>\r\n                                                        <div class=\"col-2\">\r\n");
#nullable restore
#line 159 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                             using (Html.BeginForm("RemoveGenreFromMovie", "Movies", FormMethod.Post))
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <input type=\"hidden\" name=\"MovieId\"");
            BeginWriteAttribute("value", " value=\"", 7281, "\"", 7298, 1);
#nullable restore
#line 161 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 7289, Model.Id, 7289, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                <input type=\"hidden\" name=\"GenreId\"");
            BeginWriteAttribute("value", " value=\"", 7403, "\"", 7432, 1);
#nullable restore
#line 162 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 7411, genre_movie.Genre.Id, 7411, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                <button align=\"right\" type=\"submit\" class=\"btn btn-light\">X</button>\r\n");
#nullable restore
#line 164 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </div>\r\n                                                    </div>\r\n                                                </li>\r\n");
#nullable restore
#line 168 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                }

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""list-group-item""><button type=""button"" class=""btn btn-outline-secondary"" data-toggle=""modal"" data-target=""#genreModal"">???????????????? ????????</button></li>
                    </ul>
                </div>
            </div>

            <div class=""col-4"">
                <div class=""card"">
                    <div class=""card-header"">
                        ????????????:
                    </div>
                    <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 183 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                          
                            if (Model.ActorMovies.Count > 0)
                            {
                                foreach (ActorMovie actor_movie in Model.ActorMovies)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <li class=""list-group-item"">
                                                    <div class=""row"">
                                                        <div class=""col-10"">
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 8936, "\"", 9007, 1);
#nullable restore
#line 191 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 8943, Url.Action("Show", "Actors", new { Id = actor_movie.Actor.Id }), 8943, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 191 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                                                                                                  Write(actor_movie.Actor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </div>\r\n                                                        <div class=\"col-2\">\r\n");
#nullable restore
#line 194 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                             using (Html.BeginForm("RemoveActorFromMovie", "Movies", FormMethod.Post))
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                 <input type=\"hidden\" name=\"MovieId\"");
            BeginWriteAttribute("value", " value=\"", 9478, "\"", 9495, 1);
#nullable restore
#line 196 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 9486, Model.Id, 9486, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                 <input type=\"hidden\" name=\"ActorId\"");
            BeginWriteAttribute("value", " value=\"", 9601, "\"", 9630, 1);
#nullable restore
#line 197 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 9609, actor_movie.Actor.Id, 9609, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                                 <button align=\"right\" type=\"submit\" class=\"btn btn-light\">X</button>\r\n");
#nullable restore
#line 199 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </div>\r\n                                                    </div>\r\n                                                </li>\r\n");
#nullable restore
#line 203 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                }

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""list-group-item""><button type=""button"" class=""btn btn-outline-secondary""  data-toggle=""modal"" data-target=""#actorModal"">???????????????? ????????????</button></li>
                    </ul>
                </div>
            </div>



            <div class=""col-4"">
                <div class=""card"">
                    <div class=""card-header"">
                        ??????????:
                    </div>
                    <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 220 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                          
                            if (Model.Media.Count > 0)
                            {
                                foreach (Media file in Model.Media)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 10894, "\"", 10951, 1);
#nullable restore
#line 225 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 10901, Url.Action("Show", "Media", new { Id = file.Id }), 10901, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 225 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                                                                                        Write(file.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 226 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                }

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 11123, "\"", 11189, 1);
#nullable restore
#line 230 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 11130, Url.Action("Create", "Media", new { movie_id = Model.Id }), 11130, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-secondary\">???????????????? ??????????</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 238 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
      
        if (Model.SelectionMovies.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        ???????????????????? ?? ??????????????????:
                    </div>
                    <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 247 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                           foreach (SelectionMovie selection_movie in Model.SelectionMovies)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 11880, "\"", 11963, 1);
#nullable restore
#line 249 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
WriteAttributeValue("", 11887, Url.Action("Show", "Selections", new { Id = selection_movie.Selection.Id }), 11887, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 249 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                                                                                                                                              Write(selection_movie.Selection.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 250 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 255 "C:\Users\User\source\repos\EF_LAb\Views\Movies\Show.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF_LAb.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
