#pragma checksum "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\Shared\NavPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "081e1397176efba4ed8fbc2c2fccb14de5fdda1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NavPartial), @"mvc.1.0.view", @"/Views/Shared/NavPartial.cshtml")]
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
#line 3 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\_ViewImports.cshtml"
using Platform_Lecture_ASP_MVC_II;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\_ViewImports.cshtml"
using Platform_Lecture_ASP_MVC_II.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"081e1397176efba4ed8fbc2c2fccb14de5fdda1d", @"/Views/Shared/NavPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755ba73f72add6aba7b18a543cc5f4fc87b15c7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NavPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<nav>\r\n    <ul>\r\n        <li><a href=\"/\">Home</a></li>\r\n        <li><a href=\"/about\">About Me</a></li>\r\n    </ul>\r\n</nav>\r\n\r\n\r\n<h1>Keeping Time...</h1>\r\n<p>");
#nullable restore
#line 15 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\Shared\NavPartial.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\Shared\NavPartial.cshtml"
               Write(ViewBag.CurrentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<h3>First Name: ");
#nullable restore
#line 20 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\Shared\NavPartial.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Last Name: ");
#nullable restore
#line 21 "C:\Users\taylo\OneDrive\Desktop\Coding_Dojo\c_sharp_stack\3_ASP.NET_Core\2_ASP_MVC_II\Platform_Lecture_ASP_MVC_II\Views\Shared\NavPartial.cshtml"
          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591