#pragma checksum "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920ae7e3c47ee7cf698bcfc8b7b9152810320299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stocks_Index), @"mvc.1.0.view", @"/Views/Stocks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stocks/Index.cshtml", typeof(AspNetCore.Views_Stocks_Index))]
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
#line 1 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\_ViewImports.cshtml"
using DotNetCoreWebApp;

#line default
#line hidden
#line 2 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\_ViewImports.cshtml"
using DotNetCoreWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920ae7e3c47ee7cf698bcfc8b7b9152810320299", @"/Views/Stocks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33e36ac715608fc87bbc6021abb95f27466dd7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Stocks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DotNetCoreWebApp.Models.Stock>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 94, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    \r\n    <input type=\"button\" class=\"btn btn-success\" value=\"Create\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 160, "\"", 217, 3);
            WriteAttributeValue("", 170, "location.href=\'", 170, 15, true);
#line 11 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
WriteAttributeValue("", 185, Url.Action("Create", "Stocks"), 185, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 216, "\'", 216, 1, true);
            EndWriteAttribute();
            BeginContext(218, 42, true);
            WriteLiteral(" />\r\n    <input type=\"button\" value=\"Back\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 260, "\"", 314, 3);
            WriteAttributeValue("", 270, "location.href=\'", 270, 15, true);
#line 12 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
WriteAttributeValue("", 285, Url.Action("Index", "Home"), 285, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 313, "\'", 313, 1, true);
            EndWriteAttribute();
            BeginContext(315, 95, true);
            WriteLiteral(" />\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 40, false);
#line 18 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 46, false);
#line 21 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Trade_Code));

#line default
#line hidden
            EndContext();
            BeginContext(553, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(609, 40, false);
#line 24 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.High));

#line default
#line hidden
            EndContext();
            BeginContext(649, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(705, 39, false);
#line 27 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Low));

#line default
#line hidden
            EndContext();
            BeginContext(744, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(800, 40, false);
#line 30 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Open));

#line default
#line hidden
            EndContext();
            BeginContext(840, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(896, 41, false);
#line 33 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Close));

#line default
#line hidden
            EndContext();
            BeginContext(937, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(993, 42, false);
#line 36 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1153, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1202, 39, false);
#line 45 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1297, 45, false);
#line 48 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Trade_Code));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1398, 39, false);
#line 51 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.High));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1493, 38, false);
#line 54 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Low));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1587, 39, false);
#line 57 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Open));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1682, 40, false);
#line 60 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Close));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1778, 41, false);
#line 63 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1874, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "258d83011d484076829edf6df178e70f", async() => {
                BeginContext(1919, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1927, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1947, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8092a1a7b9dc468e8b7f912893f913c7", async() => {
                BeginContext(1995, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2006, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2026, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbdd12a60f39447e916785d64a979faa", async() => {
                BeginContext(2073, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2083, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 71 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2122, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DotNetCoreWebApp.Models.Stock>> Html { get; private set; }
    }
}
#pragma warning restore 1591
