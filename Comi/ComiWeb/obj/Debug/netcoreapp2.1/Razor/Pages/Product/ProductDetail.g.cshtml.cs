#pragma checksum "D:\admin\Comi\ComiWeb\Pages\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b163f689c5cfb7c78951c6e59c80a5c9ed2b81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiWeb.Pages.Product.Pages_Product_ProductDetail), @"mvc.1.0.razor-page", @"/Pages/Product/ProductDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Product/ProductDetail.cshtml", typeof(ComiWeb.Pages.Product.Pages_Product_ProductDetail), null)]
namespace ComiWeb.Pages.Product
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b163f689c5cfb7c78951c6e59c80a5c9ed2b81", @"/Pages/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3beb8a108e3744c59a9273090d168d0c7b7fae93", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
#line 3 "D:\admin\Comi\ComiWeb\Pages\Product\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";

#line default
#line hidden
            BeginContext(83, 3968, true);
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
                            <li class=""breadcrumb-item""><a href=""#"">Ladies</a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Tops</a></li>
                            <li aria-current=""page"" class=""breadcrumb-item active"">White Blouse Armani</li>
                        </ol>
                    </nav>
                </div>
                <div class=""col-lg-3"">
                    <!--
                    *** MENUS AND FILTERS ***
                    _________________________________________________________
                    -->
                    <div class=""card sidebar-menu mb-4"">
                   ");
            WriteLiteral(@"     <div class=""card-header"">
                            <h3 class=""h4 card-title"">Categories</h3>
                        </div>
                        <div class=""card-body"">
                            <ul class=""nav nav-pills flex-column category-menu"">
                                <li>
                                    <a href=""category.html"" class=""nav-link"">Men <span class=""badge badge-secondary"">42</span></a>
                                    <ul class=""list-unstyled"">
                                        <li><a href=""category.html"" class=""nav-link"">T-shirts</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Shirts</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Pants</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Accessories</a></li>
                                    </ul>
                                </li>
                            ");
            WriteLiteral(@"    <li>
                                    <a href=""category.html"" class=""nav-link active"">Ladies  <span class=""badge badge-light"">123</span></a>
                                    <ul class=""list-unstyled"">
                                        <li><a href=""category.html"" class=""nav-link"">T-shirts</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Skirts</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Pants</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Accessories</a></li>
                                    </ul>
                                </li>
                                <li>
                                    <a href=""category.html"" class=""nav-link"">Kids  <span class=""badge badge-secondary"">11</span></a>
                                    <ul class=""list-unstyled"">
                                        <li><a href=""category.html"" class=""nav");
            WriteLiteral(@"-link"">T-shirts</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Skirts</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Pants</a></li>
                                        <li><a href=""category.html"" class=""nav-link"">Accessories</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""card sidebar-menu mb-4"">
                        <div class=""card-header"">
                            <h3 class=""h4 card-title"">Brands <a href=""#"" class=""btn btn-sm btn-danger pull-right""><i class=""fa fa-times-circle""></i> Clear</a></h3>
                        </div>
                        <div class=""card-body"">
                            ");
            EndContext();
            BeginContext(4051, 1419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdd0e6ee6f65459ca2006710f7d6fe96", async() => {
                BeginContext(4057, 1406, true);
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""> Armani  (10)
                                        </label>
                                    </div>
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""> Versace  (12)
                                        </label>
                                    </div>
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""> Carlo Bruni  (15)
                                        </label>
                                    </div>
                                    <div class=""checkbox"">
                                        <la");
                WriteLiteral(@"bel>
                                            <input type=""checkbox""> Jack Honey  (14)
                                        </label>
                                    </div>
                                </div>
                                <button class=""btn btn-default btn-sm btn-primary""><i class=""fa fa-pencil""></i> Apply</button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5470, 446, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""card sidebar-menu mb-4"">
                        <div class=""card-header"">
                            <h3 class=""h4 card-title"">Colours <a href=""#"" class=""btn btn-sm btn-danger pull-right""><i class=""fa fa-times-circle""></i> Clear</a></h3>
                        </div>
                        <div class=""card-body"">
                            ");
            EndContext();
            BeginContext(5916, 1853, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca744e80837b4d429bac85fad0088095", async() => {
                BeginContext(5922, 1840, true);
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""><span class=""colour white""></span> White (14)
                                        </label>
                                    </div>
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""><span class=""colour blue""></span> Blue (10)
                                        </label>
                                    </div>
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""><span class=""colour green""></span>  Green (20)
                                        </label>
                                    </div>
              ");
                WriteLiteral(@"                      <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""><span class=""colour yellow""></span>  Yellow (13)
                                        </label>
                                    </div>
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""checkbox""><span class=""colour red""></span>  Red (10)
                                        </label>
                                    </div>
                                </div>
                                <button class=""btn btn-default btn-sm btn-primary""><i class=""fa fa-pencil""></i> Apply</button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7769, 11306, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <!-- *** MENUS AND FILTERS END ***-->
                    <div class=""banner""><a href=""#""><img src=""img/banner.jpg"" alt=""sales 2014"" class=""img-fluid""></a></div>
                </div>
                <div class=""col-lg-9"">
                    <div id=""productMain"" class=""row"">
                        <div class=""col-md-6"">
                            <div data-slider-id=""1"" class=""owl-carousel shop-detail-carousel"">
                                <div class=""item""> <img src=""img/detailbig1.jpg"" alt="""" class=""img-fluid""></div>
                                <div class=""item""> <img src=""img/detailbig2.jpg"" alt="""" class=""img-fluid""></div>
                                <div class=""item""> <img src=""img/detailbig3.jpg"" alt="""" class=""img-fluid""></div>
                            </div>
                            <div class=""ribbon sale"">
                                <div class=""theribbon"">SALE</div>
              ");
            WriteLiteral(@"                  <div class=""ribbon-background""></div>
                            </div>
                            <!-- /.ribbon-->
                            <div class=""ribbon new"">
                                <div class=""theribbon"">NEW</div>
                                <div class=""ribbon-background""></div>
                            </div>
                            <!-- /.ribbon-->
                        </div>
                        <div class=""col-md-6"">
                            <div class=""box"">
                                <h1 class=""text-center"">White Blouse Armani</h1>
                                <p class=""goToDescription""><a href=""#details"" class=""scroll-to"">Scroll to product details, material &amp; care and sizing</a></p>
                                <p class=""price"">$124.00</p>
                                <p class=""text-center buttons""><a href=""basket.html"" class=""btn btn-primary""><i class=""fa fa-shopping-cart""></i> Add to cart</a><a href=""basket.ht");
            WriteLiteral(@"ml"" class=""btn btn-outline-primary""><i class=""fa fa-heart""></i> Add to wishlist</a></p>
                            </div>
                            <div data-slider-id=""1"" class=""owl-thumbs"">
                                <button class=""owl-thumb-item""><img src=""img/detailsquare.jpg"" alt="""" class=""img-fluid""></button>
                                <button class=""owl-thumb-item""><img src=""img/detailsquare2.jpg"" alt="""" class=""img-fluid""></button>
                                <button class=""owl-thumb-item""><img src=""img/detailsquare3.jpg"" alt="""" class=""img-fluid""></button>
                            </div>
                        </div>
                    </div>
                    <div id=""details"" class=""box"">
                        <p></p>
                        <h4>Product details</h4>
                        <p>White lace top, woven, has a round neck, short sleeves, has knitted lining attached</p>
                        <h4>Material &amp; care</h4>
                        <ul>
");
            WriteLiteral(@"                            <li>Polyester</li>
                            <li>Machine wash</li>
                        </ul>
                        <h4>Size &amp; Fit</h4>
                        <ul>
                            <li>Regular fit</li>
                            <li>The model (height 5'8"" and chest 33"") is wearing a size S</li>
                        </ul>
                        <blockquote>
                            <p><em>Define style this season with Armani's new range of trendy tops, crafted with intricate details. Create a chic statement look by teaming this lace number with skinny jeans and pumps.</em></p>
                        </blockquote>
                        <hr>
                        <div class=""social"">
                            <h4>Show it to your friends</h4>
                            <p><a href=""#"" class=""external facebook""><i class=""fa fa-facebook""></i></a><a href=""#"" class=""external gplus""><i class=""fa fa-google-plus""></i></a><a href=""#"" class=""e");
            WriteLiteral(@"xternal twitter""><i class=""fa fa-twitter""></i></a><a href=""#"" class=""email""><i class=""fa fa-envelope""></i></a></p>
                        </div>
                    </div>
                    <div class=""row same-height-row"">
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""box same-height"">
                                <h3>You may also like these products</h3>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""product same-height"">
                                <div class=""flip-container"">
                                    <div class=""flipper"">
                                        <div class=""front""><a href=""detail.html""><img src=""img/product2.jpg"" alt="""" class=""img-fluid""></a></div>
                                        <div class=""back""><a href=""detail.html""><img src=""img/product2_2.jpg"" alt="""" class=""img-fluid""></a></div>
");
            WriteLiteral(@"                                    </div>
                                </div><a href=""detail.html"" class=""invisible""><img src=""img/product2.jpg"" alt="""" class=""img-fluid""></a>
                                <div class=""text"">
                                    <h3>Fur coat</h3>
                                    <p class=""price"">$143</p>
                                </div>
                            </div>
                            <!-- /.product-->
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""product same-height"">
                                <div class=""flip-container"">
                                    <div class=""flipper"">
                                        <div class=""front""><a href=""detail.html""><img src=""img/product1.jpg"" alt="""" class=""img-fluid""></a></div>
                                        <div class=""back""><a href=""detail.html""><img src=""img/product1_2.jpg"" alt="""" class=""img-flu");
            WriteLiteral(@"id""></a></div>
                                    </div>
                                </div><a href=""detail.html"" class=""invisible""><img src=""img/product1.jpg"" alt="""" class=""img-fluid""></a>
                                <div class=""text"">
                                    <h3>Fur coat</h3>
                                    <p class=""price"">$143</p>
                                </div>
                            </div>
                            <!-- /.product-->
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""product same-height"">
                                <div class=""flip-container"">
                                    <div class=""flipper"">
                                        <div class=""front""><a href=""detail.html""><img src=""img/product3.jpg"" alt="""" class=""img-fluid""></a></div>
                                        <div class=""back""><a href=""detail.html""><img src=""img/product3_2.jpg"" alt=""");
            WriteLiteral(@""" class=""img-fluid""></a></div>
                                    </div>
                                </div><a href=""detail.html"" class=""invisible""><img src=""img/product3.jpg"" alt="""" class=""img-fluid""></a>
                                <div class=""text"">
                                    <h3>Fur coat</h3>
                                    <p class=""price"">$143</p>
                                </div>
                            </div>
                            <!-- /.product-->
                        </div>
                    </div>
                    <div class=""row same-height-row"">
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""box same-height"">
                                <h3>Products viewed recently</h3>
                            </div>
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""product same-height"">
                                ");
            WriteLiteral(@"<div class=""flip-container"">
                                    <div class=""flipper"">
                                        <div class=""front""><a href=""detail.html""><img src=""img/product2.jpg"" alt="""" class=""img-fluid""></a></div>
                                        <div class=""back""><a href=""detail.html""><img src=""img/product2_2.jpg"" alt="""" class=""img-fluid""></a></div>
                                    </div>
                                </div><a href=""detail.html"" class=""invisible""><img src=""img/product2.jpg"" alt="""" class=""img-fluid""></a>
                                <div class=""text"">
                                    <h3>Fur coat</h3>
                                    <p class=""price"">$143</p>
                                </div>
                            </div>
                            <!-- /.product-->
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""product same-height"">
                ");
            WriteLiteral(@"                <div class=""flip-container"">
                                    <div class=""flipper"">
                                        <div class=""front""><a href=""detail.html""><img src=""img/product1.jpg"" alt="""" class=""img-fluid""></a></div>
                                        <div class=""back""><a href=""detail.html""><img src=""img/product1_2.jpg"" alt="""" class=""img-fluid""></a></div>
                                    </div>
                                </div><a href=""detail.html"" class=""invisible""><img src=""img/product1.jpg"" alt="""" class=""img-fluid""></a>
                                <div class=""text"">
                                    <h3>Fur coat</h3>
                                    <p class=""price"">$143</p>
                                </div>
                            </div>
                            <!-- /.product-->
                        </div>
                        <div class=""col-lg-3 col-md-6"">
                            <div class=""product same-height"">
");
            WriteLiteral(@"                                <div class=""flip-container"">
                                    <div class=""flipper"">
                                        <div class=""front""><a href=""detail.html""><img src=""img/product3.jpg"" alt="""" class=""img-fluid""></a></div>
                                        <div class=""back""><a href=""detail.html""><img src=""img/product3_2.jpg"" alt="""" class=""img-fluid""></a></div>
                                    </div>
                                </div><a href=""detail.html"" class=""invisible""><img src=""img/product3.jpg"" alt="""" class=""img-fluid""></a>
                                <div class=""text"">
                                    <h3>Fur coat</h3>
                                    <p class=""price"">$143</p>
                                </div>
                            </div>
                            <!-- /.product-->
                        </div>
                    </div>
                </div>
                <!-- /.col-md-9-->
            </di");
            WriteLiteral("v>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductDetailModel>)PageContext?.ViewData;
        public ProductDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591