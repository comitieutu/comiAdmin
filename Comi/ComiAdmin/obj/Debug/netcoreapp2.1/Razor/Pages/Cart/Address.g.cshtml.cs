#pragma checksum "D:\admin\Comi\ComiAdmin\Pages\Cart\Address.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f74615e68b2264d9973c30121f1ca76c849ee56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiAdmin.Pages.Cart.Pages_Cart_Address), @"mvc.1.0.razor-page", @"/Pages/Cart/Address.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cart/Address.cshtml", typeof(ComiAdmin.Pages.Cart.Pages_Cart_Address), null)]
namespace ComiAdmin.Pages.Cart
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f74615e68b2264d9973c30121f1ca76c849ee56", @"/Pages/Cart/Address.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327c7ed88802998f2fe854949b1515c984eb1ebc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart_Address : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("checkout2.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\admin\Comi\ComiAdmin\Pages\Cart\Address.cshtml"
  
    ViewData["Title"] = "Address";

#line default
#line hidden
            BeginContext(92, 678, true);
            WriteLiteral(@"
<div id=""all"">
    <div id=""content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- breadcrumb-->
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                            <li aria-current=""page"" class=""breadcrumb-item active"">Checkout - Address</li>
                        </ol>
                    </nav>
                </div>
                <div id=""checkout"" class=""col-lg-9"">
                    <div class=""box"">
                        ");
            EndContext();
            BeginContext(770, 5686, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44bfe31e4ab34507bb9ea3a74b3071a0", async() => {
                BeginContext(813, 5636, true);
                WriteLiteral(@"
                            <h1>Checkout - Address</h1>
                            <div class=""nav flex-column flex-md-row nav-pills text-center""><a href=""checkout1.html"" class=""nav-link flex-sm-fill text-sm-center active""> <i class=""fa fa-map-marker"">                  </i>Address</a><a href=""#"" class=""nav-link flex-sm-fill text-sm-center disabled""> <i class=""fa fa-truck"">                       </i>Delivery Method</a><a href=""#"" class=""nav-link flex-sm-fill text-sm-center disabled""> <i class=""fa fa-money"">                      </i>Payment Method</a><a href=""#"" class=""nav-link flex-sm-fill text-sm-center disabled""> <i class=""fa fa-eye"">                     </i>Order Review</a></div>
                            <div class=""content py-3"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""firstname"">Firstname</label>
         ");
                WriteLiteral(@"                                   <input id=""firstname"" type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""lastname"">Lastname</label>
                                            <input id=""lastname"" type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                                <!-- /.row-->
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""company"">Company</label>
                                            <input id=""company"" type=""text"" class=""form-cont");
                WriteLiteral(@"rol"">
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""street"">Street</label>
                                            <input id=""street"" type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
                                <!-- /.row-->
                                <div class=""row"">
                                    <div class=""col-md-6 col-lg-3"">
                                        <div class=""form-group"">
                                            <label for=""city"">Company</label>
                                            <input id=""city"" type=""text"" class=""form-control"">
                                        </div>
                                 ");
                WriteLiteral(@"   </div>
                                    <div class=""col-md-6 col-lg-3"">
                                        <div class=""form-group"">
                                            <label for=""zip"">ZIP</label>
                                            <input id=""zip"" type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""col-md-6 col-lg-3"">
                                        <div class=""form-group"">
                                            <label for=""state"">State</label>
                                            <select id=""state"" class=""form-control""></select>
                                        </div>
                                    </div>
                                    <div class=""col-md-6 col-lg-3"">
                                        <div class=""form-group"">
                                            <label for=""country"">Country</label>
");
                WriteLiteral(@"                                            <select id=""country"" class=""form-control""></select>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""phone"">Telephone</label>
                                            <input id=""phone"" type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group"">
                                            <label for=""email"">Email</label>
                                            <input id=""email"" type=""text"" class=""form-control"">
                                        </div>
                                    </div>
                                </div>
     ");
                WriteLiteral(@"                           <!-- /.row-->
                            </div>
                            <div class=""box-footer d-flex justify-content-between"">
                                <a href=""basket.html"" class=""btn btn-outline-secondary""><i class=""fa fa-chevron-left""></i>Back to Basket</a>
                                <button type=""submit"" class=""btn btn-primary"">Continue to Delivery Method<i class=""fa fa-chevron-right""></i></button>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6456, 1920, true);
            WriteLiteral(@"
                    </div>
                    <!-- /.box-->
                </div>
                <!-- /.col-lg-9-->
                <div class=""col-lg-3"">
                    <div id=""order-summary"" class=""card"">
                        <div class=""card-header"">
                            <h3 class=""mt-4 mb-4"">Order summary</h3>
                        </div>
                        <div class=""card-body"">
                            <p class=""text-muted"">Shipping and additional costs are calculated based on the values you have entered.</p>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <tbody>
                                        <tr>
                                            <td>Order subtotal</td>
                                            <th>$446.00</th>
                                        </tr>
                                        <tr>
                              ");
            WriteLiteral(@"              <td>Shipping and handling</td>
                                            <th>$10.00</th>
                                        </tr>
                                        <tr>
                                            <td>Tax</td>
                                            <th>$0.00</th>
                                        </tr>
                                        <tr class=""total"">
                                            <td>Total</td>
                                            <th>$456.00</th>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- /.col-lg-3-->
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComiAdmin.Pages.Cart.AddressModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComiAdmin.Pages.Cart.AddressModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ComiAdmin.Pages.Cart.AddressModel>)PageContext?.ViewData;
        public ComiAdmin.Pages.Cart.AddressModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591