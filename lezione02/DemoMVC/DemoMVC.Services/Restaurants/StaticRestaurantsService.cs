using DemoMVC.Models.Restaurants;
using DemoMVC.Models.Restaurants.ExtensionMethods;
using DemoMVC.Models.Restaurants.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Services.Restaurants
{
    public class StaticRestaurantsService : IRestaurantsService
    {
        private List<Restaurant> restaurants = new List<Restaurant>();

        public StaticRestaurantsService()
        {
            restaurants = new  List<Restaurant>
            {
                new Restaurant
                {
                    Id = 10,
                    Nome = "Bella Napoli",
                    Locations = new List<Location> {
                        new Location { Id = 1000, Address = new Address

                            { City = "Milano", PostalCode = "20100", Street = "Piazza Duomo", StreetNumber ="1bis"}
                        } },
                    Reviews = new List<Review> {
                        new Review { Id = 2000, Rating = 8, ReviewerId = 1, Text = "Very nice"},
                        new Review { Id = 2001, Rating = 5, ReviewerId = 2, Text = "Camerieri scortesi"},
                        new Review { Id = 2002, Rating = 10, ReviewerId = 3, Text = "Ottima pizza"}
                    }
                },
                new Restaurant { Id = 2, Nome = "Il Pesto moderno" },
                new Restaurant { Id = 3, Nome = "Vegan Food" }
            };
        }

        public void AddRestaurant(RestaurantsListViewModel restaurant)
        {
            restaurants.Add(new Restaurant { Nome = restaurant.RestaurantName });
        }

        public RestaurantsIndexViewModel GetIndexViewModel()
        {
            return GetRestaurants().ToIndexViewModel();

            //return new RestaurantsIndexViewModel
            //{
            //    OpenRestaurants = restaurants.Count,
            //    Restaurants = restaurants.ToViewModel(),
            //    LastRestaurant = restaurants.OrderByDescending(x => x.Id).ToList().ToViewModel().FirstOrDefault()
            //};
        }

        public RestaurantsListViewModel GetRestaurant(int id)
        {
            var restaurant =  restaurants.FirstOrDefault(x => x.Id == id);
            if (restaurant != null)
            {
                return new RestaurantsListViewModel { RestaurantName = restaurant.Nome, 
                    Address = restaurant.Locations != null && restaurant.Locations.Count > 0 ? restaurant.Locations[0].Address.Street : "" };
            } else
            {
                return null;
            }
        }

        public List<Restaurant> GetRestaurants()
        {
            return restaurants;

        }

        public void UpdateRestaurant(RestaurantsListViewModel restaurant)
        {
            var resta = restaurants.FirstOrDefault(x => x.Id == restaurant.RestaurantId);
            resta.Nome = restaurant.RestaurantName;
        }

        //public List<RestaurantsListViewModel> GetRestaurantsIndexViewModel()
        //{
        //    return GetRestaurants().ToViewModel();            
        //}
    }
}
