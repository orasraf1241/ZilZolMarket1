#pragma checksum "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0aa672fa09aec411df92678a1f7561600aeff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0aa672fa09aec411df92678a1f7561600aeff5", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2de351f9af7bb325abce4cac79ac6492034c55", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZilZolMarket.Models.Orders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "My Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"




<section class=""confirmation_part section_padding"">
   
        
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""confirmation_tittle"">
                    </div>
                </div>
                <div class=""col-lg-12 col-lx-4"">
                    <div class=""single_confirmation_details"">

                        <h4>order info</h4>
                       
                            <tbody>
");
#nullable restore
#line 57 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                                                 foreach (Orders item in Model)
    {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <ul>\n                                 <div>  \n                       \n                  \n        \n                            <li>\n                                <p>Total Price</p><span>: $ ");
#nullable restore
#line 65 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                                                       Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span>\n                            </li>\n\n                              <li>\n                                <p>data</p>\n                                <span>: \n                                      ");
#nullable restore
#line 71 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                                 Write(item.DateOfOrder.Date.Day.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 71 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                                                                       Write(item.DateOfOrder.Date.Month.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 71 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                                                                                                               Write(item.DateOfOrder.Date.Year.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                                 </span>\n                            </li>\n                            <li>\n                                <p>Order Information </p>\n                                <span>\n                                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab0aa672fa09aec411df92678a1f7561600aeff57026", async() => {
                WriteLiteral("<h5>Order Information </h5>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </span>\n                            </li>\n                     </div> \n                  <br />\n                 </ul>\n");
#nullable restore
#line 85 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Orders\Details.cshtml"
                  

                             
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                     </tbody>\n\n\n                    </div>\n\n                </div>\n            </div>\n        </div>\n    \n                            <span>Thank you. Your order has been received.</span>\n\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZilZolMarket.Models.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
