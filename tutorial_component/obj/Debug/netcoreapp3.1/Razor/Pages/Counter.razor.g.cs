#pragma checksum "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18b8d9b03f663ac5f93607d4e69bc00d0683315"
// <auto-generated/>
#pragma warning disable 1591
namespace tutorial_component.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using tutorial_component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\_Imports.razor"
using tutorial_component.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<hr>\r\n");
            __builder.OpenComponent<tutorial_component.Pages.Graph>(5);
            __builder.AddAttribute(6, "values", "20,30,40,50,60,70,80,90");
            __builder.AddAttribute(7, "colors", "#339090, #903378, #a3a322, #45a3b4, #456712, #777666, #986144, #555666");
            __builder.AddAttribute(8, "titles", "coal,cotton,oil,wood,brick,wool,silver,NaN");
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n<hr>\r\n<hr>\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
