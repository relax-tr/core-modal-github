#pragma checksum "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30bf5dab00a628226f498bd723c5697b2ff1e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_deneme), @"mvc.1.0.view", @"/Views/Home/deneme.cshtml")]
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
#line 1 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\_ViewImports.cshtml"
using modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\_ViewImports.cshtml"
using modal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30bf5dab00a628226f498bd723c5697b2ff1e0c", @"/Views/Home/deneme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91553e0f7f54989d15692aba9affd487f2937f3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_deneme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("   Enumerable<modal.Models.Soru>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"
      
        ViewBag.Title = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>Index</h2>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 10 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"
   Write(Html.ActionLink("View All", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"
         using (Html.BeginForm("Search", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table>
                <tr>
                    <td>
                        <input type=""text"" id=""txtName"" name=""searchparam"" placeholder=""type here to search"" />
                    </td>
                    <td>
                        <input type=""submit"" id=""btnSubmit"" value=""Search"" />
                    </td>
                </tr>
            </table>
");
#nullable restore
#line 24 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>vsdfgvsd\r\n            </th>\r\n            <th>gvr</th>\r\n            <th>\r\n                sdvsd </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                </td>\r\n                <td>\r\n                </td>\r\n                <td>\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("\r\n                    <a href=\"javascript:void(0);\" class=\"anchorDetail\" data-id=\"");
#nullable restore
#line 51 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"
                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Details</a>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\GLBHR\Desktop\abidin\core modal\modal\modal\Views\Home\deneme.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
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
