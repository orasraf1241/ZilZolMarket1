#pragma checksum "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f15e770bbc160910c66daf59e1a318f14e453a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pcs_Details), @"mvc.1.0.view", @"/Views/Pcs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f15e770bbc160910c66daf59e1a318f14e453a82", @"/Views/Pcs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2de351f9af7bb325abce4cac79ac6492034c55", @"/Views/_ViewImports.cshtml")]
    public class Views_Pcs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZilZolMarket.Models.Pc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Quantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("update()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 49px; text-align:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("f"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
  
    ViewData["Title"] = Model.Name;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- slider Area Start-->
<div class=""slider-area "">
    <!-- Mobile Menu -->
    <div class=""single-slider slider-height2 d-flex align-items-center"" data-background=""assets/img/hero/category.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""hero-cap text-center"">
                        <h2>");
#nullable restore
#line 16 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                       Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- slider Area End-->
<!--================Single Product Area =================-->
<div class=""product_image_area"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""product_img_slide owl-carousel"">
                    <div class=""single_product_img"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 964, "\"", 991, 1);
#nullable restore
#line 31 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
WriteAttributeValue("", 970, Model.img.ToString(), 970, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    </div>\n                </div>\n            </div>\n            <div class=\"col-lg-8\">\n                <div class=\"single_product_text text-center\">\n                    <h3>\n                        The ");
#nullable restore
#line 38 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                           string kind; if (Model.Laptop) { kind = "Laptop"; } else { kind = "PC"; } 

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                                                                                  Write(kind);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        by ");
#nullable restore
#line 39 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                      Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> for ");
#nullable restore
#line 39 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$ only!
                    </h3>
                    <p>
                        Specs:
                    </p>
                    <div>
                        <hr />
                        <dl class=""row"">
                            <dt class=""col-sm-2"">
                                ");
#nullable restore
#line 48 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Cpu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
#nullable restore
#line 51 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Cpu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                ");
#nullable restore
#line 54 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
#nullable restore
#line 57 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                ");
#nullable restore
#line 60 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.GraphicsCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
#nullable restore
#line 63 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayFor(model => model.GraphicsCard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                ");
#nullable restore
#line 66 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Storage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
#nullable restore
#line 69 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Storage));

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                ");
#nullable restore
#line 72 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
#nullable restore
#line 75 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dd>\n                            <dt class=\"col-sm-2\">\n                                ");
#nullable restore
#line 78 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </dt>\n                            <dd class=\"col-sm-10\">\n                                ");
#nullable restore
#line 81 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("???\n                            </dd>\n                        </dl>\n                    </div>\n\n\n");
#nullable restore
#line 87 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                      
                        if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""card_area"">
                                <div class=""product_count_area"">
                                    <p>Quantity</p>

                                    <script>
                                function update() {
                                   var price = document.getElementById('price');
                                    var number = document.forms[""f""][""Quantity""].value;
                                    if (number > 10 || number > ");
#nullable restore
#line 98 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                           Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(") {\n                                        alert(\"you have reached the maximum quantity\");\n                                        number = Math.min(10,");
#nullable restore
#line 100 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                        Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
                                        document.forms[""f""][""Quantity""].value = number;
                                        update();
                                        return;
                                    }
                                    if (number < 0) {
                                        alert(""you have reached the minimum quantity"");
                                        document.forms[""f""][""Quantity""].value = 1;
                                        update();
                                        return;
                                    }
                                    var n = ");
#nullable restore
#line 111 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("*number;\n                                    price.innerHTML = n;\n                                }\n                                    </script>\n\n                                </div>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f15e770bbc160910c66daf59e1a318f14e453a8217879", async() => {
                WriteLiteral("\n                                    <div class=\"form-group\">\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f15e770bbc160910c66daf59e1a318f14e453a8218240", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 119 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Quantity);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                    <div class=""form-group"">
                                        <input type=""submit"" value=""Add to cart"" class=""btn_3"" />
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                                                                                             WriteLiteral(Model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                                                                                                                             WriteLiteral(Model.Company);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["company"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-company", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["company"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                                                                                                                                                              WriteLiteral(Model.Price);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["price"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-price", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["price"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                                                                                                                                                                                           WriteLiteral(Model.img);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["img"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-img", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["img"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <div>
                                    <p id=""price"" style=""
                                left: 440px;
                                top: -160px;
                                position: relative;
                                border-left-style: dashed;
                                border-top-style: dashed;
                                border-bottom-style: dashed;
                                width: 71px;
                                font-weight: bold;
                                "">");
#nullable restore
#line 136 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                             Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <p style=""
                            border-right-style: dashed;
                            font-weight: bold;
                            position: relative;
                            top: -242px;
                            left: 497px;
                            width: 19px;
                            "">$</p>
                            </div>
                                </div>
");
#nullable restore
#line 147 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                            }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <p>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f15e770bbc160910c66daf59e1a318f14e453a8227998", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\orasr\Desktop\ZilZolMarket-dev\ZilZolMarket\Views\Pcs\Details.cshtml"
                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f15e770bbc160910c66daf59e1a318f14e453a8230277", async() => {
                WriteLiteral("Back to list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </p>\n                        </div>\n                    </div>\n        </div>\n    </div>\n</div>\n\n\n<!--================End Single Product Area =================-->\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZilZolMarket.Models.Pc> Html { get; private set; }
    }
}
#pragma warning restore 1591
