// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace firebase_pruebas.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using firebase_pruebas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using firebase_pruebas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\_Imports.razor"
using firebase_pruebas.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\Pages\Counter.razor"
using FireSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\Pages\Counter.razor"
using FireSharp.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\Pages\Counter.razor"
using FireSharp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\Pages\Counter.razor"
using FireSharp.Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\Pages\Counter.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\gerar\OneDrive\Escritorio\Nueva carpeta\firebase-pruebas\firebase-pruebas\Pages\Counter.razor"
       
    private int currentCount = 0;

    string datos;

    private void IncrementCount()
    {
        currentCount++;
    }

    protected override async Task OnInitializedAsync()
    {
        //LoadData();
        // foreach (var item in await LoadData())
        // {
        //     Console.WriteLine("Name :" + item.Value.User);
        //     Console.WriteLine("Password :" + item.Value.Password);
        // }
        //Console.WriteLine(await LoadData());
    }

    class connection
    {
        //firebase connection Settings
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "tR91FLbzKUIoulcdrBwVRLhe5oNdEKwu0Ft2zBrO",
            BasePath = "https://crud-firebase-67d8a-default-rtdb.firebaseio.com/"
        };
        //IFirebaseClient client = new FirebaseClient(config);
        public IFirebaseClient client;
        //Code to warn console if class cannot connect when called.
        public connection()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                Console.WriteLine("Conexion correcta");
            }
            catch (Exception)
            {
                Console.WriteLine("Error en la conexión 1");
            }
        }
    }

    connection conn = new connection();

    private async void Get()
    {
        FirebaseResponse response = await conn.client.GetAsync("users/gerardo");
        Users user = response.ResultAs<Users>();
        Console.WriteLine(user.user);
    }

    // public async Task<Dictionary<string, Users>> LoadData()
    // {
    //     try
    //     {
    //         FirebaseResponse al = await conn.client.GetAsync("users");
    //         Dictionary<string, Users> ListData = JsonConvert.DeserializeObject<Dictionary<string, Users>>(al.Body.ToString());
    //         return ListData;
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine("Error en la conexión 2" + ex);
    //         return null;
    //     }
    // }

    // private async Task<List<Users>> GetDatos()
    // {
    //     FirebaseResponse response = await conn.client.GetAsync("users/set");
    //     Users users = response.ResultAs<Users>(); //The response will contain the data being retreived
    //     return users.ToString();
    // }

    private async void New()
    {        
        var user = new Users { user = "Prueba blazor", password = "holaatodos" };
        SetResponse response = await conn.client.SetAsync("users/gerardo", user);
        //Users result = response.ResultAs<Users>(); //The response will contain the data written
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
