using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondoTestDatabaseFirst.ViewModels
{
    public  class CategoryDetails
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }
}
