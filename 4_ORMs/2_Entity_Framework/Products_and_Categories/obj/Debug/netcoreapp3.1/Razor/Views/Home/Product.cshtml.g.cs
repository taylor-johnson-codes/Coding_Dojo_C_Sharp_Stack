#pragma checksum "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ea7b3d3ee67f6bde70b144411b7b112f1500c7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
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
#nullable restore
#line 1 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\_ViewImports.cshtml"
using Products_and_Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\_ViewImports.cshtml"
using Products_and_Categories.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea7b3d3ee67f6bde70b144411b7b112f1500c7e", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1938ce52cb64963fe7814919b21ab53f7e9d991", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCategoryToProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"text-center mb-3\">");
#nullable restore
#line 4 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
            WriteLiteral("            <h5>Categories:</h5>\r\n");
#nullable restore
#line 15 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 17 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
               Write(item.CategoryOfProduct.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col\">\r\n            <h5>Add Category:</h5>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea7b3d3ee67f6bde70b144411b7b112f1500c7e6202", async() => {
                WriteLiteral("\r\n                <select class=\"custom-select\" name=\"categoryId\">\r\n");
#nullable restore
#line 25 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                     if (ViewBag.Categories1 != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                         foreach (var item in @ViewBag.Categories1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ea7b3d3ee67f6bde70b144411b7b112f1500c7e7225", async() => {
#nullable restore
#line 29 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                               WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n                <button class=\"btn btn-success mt-3\">Add</button>\r\n            ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\Products_and_Categories\Views\Home\Product.cshtml"
                                                                                   WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
