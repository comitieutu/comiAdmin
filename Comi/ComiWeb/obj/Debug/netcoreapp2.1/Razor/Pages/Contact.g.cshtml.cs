#pragma checksum "D:\admin\Comi\ComiWeb\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf7661520b63b3a6e013e35fcfe33595c13ac24d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiWeb.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contact.cshtml", typeof(ComiWeb.Pages.Pages_Contact), null)]
namespace ComiWeb.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf7661520b63b3a6e013e35fcfe33595c13ac24d", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3beb8a108e3744c59a9273090d168d0c7b7fae93", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "D:\admin\Comi\ComiWeb\Pages\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(71, 3628, true);
            WriteLiteral(@"<div id=""all"">
    <div id=""content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- breadcrumb-->
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                            <li aria-current=""page"" class=""breadcrumb-item active"">Contact</li>
                        </ol>
                    </nav>
                </div>
                <div class=""col-lg-3"">
                    <div class=""card sidebar-menu mb-4"">
                        <div class=""card-header"">
                            <h3 class=""h4 card-title"">Pages</h3>
                        </div>
                        <div class=""card-body"">
                            <ul class=""nav nav-pills flex-column"">
                                <li><a href=""text.html"" class=""nav-link"">Text page</a></li>
                   ");
            WriteLiteral(@"             <li><a href=""contact.html"" class=""nav-link"">Contact page</a></li>
                                <li><a href=""faq.html"" class=""nav-link"">FAQ</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""banner""><a href=""#""><img src=""img/banner.jpg"" alt=""sales 2014"" class=""img-fluid""></a></div>
                </div>
                <div class=""col-lg-9"">
                    <div id=""contact"" class=""box"">
                        <h1>Contact</h1>
                        <p class=""lead"">Are you curious about something? Do you have some kind of problem with our products?</p>
                        <p>Please feel free to contact us, our customer service center is working for you 24/7.</p>
                        <hr>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <h3><i class=""fa fa-map-marker""></i>Address</h3>
                          ");
            WriteLiteral(@"      <p>13/25 New Avenue<br>New Heaven<br>45Y 73J<br>England<br><strong>Great Britain</strong></p>
                            </div>
                            <!-- /.col-sm-4-->
                            <div class=""col-md-4"">
                                <h3><i class=""fa fa-phone""></i> Call center</h3>
                                <p class=""text-muted"">This number is toll free if calling from Great Britain otherwise we advise you to use the electronic form of communication.</p>
                                <p><strong>+33 555 444 333</strong></p>
                            </div>
                            <!-- /.col-sm-4-->
                            <div class=""col-md-4"">
                                <h3><i class=""fa fa-envelope""></i> Electronic support</h3>
                                <p class=""text-muted"">Please feel free to write an email to us or to use our electronic ticketing system.</p>
                                <ul>
                                    <li>");
            WriteLiteral(@"<strong><a href=""mailto:"">info@fakeemail.com</a></strong></li>
                                    <li><strong><a href=""#"">Ticketio</a></strong> - our ticketing support platform</li>
                                </ul>
                            </div>
                            <!-- /.col-sm-4-->
                        </div>
                        <!-- /.row-->
                        <hr>
                        <div id=""map""></div>
                        <hr>
                        <h2>Contact form</h2>
                        ");
            EndContext();
            BeginContext(3699, 2293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "613b42c7cc2f49e08f6cbef96aee5ea3", async() => {
                BeginContext(3705, 2280, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""firstname"">Firstname</label>
                                        <input id=""firstname"" type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""lastname"">Lastname</label>
                                        <input id=""lastname"" type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""email"">Email</label>
                        ");
                WriteLiteral(@"                <input id=""email"" type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""subject"">Subject</label>
                                        <input id=""subject"" type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label for=""message"">Message</label>
                                        <textarea id=""message"" class=""form-control""></textarea>
                                    </div>
                                </div>
                                <div class=""col-md-12 text-center"">
                                    <button type=");
                WriteLiteral("\"submit\" class=\"btn btn-primary\"><i class=\"fa fa-envelope-o\"></i> Send message</button>\r\n                                </div>\r\n                            </div>\r\n                            <!-- /.row-->\r\n                        ");
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
            BeginContext(5992, 146, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!-- /.col-md-9-->\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591