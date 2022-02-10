using System.Collections.Generic;

namespace DemoMVC.Models.Restaurants
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Location> Locations { get; set; } = new List<Location>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public Menu Menu { get; set; } = new Menu();
    }
}

