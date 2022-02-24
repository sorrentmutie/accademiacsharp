using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVC.Models.Concerti
{
    public class BigliettiContext: DbContext
    {
        public BigliettiContext(
            DbContextOptions<BigliettiContext> opzioni): base(opzioni)
        {

        }

        public DbSet<BigliettoConcerto> Biglietti { get; set; }
    }
}
