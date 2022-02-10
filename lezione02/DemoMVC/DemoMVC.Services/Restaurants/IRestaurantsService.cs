using DemoMVC.Models.Restaurants;
using System.Collections.Generic;


namespace DemoMVC.Services.Restaurants
{
    public  interface IRestaurantsService
    {
        List<Restaurant> GetRestaurants();
    }
}
