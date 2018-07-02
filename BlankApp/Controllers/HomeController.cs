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
            return View(model);
        }
        public ActionResult Index(LoginViewModel model)
        {
            string animalSelected = string.Empty;
            string name = string.Empty;
            IAnimal food;
            if (model.Animal == "1")
            {
                name = "Tigger";
                food = AnimalFactory.GetAnimalFavourtieFood(AnimalBreed.BigCat, name);
                animalSelected = "Tiger";
            }
            else if (model.Animal == "2")
            {
                name = "Winnie";
                food = AnimalFactory.GetAnimalFavourtieFood(AnimalBreed.Bear, name);
                animalSelected = "Brown Bear";
            }
            else
            {
                name = "Queenie";
                food = AnimalFactory.GetAnimalFavourtieFood(AnimalBreed.Insect, name);
                animalSelected = "Insect";
            }
            string.Format("The Animal {0} was selected, it's name is {1}, and it's favourite food is {2}", animalSelected, name, food.ToString());
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
    }
}