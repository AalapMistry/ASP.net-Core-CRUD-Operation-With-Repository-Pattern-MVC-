#pragma checksum "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416066729a8d5f02a4d85684c1cf718d14e238b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AalapCRUDAutomated.Pages.Registration.Pages_Registration_Delete_registration), @"mvc.1.0.view", @"/Pages/Registration/Delete_registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Registration/Delete_registration.cshtml", typeof(AalapCRUDAutomated.Pages.Registration.Pages_Registration_Delete_registration))]
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
#line 1 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\_ViewImports.cshtml"
using AalapCRUDAutomated;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416066729a8d5f02a4d85684c1cf718d14e238b8", @"/Pages/Registration/Delete_registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ed18d07218b4c9c3376de88dcdb4b971d6b876", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Registration_Delete_registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.RegistrationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete_customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 165, true);
            WriteLiteral("<h2>Delete</h2>\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(243, 45, false);
#line 13 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 41, false);
#line 16 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 39, false);
#line 19 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(500, 35, false);
#line 22 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(535, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(579, 43, false);
#line 25 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(622, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(666, 39, false);
#line 28 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(749, 40, false);
#line 31 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(789, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(833, 36, false);
#line 34 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(869, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(913, 43, false);
#line 37 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(956, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1000, 39, false);
#line 40 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1083, 41, false);
#line 43 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1168, 37, false);
#line 46 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1249, 42, false);
#line 49 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1335, 38, false);
#line 52 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1417, 41, false);
#line 55 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1458, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1502, 37, false);
#line 58 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1583, 43, false);
#line 61 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1670, 39, false);
#line 64 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1743, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c2f3f50aaa543eca0e3b241ee489288", async() => {
                BeginContext(1778, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1788, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "585c10950f934c23939684e1268987bc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 69 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Pages\Registration\Delete_registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

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
                BeginContext(1824, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" /> |\r\n        ");
                EndContext();
                BeginContext(1908, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe6afd9207d4ae9a2ee8d0591dc1c7c", async() => {
                    BeginContext(1930, 12, true);
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
                BeginContext(1946, 6, true);
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
            BeginContext(1959, 10, true);
            WriteLiteral("\r\n</div>  ");
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
