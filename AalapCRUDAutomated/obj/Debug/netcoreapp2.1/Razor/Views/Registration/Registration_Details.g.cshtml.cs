#pragma checksum "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b6eade3179aaae46c79d5d0490b2809d92d3c16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AalapCRUDAutomated.Pages.Registration.Views_Registration_Registration_Details), @"mvc.1.0.view", @"/Views/Registration/Registration_Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Registration_Details.cshtml", typeof(AalapCRUDAutomated.Pages.Registration.Views_Registration_Registration_Details))]
namespace AalapCRUDAutomated.Pages.Registration
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\_ViewImports.cshtml"
using AalapCRUDAutomated;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6eade3179aaae46c79d5d0490b2809d92d3c16", @"/Views/Registration/Registration_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ed18d07218b4c9c3376de88dcdb4b971d6b876", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Registration_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.RegistrationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit_customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 118, true);
            WriteLiteral("<h2>Details</h2>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(197, 45, false);
#line 12 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 41, false);
#line 15 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(371, 44, false);
#line 18 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(415, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(459, 40, false);
#line 21 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(499, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(543, 39, false);
#line 24 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(582, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(626, 35, false);
#line 27 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(661, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(705, 43, false);
#line 30 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(748, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(792, 39, false);
#line 33 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(831, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(875, 40, false);
#line 36 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(915, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(959, 36, false);
#line 39 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(995, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1039, 43, false);
#line 42 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1126, 39, false);
#line 45 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1209, 41, false);
#line 48 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1294, 37, false);
#line 51 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1375, 42, false);
#line 54 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1461, 38, false);
#line 57 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1543, 41, false);
#line 60 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1628, 37, false);
#line 63 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1709, 43, false);
#line 66 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1796, 39, false);
#line 69 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1882, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f8786f279e94b52b440acbd4f00ed7f", async() => {
                BeginContext(1937, 4, true);
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
#line 74 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Registration_Details.cshtml"
                                    WriteLiteral(Model.ID);

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
            BeginContext(1945, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1953, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edfdd343f7cf4cfd80e846614075d232", async() => {
                BeginContext(1975, 12, true);
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
            BeginContext(1991, 9, true);
            WriteLiteral("\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.RegistrationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
