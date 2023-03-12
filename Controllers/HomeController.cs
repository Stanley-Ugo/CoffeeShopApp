using CoffeeShopApp.Models;
using CoffeeShopApp.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfwork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfwork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult HotDrinks()
        {
            List<HotDrink> hotDrinks = new List<HotDrink>();
            try
            {
                hotDrinks = _unitOfwork.HotDrinks.GetAll().ToList();
            }
            catch (Exception ex)
            {

                _logger.LogError("Unable to fetch Hot Drinks" + ex.Message);
            }

            return View(hotDrinks);
        }

        public IActionResult ColdDrinks()
        {
            List<ColdDrink> coldDrinks = new List<ColdDrink>();
            try
            {
                coldDrinks = _unitOfwork.ColdDrinks.GetAll().ToList();
            }
            catch (Exception ex)
            {

                _logger.LogError("Unable to fetch cold Drinks" + ex.Message);
            }

            return View(coldDrinks);
        }

        public IActionResult Food()
        {
            List<Food> food = new List<Food>();
            try
            {
                food = _unitOfwork.Foods.GetAll().ToList();
            }
            catch (Exception ex)
            {

                _logger.LogError("Unable to fetch Food" + ex.Message);
            }

            return View(food);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
