#pragma checksum "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ad37ebc330750ffdcb0680cbc63078a75498e1"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/towers")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Towers of Hanoi</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "svg");
            __builder.AddAttribute(6, "width", "1500");
            __builder.AddAttribute(7, "height", "500");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "g");
            __builder.AddAttribute(10, "id", "r1");
            __builder.AddAttribute(11, "fill", 
#nullable restore
#line 9 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                      r1.color

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                                          () => TowerClick(r1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n        <rect x=\"100\" y=\"200\" width=\"30\" height=\"300\"></rect>\r\n        <rect x=\"30\" y=\"470\" width=\"180\" height=\"30\"></rect>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "g");
            __builder.AddAttribute(16, "id", "r2");
            __builder.AddAttribute(17, "fill", 
#nullable restore
#line 14 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                      r2.color

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                                          () => TowerClick(r2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n        <rect x=\"400\" y=\"200\" width=\"30\" height=\"300\"></rect>\r\n        <rect x=\"330\" y=\"470\" width=\"180\" height=\"30\"></rect>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.OpenElement(21, "g");
            __builder.AddAttribute(22, "id", "r3");
            __builder.AddAttribute(23, "fill", 
#nullable restore
#line 19 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                      r3.color

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
                                          () => TowerClick(r3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n        <rect x=\"700\" y=\"200\" width=\"30\" height=\"300\"></rect>\r\n        <rect x=\"630\" y=\"470\" width=\"180\" height=\"30\"></rect>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\blazorserver01\Pages\Index.razor"
       
    private int currentCount = 0;
    List<Data.Rectangle> items = new List<Data.Rectangle>();
    public Data.Rectangle r1 = new Data.Rectangle(1, "black");
    public Data.Rectangle r2 = new Data.Rectangle(2, "black");
    public Data.Rectangle r3 = new Data.Rectangle(3, "black");

    public void listCreate()
    {
        items.Add(r1);
        items.Add(r2);
        items.Add(r3);
    }
    private void TowerClick(Data.Rectangle obj)
    {
        if (obj.color == "black")
        {
            obj.color = "blue";
        }
        else
        {
            obj.color = "black";
        }
    }
    public Index()
    {
        listCreate();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
