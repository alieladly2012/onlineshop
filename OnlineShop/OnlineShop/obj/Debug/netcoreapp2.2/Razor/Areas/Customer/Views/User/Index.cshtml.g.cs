#pragma checksum "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05203fa739903e40e997d7c67d3ee5f581a107b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_User_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_User_Index))]
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
#line 1 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 1 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05203fa739903e40e997d7c67d3ee5f581a107b7", @"/Areas/Customer/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0824ae1f492899eab3f51cf62adf20c585e54e98", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 156, true);
            WriteLiteral("\n<br />\n<br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">User List</h2>\n    </div>\n    <div class=\"col-6 text-right\">\n        ");
            EndContext();
            BeginContext(256, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05203fa739903e40e997d7c67d3ee5f581a107b76245", async() => {
                BeginContext(300, 42, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(346, 291, true);
            WriteLiteral(@"
    </div>
</div>
<br />
<div>
    <table class=""table table-striped border"">
        <tr class=""table-info"">
            <th>
               Name
            </th>
            <th>
                UserName
            </th>
            <th>Status</th>
             <th></th>
        </tr>
");
            EndContext();
#line 30 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(684, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(706, 14, false);
#line 33 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
       Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(720, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(722, 13, false);
#line 33 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                       Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(735, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(754, 13, false);
#line 34 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
       Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(767, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 35 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
         if (item.LockoutEnd > DateTime.Now && item.LockoutEnd != null)
        {

#line default
#line hidden
            BeginContext(855, 107, true);
            WriteLiteral("            <td>Inactive</td>\n            <td>\n                <div class=\"btn-group\">\n                    ");
            EndContext();
            BeginContext(962, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05203fa739903e40e997d7c67d3ee5f581a107b79932", async() => {
                BeginContext(1033, 73, true);
                WriteLiteral("\n                        <i class=\"far fa-edit\"></i>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
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
            BeginContext(1110, 22, true);
            WriteLiteral("\n                     ");
            EndContext();
            BeginContext(1132, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05203fa739903e40e997d7c67d3ee5f581a107b712502", async() => {
                BeginContext(1202, 78, true);
                WriteLiteral("\n                        <i class=\"fas fa-trash-alt\"></i>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
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
            BeginContext(1284, 43, true);
            WriteLiteral("\n                </div>\n\n            </td>\n");
            EndContext();
#line 49 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"

        }
        else
        {

#line default
#line hidden
            BeginContext(1361, 82, true);
            WriteLiteral("            <td>Active</td>\n            <td style=\"width: 150px\">\n                ");
            EndContext();
            BeginContext(1443, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05203fa739903e40e997d7c67d3ee5f581a107b715481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 55 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 19, true);
            WriteLiteral("\n            </td>\n");
            EndContext();
#line 57 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1521, 11, true);
            WriteLiteral("\n    </tr>\n");
            EndContext();
#line 61 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1542, 21, true);
            WriteLiteral("    </table>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1580, 174, true);
                WriteLiteral("\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\n    <script type=\"text/javascript\">\n        $(function(){\n            var save = \'");
                EndContext();
                BeginContext(1755, 16, false);
#line 69 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(1771, 107, true);
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
                EndContext();
                BeginContext(1879, 16, false);
#line 73 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(1895, 106, true);
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
                EndContext();
                BeginContext(2002, 18, false);
#line 77 "C:\Users\ammohammed\Downloads\onlineshop-master\onlineshop-master\OnlineShop\Areas\Customer\Views\User\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(2020, 105, true);
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
