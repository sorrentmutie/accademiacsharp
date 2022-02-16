using DemoMVC.Models.Restaurants.ViewModels;
using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPage.Pages
{
    public class NuovoModel : PageModel
    {
        private readonly IRestaurantsService restaurantsService;

        public NuovoModel(IRestaurantsService restaurantsService)
        {
            this.restaurantsService = restaurantsService;
        }

        [BindProperty]
        public RestaurantsListViewModel Restaurant { get; set; }

        [TempData]
        public string Messaggio { get; set; }


        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {

                return Page();

            } else
            {
                restaurantsService.AddRestaurant(Restaurant);
                Messaggio = $"E' stato aggiunto il ristorante {Restaurant.RestaurantName}";
                return RedirectToPage("Ristoranti");
            }

        
        }

    }
}
