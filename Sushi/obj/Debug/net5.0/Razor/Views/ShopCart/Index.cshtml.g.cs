#pragma checksum "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67ecbfb7f221a060077f1b2f32db4b0feab3b037daa8aba2cf349b4edc102275"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShopCart/Index.cshtml", typeof(AspNetCore.Views_ShopCart_Index))]
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
#line 1 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi;

#line default
#line hidden
#line 2 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.Data.Models;

#line default
#line hidden
#line 4 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.Data.Repisitory;

#line default
#line hidden
#line 1 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
using Sushi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"67ecbfb7f221a060077f1b2f32db4b0feab3b037daa8aba2cf349b4edc102275", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f55ede54582f2ea85aba1581f2c71d6fb438f08968c7959a64ac368674e3dcc", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
     if (Model.shopCart.ListShopItems.Count == 0)
    {

#line default
#line hidden
            BeginContext(138, 94, true);
            WriteLiteral("        <div class=\"alert alert-info mt-3\">\r\n            Ваша корзина пуста.\r\n        </div>\r\n");
            EndContext();
#line 11 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 14 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
         foreach (var el in Model.shopCart.ListShopItems)
        {

#line default
#line hidden
            BeginContext(326, 82, true);
            WriteLiteral("            <div calss=\"alert alert-warning mt-3\">\r\n                <b>Товар:</b> ");
            EndContext();
            BeginContext(409, 12, false);
#line (17,32)-(17,44) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
Write(el.Food.Name);

#line default
#line hidden
            EndContext();
            BeginContext(421, 37, true);
            WriteLiteral("<br />\r\n                <b>Цена:</b> ");
            EndContext();
            BeginContext(459, 27, false);
#line (18,31)-(18,58) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
Write(el.Food.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(486, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(504, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67ecbfb7f221a060077f1b2f32db4b0feab3b037daa8aba2cf349b4edc1022757474", async() => {
                BeginContext(592, 79, true);
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Удалить\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line (19,98)-(19,103) 13 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
WriteLiteral(el.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(678, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 23 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"

        }

#line default
#line hidden
#line 24 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
         

        int sumProd = 0;

        

#line default
#line hidden
#line 28 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
         foreach (var sum in Model.shopCart.ListShopItems)
        {
            sumProd += sum.Food.Price;
        }

#line default
#line hidden
            BeginContext(865, 53, true);
            WriteLiteral("        <hr />\r\n        <div>\r\n            <b>Итого: ");
            EndContext();
            BeginContext(919, 21, false);
#line (34,24)-(34,45) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
Write(sumProd.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(940, 22, true);
            WriteLiteral("</b>\r\n        </div>\r\n");
            EndContext();
            BeginContext(964, 24, true);
            WriteLiteral("        <hr />\r\n        ");
            EndContext();
            BeginContext(988, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67ecbfb7f221a060077f1b2f32db4b0feab3b037daa8aba2cf349b4edc10227511731", async() => {
                BeginContext(1059, 8, true);
                WriteLiteral("Оплатить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1071, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\ShopCart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1080, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
