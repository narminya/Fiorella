#pragma checksum "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2c0584529c6d7afddf395618d68a1e47775376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2c0584529c6d7afddf395618d68a1e47775376", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d78f946b264df4bb8712f3bc529dfc213e75404", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LayoutInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav class=""navbar navbar-expand-lg d-flex d-lg-block justify-content-between d-xl-flex navbar-light py-3 py-lg-0"">
                    <a class=""navbar-brand"" href=""#"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b2c0584529c6d7afddf395618d68a1e477753764235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 334, "~/img/", 334, 6, true);
#nullable restore
#line 8 "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 340, Model.Logo, 340, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse""
                            data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                            aria-expanded=""false"" aria-label=""Toggle navigation"" id=""mobile-navbar-show"">
                        <span class=""navbar-toggler-icon"" style=""font-size: 12px;""></span>
                    </button>
                    ");
#nullable restore
#line 15 "C:\Users\afsana.mammadova\Desktop\Fiorella\Fiorella\Fiorella\Views\Shared\Components\Header\Default.cshtml"
               Write(await Component.InvokeAsync("Navigation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </nav>
            </div>
        </div>
        <div class=""mobile-navbar position-absolute shadow-lg h-100 p-5"">
            <i class=""fas fa-times fa-lg"" id=""mobile-navbar-close""></i>
            <ul class=""list-unstyled"">
                <li><a href=""#"">Home <i class=""fas fa-caret-right fa-sm""></i></a></li>
                <ul class=""list-unstyled"">
                    <li");
            BeginWriteAttribute("class", " class=\"", 1275, "\"", 1283, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 1300, "\"", 1307, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 1</a></li>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1348, "\"", 1356, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1380, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 2</a></li>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1421, "\"", 1429, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 1446, "\"", 1453, 0);
            EndWriteAttribute();
            WriteLiteral(">Home 3</a></li>\n                </ul>\n                <li><a href=\"#\">Pages <i class=\"fas fa-caret-right fa-sm\"></i></a></li>\n                <ul class=\"list-unstyled\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1647, "\"", 1655, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 1672, "\"", 1679, 0);
            EndWriteAttribute();
            WriteLiteral(">Page 1</a></li>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1720, "\"", 1728, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 1745, "\"", 1752, 0);
            EndWriteAttribute();
            WriteLiteral(">Page 2</a></li>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1793, "\"", 1801, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-1\"");
            BeginWriteAttribute("href", " href=\"", 1818, "\"", 1825, 0);
            EndWriteAttribute();
            WriteLiteral(">Page 3</a></li>\n                </ul>\n                <li><a href=\"#\">Shop <i class=\"fas fa-caret-right fa-sm\"></i></a></li>\n                <ul class=\"list-unstyled py-3\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 2023, "\"", 2031, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">PRODUCT TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 2247, "\"", 2255, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2272, "\"", 2279, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 2333, "\"", 2341, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2358, "\"", 2365, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 2419, "\"", 2427, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2444, "\"", 2451, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 2527, "\"", 2535, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP PAGES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 2748, "\"", 2756, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2773, "\"", 2780, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 2834, "\"", 2842, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2859, "\"", 2866, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 2920, "\"", 2928, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 2945, "\"", 2952, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3028, "\"", 3036, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3249, "\"", 3257, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3274, "\"", 3281, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3335, "\"", 3343, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3360, "\"", 3367, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3421, "\"", 3429, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3446, "\"", 3453, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                </ul>\n                <li><a href=\"#\">Portfolio <i class=\"fas fa-caret-right fa-sm\"></i></a></li>\n                <ul class=\"list-unstyled py-3\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3691, "\"", 3699, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">PRODUCT TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 3915, "\"", 3923, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 3940, "\"", 3947, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4001, "\"", 4009, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4026, "\"", 4033, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4087, "\"", 4095, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4112, "\"", 4119, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 4195, "\"", 4203, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP PAGES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4416, "\"", 4424, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4441, "\"", 4448, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4502, "\"", 4510, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4527, "\"", 4534, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4588, "\"", 4596, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4613, "\"", 4620, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 4696, "\"", 4704, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 4917, "\"", 4925, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 4942, "\"", 4949, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5003, "\"", 5011, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5028, "\"", 5035, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5089, "\"", 5097, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5114, "\"", 5121, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                </ul>\n                <li><a href=\"#\">Blog <i class=\"fas fa-caret-right fa-sm\"></i></a></li>\n                <ul class=\"list-unstyled py-3\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 5354, "\"", 5362, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">PRODUCT TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5578, "\"", 5586, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5603, "\"", 5610, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5664, "\"", 5672, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5689, "\"", 5696, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 5750, "\"", 5758, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 5775, "\"", 5782, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 5858, "\"", 5866, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP PAGES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 6079, "\"", 6087, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 6104, "\"", 6111, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 6165, "\"", 6173, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 6190, "\"", 6197, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 6251, "\"", 6259, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 6276, "\"", 6283, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 6359, "\"", 6367, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 6580, "\"", 6588, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 6605, "\"", 6612, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 6666, "\"", 6674, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 6691, "\"", 6698, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 6752, "\"", 6760, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 6777, "\"", 6784, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                </ul>\n                <li><a href=\"#\">Elements <i class=\"fas fa-caret-right fa-sm\"></i></a></li>\n                <ul class=\"list-unstyled py-3\">\n                    <li");
            BeginWriteAttribute("class", " class=\"", 7021, "\"", 7029, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">PRODUCT TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 7245, "\"", 7253, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 7270, "\"", 7277, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 7331, "\"", 7339, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 7356, "\"", 7363, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 7417, "\"", 7425, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 7442, "\"", 7449, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 7525, "\"", 7533, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP PAGES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 7746, "\"", 7754, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 7771, "\"", 7778, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 7832, "\"", 7840, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 7857, "\"", 7864, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 7918, "\"", 7926, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 7943, "\"", 7950, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                    <li");
            BeginWriteAttribute("class", " class=\"", 8026, "\"", 8034, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <a class=\"px-3\" href=\"#\">SHOP TYPES <i class=\"fas fa-caret-right fa-sm\"></i></a>\n                    </li>\n                    <ul class=\"list-unstyled py-3\">\n                        <li");
            BeginWriteAttribute("class", " class=\"", 8247, "\"", 8255, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 8272, "\"", 8279, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 1</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 8333, "\"", 8341, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 8358, "\"", 8365, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 2</a></li>\n                        <li");
            BeginWriteAttribute("class", " class=\"", 8419, "\"", 8427, 0);
            EndWriteAttribute();
            WriteLiteral("><a class=\"px-3\"");
            BeginWriteAttribute("href", " href=\"", 8444, "\"", 8451, 0);
            EndWriteAttribute();
            WriteLiteral(">Product Types 3</a></li>\n                    </ul>\n                </ul>\n            </ul>\n        </div>\n    </div>\n\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LayoutInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591