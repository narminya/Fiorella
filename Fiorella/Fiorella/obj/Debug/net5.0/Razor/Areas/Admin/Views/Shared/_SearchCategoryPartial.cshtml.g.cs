#pragma checksum "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf55ee71377a27b7ceeef8f3e949193417bd8397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SearchCategoryPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SearchCategoryPartial.cshtml")]
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
#line 3 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorella.Areas.Admin.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorella.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf55ee71377a27b7ceeef8f3e949193417bd8397", @"/Areas/Admin/Views/Shared/_SearchCategoryPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1112f944e0c626d95c21744ffe181ecf57665320", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SearchCategoryPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 5 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
   Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 6 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\n");
#nullable restore
#line 10 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <li>");
#nullable restore
#line 12 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 13 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 15 "C:\Users\afsana.mammadova\Downloads\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
