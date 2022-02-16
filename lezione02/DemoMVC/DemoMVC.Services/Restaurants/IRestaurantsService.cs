using DemoMVC.Models.Restaurants;
using DemoMVC.Models.Restaurants.ViewModels;
using System.Collections.Generic;


namespace DemoMVC.Services.Restaurants
{
    public  interface IRestaurantsService
    {
       // List<Restaurant> GetRestaurants();
       // List<RestaurantsListViewModel> GetRestaurantsIndexViewModel();
        RestaurantsIndexViewModel GetIndexViewModel();
        void AddRestaurant(RestaurantsListViewModel restaurant);
        RestaurantsListViewModel GetRestaurant(int id);
        void UpdateRestaurant(RestaurantsListViewModel restaurant);
    }
}
