#pragma checksum "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd9446d21705c2f26a92d4c7351dda54e6a20fde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AalapCRUDAutomated.Pages.Registration.Views_Registration_Index), @"mvc.1.0.view", @"/Views/Registration/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Index.cshtml", typeof(AalapCRUDAutomated.Pages.Registration.Views_Registration_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9446d21705c2f26a92d4c7351dda54e6a20fde", @"/Views/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ed18d07218b4c9c3376de88dcdb4b971d6b876", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.RegistrationModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create_registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit_registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration_Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete_registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 25, true);
            WriteLiteral("<h2>Index</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(114, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c9c18af22e4aa7a60a9c2d7dd98870", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 124, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-responsive\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(289, 45, false);
#line 14 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(334, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(390, 44, false);
#line 17 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 39, false);
#line 20 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(529, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(585, 40, false);
#line 23 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(625, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(681, 43, false);
#line 26 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(724, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(780, 41, false);
#line 29 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(821, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(877, 42, false);
#line 32 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(919, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(975, 42, false);
#line 35 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1073, 41, false);
#line 38 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1170, 43, false);
#line 41 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 93, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1355, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1416, 44, false);
#line 51 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1528, 43, false);
#line 54 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1639, 39, false);
#line 57 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1746, 42, false);
#line 60 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1856, 39, false);
#line 63 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1963, 42, false);
#line 66 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2005, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2073, 41, false);
#line 69 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2182, 41, false);
#line 72 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2291, 40, false);
#line 75 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2399, 43, false);
#line 78 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2509, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eb881ea512e4211966142130d132872", async() => {
                BeginContext(2567, 4, true);
                WriteLiteral("Edit");
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
#line 81 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
                                                        WriteLiteral(item.ID);

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
            BeginContext(2575, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2599, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fab486f7c3b417587652793e9710c40", async() => {
                BeginContext(2660, 7, true);
                WriteLiteral("Details");
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
#line 82 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
                                                           WriteLiteral(item.ID);

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
            BeginContext(2671, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2695, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05dfb42569564b33a9559aa33e1f5eb1", async() => {
                BeginContext(2755, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
                                                          WriteLiteral(item.ID);

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
            BeginContext(2765, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 86 "E:\.Net Data\ASP.Net Core\ASP.net Core CRUD Operation\ASP.net-Core-CRUD-Operation-With-Repository-Pattern-MVC-\AalapCRUDAutomated\Views\Registration\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2820, 26, true);
            WriteLiteral("    </tbody>\r\n</table>    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.RegistrationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
