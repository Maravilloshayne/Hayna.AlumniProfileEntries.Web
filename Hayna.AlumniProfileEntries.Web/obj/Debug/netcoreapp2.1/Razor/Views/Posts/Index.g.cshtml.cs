#pragma checksum "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ab81870d615eeabb3dcada1687a7ee11694249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Index.cshtml", typeof(AspNetCore.Views_Posts_Index))]
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
#line 1 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\_ViewImports.cshtml"
using Hayna.AlumniProfileEntries.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\_ViewImports.cshtml"
using Hayna.AlumniProfileEntries.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
using Hayna.AlumniProfileEntries.Web.Infrastructures.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ab81870d615eeabb3dcada1687a7ee11694249", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc76cdb5996d291918cd05d2cef4beadc48688c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hayna.AlumniProfileEntries.Web.VIewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:750px;max-height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
  
    Layout = "~/Views/Shared/_BlogWithWidgets.cshtml";

#line default
#line hidden
            BeginContext(195, 54, true);
            WriteLiteral("\r\n<h1>Announcements</h1>\r\n<section class=\"post-con\">\r\n");
            EndContext();
#line 9 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
      
        foreach (Post post in Model.Posts)
        {

#line default
#line hidden
            BeginContext(312, 79, true);
            WriteLiteral("            <article>\r\n                <div class=\"info\">\r\n                    ");
            EndContext();
            BeginContext(391, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "605b21b9606449ed874e36c4389f1c5f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 422, "~/posts/", 422, 8, true);
#line 14 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 430, post.Id, 430, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 438, "/banner.png", 438, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(514, 26, true);
            WriteLiteral("\r\n                    <h3>");
            EndContext();
            BeginContext(541, 12, false);
#line 15 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                   Write(post.Company);

#line default
#line hidden
            EndContext();
            BeginContext(553, 255, true);
            WriteLiteral("</h3>\r\n                    <table>\r\n                        <tr>\r\n                            <th>Position</th>\r\n                            <th>Location</th>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(809, 13, false);
#line 23 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                           Write(post.Position);

#line default
#line hidden
            EndContext();
            BeginContext(822, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(862, 13, false);
#line 24 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                           Write(post.Location);

#line default
#line hidden
            EndContext();
            BeginContext(875, 130, true);
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                    </table>\r\n                    <p class=\"info-line\"><span class=\"time\">");
            EndContext();
            BeginContext(1006, 51, false);
#line 28 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                                                       Write(post.ToDate.ToString("dddd, dd MMMM yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 36, true);
            WriteLiteral("</span></p>\r\n                    <p>");
            EndContext();
            BeginContext(1094, 16, false);
#line 29 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                  Write(post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(1139, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6c65aa5fb3a4cf99fd02280cd0ffef9", async() => {
                BeginContext(1190, 16, true);
                WriteLiteral("Read More &rarr;");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1148, "~/posts/", 1148, 8, true);
#line 30 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 1156, post.Id, 1156, 8, false);

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
            BeginContext(1210, 54, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </article>\r\n");
            EndContext();
#line 33 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1282, 292, true);
            WriteLiteral(@"</section>
<!-- Pagination -->
<ul class=""pagination justify-content-center mb-4"">
    <li class=""page-item"">
        <a class=""page-link"" href=""#"">&larr; Older</a>
    </li>
    <li class=""page-item disabled"">
        <a class=""page-link"" href=""#"">Newer &rarr;</a>
    </li>
</ul>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hayna.AlumniProfileEntries.Web.VIewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
