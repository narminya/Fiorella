#pragma checksum "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\Shared\Components\Navigation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623e791828547d878cbdd06c2d921b98538b8076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navigation/Default.cshtml")]
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
#line 3 "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\_ViewImports.cshtml"
using Fiorella.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\_ViewImports.cshtml"
using Fiorella.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623e791828547d878cbdd06c2d921b98538b8076", @"/Views/Shared/Components/Navigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d78f946b264df4bb8712f3bc529dfc213e75404", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Navigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"collapse navbar-collapse d-none d-lg-block\" id=\"navbarSupportedContent\">\r\n    <ul class=\"navbar-nav ml-auto\">\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "623e791828547d878cbdd06c2d921b98538b80764968", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <ul class=\"list-unstyled py-3\">\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 301, "\"", 309, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 333, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 1</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 371, "\"", 379, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 396, "\"", 403, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 2</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 441, "\"", 449, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 466, "\"", 473, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 3</a></li>\r\n            </ul>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "623e791828547d878cbdd06c2d921b98538b80767549", async() => {
                WriteLiteral("Pages");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <ul class=\"list-unstyled py-3\">\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 708, "\"", 716, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 733, "\"", 740, 0);
            EndWriteAttribute();
            WriteLiteral(">Page 1</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 778, "\"", 786, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 803, "\"", 810, 0);
            EndWriteAttribute();
            WriteLiteral(">Page 2</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 848, "\"", 856, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 880, 0);
            EndWriteAttribute();
            WriteLiteral(">Page 3</a></li>\r\n            </ul>\r\n        </li>\r\n        <li class=\"nav-item shop-li\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "623e791828547d878cbdd06c2d921b98538b807610139", async() => {
                WriteLiteral("Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""container"">
                <div class=""row shop py-5"">
                    <div class=""col-lg-3"">
                        <div class=""item px-4"">
                            <h5>Product Types</h5>
                            <ul class=""list-unstyled py-3"">
                                <li");
            BeginWriteAttribute("class", " class=\"", 1378, "\"", 1386, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 1403, "\"", 1410, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 1473, "\"", 1481, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1505, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 1568, "\"", 1576, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1600, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Types 3</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""item px-4"">
                            <h5>Shop Pages</h5>
                            <ul class=""list-unstyled py-3"">
                                <li");
            BeginWriteAttribute("class", " class=\"", 1961, "\"", 1969, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 1986, "\"", 1993, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Pages 1</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 2053, "\"", 2061, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2078, "\"", 2085, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Pages 2</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 2145, "\"", 2153, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2170, "\"", 2177, 0);
            EndWriteAttribute();
            WriteLiteral(@">Shop Pages 3</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""item px-4"">
                            <h5>Shop Types</h5>
                            <ul class=""list-unstyled py-3"">
                                <li");
            BeginWriteAttribute("class", " class=\"", 2535, "\"", 2543, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2560, "\"", 2567, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Types 1</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 2627, "\"", 2635, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2652, "\"", 2659, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Types 2</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 2719, "\"", 2727, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2744, "\"", 2751, 0);
            EndWriteAttribute();
            WriteLiteral(@">Shop Types 3</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""item px-4"">
                            <h5>Shop Layouts</h5>
                            <ul class=""list-unstyled py-3"">
                                <li");
            BeginWriteAttribute("class", " class=\"", 3111, "\"", 3119, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3136, "\"", 3143, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Layouts 1</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 3205, "\"", 3213, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3230, "\"", 3237, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Layouts 2</a></li>\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 3299, "\"", 3307, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3324, "\"", 3331, 0);
            EndWriteAttribute();
            WriteLiteral(@">Shop Layouts 3</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#"">Portfolio</a>
            <ul class=""list-unstyled py-3"">
                <li");
            BeginWriteAttribute("class", " class=\"", 3663, "\"", 3671, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 3688, "\"", 3695, 0);
            EndWriteAttribute();
            WriteLiteral(">Portfolio 1</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 3738, "\"", 3746, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 3763, "\"", 3770, 0);
            EndWriteAttribute();
            WriteLiteral(">Portfolio 2</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 3813, "\"", 3821, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"px-1 mr-5\"");
            BeginWriteAttribute("href", " href=\"", 3865, "\"", 3872, 0);
            EndWriteAttribute();
            WriteLiteral(">Portfolio 3</a>\r\n                    <i class=\"fas fa-chevron-right fa-sm\"></i>\r\n                    <ul class=\"list-unstyled py-3\">\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4035, "\"", 4043, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4060, "\"", 4067, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Layouts 1</a></li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4121, "\"", 4129, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4146, "\"", 4153, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Layouts 2</a></li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4207, "\"", 4215, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4232, "\"", 4239, 0);
            EndWriteAttribute();
            WriteLiteral(@">Shop Layouts 3</a></li>
                    </ul>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#"">Blog</a>
            <ul class=""list-unstyled py-3"">
                <li");
            BeginWriteAttribute("class", " class=\"", 4496, "\"", 4504, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 4521, "\"", 4528, 0);
            EndWriteAttribute();
            WriteLiteral(">Blog 1</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 4566, "\"", 4574, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 4591, "\"", 4598, 0);
            EndWriteAttribute();
            WriteLiteral(">Blog 2</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 4636, "\"", 4644, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"px-1 mr-5\"");
            BeginWriteAttribute("href", " href=\"", 4688, "\"", 4695, 0);
            EndWriteAttribute();
            WriteLiteral(">Blog 3</a>\r\n                    <i class=\"fas fa-chevron-right fa-sm\"></i>\r\n                    <ul class=\"list-unstyled py-3\">\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4853, "\"", 4861, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4878, "\"", 4885, 0);
            EndWriteAttribute();
            WriteLiteral(">Blog Layouts 1</a></li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4939, "\"", 4947, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4964, "\"", 4971, 0);
            EndWriteAttribute();
            WriteLiteral(">Blog Layouts 2</a></li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5025, "\"", 5033, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5050, "\"", 5057, 0);
            EndWriteAttribute();
            WriteLiteral(@">Blog Layouts 3</a></li>
                    </ul>
                </li>
            </ul>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""#"">Elements</a>
            <ul class=""list-unstyled py-3 elements"">
                <li");
            BeginWriteAttribute("class", " class=\"", 5327, "\"", 5335, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 5352, "\"", 5359, 0);
            EndWriteAttribute();
            WriteLiteral(">Element 1</a></li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 5400, "\"", 5408, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 5425, "\"", 5432, 0);
            EndWriteAttribute();
            WriteLiteral(">Element 2</a></li>\r\n                <li class=\"element\">\r\n                    <i class=\"fas fa-chevron-right fa-sm mr-5\"></i>\r\n                    <a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 5596, "\"", 5603, 0);
            EndWriteAttribute();
            WriteLiteral(">Element 3</a>\r\n                    <ul class=\"list-unstyled py-3\">\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5700, "\"", 5708, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5725, "\"", 5732, 0);
            EndWriteAttribute();
            WriteLiteral(">Element 1</a></li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5781, "\"", 5789, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5806, "\"", 5813, 0);
            EndWriteAttribute();
            WriteLiteral(">Element 2</a></li>\r\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5862, "\"", 5870, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5887, "\"", 5894, 0);
            EndWriteAttribute();
            WriteLiteral(@">Element 3</a></li>
                    </ul>
                </li>
            </ul>
        </li>
        <li class=""nav-item my-auto search"">
            <i class=""fas fa-search"" id=""search""></i>
            <ul class=""list-unstyled py-3"" id=""search-result"">
                <li class=""d-flex px-3"">
                    <input id=""input-search"" type=""text"" placeholder=""Search"">
                    <i class=""fas fa-search my-auto"" id=""search""></i>
                </li>

            </ul>
        </li>
        <li class=""nav-item my-auto shop-cart"">
            <i class=""fas fa-shopping-bag""></i>
            <sup class=""rounded-circle"">");
#nullable restore
#line 126 "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\Shared\Components\Navigation\Default.cshtml"
                                   Write(TempData["Count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</sup>\r\n            <span>CART ($0)</span>\r\n            <ul class=\"list-unstyled py-3\">\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 6681, "\"", 6689, 0);
            EndWriteAttribute();
            WriteLiteral(">No products in the cart.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
