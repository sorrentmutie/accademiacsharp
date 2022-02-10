using System.Collections.Generic;

namespace DemoMVC.Models.Restaurants
{
    public class Menu
    {
        public List<Pietanza> Pietanze { get; set; } = new List<Pietanza>();
    }
}