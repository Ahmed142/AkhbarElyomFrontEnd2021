#pragma checksum "E:\AkhbarElYom.com\GitHub\AkhbarElyomFrontEnd2021\akhbarelyom.front.end.2021\MVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e6aa3584f4d04942eb6a8a0ee5a06173f7ed3d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\AkhbarElYom.com\GitHub\AkhbarElyomFrontEnd2021\akhbarelyom.front.end.2021\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AkhbarElYom.com\GitHub\AkhbarElyomFrontEnd2021\akhbarelyom.front.end.2021\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e6aa3584f4d04942eb6a8a0ee5a06173f7ed3d0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "E:\AkhbarElYom.com\GitHub\AkhbarElyomFrontEnd2021\akhbarelyom.front.end.2021\MVC\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - MVC</title>
    <link rel=""stylesheet"" href=""~/lib/bootstrap/dist/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""~/css/site.css"" />
</head>
<body>
    <header>
        <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
            <div class=""container"">
                <a class=""navbar-brand""");
            BeginWriteAttribute("asp-area", " asp-area=\"", 557, "\"", 568, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-controller=""Home"" asp-action=""Index"">MVC</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark""");
            BeginWriteAttribute("asp-area", " asp-area=\"", 1198, "\"", 1209, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Home\" asp-action=\"Index\">Home</a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 1397, "\"", 1408, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-controller=""Home"" asp-action=""Privacy"">Privacy</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 34 "E:\AkhbarElYom.com\GitHub\AkhbarElyomFrontEnd2021\akhbarelyom.front.end.2021\MVC\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </main>\r\n    </div>\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2020 - MVC - <a");
            BeginWriteAttribute("asp-area", " asp-area=\"", 1845, "\"", 1856, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-controller=""Home"" asp-action=""Privacy"">Privacy</a>
        </div>
    </footer>
    <script src=""~/lib/jquery/dist/jquery.min.js""></script>
    <script src=""~/lib/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""~/js/site.js"" asp-append-version=""true""></script>
    ");
#nullable restore
#line 46 "E:\AkhbarElYom.com\GitHub\AkhbarElyomFrontEnd2021\akhbarelyom.front.end.2021\MVC\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</body>\r\n</html>\r\n");
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