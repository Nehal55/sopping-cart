#pragma checksum "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa73e4e834b6072ab656064a1723e97e3b2d4136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineShop;

#line default
#line hidden
#line 1 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa73e4e834b6072ab656064a1723e97e3b2d4136", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0824ae1f492899eab3f51cf62adf20c585e54e98", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 158, true);
            WriteLiteral("\n<br /><br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Product List</h2>\n    </div>\n    <div class=\"col-6 text-right\">\n        ");
            EndContext();
            BeginContext(251, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9cdd43947184bd78e56458fe92b68a8", async() => {
                BeginContext(295, 49, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New Product");
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
            BeginContext(348, 20, true);
            WriteLiteral("\n    </div>\n\n</div>\n");
            EndContext();
            BeginContext(368, 446, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a547c0acbb6446ef9695d4493c51f327", async() => {
                BeginContext(388, 419, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""lowAmount""/>
        </div>
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""largeAmount""/>
        </div>
        <div class=""col-3"">
            <input type=""submit"" value=""Search"" class=""btn btn-success""/>
        </div>
        <div class=""col-3""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(814, 155, true);
            WriteLiteral("\n<br />\n<div>\n    <table class=\"table table-striped border\" id=\"myTable\">\n        <thead>\n        <tr class=\"table-info\">\n            <th>\n                ");
            EndContext();
            BeginContext(970, 32, false);
#line 37 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1055, 33, false);
#line 40 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1141, 40, false);
#line 43 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1234, 39, false);
#line 46 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1326, 41, false);
#line 49 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(c => c.ProductTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 131, true);
            WriteLiteral("\n            </th>\n            \n            <th></th>\n            <th></th>\n        </tr>\n        </thead>\n       \n        <tbody>\n");
            EndContext();
#line 58 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1553, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(1599, 9, false);
#line 61 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1608, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1639, 10, false);
#line 62 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1649, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1680, 17, false);
#line 63 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(1697, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1728, 16, false);
#line 64 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1775, 29, false);
#line 65 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(item.ProductTypes.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(1804, 76, true);
            WriteLiteral("</td>\n                    \n                    <td>\n                        ");
            EndContext();
            BeginContext(1880, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "081af0a2df1049ee86016ecedf213178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 68 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
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
            BeginContext(1930, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 71 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1993, 36, true);
            WriteLiteral("        </tbody>\n\n\n</table>\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2046, 422, true);
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js""></script>
    
    <script type=""text/javascript"">
        $(document).ready( function () {
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        } );
        $(function(){
            var save = '");
                EndContext();
                BeginContext(2469, 16, false);
#line 91 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(2485, 107, true);
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
                EndContext();
                BeginContext(2593, 16, false);
#line 95 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(2609, 106, true);
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
                EndContext();
                BeginContext(2716, 18, false);
#line 99 "C:\Users\youtechBD\Downloads\IDM\onlineshop-master\OnlineShop\Areas\Admin\Views\Product\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(2734, 105, true);
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(2841, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
