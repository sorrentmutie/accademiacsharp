#pragma checksum "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ae8fc260f704616a1f096bbad801eb7db7c354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DemoRazorPage.Pages.Pages_Ristoranti), @"mvc.1.0.razor-page", @"/Pages/Ristoranti.cshtml")]
namespace DemoRazorPage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\_ViewImports.cshtml"
using DemoRazorPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ae8fc260f704616a1f096bbad801eb7db7c354", @"/Pages/Ristoranti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9726daee666ca82676714b25a3f6515f8735ff1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ristoranti : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Modifica", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Nuovo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-large btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
 if(Model.ShowMessage){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        ");
#nullable restore
#line 6 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
   Write(Model.Messaggio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
 if (Model.HasRestaurants)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Ristoranti: ");
#nullable restore
#line 12 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
               Write(Model.Restaurants.Restaurants.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <table class=\"table table-striped table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 16 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
               Write(Html.DisplayNameFor(r => r.Restaurants.Restaurants[0].RestaurantName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Address</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 22 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
             foreach(var restaurant in @Model.Restaurants.Restaurants)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
                   Write(restaurant.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
                   Write(restaurant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5ae8fc260f704616a1f096bbad801eb7db7c3546851", async() => {
                WriteLiteral(" Modifica");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
                                                 WriteLiteral(restaurant.RestaurantId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 34 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"

} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text text-danger\">Non ci sono ristoranti</h3>\r\n");
#nullable restore
#line 38 "E:\corsi\insiel\demos\lezione02\DemoMVC\DemoRazorPage\Pages\Ristoranti.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5ae8fc260f704616a1f096bbad801eb7db7c3549873", async() => {
                WriteLiteral("Aggiungi Un ristorante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoRazorPage.Pages.RistorantiModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DemoRazorPage.Pages.RistorantiModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DemoRazorPage.Pages.RistorantiModel>)PageContext?.ViewData;
        public DemoRazorPage.Pages.RistorantiModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
