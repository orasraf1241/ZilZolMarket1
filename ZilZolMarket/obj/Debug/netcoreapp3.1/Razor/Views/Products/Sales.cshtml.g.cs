#pragma checksum "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Products\Sales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b232195992c3e9af9f8133ee7472c2a02578a956"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Sales), @"mvc.1.0.view", @"/Views/Products/Sales.cshtml")]
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
#nullable restore
#line 1 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\_ViewImports.cshtml"
using ZilZolMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\_ViewImports.cshtml"
using ZilZolMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b232195992c3e9af9f8133ee7472c2a02578a956", @"/Views/Products/Sales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2de351f9af7bb325abce4cac79ac6492034c55", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Sales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZilZolMarket.Models.GroupJoin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Products\Sales.cshtml"
  
    ViewData["Title"] = "Sales";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-4"">

    </div>


    <div class=""col-4"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        User Name
                    </th>
                    <th>
                        Total
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Products\Sales.cshtml"
                 if (Model != null ) {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
#nullable restore
#line 32 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Products\Sales.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 35 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Products\Sales.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("$\n                        </td>\n                    </tr>\n");
#nullable restore
#line 38 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Products\Sales.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZilZolMarket.Models.GroupJoin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
