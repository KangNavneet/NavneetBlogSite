#pragma checksum "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a20440786c69f6fdcbcc6d0e1e9cedb96e907c4"
// <auto-generated/>
#pragma warning disable 1591
namespace NavneetBlogSite.Views.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"
using NavneetBlogSite.Models;

#line default
#line hidden
#nullable disable
    public partial class BlogList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Blog List</h3>\r\n\r\n");
            __builder.OpenElement(1, "dl");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 5 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"
     foreach (BlogPost blog in ModelList)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "dt");
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"
             blog.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"
                        blog.AuthorEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "dd");
            __builder.AddContent(10, 
#nullable restore
#line 8 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"
             blog.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 9 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\navne\source\repos\NavneetBlogSite\NavneetBlogSite\Views\Components\BlogList.razor"
       
    [Parameter]
    public IEnumerable<BlogPost> ModelList { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
