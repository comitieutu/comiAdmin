#pragma checksum "D:\admin\Comi\ComiWeb\Pages\Cart\PaymentMethod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "112b64ec3e8227a4bc35ace7610a64e770eda124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiWeb.Pages.Cart.Pages_Cart_PaymentMethod), @"mvc.1.0.razor-page", @"/Pages/Cart/PaymentMethod.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cart/PaymentMethod.cshtml", typeof(ComiWeb.Pages.Cart.Pages_Cart_PaymentMethod), null)]
namespace ComiWeb.Pages.Cart
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\admin\Comi\ComiWeb\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\admin\Comi\ComiWeb\Pages\_ViewImports.cshtml"
using ComiWeb;

#line default
#line hidden
#line 3 "D:\admin\Comi\ComiWeb\Pages\_ViewImports.cshtml"
using ComiCore;

#line default
#line hidden
#line 4 "D:\admin\Comi\ComiWeb\Pages\_ViewImports.cshtml"
using ComiCore.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112b64ec3e8227a4bc35ace7610a64e770eda124", @"/Pages/Cart/PaymentMethod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3beb8a108e3744c59a9273090d168d0c7b7fae93", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart_PaymentMethod : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("checkout4.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\admin\Comi\ComiWeb\Pages\Cart\PaymentMethod.cshtml"
  
    ViewData["Title"] = "PaymentMethod";

#line default
#line hidden
            BeginContext(83, 685, true);
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
                            <li aria-current=""page"" class=""breadcrumb-item active"">Checkout - Payment method</li>
                        </ol>
                    </nav>
                </div>
                <div id=""checkout"" class=""col-lg-9"">
                    <div class=""box"">
                        ");
            EndContext();
            BeginContext(768, 3284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f38611c30b6410f80ae310c9db4251d", async() => {
                BeginContext(811, 3234, true);
                WriteLiteral(@"
                            <h1>Checkout - Payment method</h1>
                            <div class=""nav flex-column flex-sm-row nav-pills""><a href=""checkout1.html"" class=""nav-link flex-sm-fill text-sm-center""> <i class=""fa fa-map-marker"">                  </i>Address</a><a href=""checkout2.html"" class=""nav-link flex-sm-fill text-sm-center""> <i class=""fa fa-truck"">                       </i>Delivery Method</a><a href=""checkout3.html"" class=""nav-link flex-sm-fill text-sm-center active""> <i class=""fa fa-money"">                      </i>Payment Method</a><a href=""#"" class=""nav-link flex-sm-fill text-sm-center disabled""> <i class=""fa fa-eye"">                     </i>Order Review</a></div>
                            <div class=""content py-3"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""box payment-method"">
                                            <h4>Paypal</h4>
                       ");
                WriteLiteral(@"                     <p>We like it all.</p>
                                            <div class=""box-footer text-center"">
                                                <input type=""radio"" name=""payment"" value=""payment1"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""box payment-method"">
                                            <h4>Payment gateway</h4>
                                            <p>VISA and Mastercard only.</p>
                                            <div class=""box-footer text-center"">
                                                <input type=""radio"" name=""payment"" value=""payment2"">
                                            </div>
                                        </div>
                                    </div>
                                    <div ");
                WriteLiteral(@"class=""col-md-6"">
                                        <div class=""box payment-method"">
                                            <h4>Cash on delivery</h4>
                                            <p>You pay when you get it.</p>
                                            <div class=""box-footer text-center"">
                                                <input type=""radio"" name=""payment"" value=""payment3"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- /.row-->
                            </div>
                            <!-- /.content-->
                            <div class=""box-footer d-flex justify-content-between"">
                                <a href=""checkout2.html"" class=""btn btn-outline-secondary""><i class=""fa fa-chevron-left""></i>Back to Shipping Method</a>
                                <button type=""");
                WriteLiteral("submit\" class=\"btn btn-primary\">Continue to Order Review<i class=\"fa fa-chevron-right\"></i></button>\r\n                            </div>\r\n                        ");
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
            BeginContext(4052, 1924, true);
            WriteLiteral(@"
                        <!-- /.box-->
                    </div>
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
            WriteLiteral(@"                  <td>Shipping and handling</td>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentMethodModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PaymentMethodModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PaymentMethodModel>)PageContext?.ViewData;
        public PaymentMethodModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
