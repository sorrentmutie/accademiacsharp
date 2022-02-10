using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Models.Restaurants.ViewModels
{
    public class RestaurantsListViewModel
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set;}
        public int LocationsCount { get; set; }
        public int ReviewsCount { get; set; }
        public double AverageRating { get; set; }
        public int MenuCount { get; set; }
        public double PriceAverge { get; set; }
        public string Address { get; set; }

    }
}
