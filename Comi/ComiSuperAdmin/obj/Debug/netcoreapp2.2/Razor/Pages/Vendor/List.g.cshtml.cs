#pragma checksum "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed4a66eb569b89c1600aab0830c50157a16d2cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiSuperAdmin.Pages.Vendor.Pages_Vendor_List), @"mvc.1.0.razor-page", @"/Pages/Vendor/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Vendor/List.cshtml", typeof(ComiSuperAdmin.Pages.Vendor.Pages_Vendor_List), null)]
namespace ComiSuperAdmin.Pages.Vendor
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed4a66eb569b89c1600aab0830c50157a16d2cf", @"/Pages/Vendor/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6954e3851fec59c60578eb3865603d9409ea80df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vendor_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Vendor/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(65, 1025, true);
            WriteLiteral(@"
<h3><i class=""fa fa-angle-right""></i> All vendors</h3>
<div class=""row mt"">
    <div class=""col-md-12"">
        <div class=""content-panel"">
            <table class=""table table-striped table-advance table-hover"">
                <h4><i class=""fa fa-angle-right""></i>All vendors</h4>
                <hr>
                <thead>
                    <tr>
                        <th><i class=""fa fa-align-justify""></i> Name</th>
                        <th><i class=""fa fa-align-justify""></i> Username</th>
                        <th><i class=""fa fa-align-justify""></i> Tax number</th>
                        <th><i class=""fa fa-align-justify""></i> Type</th>
                        <th><i class=""fa fa-align-justify""></i> Description</th>
                        <th><i class=""fa fa-align-justify""></i> Warehouse</th>
                        <th><i class=""fa fa-align-justify""></i> Bank</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
            WriteLiteral("\n");
            EndContext();
#line 27 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                     foreach (var v in Model.Vendors)
                    {

#line default
#line hidden
            BeginContext(1168, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1231, 6, false);
#line 30 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                           Write(v.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1277, 15, false);
#line 31 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                           Write(v.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1292, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1332, 11, false);
#line 32 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                           Write(v.TaxNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1383, 13, false);
#line 33 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                           Write(v.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1396, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1436, 16, false);
#line 34 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                           Write(v.Warehouse.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1492, 18, false);
#line 35 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                           Write(v.Bank.BankAccount);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1583, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed4a66eb569b89c1600aab0830c50157a16d2cf7718", async() => {
                BeginContext(1662, 28, true);
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
#line 37 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                                                             WriteLiteral(v.Id);

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
            BeginContext(1694, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 40 "D:\admin\Comi\ComiSuperAdmin\Pages\Vendor\List.cshtml"
                    }

#line default
#line hidden
            BeginContext(1785, 88, true);
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