using BlankApp.Factory;
using BlankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login(string returnUrl, string errorMessage)
        {
            var model = new LoginViewModel();
            model.AnimalList = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text ="Tiger"},
                new SelectListItem{Value = "2", Text ="Brown Bear"},
                new SelectListItem{Value = "3", Text ="Bee"}
            };
            model.AvailableAnimals = RetrieveAnimals(); 
            return View(model);
        }

        public ActionResult Index(LoginViewModel model)
        {
            Animal animal = AnimalListItem(model);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private Animal AnimalListItem(LoginViewModel model)
        {
            return AnimalFactory.GetAnimalsFavouriteFood(model.Animal, model.AnimalName);
        }
    }
}