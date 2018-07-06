using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlankApp.Factory
{
    public static class AnimalFactory
    {
        public static Animal GetAnimalsFavouriteFood(string breed, string animalName)
        {
            return new Animal(breed, animalName);
        }
    }
}