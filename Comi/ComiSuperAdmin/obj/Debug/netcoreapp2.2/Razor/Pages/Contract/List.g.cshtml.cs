#pragma checksum "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea1c9e8ee291475d1756775b8b43b0d62ce0e6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiSuperAdmin.Pages.Contract.Pages_Contract_List), @"mvc.1.0.razor-page", @"/Pages/Contract/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contract/List.cshtml", typeof(ComiSuperAdmin.Pages.Contract.Pages_Contract_List), null)]
namespace ComiSuperAdmin.Pages.Contract
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\admin\Comi\ComiSuperAdmin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\admin\Comi\ComiSuperAdmin\Pages\_ViewImports.cshtml"
using ComiSuperAdmin;

#line default
#line hidden
#line 3 "D:\admin\Comi\ComiSuperAdmin\Pages\_ViewImports.cshtml"
using ComiCore.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea1c9e8ee291475d1756775b8b43b0d62ce0e6b", @"/Pages/Contract/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6954e3851fec59c60578eb3865603d9409ea80df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contract_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Contract/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(65, 1037, true);
            WriteLiteral(@"
<h3><i class=""fa fa-angle-right""></i> All contracts</h3>
<div class=""row mt"">
    <div class=""col-md-12"">
        <div class=""content-panel"">
            <table class=""table table-striped table-advance table-hover"">
                <h4><i class=""fa fa-angle-right""></i>All contracts</h4>
                <hr>
                <thead>
                    <tr>
                        <th><i class=""fa fa-align-justify""></i> Vendor</th>
                        <th><i class=""fa fa-align-justify""></i> Package</th>
                        <th><i class=""fa fa-align-justify""></i> Description</th>
                        <th><i class=""fa fa-align-justify""></i> Duration</th>
                        <th><i class=""fa fa-align-justify""></i> Total price</th>
                        <th><i class=""fa fa-align-justify""></i> Status</th>
                        <th><i class=""fa fa-align-justify""></i> From date</th>
                        <th></th>
                    </tr>
                </thead>
            ");
            WriteLiteral("    <tbody>\r\n");
            EndContext();
#line 27 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                     foreach (var c in Model.Contracts)
                    {
                        var month = 0;
                        switch (c.Duration)
                        {
                            case Duration.ThreeMonth:
                                month = 3;
                                break;
                            case Duration.SixMonth:
                                month = 6;
                                break;
                            case Duration.OneYear:
                                month = 12;
                                break;
                            default:
                                break;
                        }

#line default
#line hidden
            BeginContext(1812, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1867, 13, false);
#line 45 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                       Write(c.Vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1880, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1916, 14, false);
#line 46 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                       Write(c.Package.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1966, 13, false);
#line 47 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                       Write(c.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1979, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2015, 10, false);
#line 48 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                       Write(c.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2062, 19, false);
#line 49 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                        Write(c.UnitPrice * month);

#line default
#line hidden
            EndContext();
            BeginContext(2082, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2118, 8, false);
#line 50 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                       Write(c.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2126, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2162, 13, false);
#line 51 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                       Write(c.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(2175, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2240, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea1c9e8ee291475d1756775b8b43b0d62ce0e6b8694", async() => {
                BeginContext(2321, 28, true);
                WriteLiteral("<i class=\"fa fa-pencil\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                                                           WriteLiteral(c.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2353, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 56 "D:\admin\Comi\ComiSuperAdmin\Pages\Contract\List.cshtml"
                    }

#line default
#line hidden
            BeginContext(2436, 88, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel>)PageContext?.ViewData;
        public ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591