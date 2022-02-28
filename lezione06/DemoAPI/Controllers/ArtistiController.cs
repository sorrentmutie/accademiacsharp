using DemoMVC.Models.Concerti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistiController : ControllerBase
    {
        private readonly BigliettiContext database;

        public ArtistiController(BigliettiContext database)
        {
            this.database = database;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtistById(int id)
        {
            return Ok(await database.Artisti.Include(a => a.DateTour).FirstOrDefaultAsync(a => a.Id == id ));
        }


        [HttpPost] 
        public async Task<IActionResult> PostArtista([FromBody] Artista nuovoArtista)
        {
            database.Artisti.Add(nuovoArtista);
            await database.SaveChangesAsync();

            return Ok(nuovoArtista);
        }

    }
}
