#pragma checksum "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd10f3a3ecabf56766f5dc4567d8aa7ce0ee4a03"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoServerBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using DemoServerBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using DemoServerBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using DemoMVC.Models.Restaurants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using DemoMVC.Services.Restaurants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using DemoMVC.Models.Restaurants.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\_Imports.razor"
using DemoRazorLibrary.Components;

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
#nullable restore
#line 6 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-warning");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                          AggiungiRistorante

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Aggiunti Ristorante");
            __builder.CloseElement();
#nullable restore
#line 14 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
 if(RistoranteCorrente == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DemoRazorLibrary.Components.ListaRistoranti>(14);
            __builder.AddAttribute(15, "ViewModelRistoranti", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DemoMVC.Models.Restaurants.ViewModels.RestaurantsIndexViewModel>(
#nullable restore
#line 16 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                          ViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnRimuovi", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DemoMVC.Models.Restaurants.ViewModels.RestaurantsListViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DemoMVC.Models.Restaurants.ViewModels.RestaurantsListViewModel>(this, 
#nullable restore
#line 16 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                                                RimuoviRistorante

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "TitoloPagina", "Lista Ristoranti");
            __builder.CloseComponent();
#nullable restore
#line 17 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DemoRazorLibrary.Components.DettaglioRistorante>(18);
            __builder.AddAttribute(19, "RistoranteCorrente", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DemoMVC.Models.Restaurants.ViewModels.RestaurantsListViewModel>(
#nullable restore
#line 19 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                             RistoranteCorrente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnSalvaForm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DemoMVC.Models.Restaurants.ViewModels.RestaurantsListViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DemoMVC.Models.Restaurants.ViewModels.RestaurantsListViewModel>(this, 
#nullable restore
#line 19 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                                                              SalvaForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "OnAnnulla", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 19 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
                                                                                                    Annulla

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 20 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Pages\Counter.razor"
       
    private int currentCount = 0;
    private RestaurantsIndexViewModel ViewModel;
    private RestaurantsListViewModel RistoranteCorrente;

    private void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInitialized()
    {
        ViewModel = servizio.GetIndexViewModel();
    }

    public void RimuoviRistorante(RestaurantsListViewModel ristorante)
    {
        ViewModel.Restaurants.Remove(ristorante);
    }

    public void AggiungiRistorante()
    {
        RistoranteCorrente = new RestaurantsListViewModel();
    }

    public void SalvaForm(RestaurantsListViewModel ristorante)
    {
        servizio.AddRestaurant(ristorante);
        RistoranteCorrente = null;
        ViewModel = servizio.GetIndexViewModel();
    }

    public void Annulla()
    {
        RistoranteCorrente = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRestaurantsService servizio { get; set; }
    }
}
#pragma warning restore 1591
