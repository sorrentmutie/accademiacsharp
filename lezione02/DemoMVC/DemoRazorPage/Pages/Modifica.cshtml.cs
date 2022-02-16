using DemoMVC.Models.Restaurants.ViewModels;
using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorPage.Pages
{
    public class ModificaModel : PageModel
    {
        private readonly IRestaurantsService restaurantsService;

        [BindProperty]
        public RestaurantsListViewModel Restaurant { get; set; } = new RestaurantsListViewModel();


        [TempData]
        public string Messaggio { get; set; }

        public ModificaModel(IRestaurantsService restaurantsService)
        {
            this.restaurantsService = restaurantsService;
        }


        public void OnGet(int? id)
        {
            if (id.HasValue)
            {
                Restaurant = restaurantsService.GetRestaurant(id.Value);
                Restaurant.RestaurantId = id.Value;
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                restaurantsService.UpdateRestaurant(Restaurant);
                Messaggio = $"E' stato modificato il ristorante {Restaurant.RestaurantName}";
                return RedirectToPage("Ristoranti");
            } else
            {
                return Page();
            }
        }

    }
}
