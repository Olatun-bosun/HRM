#pragma checksum "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de51d014535c5ddf3f632004d5f55135f29409e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRMSApplication.Pages.Setup.Gralls.Pages_Setup_Gralls_Index), @"mvc.1.0.razor-page", @"/Pages/Setup/Gralls/Index.cshtml")]
namespace HRMSApplication.Pages.Setup.Gralls
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de51d014535c5ddf3f632004d5f55135f29409e1", @"/Pages/Setup/Gralls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bba0893f36791b8953b3bf144a7917db44c7b5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Setup_Gralls_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class=\"my-3\">PaySheet Allowance</h2>\r\n<div class=\"col\">\r\n\t<a class=\'btn btn-primary\' href=\'/Setup/Gralls/Create\'>New Allowance</a>\r\n</div>\r\n\r\n\r\n\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n");
            WriteLiteral("\t\t\t<th>Name</th>\r\n\t\t\t<th>Amount</th>\r\n\t\t\t<th>Steps</th>\r\n\t\t\t<th>Grade</th>\r\n\r\n\t\t\t\r\n\t\t\t\r\n\r\n\t\t</tr>\r\n\t</thead>\r\n");
#nullable restore
#line 27 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
      foreach(var item in Model.listGralls)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tbody>\r\n\t\t\t<tr>\r\n");
            WriteLiteral("\t\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
                 Write(item.AllowName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t  </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
               Write(item.Value1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 34 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
               Write(item.Steps);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 35 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
               Write(item.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  </td>\r\n\r\n\r\n\t\t\t\t\r\n\t\t\t\t<td style=\"white-space:nowrap\">\r\n\t\t\t\t\t\r\n\t\t\t\t\t<a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 725, "\"", 766, 2);
            WriteAttributeValue("", 732, "/Setup/Gralls/Delete?HID=", 732, 25, true);
#nullable restore
#line 41 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
WriteAttributeValue("", 757, item.HID, 757, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t</tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRMSApplication.Setup.Gralls.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Gralls.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HRMSApplication.Setup.Gralls.IndexModel>)PageContext?.ViewData;
        public HRMSApplication.Setup.Gralls.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591