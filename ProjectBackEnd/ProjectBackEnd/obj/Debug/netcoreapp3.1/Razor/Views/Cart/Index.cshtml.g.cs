#pragma checksum "C:\Users\metin\OneDrive\Рабочий стол\.net core\.Net-Core-Tasks\ProjectBackEnd\ProjectBackEnd\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51df6cdcddc1725b5691bbc5d4f31bccf27e4b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 2 "C:\Users\metin\OneDrive\Рабочий стол\.net core\.Net-Core-Tasks\ProjectBackEnd\ProjectBackEnd\Views\_ViewImports.cshtml"
using ProjectBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\metin\OneDrive\Рабочий стол\.net core\.Net-Core-Tasks\ProjectBackEnd\ProjectBackEnd\Views\_ViewImports.cshtml"
using ProjectBackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51df6cdcddc1725b5691bbc5d4f31bccf27e4b3a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85af145b8e39cd8feb81742f4b2872e737159d20", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"page-header\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"crumb\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 105, "\"", 112, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-solid fa-house""></i>Home</a>
            <i class=""fa-solid fa-angle-right to1""></i>
            Shop
            <i class=""fa-solid fa-angle-right to2""></i>
            Cart
        </div>
    </div>
</div>

<div class=""cart-main"">
    <div class=""container-fluid"">
        <div class=""heading"">
            <h1>Your Cart</h1>
            <h6>There are <span class=""count"">2</span>products in your cart</h6>
        </div>
        <div class=""addto-cart"">
            <table class=""table table-bordered table-striped mt-5"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Unit Price</th>
                        <th>Quantity</th>
                        <th>SubTotal</th>
                        <th>Remove</th>
                    </tr>
                </thead>
                <tbody class=""tbody1"">
                    <!-- <tr>
                        <td><img src="""" alt=""""></td>
                        <");
            WriteLiteral(@"td class=""product-des product-name"">
                            <h6 class=""mb-5""><a class=""product-name"" href=""shop-product-right.html"">Field Roast Chao
                                    Cheese
                                    Creamy Original</a></h6>
                            <div class=""product-rate"">
                                <i class=""fa-solid fa-star star""></i>
                                <i class=""fa-solid fa-star star""></i>
                                <i class=""fa-solid fa-star star""></i>
                                <i class=""fa-solid fa-star star""></i>
                                <i class=""fa-solid fa-star-half star""></i>
                                <span>(4.0)</span>
                            </div>
                        </td>
                        <td>
                            <h4>
                                $2.51
                            </h4>
                        </td>
                        <td>
                            ");
            WriteLiteral(@"<div class=""detail-extra"">
                                <div class=""count"">
                                    <a href="""" class=""qty-down""><i class=""fa-solid fa-angle-down""></i></a>
                                    <span class=""qty-val"">1</span>
                                    <a href="""" class=""qty-up""><i class=""fa-solid fa-angle-up""></i></a>
                                </div>
                                <div class=""add-cart"">
                                    <button type=""submit""><i class=""fa-solid fa-cart-shopping""></i> Add To
                                        Cart</button>
                                    <a href=""""><i class=""fa-regular fa-heart""></i></a>
                                    <a href=""""><i class=""fa-solid fa-code-compare""></i></a>
                                </div>
                            </div>
                        </td>
                        <td>
                            <a href=""#"" class=""text-body""><i class=""fa-solid fa-trash-");
            WriteLiteral("can\"></i></a>\r\n                        </td>\r\n                    </tr> -->\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
