#pragma checksum "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e77d0f1ab347c5523cef0429ef62b1fed56d752f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Posts_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Posts/Index.cshtml", typeof(AspNetCore.Areas_Manage_Views_Posts_Index))]
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
#line 1 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77d0f1ab347c5523cef0429ef62b1fed56d752f", @"/Areas/Manage/Views/Posts/Index.cshtml")]
    public class Areas_Manage_Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Banner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Upload Thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/posts?pageIndex=1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(242, 242, true);
            WriteLiteral("\r\n<h3>Manage Posts</h3>`\r\n\r\n<div class=\"card-container col-md-8\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"input-group mb-3\">\r\n                <input id=\"searchKeyword\" type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 484, "\"", 512, 1);
#line 14 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 492, Model.Posts.Keyword, 492, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(513, 334, true);
            WriteLiteral(@" placeholder=""Search by title"" aria-label=""Search title"" aria-describedby=""basic-addon2"">
                <div class=""input-group-append"">
                    <button class=""btn btn-outline-secondary"" type=""button"" onclick=""searchTrigger()"">Search</button>
                </div>
            </div>
        </div>
    </div>

");
            EndContext();
#line 22 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
      
        if (Model.Posts != null)
        {
            if (Model.Posts.Items.Count > 0)
            {
                foreach (Post post in Model.Posts.Items)
                {

#line default
#line hidden
            BeginContext(1038, 228, true);
            WriteLiteral("                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-sm-3\">\r\n                                    ");
            EndContext();
            BeginContext(1266, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1eab5b731f27461c83b8c98b7bb15645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1276, "~/posts/", 1276, 8, true);
#line 33 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 1284, post.Id, 1284, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1292, "/Shane.png.jpg", 1292, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1344, 138, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-9\">\r\n                                    <h4>");
            EndContext();
            BeginContext(1483, 12, false);
#line 36 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                   Write(post.Company);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 369, true);
            WriteLiteral(@"</h4>

                                    <table>
                                        <tr>
                                            <th>Position</th>
                                            <th>Location</th>

                                        </tr>
                                        <tr>
                                            <td>");
            EndContext();
            BeginContext(1865, 13, false);
#line 45 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                           Write(post.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1878, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(1934, 13, false);
#line 46 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                           Write(post.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 348, true);
            WriteLiteral(@"</td>

                                        </tr>
                                    </table>
                                    <table>
                                        <tr>
                                            <th>Description</th>

                                    </table>

                                    <p>");
            EndContext();
            BeginContext(2296, 16, false);
#line 56 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                  Write(post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2312, 137, true);
            WriteLiteral("</p>\r\n                                    <ul class=\"list-inline\">\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2449, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31748a94c840425eb6a5da58cafe687e", async() => {
                BeginContext(2519, 81, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2458, "~/manage/posts/update-banner/", 2458, 29, true);
#line 58 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 2487, post.Id, 2487, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2604, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2680, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d22fe38163e34bc4bd69a78c2a8fb786", async() => {
                BeginContext(2756, 86, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-image\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2689, "~/manage/posts/update-thumbnail/", 2689, 32, true);
#line 59 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 2721, post.Id, 2721, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2846, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(2922, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d30f468d67fc426aae94c54185128dad", async() => {
                BeginContext(2994, 84, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-file-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2931, "~/manage/posts/update-content/", 2931, 30, true);
#line 60 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 2961, post.Id, 2961, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3082, 76, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3158, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2c15034c58145d49949bfef32751840", async() => {
                BeginContext(3226, 83, true);
                WriteLiteral("<button class=\"btn-success form-control-sm\"><i class=\"fas fa-pen-alt\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3167, "~/manage/posts/update-title/", 3167, 28, true);
#line 61 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 3195, post.Id, 3195, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3313, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 62 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                          
                                            if (post.IsPublished)
                                            {

#line default
#line hidden
            BeginContext(3478, 106, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Unpublish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3584, "\"", 3638, 5);
            WriteAttributeValue("", 3594, "confirmUnpublish(\'", 3594, 18, true);
#line 65 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3612, post.Id, 3612, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3620, "\',\'", 3620, 3, true);
#line 65 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 3623, post.Company, 3623, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3636, "\')", 3636, 2, true);
            EndWriteAttribute();
            BeginContext(3639, 99, true);
            WriteLiteral("><button class=\"btn-danger form-control-sm\"><i class=\"fas fa-window-close\"></i></button></a></li>\r\n");
            EndContext();
#line 66 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3882, 104, true);
            WriteLiteral("                                                <li class=\"list-inline-item\"><a href=\"#\" title=\"Publish\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3986, "\"", 4038, 5);
            WriteAttributeValue("", 3996, "confirmPublish(\'", 3996, 16, true);
#line 69 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 4012, post.Id, 4012, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4020, "\',\'", 4020, 3, true);
#line 69 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
WriteAttributeValue("", 4023, post.Company, 4023, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4036, "\')", 4036, 2, true);
            EndWriteAttribute();
            BeginContext(4039, 100, true);
            WriteLiteral("><button class=\"btn-success form-control-sm\"><i class=\"fas fa-check-square\"></i></button></a></li>\r\n");
            EndContext();
#line 70 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                            }
                                        

#line default
#line hidden
            BeginContext(4229, 179, true);
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 77 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                }




#line default
#line hidden
            BeginContext(4433, 83, true);
            WriteLiteral("                <ul class=\"pagination\">\r\n                    <li class=\"page-item\">");
            EndContext();
            BeginContext(4516, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98317aeac1d5436fa1499992f4cdf515", async() => {
                BeginContext(4571, 5, true);
                WriteLiteral("First");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4580, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 83 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                       if (Model.Posts.PageIndex > 1)
                        {

#line default
#line hidden
            BeginContext(4669, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(4719, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddc181fa6e4640ac979488ba3cd26fc3", async() => {
                BeginContext(4803, 25, false);
#line 85 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                                                                                                                Write(Model.Posts.PageIndex - 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4746, "~/manage/posts?pageIndex=", 4746, 25, true);
#line 85 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 4771, Model.Posts.PageIndex - 1, 4771, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4833, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 86 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4890, 78, true);
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link active href=\"#\">");
            EndContext();
            BeginContext(4970, 21, false);
#line 88 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                                                          Write(Model.Posts.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4992, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 89 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                       if ((Model.Posts.PageIndex + 1) <= Model.Posts.PageCount)
                        {

#line default
#line hidden
            BeginContext(5112, 50, true);
            WriteLiteral("                            <li class=\"page-item\">");
            EndContext();
            BeginContext(5162, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6e387b511dd4b0ebdf632abb99be516", async() => {
                BeginContext(5246, 25, false);
#line 91 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                                                                                                                                Write(Model.Posts.PageIndex + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5189, "~/manage/posts?pageIndex=", 5189, 25, true);
#line 91 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 5214, Model.Posts.PageIndex + 1, 5214, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5276, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 92 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(5333, 42, true);
            WriteLiteral("                    <li class=\"page-item\">");
            EndContext();
            BeginContext(5375, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b532954c27f747259a70c4f238affd22", async() => {
                BeginContext(5451, 4, true);
                WriteLiteral("Last");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5402, "~/manage/posts?pageIndex=", 5402, 25, true);
#line 94 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 5427, Model.Posts.PageCount, 5427, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5459, 30, true);
            WriteLiteral("</li>\r\n                </ul>\r\n");
            EndContext();
#line 96 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Areas\Manage\Views\Posts\Index.cshtml"
            }
        }
    

#line default
#line hidden
            BeginContext(5522, 1862, true);
            WriteLiteral(@"
</div>

<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-unpublish"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Unpublish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to unpublish <span id=""modal-unpublish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-unpublish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-publish"">
");
            WriteLiteral(@"    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Publish Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to publish <span id=""modal-publish-title""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" id=""modal-publish-button"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("pageStyles", async() => {
                BeginContext(7404, 254, true);
                WriteLiteral("\r\n    <style>\r\n        h2 {\r\n            margin-top: 30px;\r\n        }\r\n\r\n        .card-container {\r\n            margin-bottom: 30px;\r\n        }\r\n\r\n        .card {\r\n            margin-top: 15px;\r\n            margin-bottom: 15px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(7661, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(7686, 2235, true);
                WriteLiteral(@"
    <script>

        //////////////////////SEARCH/////////////////////////////////////////////////////////////////
        function searchTrigger() {
            window.location = ""/manage/posts?pageIndex=1&keyword="" + $(""#searchKeyword"").val();
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                searchTrigger();
            }
        });


        ////////////////////UNPUBLISH/////////////////////////////////////////////////////////////////
        function confirmUnpublish(id, title) {
            $(""#modal-unpublish-title"").html(title);
            $(""#modal-unpublish-button"").attr(""onclick"", ""unPublishPost('"" + id + ""')"");
            $(""#modal-unpublish"").modal(""show"");
        }

        function unPublishPost(id) {
            $.ajax({
                type: ""POST"",
                url: ""/manage/posts/unpublish"",
                data: { id: id },
                success: function (data) {
                  ");
                WriteLiteral(@"  location.reload();
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.responseText);
                    alert(""Error Occured : "" + response.errors[0]);
                    location.reload();
                }
            });
        }

        //////////////////PUBLISH///////////////////////////////////////////////////////////////////////
        function confirmPublish(id, title) {
            $(""#modal-publish-title"").html(title);
            $(""#modal-publish-button"").attr(""onclick"", ""publishPost('"" + id + ""')"");
            $(""#modal-publish"").modal(""show"");
        }

        function publishPost(id) {
            $.ajax({
                type: ""POST"",
                url: ""/manage/posts/publish"",
                data: { id: id },
                success: function (data) {
                    location.reload();
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.");
                WriteLiteral("responseText);\r\n                    alert(\"Error Occured : \" + response.errors[0]);\r\n                    location.reload();\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(9924, 30, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hayna.AlumniProfileEntries.Web.Areas.Manage.Models.Posts.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
