#pragma checksum "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df09b468fec58228ffc3a1db12db79a055e52ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiWeb.Pages.Cart.Pages_Cart_DeliveryMethod), @"mvc.1.0.razor-page", @"/Pages/Cart/DeliveryMethod.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cart/DeliveryMethod.cshtml", typeof(ComiWeb.Pages.Cart.Pages_Cart_DeliveryMethod), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df09b468fec58228ffc3a1db12db79a055e52ef", @"/Pages/Cart/DeliveryMethod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3beb8a108e3744c59a9273090d168d0c7b7fae93", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart_DeliveryMethod : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart/Address", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link flex-sm-fill text-sm-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
  
    ViewData["Title"] = "DeliveryMethod";

#line default
#line hidden
            BeginContext(85, 686, true);
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
                            <li aria-current=""page"" class=""breadcrumb-item active"">Checkout - Delivery method</li>
                        </ol>
                    </nav>
                </div>
                <div id=""checkout"" class=""col-lg-9"">
                    <div class=""box"">
                        ");
            EndContext();
            BeginContext(771, 2136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df09b468fec58228ffc3a1db12db79a055e52ef6305", async() => {
                BeginContext(791, 146, true);
                WriteLiteral("\r\n                            <h1>Checkout - Delivery method</h1>\r\n                            <div class=\"nav flex-column flex-sm-row nav-pills\">");
                EndContext();
                BeginContext(937, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df09b468fec58228ffc3a1db12db79a055e52ef6837", async() => {
                    BeginContext(1010, 58, true);
                    WriteLiteral(" <i class=\"fa fa-map-marker\">                  </i>Address");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
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
                BeginContext(1072, 525, true);
                WriteLiteral(@"<a href=""checkout2.html"" class=""nav-link flex-sm-fill text-sm-center active""> <i class=""fa fa-truck"">                       </i>Delivery Method</a><a href=""#"" class=""nav-link flex-sm-fill text-sm-center disabled""> <i class=""fa fa-money"">                      </i>Payment Method</a><a href=""#"" class=""nav-link flex-sm-fill text-sm-center disabled""> <i class=""fa fa-eye"">                     </i>Order Review</a></div>
                            <div class=""content py-3"">
                                <div class=""row"">
");
                EndContext();
#line 27 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
                                     foreach (var i in Model.Deliveries)
                                    {

#line default
#line hidden
                BeginContext(1710, 195, true);
                WriteLiteral("                                        <div class=\"col-md-6\">\r\n                                            <div class=\"box shipping-method\">\r\n                                                <h4>");
                EndContext();
                BeginContext(1906, 6, false);
#line 31 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
                                               Write(i.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1912, 58, true);
                WriteLiteral("</h4>\r\n                                                <p>");
                EndContext();
                BeginContext(1971, 13, false);
#line 32 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
                                              Write(i.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1984, 144, true);
                WriteLiteral("</p>\r\n                                                <div class=\"box-footer text-center\">\r\n                                                    ");
                EndContext();
                BeginContext(2128, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5df09b468fec58228ffc3a1db12db79a055e52ef10433", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 34 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeliveryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 34 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
                                                                                        WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2183, 158, true);
                WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n");
                EndContext();
#line 38 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2380, 193, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"box-footer d-flex justify-content-between\">\r\n                                ");
                EndContext();
                BeginContext(2573, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5df09b468fec58228ffc3a1db12db79a055e52ef13513", async() => {
                    BeginContext(2635, 49, true);
                    WriteLiteral("<i class=\"fa fa-chevron-left\"></i>Back to address");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2688, 212, true);
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-primary\">Continue to Payment Method<i class=\"fa fa-chevron-right\"></i></button>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2907, 105, true);
            WriteLiteral("\r\n                    </div>\r\n                    <!-- /.box-->\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(3014, 43, false);
#line 49 "D:\admin\Comi\ComiWeb\Pages\Cart\DeliveryMethod.cshtml"
            Write(await Component.InvokeAsync("OrderSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(3058, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryMethodModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeliveryMethodModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeliveryMethodModel>)PageContext?.ViewData;
        public DeliveryMethodModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
