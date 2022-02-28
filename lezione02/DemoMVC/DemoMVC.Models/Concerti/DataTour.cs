using System;

namespace DemoMVC.Models.Concerti
{
    public class DataTour
    {
        public int Id { get; set; }
        public string Indirizzo { get; set; }
        public DateTime Data { get; set; }
        public int ArtistaId { get; set; }
    }
}