#pragma checksum "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb4f24eba4b12c8b77d2dc3e0e5fa352c928bee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_MatchingAuthorList), @"mvc.1.0.view", @"/Views/Book/MatchingAuthorList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb4f24eba4b12c8b77d2dc3e0e5fa352c928bee", @"/Views/Book/MatchingAuthorList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47ec491a302caf1e9dddd1687094e035f692fa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_MatchingAuthorList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
  
    ViewData["Title"] = "ShowSearchResults";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container p-2\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"=\" col-6\">\r\n            <h2 class=\"text-primary\">Search Results</h2>\r\n        </div>\r\n        <br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-striped"" stryle=""width:100%"">
                <thead>
                    <tr>
                        <th>
                            Id
                        </th>
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
                            Amount of books
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 35 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                     foreach (var book in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\'\r\n                            <td width=\"20%\">");
#nullable restore
#line 38 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                                       Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\'\r\n                            <td width=\"20%\">");
#nullable restore
#line 39 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                                       Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"20%\">");
#nullable restore
#line 40 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                                       Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"20%\">");
#nullable restore
#line 41 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                                       Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"20%\">");
#nullable restore
#line 42 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                                       Write(book.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"40%\">\r\n                                <div class=\"w-100 btn-group\" role-\"group\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb4f24eba4b12c8b77d2dc3e0e5fa352c928bee7583", async() => {
                WriteLiteral("Buy book ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                                                                                    WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 52 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"

    }
        else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No books created yet</p>\r\n");
#nullable restore
#line 57 "C:\Users\toves\source\repos\SegerBookShop\SegerBookShop\Views\Book\MatchingAuthorList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>");
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
