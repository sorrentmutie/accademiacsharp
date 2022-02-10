using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantsService restaurantsService;

        public RestaurantsController(IRestaurantsService restaurantsService )
        {
            this.restaurantsService = restaurantsService;
        }

        public IActionResult Index()
        {
            //return new ObjectResult(GetRestaurants());
            return View(restaurantsService.GetRestaurants());
        }



        //private List<Restaurant> GetRestaurants()
        //{
        //    return new List<Restaurant>
        //    {
        //        new Restaurant {Id = 1, Nome ="Bella Napoli"},
        //        new Restaurant {Id = 2, Nome ="Il Pesto moderno"},
        //        new Restaurant {Id = 3, Nome ="Vegan Food"}

        //    };
        //}

    }
}
