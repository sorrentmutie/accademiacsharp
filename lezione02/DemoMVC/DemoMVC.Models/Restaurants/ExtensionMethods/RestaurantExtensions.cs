using DemoMVC.Models.Restaurants.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Models.Restaurants.ExtensionMethods
{
    public static  class RestaurantExtensions
    {
        public static string GetAddressString(this Address address)
        {
            return $"{address.Street} {address.StreetNumber} {address.City} {address.PostalCode}";
        }

        public static List<RestaurantsListViewModel> ToViewModel(this List<Restaurant> restaurants)
        {
            return restaurants.Select(restaurant => new RestaurantsListViewModel
            {
                RestaurantId = restaurant.Id,
                RestaurantName = restaurant.Nome,
                LocationsCount = restaurant.Locations.Count,
                Address = restaurant.Locations.FirstOrDefault()?.Address.GetAddressString(),
                ReviewsCount = restaurant.Reviews.Count,
                MenuCount = restaurant.Menu.Pietanze.Count,
                PriceAverge = restaurant.Menu.Pietanze.Count > 0 ? (double)restaurant.Menu.Pietanze.Average(r => r.Prezzo) : 0.0,
                AverageRating = restaurant.Reviews.Count > 0 ? restaurant.Reviews.Average(r => r.Rating) : 0.0
            }).ToList();
        }

        public static RestaurantsIndexViewModel ToIndexViewModel(this List<Restaurant> restaurants)
        {
            return new RestaurantsIndexViewModel
            {
                OpenRestaurants = restaurants.Count,
                Restaurants = restaurants.ToViewModel(),
                LastRestaurant = restaurants.OrderByDescending(x => x.Id).ToList().ToViewModel().FirstOrDefault()
            };
        }


    }
}
