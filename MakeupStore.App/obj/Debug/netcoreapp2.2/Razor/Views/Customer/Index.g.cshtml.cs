#pragma checksum "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5f67933d74f8e404bb3a54ffa7e2e2fc8735b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/_ViewImports.cshtml"
using MakeupStore.App;

#line default
#line hidden
#line 2 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/_ViewImports.cshtml"
using MakeupStore.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5f67933d74f8e404bb3a54ffa7e2e2fc8735b6", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"facbb717e483d35442762895f347ee4a270a5d88", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MakeupStore.App.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 265, true);
            WriteLiteral(@"
<h4>Here is all customer data:</h4>

<div class=""text-center"">
    <h1 class=""display-4"">Here is all the customer data: </h1>
    <p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
            EndContext();
            BeginContext(362, 38, false);
#line 16 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(400, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(480, 45, false);
#line 19 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(525, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(605, 44, false);
#line 22 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(649, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(729, 41, false);
#line 25 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(770, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(850, 60, false);
#line 28 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DefLocation.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(910, 97, true);
            WriteLiteral("\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 34 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
                 foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1064, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1125, 37, false);
#line 38 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1230, 44, false);
#line 41 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1342, 43, false);
#line 44 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1453, 44, false);
#line 47 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1565, 63, false);
#line 50 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.DefLocation.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 53 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Customer/Index.cshtml"
}

#line default
#line hidden
            BeginContext(1675, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </p>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MakeupStore.App.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
