#pragma checksum "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51bc2ec039c08b01f59e02e11c38a9898f970c70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HotDrinks), @"mvc.1.0.view", @"/Views/Home/HotDrinks.cshtml")]
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
#line 1 "C:\Projects\CoffeeShopApp\Views\_ViewImports.cshtml"
using CoffeeShopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\CoffeeShopApp\Views\_ViewImports.cshtml"
using CoffeeShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51bc2ec039c08b01f59e02e11c38a9898f970c70", @"/Views/Home/HotDrinks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33479ae7daa2bc01bea2466d33dcc7c588e95329", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HotDrinks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoffeeShopApp.Models.HotDrink>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
  
    ViewData["Title"] = "Hot Drinks";
    var quantity = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hot Drinks</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>S/N</th>\r\n            <th>Name</th>\r\n            <th>Description</th>\r\n            <th>Price</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 638, "\"", 645, 0);
            EndWriteAttribute();
            WriteLiteral(">ADD</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Projects\CoffeeShopApp\Views\Home\HotDrinks.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoffeeShopApp.Models.HotDrink>> Html { get; private set; }
    }
}
#pragma warning restore 1591
