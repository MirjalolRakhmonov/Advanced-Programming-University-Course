#pragma checksum "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0a3644293b4192a4d158b5c211aeac20407b6f"
// <auto-generated/>
#pragma warning disable 1591
namespace data01.Pages
{
    #line hidden
    using System;
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
#nullable restore
#line 3 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
using Data;

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
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
                                          GetRunningTasks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Running Tasks");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<hr>\r\n");
#nullable restore
#line 9 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
 if(myTasks.Count>0){
        int tot=0;

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "border", "1");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<tr><td>Id</td><td>Task</td><td>On charge</td><td>Deadline</td></tr>\r\n");
#nullable restore
#line 13 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
         foreach (var tsk in myTasks){
            tot++;

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddAttribute(13, "style", "font-size:9");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 16 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
                  tsk.task_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 17 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
                  tsk.taskname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
                  tsk.responsible

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 19 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
                  tsk.deadline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 21 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, "Total of Running Tasks: ");
            __builder.AddContent(32, 
#nullable restore
#line 23 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
                                    tot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 24 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
}
    else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.AddMarkupContent(35, "<h3>No Running Tasks</h3>\r\n");
#nullable restore
#line 27 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\e6530\source\repos\MyRepositories\Advanced Programming University Course\OO C#\Second part\data01\Pages\Counter.razor"
       
    //private Int64 currentCount = 0;
    //private string con;
    //private NpgsqlDataReader data=null;
    //private NpgsqlConnection connLink;
    private MyPostgresDB myDB = new MyPostgresDB();
    private List<DBTask> myTasks=new List<DBTask>();

    private void GetRunningTasks()
    {
        string sql = "SELECT ";
        sql += "task_id, taskname, responsible, ";
        sql += "to_char(deadline, 'DD//MON/YYYY') as deadline ";
        sql += "FROM task WHERE status='Running';";
        DBTask tsk;
        NpgsqlDataReader data=myDB.executeSQL(sql);
        while(data.Read()){
            tsk=new DBTask();
            tsk.set_from_reader(data);
            myTasks.Add(tsk);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
