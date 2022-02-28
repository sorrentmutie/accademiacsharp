using System.Collections.Generic;

namespace DemoMVC.Models.Concerti
{
    public class Artista
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public ICollection<DataTour> DateTour { get; set; }
    }
}