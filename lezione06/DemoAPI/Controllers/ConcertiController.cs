using DemoMVC.Models.Concerti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcertiController : ControllerBase
    {
        private readonly BigliettiContext database;

        public ConcertiController(BigliettiContext database)
        {
            this.database = database;
        }


        [HttpGet]
        public async Task<IActionResult> GetBigliettiAsync()
        {
            var biglietti = await database.Biglietti.ToListAsync();
            return Ok(biglietti);
        }


        [HttpGet("/artista/{NomeArtista}")]
        public async Task<IActionResult> GetBigliettiByArtista(string NomeArtista)
        {
           
            var biglietti = await database.Biglietti.Where(b => b.Artista.ToUpper().Contains(NomeArtista.ToUpper())).ToListAsync();
            if (biglietti.Count == 0) return NotFound();
            return Ok(biglietti);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetBigliettiByIdAsync(int id)
        {
           // var biglietto = await database.Biglietti.FindAsync(id);

            var biglietto = await database.Biglietti.FirstOrDefaultAsync(b => b.Id == id);
            if (biglietto == null) return NotFound();
            return Ok(biglietto);
        }


        [HttpPost]
        public async Task<IActionResult> PostAsync(BigliettoConcerto biglietto)
        {
            database.Biglietti.Add(biglietto);
            await database.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] BigliettoConcerto bigliettoModificato)
        {
            var bigliettoDb = await database.Biglietti.FindAsync(id);
            if (bigliettoDb == null) return NotFound();
            database.Entry(bigliettoDb).State = EntityState.Detached;
            database.Attach(bigliettoModificato);
            database.Entry(bigliettoModificato).State = EntityState.Modified;
            await database.SaveChangesAsync();
            return NoContent();

        }


    }
}
