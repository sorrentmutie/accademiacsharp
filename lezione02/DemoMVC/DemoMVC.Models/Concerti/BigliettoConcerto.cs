using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Models.Concerti
{
    public class BigliettoConcerto
    {
        public int Id { get; set; }
        public string Artista { get; set; }
        public int Prezzo { get; set; }
        public bool Disponibile { get; set; }
    }
}
