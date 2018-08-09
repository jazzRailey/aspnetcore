using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurant;
        private readonly IGreeter _greeter;

        public HomeController(IRestaurantData restaurant, IGreeter greeter)
        {
            _restaurant = restaurant;
            _greeter = greeter;
        }
        public IActionResult Index() {

            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurant.GetAllRestaurants();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();
            return View(model);
        }

        public IActionResult IndexUsingPartialView() {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurant.GetAllRestaurants();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();
            return View(model);
        }

        public IActionResult Details(int id) {

            var model = _restaurant.Get(id);

            return View(model);
        }
        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
              return RedirectToAction(nameof(Details), new { id = restaurant.Id });
            }else {
                return View();
            }
            
        }
    }
}
