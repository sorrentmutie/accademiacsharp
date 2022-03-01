using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondoTest.ViewModels
{
    public  class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }

    public class ProductCreateViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
