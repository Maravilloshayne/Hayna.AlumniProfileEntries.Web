#pragma checksum "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3222fff54c5b079c4890ed175226f251a705e7f8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3222fff54c5b079c4890ed175226f251a705e7f8", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc76cdb5996d291918cd05d2cef4beadc48688c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hayna.AlumniProfileEntries.Web.VIewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:150px;max-height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(195, 72, true);
            WriteLiteral("\r\n\r\n<h1 class=\"my-4\">\r\n    Posts\r\n    <small>Wall view </small>\r\n</h1>\r\n");
            EndContext();
#line 12 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
  


    foreach (Post post in Model.Posts)
    {

#line default
#line hidden
            BeginContext(322, 73, true);
            WriteLiteral("        <!--Blog Post-->\r\n        <div class=\" cardd mb-4\">\r\n            ");
            EndContext();
            BeginContext(395, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f649bee91c042ffad82ec209db242c5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 426, "~/posts/", 426, 8, true);
#line 19 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
AddHtmlAttributeValue("", 434, post.Id, 434, 8, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 442, "/shane.png.jpg", 442, 14, true);
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
            BeginContext(521, 104, true);
            WriteLiteral("\r\n            <div class=\" card body\">\r\n                <h2 style=\"background-color:tomato;\"card-title\">");
            EndContext();
            BeginContext(626, 12, false);
#line 21 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                                                           Write(post.Company);

#line default
#line hidden
            EndContext();
            BeginContext(638, 86, true);
            WriteLiteral("</h2>\r\n                <table>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(725, 13, false);
#line 24 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                       Write(post.Position);

#line default
#line hidden
            EndContext();
            BeginContext(738, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(774, 13, false);
#line 25 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                       Write(post.Location);

#line default
#line hidden
            EndContext();
            BeginContext(787, 97, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                </table>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(885, 16, false);
#line 28 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                                Write(post.Description);

#line default
#line hidden
            EndContext();
            BeginContext(901, 178, true);
            WriteLiteral("</p>\r\n                <a href=\"#\" class=\"btn btn-primary\">Read More &rarr;</a>\r\n\r\n            </div>\r\n            <div class=\"card footer text-muted\">\r\n                Posted on ");
            EndContext();
            BeginContext(1080, 49, false);
#line 33 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"
                     Write(post.Timestamp.ToString("dddd, dd yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 40, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 37 "C:\Users\Shayne Maravillo\Desktop\Hayna.AlumniProfileEntries\Hayna.AlumniProfileEntries.Web\Views\Posts\Index.cshtml"


    }

#line default
#line hidden
            BeginContext(1183, 273, true);
            WriteLiteral(@"<!--Pagination-->
<ul class=""pagination justify-content-center mb-4"">
    <li class=""page-item"">
        <a class=""page-link"" href=""#"">&larr; Older</a>

    </li>
    <li class=""page-item"">
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
