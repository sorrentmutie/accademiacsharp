using DemoMVC.Models.Restaurants.ViewModels;
using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RistorantiController : ControllerBase
    {
        private readonly IRestaurantsService restaurantsService;

        public RistorantiController(IRestaurantsService restaurantsService)
        {
            this.restaurantsService = restaurantsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new ObjectResult(restaurantsService.GetIndexViewModel());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var restaurant = restaurantsService.GetRestaurant(id);
            if(restaurant == null)
            {
                return NotFound();
            } else
            {
                return new ObjectResult(restaurant);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] RestaurantsListViewModel nuovoRistorante)
        {
            restaurantsService.AddRestaurant(nuovoRistorante);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] RestaurantsListViewModel ristoranteModificato)
        {
            restaurantsService.UpdateRestaurant(ristoranteModificato);
            return new NoContentResult();
        }

    }
}
