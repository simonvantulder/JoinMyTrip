#pragma checksum "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b3de6838c84c17b0c1bd8dbfe49d6e74d58a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TripDetail), @"mvc.1.0.view", @"/Views/Home/TripDetail.cshtml")]
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
#line 1 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\_ViewImports.cshtml"
using LoginReg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\_ViewImports.cshtml"
using LoginReg.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b3de6838c84c17b0c1bd8dbfe49d6e74d58a9f", @"/Views/Home/TripDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055bc58c475258137262f4c9378fc5b16430f41e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TripDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trip>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
  
    ViewData["Title"] = "Wedding Details";
    int? uid = @Context.Session.GetInt32("UserId");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n<h1>");
#nullable restore
#line 8 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
Write(Model.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b3de6838c84c17b0c1bd8dbfe49d6e74d58a9f4707", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b3de6838c84c17b0c1bd8dbfe49d6e74d58a9f6071", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n<div>\r\n\r\n    <h3>\r\n        Start Date: ");
#nullable restore
#line 16 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
               Write(Model.StartDate.ToString("MMMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <h3>\r\n        End Date: ");
#nullable restore
#line 19 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
             Write(Model.EndDate.ToString("MMMM d, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <h3>\r\n        Plan: ");
#nullable restore
#line 22 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
         Write(Model.Plan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <h3>\r\n        Guide: ");
#nullable restore
#line 25 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
          Write(Model.Guide.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <div>\r\n        <h3>People on this Trip: ");
#nullable restore
#line 28 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
                            Write(Model.Tourists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n            <ul>\r\n");
#nullable restore
#line 31 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
                 foreach (UTRel item in Model.Tourists)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 33 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
                   Write(item.UserTourist.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 34 "C:\Users\kaitl\Desktop\CodingDojo\C#\FullStack\TripBuddy\Views\Home\TripDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trip> Html { get; private set; }
    }
}
#pragma warning restore 1591
