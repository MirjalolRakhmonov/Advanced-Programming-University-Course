#pragma checksum "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\Pages\Graph.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d640e27c516022f25e37668fb844983bf3e1b9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Graph/{values; colors}")]
    public partial class Graph : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\tutorial_component\Pages\Graph.razor"
      
    [Parameter]
    public string values { get; set; }
    [Parameter]
    public string colors { get; set; }
    [Parameter]
    public string titles { get; set; }
    private String[] val = null;
    private String[] col = null;
    private String[] tit = null;
    private int n = 0;
    private int[] v, h;
    protected override void OnInitialized()
    {
        values = values ?? "0,1,2,3,4,5,6,7,8";
        colors = colors ?? "#ff0000, #00ff00, #0000ff, #0f0f0f, #0f0f00, #0f0000, #0fffff, #0000f0, #fffff0";
        titles = titles ?? "title1, title2, title3, title4, title5, title6, title7, title8";
        val = values.Split(",");
        col = colors.Split(",");
        tit = titles.Split(",");
        n = Math.Min(val.Length, col.Length);
        v = values.Split(",").Select(Int32.Parse).ToArray();
        h = new int[v.Length];
        for (int i = 0; i < v.Length; i++)
        {
            h[i] = (int)(v[i] * 100) / v.Max();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
