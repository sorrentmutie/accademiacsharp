using System;
using System.Collections.Generic;

namespace DemoMVC.Models.Restaurants.ViewModels
{
    public class RestaurantsIndexViewModel
    {
        public RestaurantsListViewModel LastRestaurant { get; set; } = new RestaurantsListViewModel();
        public List<RestaurantsListViewModel> Restaurants { get; set; } = new List<RestaurantsListViewModel>();
        public int OpenRestaurants { get; set; }
    }
}
