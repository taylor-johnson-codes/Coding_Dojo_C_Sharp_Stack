#pragma checksum "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9c9e4c670ab6d41f2826cc91a00d2a2cbe4a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_All), @"mvc.1.0.view", @"/Views/Posts/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9c9e4c670ab6d41f2826cc91a00d2a2cbe4a4c", @"/Views/Posts/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e14c2d90503ffea2b49bcf0259a9decaeaff3ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>All Posts</h2>\r\n");
#nullable restore
#line 7 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml"
     foreach (Post post in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card shadow p-3 rounded\">\r\n            <h4>");
#nullable restore
#line 10 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml"
           Write(post.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 11 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml"
          Write(post.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 301, "\"", 319, 1);
#nullable restore
#line 12 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml"
WriteAttributeValue("", 307, post.ImgURL, 307, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post\">\r\n            <small class=\"text-muted\">Submitted: ");
#nullable restore
#line 13 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml"
                                            Write(post.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\4_ORMs\2_Entity_Framework\EF_Core_Instructor_Lecture\Views\Posts\All.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591