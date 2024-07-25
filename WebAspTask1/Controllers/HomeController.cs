using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using WebAspTask1.Entities;
using WebAspTask1.Models;

namespace WebAspTask1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //INDEX +
        public IActionResult Index()
        {
            var fastFoods = new List<FastFoods>
            {
                new FastFoods
                {
                    Id = 1,
                    Name = "Burger",
                    Description = "Tasty Black Burger",
                    Price = 5
                },
                new FastFoods
                {
                    Id = 2,
                    Name = "Fries",
                    Description = "Tasty Fries",
                    Price = 2
                },
                new FastFoods
                {
                    Id = 3,
                    Name = "Sezar Salad",
                    Description = "Tasty Sezar Salad",
                    Price = 8
                }
            };

            var hotMeals = new List<HotMeals>
            {
                new HotMeals
                {
                    Id = 1,
                    Name = "Steak",
                    Description = "Tasty Steak",
                    Price = 15
                },
                    new HotMeals
                {
                    Id = 1,
                    Name = "Kabab",
                    Description = "Tasty Kabab",
                    Price = 12
                }
            };

            var drinks = new List<Drinks>
            {
                new Drinks
                {
                    Id = 1,
                    Name = "Coke",
                    Description = "Zero Coke",
                    Price = 2
                },
                new Drinks
                {
                    Id = 2,
                    Name = "Lemonade",
                    Description = "Fresh Lemonade",
                    Price = 3
                }
            };

            var model = new FoodCategoriesViewModel
            {
                FastFoods = fastFoods,
                HotMeals = hotMeals,
                Drinks = drinks
            };

            return View("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //FAST FOODS ADDED
        public IActionResult FastFoods()
        {
            var fastFoods = new List<FastFoods>
            {
                new FastFoods
                {
                    Id = 1,
                    Name = "Burger",
                    Description = "Tasty Black Burger",
                    Price = 5
                },
                new FastFoods
                {
                    Id = 2,
                    Name = "Fries",
                    Description = "Tasty Fries",
                    Price = 2
                },
                new FastFoods
                {
                    Id = 3,
                    Name = "Sezar Salad",
                    Description = "Tasty Sezar Salad",
                    Price = 8
                }
            };

            var model = new FoodCategoriesViewModel
            {
                FastFoods = fastFoods,
                HotMeals = new List<HotMeals>(),
                Drinks = new List<Drinks>()
            };

            return View("FastFoods", model);
        }
        //HOTMEALS ADDED
        public IActionResult HotMeals()
        {
            var hotMeals = new List<HotMeals>
            {
                new HotMeals
                {
                    Id = 1,
                    Name = "Steak",
                    Description = "Tasty Steak",
                    Price = 15
                },
                  new HotMeals
                {
                    Id = 2,
                    Name = "Kabab",
                    Description = "Tasty Kabab",
                    Price = 12
                }
            };

            var model = new FoodCategoriesViewModel
            {
                FastFoods = new List<FastFoods>(),
                HotMeals = hotMeals,
                Drinks = new List<Drinks>()
            };

            return View("HotMeals", model);
        }

        //Drinks ADDED

        public IActionResult Drinks()
        {
            var drinks = new List<Drinks>
            {
                new Drinks
                {
                    Id = 1,
                    Name = "Coke",
                    Description = "Zero Coke",
                    Price = 2
                },
                new Drinks
                {
                    Id = 2,
                    Name = "Lemonade",
                    Description = "Fresh Lemonade",
                    Price = 3
                }
            };

            var model = new FoodCategoriesViewModel
            {
                FastFoods = new List<FastFoods>(),
                HotMeals = new List<HotMeals>(),
                Drinks = drinks
            };

            return View("Drinks", model);
        }
    }
}
