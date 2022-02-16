﻿using DemoMVC.Filters;
using DemoMVC.Services.Restaurants;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    // [MyFirstFilter]
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantsService restaurantsService;

        public RestaurantsController(IRestaurantsService restaurantsService )
        {
            this.restaurantsService = restaurantsService;
        }

        public IActionResult Index()
        {
            return View(restaurantsService.GetIndexViewModel());
        }
    }
}
