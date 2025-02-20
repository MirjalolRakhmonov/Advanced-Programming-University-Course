#pragma checksum "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\Pages\HanoiTower.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56339fae8d82bab737bd64ff88769075df99054c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hanoitower")]
    public partial class HanoiTower : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "c:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\blazorserver01_Hanoi_Tower\blazorserver01\Pages\HanoiTower.razor"
       
    private string takenColor = "fill:rgb(0,0,255);";
    private string targetColor = "fill:rgb(0,120,0);";
    private string passiveColor = "fill:rgb(0,0,0);";
    private List<string> colors = new List<string>();
    private Data.HanoiGame h;

    private int height;
    private int width;

    private int takenDiskSize;
    private int targetDiskSize;

    private Data.HanoiTower t;
    private int currentCount = 0;
    private int takenTower, targetTower;
    private int totalDisks = 0;

    private bool checkCondition = true;
    private bool winCondition = false;

    private void changeDisk(int towerID)
    {
        currentCount++;
        for (int i = 0; i < h.totalOfTowers(); i++)
        {
            h.getTower(i).selection(false);
        }
        h.getTower(towerID).selection(true);
        for (int i = 0; i < h.totalOfTowers(); i++)
        {
            if (h.getTower(i).is_selected())
            {
                if (currentCount % 2 == 0)
                {
                    colors[towerID] = targetColor;
                    targetTower = towerID;
                }
                else
                {
                    colors[towerID] = takenColor;
                    takenTower = towerID;
                }
            }
            else
                colors[i] = passiveColor;
        }
        if (currentCount % 2 == 0 && currentCount != 0)
        {
            if (h.getTower(takenTower).getNextDisk() != null)
                takenDiskSize = h.getTower(takenTower).getNextDisk().size;
            else
                takenDiskSize = 0;

            if (h.getTower(targetTower).getNextDisk() != null)
                targetDiskSize = h.getTower(targetTower).getNextDisk().size;
            else
                targetDiskSize = 0;

            if (takenDiskSize > targetDiskSize && targetDiskSize != 0)
            {
                checkCondition = false;
                colors[targetTower] = passiveColor;
                targetTower = takenTower;
            }
            else
                checkCondition = true;
            h.getTower(targetTower).pushDisk(h.getTower(takenTower).popDisk());
        }

        if (h.getTower(h.totalOfTowers() - 1).hanoiDisks.Count == totalDisks)
            winCondition = true;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
