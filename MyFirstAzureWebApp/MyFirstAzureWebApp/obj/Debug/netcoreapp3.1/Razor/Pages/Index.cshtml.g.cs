#pragma checksum "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61838dd6cfef3e74d9095a700df83a67ef5c1915"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyFirstAzureWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MyFirstAzureWebApp.Pages
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
#line 1 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\_ViewImports.cshtml"
using MyFirstAzureWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61838dd6cfef3e74d9095a700df83a67ef5c1915", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69ae2550b91dc12eb16319922f44697898b8c9d5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

    
    var myMessage = "Hello all";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>My message is: ");
#nullable restore
#line 11 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml"
                 Write(myMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">Shannon\'s Web Application with Azure</h2>\r\n</div>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61838dd6cfef3e74d9095a700df83a67ef5c19153900", async() => {
                WriteLiteral("\r\n    <!-- Single statement block -->\r\n");
#nullable restore
#line 26 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml"
       var myMessage2 = "Hello World"; 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Inline expression or variable -->\r\n    <p>All I want to say is: ");
#nullable restore
#line 29 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml"
                        Write(myMessage2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    <!-- Multi-statement block -->\r\n");
#nullable restore
#line 32 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml"
      
        var greeting = "Welcome to our site!";
        var utcDate = DateTime.Now;
        var greetingMessage = greeting + " Here in Jacksonville, Florida it is: " + utcDate;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p>The greeting is: ");
#nullable restore
#line 38 "C:\Users\shodg\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MyFirstAzureWebApp\MyFirstAzureWebApp\Pages\Index.cshtml"
                   Write(greetingMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591