#pragma checksum "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73d7b7c634c66f8afb712b75c99daa94df4af58b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Edit), @"mvc.1.0.view", @"/Views/Albums/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albums/Edit.cshtml", typeof(AspNetCore.Views_Albums_Edit))]
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
#line 1 "D:\Programs\Projects\Photo.by\WebUI\Views\_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
#line 2 "D:\Programs\Projects\Photo.by\WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Models;

#line default
#line hidden
#line 3 "D:\Programs\Projects\Photo.by\WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73d7b7c634c66f8afb712b75c99daa94df4af58b", @"/Views/Albums/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf92156fb463391438c5e88bb750e96aaf4c73f", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlbumsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("size", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("photoSelect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("photoSelectSource"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/albumPhotos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
  
    ViewData["Title"] = "Изменение альбома";

#line default
#line hidden
            BeginContext(79, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(86, 17, false);
#line 7 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(103, 89, true);
            WriteLiteral("</h2>\r\n\r\n<h4>Альбом</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(192, 3104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cf498f0db0c4f9d80a59fbd2b329ee3", async() => {
                BeginContext(216, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(230, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e817ef7463074953ac527a7659dcedef", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(296, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(311, 31, false);
#line 15 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
       Write(Html.HiddenFor(m => m.Album.Id));

#line default
#line hidden
                EndContext();
                BeginContext(342, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(399, 66, false);
#line 17 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.LabelFor(m => m.Album.Name, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(465, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(484, 91, false);
#line 18 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.EditorFor(m => m.Album.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(575, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(594, 80, false);
#line 19 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Album.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(674, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(751, 73, false);
#line 22 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.LabelFor(m => m.Album.Description, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(824, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(843, 98, false);
#line 23 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.EditorFor(m => m.Album.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(941, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(960, 87, false);
#line 24 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Album.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1047, 164, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Фотографии</label><br>\r\n                <div id=\"photos\">\r\n");
                EndContext();
#line 29 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
                      int v = 0;

#line default
#line hidden
                BeginContext(1246, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 30 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
                     foreach (var photo in Model.Photos)
                    {

#line default
#line hidden
                BeginContext(1327, 153, true);
                WriteLiteral("                        <div class=\"photoItem\" style=\"display:inline-block; margin: 0px 10px;\">\r\n                            <h5 class=\"fotoLabel\">Фото №");
                EndContext();
                BeginContext(1482, 3, false);
#line 33 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
                                                    Write(++v);

#line default
#line hidden
                EndContext();
                BeginContext(1486, 88, true);
                WriteLiteral("</h5>\r\n                            <label>Название</label>\r\n                            ");
                EndContext();
                BeginContext(1574, 173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59d9cde2d7d4487e9fd96a9e45ab72b8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 35 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.AllPhotos,"Id","Name", photo));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 36 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
                                                        WriteLiteral($"Photos[{v-1}]");

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1747, 38, true);
                WriteLiteral("<br>\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1785, "\"", 1843, 1);
#line 37 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
WriteAttributeValue("", 1791, Model.AllPhotos.First(p => p.Id == photo).LowSource, 1791, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1844, 47, true);
                WriteLiteral(" width=\"150\">\r\n                        </div>\r\n");
                EndContext();
#line 39 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
                    }

#line default
#line hidden
                BeginContext(1914, 513, true);
                WriteLiteral(@"                </div>
                <p>
                    <a class=""addPhoto"" style=""cursor:pointer"">Добавить фото</a>
                    <a class=""removePhoto"" style=""cursor:pointer"">Удалить фото</a>
                </p>
                <div hidden=""hidden"">
                    <div id=""photoItem"" class=""photoItem"" style=""display:inline-block; margin: 0px 10px;"">
                        <h5 class=""fotoLabel"">Фото №0</h5>
                        <label>Название</label>
                        ");
                EndContext();
                BeginContext(2427, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98bdda2539244ff7ac93ce9fd7bf9e0c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 49 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.AllPhotos,"Id","Name"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2532, 97, true);
                WriteLiteral("<br>\r\n                        <img width=\"150\">\r\n                    </div>\r\n                    ");
                EndContext();
                BeginContext(2629, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71cbfc057acb43aea93d59ad2cae99a8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 52 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.AllPhotos,"Id","LowSource"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2742, 100, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(2843, 66, false);
#line 56 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.LabelFor(m => m.Album.Date, new { @class = "control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(2909, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2928, 91, false);
#line 57 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.EditorFor(m => m.Album.Date, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3019, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3038, 80, false);
#line 58 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Album.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3118, 171, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Сохранить\" class=\"btn btn-default\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3296, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3331, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05105a0d4945474e82f8739aec884487", async() => {
                BeginContext(3353, 18, true);
                WriteLiteral("Вернуться к списку");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3375, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3405, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 72 "D:\Programs\Projects\Photo.by\WebUI\Views\Albums\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3475, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(3479, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02cb9e73d8647a4acf6a5671b400eb8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3522, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlbumsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
