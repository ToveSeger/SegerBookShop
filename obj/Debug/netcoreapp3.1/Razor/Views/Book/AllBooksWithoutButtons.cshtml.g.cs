#pragma checksum "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b85e1fe1951e4d4dd391fc2ac580e27df9e110b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_AllBooksWithoutButtons), @"mvc.1.0.view", @"/Views/Book/AllBooksWithoutButtons.cshtml")]
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
#line 1 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\_ViewImports.cshtml"
using SegerBookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\_ViewImports.cshtml"
using SegerBookShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b85e1fe1951e4d4dd391fc2ac580e27df9e110b", @"/Views/Book/AllBooksWithoutButtons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47ec491a302caf1e9dddd1687094e035f692fa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_AllBooksWithoutButtons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LoginVerification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
  
    ViewData["Title"] = "ShowSearchResults";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p-2\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"=\" col-6\">\r\n            <h2 class=\"text-primary\">Search Results</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b85e1fe1951e4d4dd391fc2ac580e27df9e110b5224", async() => {
                WriteLiteral("Create New Book");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n");
#nullable restore
#line 16 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" stryle=""width:100%"">
            <thead>
                <tr>
                    <th>
                        Title
                    </th>
                    <th>
                        Author
                    </th>
                    <th>
                        Price
                    </th>
                    <th>
                        Amount
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
                 foreach (var book in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"20%\">");
#nullable restore
#line 39 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
                                   Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"20%\">");
#nullable restore
#line 40 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
                                   Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"20%\">");
#nullable restore
#line 41 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
                                   Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"20%\">");
#nullable restore
#line 42 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
                                   Write(book.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"40%\">\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 49 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No books created yet</p>\r\n");
#nullable restore
#line 54 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\AllBooksWithoutButtons.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b85e1fe1951e4d4dd391fc2ac580e27df9e110b9959", async() => {
                WriteLiteral("Back to Admin Menu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookShop.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591