#pragma checksum "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252ca9b0583367238d0b31c9c06207180227ef48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRMSApplication.Pages.Setup.Vardeds.Pages_Setup_Vardeds_Index), @"mvc.1.0.razor-page", @"/Pages/Setup/Vardeds/Index.cshtml")]
namespace HRMSApplication.Pages.Setup.Vardeds
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252ca9b0583367238d0b31c9c06207180227ef48", @"/Pages/Setup/Vardeds/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bba0893f36791b8953b3bf144a7917db44c7b5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Setup_Vardeds_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2 class=""my-3"">Variance Deduction</h2>
<div class=""col"">
	<a class='btn btn-primary' href='/Setup/Vardeds/Create'>New Deduction</a>
</div>



<table class=""table"">
	<thead>
		<tr>
			<th>DedID</th>
			<th>Name</th>
			<th>Amount</th>



		</tr>
	</thead>
");
#nullable restore
#line 24 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml"
     foreach (var item in Model.listVardeds)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tbody>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 28 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml"
               Write(item.DedID);

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 29 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml"
               Write(item.DedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t  </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml"
               Write(item.Value2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  </td>\r\n\r\n\t\t\t\t<td style=\"white-space:nowrap\">\r\n\r\n\t\t\t\t\t<a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 591, "\"", 637, 2);
            WriteAttributeValue("", 598, "/Setup/Vardeds/Delete?DedID=", 598, 28, true);
#nullable restore
#line 34 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml"
WriteAttributeValue("", 626, item.DedID, 626, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t</tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Vardeds\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRMSApplication.Setup.Vardeds.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Vardeds.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Vardeds.IndexModel>)PageContext?.ViewData;
        public HRMSApplication.Setup.Vardeds.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591