#pragma checksum "D:\admin\Comi\ComiAdmin\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9e3a2b396caec39857098be8c15f8288603f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiAdmin.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(ComiAdmin.Pages.Pages_About), null)]
namespace ComiAdmin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\admin\Comi\ComiAdmin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\admin\Comi\ComiAdmin\Pages\_ViewImports.cshtml"
using ComiAdmin;

#line default
#line hidden
#line 3 "D:\admin\Comi\ComiAdmin\Pages\_ViewImports.cshtml"
using ComiAdmin.Data;

#line default
#line hidden
#line 4 "D:\admin\Comi\ComiAdmin\Pages\_ViewImports.cshtml"
using ComiCore;

#line default
#line hidden
#line 5 "D:\admin\Comi\ComiAdmin\Pages\_ViewImports.cshtml"
using ComiCore.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9e3a2b396caec39857098be8c15f8288603f03", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327c7ed88802998f2fe854949b1515c984eb1ebc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\admin\Comi\ComiAdmin\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(67, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(72, 17, false);
#line 6 "D:\admin\Comi\ComiAdmin\Pages\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(89, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(101, 13, false);
#line 7 "D:\admin\Comi\ComiAdmin\Pages\About.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(114, 66, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591