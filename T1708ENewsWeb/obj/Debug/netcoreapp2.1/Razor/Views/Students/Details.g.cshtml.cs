#pragma checksum "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a996ddd5cdd430a0634857da68d80bb45cd496fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
#line 1 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\_ViewImports.cshtml"
using T1708ENewsWeb;

#line default
#line hidden
#line 2 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\_ViewImports.cshtml"
using T1708ENewsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a996ddd5cdd430a0634857da68d80bb45cd496fe", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66e53d198a4ff1af924bb849b6f425e2295b966", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<T1708ENewsWeb.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(204, 45, false);
#line 14 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 41, false);
#line 17 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(334, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(378, 44, false);
#line 20 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 40, false);
#line 23 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(506, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(550, 41, false);
#line 26 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(635, 37, false);
#line 29 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(672, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(716, 44, false);
#line 32 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateAt));

#line default
#line hidden
            EndContext();
            BeginContext(760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(804, 40, false);
#line 35 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdateAt));

#line default
#line hidden
            EndContext();
            BeginContext(844, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(888, 44, false);
#line 38 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateAt));

#line default
#line hidden
            EndContext();
            BeginContext(932, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(976, 40, false);
#line 41 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreateAt));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1060, 42, false);
#line 44 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1146, 38, false);
#line 47 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 53, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <ul>\r\n");
            EndContext();
#line 53 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
         foreach(var mark in Model.Marks)
        {

#line default
#line hidden
            BeginContext(1291, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(1308, 16, false);
#line 55 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
           Write(mark.SubjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1328, 16, false);
#line 55 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
                               Write(mark.SubjectMark);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 56 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1362, 30, true);
            WriteLiteral("    </ul>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1392, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bed2017e3ba43909d8b4c39a157e460", async() => {
                BeginContext(1446, 4, true);
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
#line 60 "C:\Users\Hp\Desktop\T1708E_Net\T1708ENewsWeb\T1708ENewsWeb\Views\Students\Details.cshtml"
                           WriteLiteral(Model.RollNumber);

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
            BeginContext(1454, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1462, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bc0531267ee40658275c13fe80f351a", async() => {
                BeginContext(1484, 12, true);
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
            BeginContext(1500, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<T1708ENewsWeb.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
