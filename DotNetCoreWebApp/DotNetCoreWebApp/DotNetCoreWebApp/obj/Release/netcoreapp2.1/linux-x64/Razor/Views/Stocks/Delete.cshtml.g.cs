#pragma checksum "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53feee0541918ebcf1b686f0c6703bdf50d31ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stocks_Delete), @"mvc.1.0.view", @"/Views/Stocks/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stocks/Delete.cshtml", typeof(AspNetCore.Views_Stocks_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53feee0541918ebcf1b686f0c6703bdf50d31ec5", @"/Views/Stocks/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33e36ac715608fc87bbc6021abb95f27466dd7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Stocks_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCoreWebApp.Models.Stock>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Stock</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(249, 40, false);
#line 15 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(333, 36, false);
#line 18 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(413, 46, false);
#line 21 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Trade_Code));

#line default
#line hidden
            EndContext();
            BeginContext(459, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(503, 42, false);
#line 24 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Trade_Code));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(589, 40, false);
#line 27 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.High));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 36, false);
#line 30 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.High));

#line default
#line hidden
            EndContext();
            BeginContext(709, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(753, 39, false);
#line 33 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Low));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(836, 35, false);
#line 36 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Low));

#line default
#line hidden
            EndContext();
            BeginContext(871, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(915, 40, false);
#line 39 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Open));

#line default
#line hidden
            EndContext();
            BeginContext(955, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(999, 36, false);
#line 42 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Open));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1079, 41, false);
#line 45 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Close));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1164, 37, false);
#line 48 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Close));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1245, 42, false);
#line 51 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1331, 38, false);
#line 54 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Volume));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1407, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe221efd5e647258302221e8bbb57a3", async() => {
                BeginContext(1433, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1443, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "929d425381b8469f80012003859a6cad", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\shati\OneDrive\Desktop\Intenship\DotNetCoreWebApp\DotNetCoreWebApp\DotNetCoreWebApp\Views\Stocks\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1479, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1563, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14c417f9879c4960bdac9daebdacf5be", async() => {
                    BeginContext(1585, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1601, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1614, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCoreWebApp.Models.Stock> Html { get; private set; }
    }
}
#pragma warning restore 1591