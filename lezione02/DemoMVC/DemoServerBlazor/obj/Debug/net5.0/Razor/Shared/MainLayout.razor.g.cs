#pragma checksum "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a02bb46358323d602228beecd78f63de46fea0"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoServerBlazor.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-p3ji7hkck5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-p3ji7hkck5");
            __builder.OpenComponent<DemoServerBlazor.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-p3ji7hkck5");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-p3ji7hkck5><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-p3ji7hkck5>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-p3ji7hkck5");
#nullable restore
#line 14 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoServerBlazor\Shared\MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
