using DemoMVC.Models.Restaurants.ViewModels;
using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPage.Pages
{
    public class RistorantiModel : PageModel
    {
        private readonly IRestaurantsService restaurantsService;
        public RestaurantsIndexViewModel Restaurants { get; set; } = new RestaurantsIndexViewModel();
        public bool HasRestaurants { get; set; }

        public bool ShowMessage => !string.IsNullOrEmpty(Messaggio);


        [TempData]
        public string Messaggio { get; set; }

        public RistorantiModel(IRestaurantsService restaurantsService)
        {
            this.restaurantsService = restaurantsService;
        }

        public void OnGet()
        {
            Restaurants = restaurantsService.GetIndexViewModel();
            HasRestaurants = Restaurants.Restaurants.Count > 0;
        }
    }
}
