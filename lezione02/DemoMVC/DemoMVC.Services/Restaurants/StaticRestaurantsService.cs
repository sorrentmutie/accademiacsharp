using DemoMVC.Models.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Services.Restaurants
{
    public class StaticRestaurantsService : IRestaurantsService
    {
        public List<Restaurant> GetRestaurants()
        {
            return new List<Restaurant>
            {
                new Restaurant {Id = 1, Nome ="Bella Napoli"},
                new Restaurant {Id = 2, Nome ="Il Pesto moderno"},
                new Restaurant {Id = 3, Nome ="Vegan Food"}
            };
        }
    }
}
