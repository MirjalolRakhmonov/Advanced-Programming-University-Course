#pragma checksum "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230219c25737b0a887fb84b6b4497e6d5d56aa5b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace data01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using data01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\_Imports.razor"
using data01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
       
    //private Int64 currentCount = 0;
    private string con;
    private NpgsqlDataReader data=null;
    private NpgsqlConnection connLink;

    private void IncrementCount()
    {
        con = "Server=209.126.96.59;";
        con += "User Id=u107627;";
        con += "Password=FUW9ESS8;";
        con += "Database=adv_prog;";
        NpgsqlConnection connLink = new NpgsqlConnection(con);
        connLink.Open();
        string sql = "SELECT ";
        sql+=" task_id, taskname, responsible, ";
        sql+=" to_char(deadline,'DD/MON/YYYY') ";
        sql+=" FROM task WHERE status='Running';";
        NpgsqlCommand command = new NpgsqlCommand(sql, connLink);
        data=command.ExecuteReader();
        // This obtains the value of the first column in the first record
        //currentCount = (Int64)command.ExecuteScalar();
        //connLink.Close();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
