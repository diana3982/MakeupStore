#pragma checksum "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fdf51f5757193ba97116de20e69ec352fa6810b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fdf51f5757193ba97116de20e69ec352fa6810b", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"facbb717e483d35442762895f347ee4a270a5d88", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MakeupStore.App.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 203, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> Orders </h1>\r\n    <p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(297, 38, false);
#line 14 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(335, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(415, 62, false);
#line 17 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderLocation.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(477, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(557, 59, false);
#line 20 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderCustomer.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(616, 51, true);
            WriteLiteral("                         \r\n                        ");
            EndContext();
            BeginContext(668, 58, false);
#line 21 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderCustomer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(726, 81, true);
            WriteLiteral("\r\n\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(808, 45, false);
#line 25 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(853, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(933, 41, false);
#line 28 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(974, 97, true);
            WriteLiteral("\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 34 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1136, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1221, 37, false);
#line 38 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1350, 61, false);
#line 41 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderLocation.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1503, 58, false);
#line 44 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderCustomer.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1592, 57, false);
#line 45 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderCustomer.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 93, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1743, 48, false);
#line 49 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1883, 44, false);
#line 52 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "/Users/dianajuarez/Projects/Project1/MakeupStore.App/Views/Order/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2006, 56, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MakeupStore.App.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
