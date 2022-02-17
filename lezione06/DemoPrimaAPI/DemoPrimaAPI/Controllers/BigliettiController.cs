using DemoPrimaAPI.Interfaces;
using DemoPrimaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DemoPrimaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BigliettiController : ControllerBase
    {
        private readonly IServizioBiglietti servizioBiglietti;

        public BigliettiController(IServizioBiglietti servizioBiglietti)
        {
            this.servizioBiglietti = servizioBiglietti;
        }


        [HttpGet]
        [Produces(typeof(List<BigliettoConcerto>))]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(servizioBiglietti.EstraiBiglietti());
            }
            catch (System.Exception ex)
            {

                return StatusCode(500, ex);
            }
        }


        [HttpGet("{id}", Name = "GetBiglietto")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult GetById(int id)
        {
            try
            {
                var biglietto = servizioBiglietti.EstraiBiglietto(id);

                if (biglietto != null) {
                    return new ObjectResult(biglietto);
                } else
                {
                    return NotFound();
                };
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult PostBiglietto([FromBody] BigliettoConcerto bigliettoConcerto)
        {
            if (bigliettoConcerto == null || bigliettoConcerto?.Id == 0)
            {
                return BadRequest();
            }

            try
            {
                servizioBiglietti.AggiungiBiglietto(bigliettoConcerto);
                //return StatusCode(201, bigliettoConcerto);
                return CreatedAtRoute("GetBiglietto", new { id = bigliettoConcerto.Id }, bigliettoConcerto);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult PutBiglietto([FromBody] BigliettoConcerto bigliettoModificato, int id)
        {
            if(bigliettoModificato == null || bigliettoModificato?.Id != id)
            {
                return BadRequest();
            }

            try
            {
                var esisteBiglietto = servizioBiglietti.ModificaBiglietto(bigliettoModificato);
                if(esisteBiglietto == true)
                {
                    return new NoContentResult();
                } else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }
    
    }
}
