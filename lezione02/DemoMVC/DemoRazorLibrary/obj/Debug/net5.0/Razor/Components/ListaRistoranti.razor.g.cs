#pragma checksum "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6875025a153530d4200c6e13fead00c477e28ae"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoRazorLibrary.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using DemoMVC.Models.Restaurants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using DemoMVC.Services.Restaurants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using DemoMVC.Models.Restaurants.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class ListaRistoranti : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DemoRazorLibrary.Components.PrimoComponente>(0);
            __builder.AddAttribute(1, "Intestazione", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
                                ViewModelRistoranti.OpenRestaurants.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "h3");
#nullable restore
#line 3 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(4, TitoloPagina);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-bordered table-striped table-hover");
            __builder.AddMarkupContent(8, @"<thead><tr><th>Id</th>
            <th>Nome</th>
            <th>Sedi</th>
            <th>Recensioni</th>
            <th>Media recensioni</th>
            <th>Numero Pietanze</th>
            <th>Prezzo Medio</th>
            <th></th></tr></thead>
    ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 19 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
         foreach(var ristorante in ViewModelRistoranti.Restaurants)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
#nullable restore
#line 22 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(12, ristorante.RestaurantId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 23 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(15, ristorante.RestaurantName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 24 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(18, ristorante.LocationsCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 25 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(21, ristorante.ReviewsCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 26 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(24, ristorante.AverageRating);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 27 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(27, ristorante.MenuCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 28 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
__builder.AddContent(30, ristorante.PriceAverge);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-danger");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
                                                             () => OnRimuovi.InvokeAsync(ristorante) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Elimina Ristorante");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\ListaRistoranti.razor"
       
    [Parameter]
    public string TitoloPagina { get; set; } = "Titolo Pagina";

    [Parameter]
    public RestaurantsIndexViewModel ViewModelRistoranti { get; set; } = new RestaurantsIndexViewModel();

    [Parameter]
    public EventCallback<RestaurantsListViewModel> OnRimuovi { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
