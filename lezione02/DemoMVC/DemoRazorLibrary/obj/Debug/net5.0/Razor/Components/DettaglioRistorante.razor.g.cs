#pragma checksum "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a746bdbfe00dc46ab29ad661335d3499ab050069"
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
#nullable restore
#line 6 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using DemoMVC.Models.ReqRes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using DemoRazorLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class DettaglioRistorante : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Dettaglio Ristorante ");
#nullable restore
#line 1 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
__builder.AddContent(2, RistoranteCorrente.RestaurantName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                 RistoranteCorrente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                                                       () => OnSalvaForm.InvokeAsync(RistoranteCorrente)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n     ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"RestaurantName\">Nome</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "for", "RestaurantName");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                                                     RistoranteCorrente.RestaurantName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RistoranteCorrente.RestaurantName = __value, RistoranteCorrente.RestaurantName))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RistoranteCorrente.RestaurantName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __Blazor.DemoRazorLibrary.Components.DettaglioRistorante.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 9 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                                   () => RistoranteCorrente.RestaurantName

#line default
#line hidden
#nullable disable
                , 22, "text text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n     ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label for=\"Address\">Indirizzo</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "for", "Address");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                                              RistoranteCorrente.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RistoranteCorrente.Address = __value, RistoranteCorrente.Address))));
                __builder2.AddAttribute(32, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RistoranteCorrente.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __Blazor.DemoRazorLibrary.Components.DettaglioRistorante.TypeInference.CreateValidationMessage_1(__builder2, 34, 35, 
#nullable restore
#line 15 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                                   () => RistoranteCorrente.Address

#line default
#line hidden
#nullable disable
                , 36, "text text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(38, "<button type=\"submit\" class=\"btn btn-info\">OK</button>\r\n    ");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "type", "button");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
                                    () => OnAnnulla.InvokeAsync()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "class", "btn btn-info");
                __builder2.AddContent(43, "Cancella");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\Components\DettaglioRistorante.razor"
       

    [Parameter]
    public RestaurantsListViewModel RistoranteCorrente { get; set; } = new RestaurantsListViewModel();

    [Parameter]
    public EventCallback<RestaurantsListViewModel> OnSalvaForm { get; set; }

    [Parameter]
    public EventCallback OnAnnulla { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DemoRazorLibrary.Components.DettaglioRistorante
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
