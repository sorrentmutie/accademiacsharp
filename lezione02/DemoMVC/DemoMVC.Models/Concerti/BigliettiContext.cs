using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models.Concerti
{
    public class BigliettiContext: DbContext
    {
        public BigliettiContext(
            DbContextOptions<BigliettiContext> opzioni): base(opzioni)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BigliettoConcerto> Biglietti { get; set; }
        public DbSet<Artista> Artisti { get; set; }
        public DbSet<DataTour> DateTour { get; set; }
    }
}
