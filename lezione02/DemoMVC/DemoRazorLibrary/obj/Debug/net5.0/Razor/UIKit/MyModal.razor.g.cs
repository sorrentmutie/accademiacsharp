#pragma checksum "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2674d5b158ce3e17ea85a113e9023b5381c5fb4"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoRazorLibrary.UIKit
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
    public partial class MyModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal");
            __builder.AddAttribute(2, "id", 
#nullable restore
#line 1 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor"
                        Id

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "modal-dialog");
            __builder.AddAttribute(5, "role", "document");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-content");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-header");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "modal-title");
#nullable restore
#line 5 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor"
__builder.AddContent(12, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n      ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-body");
            __builder.OpenElement(16, "p");
#nullable restore
#line 8 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor"
__builder.AddContent(17, Content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n      ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-footer");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor"
                                        OnSave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddContent(25, "Save changes");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor"
                                        OnClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-secondary");
            __builder.AddAttribute(31, "data-dismiss", "modal");
            __builder.AddContent(32, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorLibrary\UIKit\MyModal.razor"
       
    [Parameter] public string Id { get; set; }
    [Parameter] public string Title { get; set; }
    [Parameter] public string Content { get; set; }
    [Parameter] public EventCallback OnSave { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
