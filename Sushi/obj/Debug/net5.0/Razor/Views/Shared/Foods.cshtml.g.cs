#pragma checksum "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5a404f0f169cc710bf5771f5334514439c5a618175116e92a4910f1a348e4d1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Foods), @"mvc.1.0.view", @"/Views/Shared/Foods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Foods.cshtml", typeof(AspNetCore.Views_Shared_Foods))]
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
#line 3 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\_ViewImports.cshtml"
using Sushi.Data.Repisitory;

#line default
#line hidden
#line 2 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5a404f0f169cc710bf5771f5334514439c5a618175116e92a4910f1a348e4d1c", @"/Views/Shared/Foods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8f55ede54582f2ea85aba1581f2c71d6fb438f08968c7959a64ac368674e3dcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Foods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
  
    var isAdmin = User.IsInRole("admin");

#line default
#line hidden
            BeginContext(139, 54, true);
            WriteLiteral("<div class=\"col-lg-3\">\r\n    <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 193, "\"", 209, 1);
#line (8,37)-(8,47) 29 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
WriteAttributeValue("", 199, Model.Img, 199, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 210, "\"", 227, 1);
#line (8,54)-(8,65) 29 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
WriteAttributeValue("", 216, Model.Name, 216, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(228, 13, true);
            WriteLiteral(" />\r\n    <h2>");
            EndContext();
            BeginContext(242, 10, false);
#line (9,10)-(9,20) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(252, 14, true);
            WriteLiteral("</h2>\r\n    <p>");
            EndContext();
            BeginContext(267, 17, false);
#line (10,9)-(10,26) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(284, 19, true);
            WriteLiteral("</p>\r\n    <p>Цена: ");
            EndContext();
            BeginContext(304, 25, false);
#line (11,15)-(11,40) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(329, 47, true);
            WriteLiteral("</p>\r\n    <button class=\"add-to-cart\" data-id=\"");
            EndContext();
            BeginContext(377, 8, false);
#line (12,43)-(12,51) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(385, 31, true);
            WriteLiteral("\">В корзину!</button>\r\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 416, "\"", 435, 2);
            WriteAttributeValue("", 421, "show-", 421, 5, true);
#line (13,19)-(13,28) 29 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
WriteAttributeValue("", 426, Model.Id, 426, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(436, 23, true);
            WriteLiteral(" class=\"show\" data-id=\"");
            EndContext();
            BeginContext(460, 8, false);
#line (13,53)-(13,61) 6 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(468, 10, true);
            WriteLiteral("\"></div>\r\n");
            EndContext();
#line 14 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
     if (isAdmin)
    {

#line default
#line hidden
            BeginContext(504, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(512, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a404f0f169cc710bf5771f5334514439c5a618175116e92a4910f1a348e4d1c9267", async() => {
                BeginContext(609, 8, true);
                WriteLiteral("Изменить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line (16,96)-(16,104) 13 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
WriteLiteral(Model.Id);

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
            BeginContext(621, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(631, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a404f0f169cc710bf5771f5334514439c5a618175116e92a4910f1a348e4d1c11884", async() => {
                BeginContext(743, 86, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Удалить\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line (17,86)-(17,94) 13 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(836, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 20 "C:\Users\Alex Ei\source\repos\Sushi\Sushi\Views\Shared\Foods.cshtml"
    }

#line default
#line hidden
            BeginContext(845, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(871, 1330, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.add-to-cart').on('click', function () {
                var id = $(this).data('id');
                var showDiv = $('#show-' + id);
                $.ajax({
                    url: '/ShopCart/addToCart',
                    type: 'POST',
                    data: { id: id },
                    success: function (response) {
                        showDiv.html(response);
                        showDiv.append('<div class=""alert alert-success mt-2"">Товар добавлен в корзину!</div>');
                        showDiv.append(successMessage);

                        // Анимация показа сообщения
                        successMessage.fadeIn();

                        // Установка таймера на скрытие сообщения через 2 секунды
                        setTimeout(function () {
                            successMessage.fadeOut('slow', function () {
                                $(this).remove(); // Удаляем элемент после аним");
                WriteLiteral(@"ации
                            });
                        }, 2000);
                    },
                    error: function (xhr, status, error) {
                        console.error('Error: ' + error);
                    }
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManage { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
