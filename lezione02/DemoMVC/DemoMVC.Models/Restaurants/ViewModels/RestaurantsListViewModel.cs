using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Models.Restaurants.ViewModels
{
    public class RestaurantsListViewModel
    {
        public int RestaurantId { get; set; }
        [Display(Name = "Nome Ristorante")]
        [Required(ErrorMessage = "Il nome è obbligatorio")]
        [MaxLength(20, ErrorMessage = "Il nome può essere al massimo di {0} caratteri")]
        public string RestaurantName { get; set;}
        public int LocationsCount { get; set; }
        public int ReviewsCount { get; set; }
        public double AverageRating { get; set; }
        public int MenuCount { get; set; }
        public double PriceAverge { get; set; }
        [Display(Name = "Indirizzo")]
        [Required(ErrorMessage = "L'indirizzo è obbligatorio")]
        public string Address { get; set; }

    }
}
