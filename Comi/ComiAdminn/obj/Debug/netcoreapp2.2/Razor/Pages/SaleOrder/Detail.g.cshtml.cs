#pragma checksum "D:\admin\Comi\ComiAdminn\Pages\SaleOrder\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dafcbe9642bb62f9bd994d27a4a509a4ee26f725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ComiAdminn.Pages.SaleOrder.Pages_SaleOrder_Detail), @"mvc.1.0.razor-page", @"/Pages/SaleOrder/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SaleOrder/Detail.cshtml", typeof(ComiAdminn.Pages.SaleOrder.Pages_SaleOrder_Detail), null)]
namespace ComiAdminn.Pages.SaleOrder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\admin\Comi\ComiAdminn\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\admin\Comi\ComiAdminn\Pages\_ViewImports.cshtml"
using ComiAdminn;

#line default
#line hidden
#line 3 "D:\admin\Comi\ComiAdminn\Pages\_ViewImports.cshtml"
using ComiAdminn.Data;

#line default
#line hidden
#line 4 "D:\admin\Comi\ComiAdminn\Pages\_ViewImports.cshtml"
using ComiCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafcbe9642bb62f9bd994d27a4a509a4ee26f725", @"/Pages/SaleOrder/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879210241c3a53836845e157ba99d50a347bcfe2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SaleOrder_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\admin\Comi\ComiAdminn\Pages\SaleOrder\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(69, 1853, true);
            WriteLiteral(@"
<h3><i class=""fa fa-angle-right""></i> Sale order detail</h3>
<div class=""row mt"">
    <div class=""col-md-12"">
        <div class=""content-panel"">
            <table class=""table table-striped table-advance table-hover"">
                <h4><i class=""fa fa-angle-right""></i>Sales order detail</h4>
                <hr>
                <thead>
                    <tr>
                        <th><i class=""fa fa-windows""></i> Id</th>
                        <th><i class=""fa fa-apple""></i> UId</th>
                        <th><i class=""fa fa-align-justify""></i> Sale id</th>
                        <th><i class=""fa fa-align-justify""></i> Product id</th>
                        <th><i class=""fa fa-align-justify""></i> Quantity</th>
                        <th><i class=""fa fa-align-justify""></i> Discount</th>
                        <th><i class=""fa fa-calendar""></i> Created date</th>
                        <th><i class=""fa fa-calendar""></i> Modified date</th>
                        <th></th>
    ");
            WriteLiteral(@"                </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>1</td>
                        <td>1</td>
                        <td>1</td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td>
                            <button class=""btn btn-primary btn-xs""><i class=""fa fa-pencil""></i></button>
                            <button class=""btn btn-danger btn-xs""><i class=""fa fa-trash-o ""></i></button>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!-- /content-panel -->
    </div>
    <!-- /col-md-12 -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailModel>)PageContext?.ViewData;
        public DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
