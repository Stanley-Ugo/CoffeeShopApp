using CoffeeShopApp.Extensions;
using CoffeeShopApp.Models;
using CoffeeShopApp.Repository.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfwork;
        private List<Order_Item> order_Items;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfwork = unitOfWork;
            order_Items = new List<Order_Item>();
            
        }

        public IActionResult Index()
        {
            SetOrderItemsInSession(order_Items);

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
                return RedirectToAction("Error", "Home", new { message = ex.Message });
            }

            return View(food);
        }


        public IActionResult AddFoodToOrderItem(int id)
        {
            
            try
            {
                var food = _unitOfwork.Foods.GetById(id);
                if(food == null)
                    return RedirectToAction("Error", "Home", new { message = $"Food item with id: {id} does not exist!!" });

                order_Items = GetOrderItemsFromSession();
                var existingFoodOrdrItem = order_Items.FirstOrDefault(x => x.FoodId == food.Id);
                if (existingFoodOrdrItem != null)
                {
                    existingFoodOrdrItem.Quantity += 1;
                    existingFoodOrdrItem.Foods = food;
                    order_Items.Remove(existingFoodOrdrItem);

                    order_Items.Add(existingFoodOrdrItem);
                    HttpContext.Session.Set("OrderItems", order_Items);

                    return RedirectToAction("Food");
                }

                order_Items.Add(new Order_Item { FoodId = id, Quantity = 1, ItemType = "Food", Foods = food });
                HttpContext.Session.Set("OrderItems", order_Items);
            }
            catch (Exception ex)
            {

                _logger.LogError("Unable to fetch Food" + ex.Message);
                return RedirectToAction("Error", "Home", new { message = "An error occured, please try again!." });

            }

            return RedirectToAction("Food");
        }


        public IActionResult AddColdDrinksToOrderItem(int id)
        {

            try
            {
                var coldDrink = _unitOfwork.ColdDrinks.GetById(id);
                if (coldDrink == null)
                    return RedirectToAction("Error", "Home", new { message = $"Cold Drink item with id: {id} does not exist!!" });

                order_Items = GetOrderItemsFromSession();
                var existingColdDrinksOrdrItem = order_Items.FirstOrDefault(x => x.ColdDrinkId == coldDrink.Id);
                if (existingColdDrinksOrdrItem != null)
                {
                    existingColdDrinksOrdrItem.Quantity += 1;
                    existingColdDrinksOrdrItem.ColdDrinks = coldDrink;
                    order_Items.Remove(existingColdDrinksOrdrItem);

                    order_Items.Add(existingColdDrinksOrdrItem);
                    HttpContext.Session.Set("OrderItems", order_Items);

                    return RedirectToAction("ColdDrinks");
                }

                order_Items.Add(new Order_Item { ColdDrinkId = id, Quantity = 1, ItemType = "Cold Drinks", ColdDrinks = coldDrink });
                HttpContext.Session.Set("OrderItems", order_Items);
            }
            catch (Exception ex)
            {

                _logger.LogError("Unable to fetch Cold Drink" + ex.Message);
                return RedirectToAction("Error", "Home", new { message = "An Error occured, please try again!." });

            }

            return RedirectToAction("ColdDrinks");
        }


        public IActionResult AddHotDrinksToOrderItem(int id)
        {

            try
            {
                var hotDrink = _unitOfwork.HotDrinks.GetById(id);
                if (hotDrink == null)
                    return RedirectToAction("Error", "Home", new { message = $"Hot Drink item with id: {id} does not exist!!" });


                order_Items = GetOrderItemsFromSession();
                var existingHotDrinksOrdrItem = order_Items.FirstOrDefault(x => x.HotDrinkId == hotDrink.Id);
                if (existingHotDrinksOrdrItem != null)
                {
                    existingHotDrinksOrdrItem.Quantity += 1;
                    existingHotDrinksOrdrItem.HotDrinks = hotDrink;
                    order_Items.Remove(existingHotDrinksOrdrItem);

                    order_Items.Add(existingHotDrinksOrdrItem);
                    HttpContext.Session.Set("OrderItems", order_Items);

                    return RedirectToAction("HotDrinks");
                }

                order_Items.Add(new Order_Item { HotDrinkId = id, Quantity = 1, ItemType = "Hot Drink", HotDrinks = hotDrink });
                HttpContext.Session.Set("OrderItems", order_Items);
            }
            catch (Exception ex)
            {

                _logger.LogError("Unable to fetch Hot Drink" + ex.Message);
                return RedirectToAction("Error", "Home", new { message = "An error occured, please try again!." });

            }

            return RedirectToAction("HotDrinks");
        }

        public IActionResult ViewOrderItems()
        {
            Random random = new Random();
            int orderId = random.Next(1000, 100000);
            var viewToDsplay = new List<Order_Item>();

            decimal totalFoodPrice = 0.0m;
            int totalFoodQuantity = 0;

            decimal totalColdDrinkPrice = 0.0m;
            int totalColdDrinkQuantity = 0;

            decimal totalHotDrinkPrice = 0.0m;
            int totalHotDrinkQuantity = 0;

            var orderItems = GetOrderItemsFromSession();
            if (!orderItems.Any())
                return RedirectToAction("Error", "Home", new { message = "Order item(s) currently empty, please select items and try again!." });

            foreach (var orders in orderItems)
            {
                if (orders.ItemType.Equals("Food", StringComparison.OrdinalIgnoreCase))
                {
                    totalFoodPrice += orders.Foods.Price * orders.Quantity;
                    totalFoodQuantity += orders.Quantity;
                }

                if (orders.ItemType.Equals("Cold Drinks", StringComparison.OrdinalIgnoreCase))
                {
                    totalColdDrinkPrice += orders.ColdDrinks.Price * orders.Quantity; ;
                    totalColdDrinkQuantity += orders.Quantity;
                }

                if (orders.ItemType.Equals("Hot Drink", StringComparison.OrdinalIgnoreCase))
                {
                    totalHotDrinkPrice += orders.HotDrinks.Price * orders.Quantity;
                    totalHotDrinkQuantity += orders.Quantity;
                }

            }
            viewToDsplay.Add(new Order_Item { FoodId = 1, ItemType = "Food", Quantity = totalFoodQuantity, OrderId = orderId, Foods = new Food { Price = totalFoodPrice } });
            viewToDsplay.Add(new Order_Item { HotDrinkId = 2, ItemType = "Hot Drinks", Quantity = totalHotDrinkQuantity, OrderId = orderId, HotDrinks =  new HotDrink { Price = totalHotDrinkPrice }  });
            viewToDsplay.Add(new Order_Item { ColdDrinkId = 3, ItemType = "Cold Drinks", Quantity = totalColdDrinkQuantity, OrderId = orderId, ColdDrinks = new ColdDrink { Price = totalColdDrinkPrice } });

            return View(viewToDsplay);
        }
        public IActionResult CheckOut(string email, string address, string name, string phone, int orderId, decimal totalPrice )
        {
            var newUser = new Users { Address = address, Email = email, Name = name, Phone = phone };
            var insertedUsder = _unitOfwork.Users.AddUser(newUser);
            _unitOfwork.Complete();

            var newOrder = new Order { OrderDate = DateTime.Now, TotalCost = totalPrice, UserId = insertedUsder.Id, Users = insertedUsder, OderId = orderId };
            _unitOfwork.Orders.Add(newOrder);
            _unitOfwork.Complete();

            return View(newOrder);
        }

        public IActionResult OrderHistory()
        {
            var orderHistory = _unitOfwork.Orders.Find(x => x.OrderDate.Date == DateTime.Now.Date).ToList();
            foreach (var item in orderHistory)
            {
                item.Users = _unitOfwork.Users.GetById(item.UserId);
            }

            return View(orderHistory);
        }
        
        private List<Order_Item> GetOrderItemsFromSession()
        {
            var items = HttpContext.Session.Get<List<Order_Item>>("OrderItems");
            return items ?? new List<Order_Item>();
        }

        private void SetOrderItemsInSession(List<Order_Item> items)
        {
            HttpContext.Session.Set("OrderItems", items);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string message)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier, Message = message });
        }
    }
}
