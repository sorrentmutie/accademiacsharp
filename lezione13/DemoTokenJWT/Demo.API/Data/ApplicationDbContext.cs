using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> opzioni): base(opzioni)
        {

        }
    }
}
