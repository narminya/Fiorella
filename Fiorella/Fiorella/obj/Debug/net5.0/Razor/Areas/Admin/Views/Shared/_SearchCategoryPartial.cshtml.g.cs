#pragma checksum "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3767848faa641859cf9022a90734fafdf432b9f"
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
#line 3 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorella.Areas.Admin.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\_ViewImports.cshtml"
using Fiorella.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3767848faa641859cf9022a90734fafdf432b9f", @"/Areas/Admin/Views/Shared/_SearchCategoryPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48044aa8ec4646bb7f9d3046549ada381693d6f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SearchCategoryPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 5 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
   Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 6 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 10 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <li>");
#nullable restore
#line 12 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 15 "C:\Users\Narminya\Desktop\Fiorella\Fiorella\Fiorella\Areas\Admin\Views\Shared\_SearchCategoryPartial.cshtml"
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
