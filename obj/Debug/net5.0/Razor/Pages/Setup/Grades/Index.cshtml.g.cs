#pragma checksum "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Grades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04e3c8ff93b9255dcb001a1e6e2e920ad8e240c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRMSApplication.Pages.Setup.Grades.Pages_Setup_Grades_Index), @"mvc.1.0.razor-page", @"/Pages/Setup/Grades/Index.cshtml")]
namespace HRMSApplication.Pages.Setup.Grades
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
#line 1 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\_ViewImports.cshtml"
using HRMSApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e3c8ff93b9255dcb001a1e6e2e920ad8e240c8", @"/Pages/Setup/Grades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bba0893f36791b8953b3bf144a7917db44c7b5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Setup_Grades_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class=\"my-3\">Grade</h2>\r\n<div class=\"col\">\r\n\t<a class=\'btn btn-primary\' href=\'/Setup/Grades/Create\'>New Grade</a>\r\n</div>\r\n\r\n\r\n\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>ID</th>\r\n\t\t\t<th>Name</th>\r\n\t\t\t\r\n\t\t\t\r\n\r\n\t\t</tr>\r\n\t</thead>\r\n");
#nullable restore
#line 23 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Grades\Index.cshtml"
      foreach(var item in Model.listGrades)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tbody>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 27 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Grades\Index.cshtml"
               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 28 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Grades\Index.cshtml"
               Write(item.GradeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t  </td>\r\n\t\t\t\t\r\n\t\t\t\t<td style=\"white-space:nowrap\">\r\n\t\t\t\t\t\r\n\t\t\t\t\t<a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 533, "\"", 573, 2);
            WriteAttributeValue("", 540, "/Setup/Varalls/Delete?ID=", 540, 25, true);
#nullable restore
#line 32 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Grades\Index.cshtml"
WriteAttributeValue("", 565, item.ID, 565, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t</tbody>\r\n");
#nullable restore
#line 36 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Grades\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRMSApplication.Setup.Grades.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Grades.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Grades.IndexModel>)PageContext?.ViewData;
        public HRMSApplication.Setup.Grades.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591