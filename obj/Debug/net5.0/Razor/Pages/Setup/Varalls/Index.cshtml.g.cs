#pragma checksum "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8338d74715ccc6f6b01ff07bb2130ada02c3c61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRMSApplication.Pages.Setup.Varalls.Pages_Setup_Varalls_Index), @"mvc.1.0.razor-page", @"/Pages/Setup/Varalls/Index.cshtml")]
namespace HRMSApplication.Pages.Setup.Varalls
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8338d74715ccc6f6b01ff07bb2130ada02c3c61", @"/Pages/Setup/Varalls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bba0893f36791b8953b3bf144a7917db44c7b5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Setup_Varalls_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2 class=""my-3"">Variance Allowance</h2>
<div class=""col"">
	<a class='btn btn-primary' href='/Setup/Varalls/Create'>New Allowance</a>
</div>



<table class=""table"">
	<thead>
		<tr>
			<th>AllowID</th>
			<th>Name</th>
			<th>Amount</th>
			
			

		</tr>
	</thead>
");
#nullable restore
#line 24 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml"
      foreach(var item in Model.listVaralls)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tbody>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 28 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml"
               Write(item.AllowID);

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 29 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml"
               Write(item.AllowName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t  </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml"
               Write(item.Value1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  </td>\r\n\t\t\t\t\r\n\t\t\t\t<td style=\"white-space:nowrap\">\r\n\t\t\t\t\t\r\n\t\t\t\t\t<a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 619, "\"", 669, 2);
            WriteAttributeValue("", 626, "/Setup/Varalls/Delete?AllowID=", 626, 30, true);
#nullable restore
#line 34 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml"
WriteAttributeValue("", 656, item.AllowID, 656, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t</tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Varalls\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRMSApplication.Setup.Varalls.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Varalls.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Varalls.IndexModel>)PageContext?.ViewData;
        public HRMSApplication.Setup.Varalls.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591