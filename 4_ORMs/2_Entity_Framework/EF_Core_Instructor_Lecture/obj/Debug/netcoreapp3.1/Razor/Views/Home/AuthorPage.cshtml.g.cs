#pragma checksum "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75065c55ac8e1a4a820f3c3d46ab999f37a13984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AuthorPage), @"mvc.1.0.view", @"/Views/Home/AuthorPage.cshtml")]
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
#line 1 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\_ViewImports.cshtml"
using EF_Core_Instructor_Lecture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\_ViewImports.cshtml"
using EF_Core_Instructor_Lecture.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75065c55ac8e1a4a820f3c3d46ab999f37a13984", @"/Views/Home/AuthorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e14c2d90503ffea2b49bcf0259a9decaeaff3ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AuthorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2 class=\"text-center\">Welcome to ");
#nullable restore
#line 4 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
                                  Write(Model.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Page!</h2>\r\n    <p class=\"text-center\">Member since ");
#nullable restore
#line 5 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
                                   Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"text-center\">Total posts: ");
#nullable restore
#line 6 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
                                   Write(Model.Posts.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    \r\n");
#nullable restore
#line 8 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
     foreach (Post post in Model.Posts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card shadow p-3 rounded mb-4 w-50\">\r\n            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75065c55ac8e1a4a820f3c3d46ab999f37a139845650", async() => {
#nullable restore
#line 11 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
                                                                                          Write(post.Topic);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PostID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
                                                                     WriteLiteral(post.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PostID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PostID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PostID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 12 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
          Write(post.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 512, "\"", 530, 1);
#nullable restore
#line 13 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
WriteAttributeValue("", 518, post.ImgURL, 518, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post\">\r\n            <small class=\"text-muted\">Submitted on ");
#nullable restore
#line 14 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
                                              Write(post.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Home\AuthorPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
