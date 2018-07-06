using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlankApp.Factory
{
    public class Insect : Animal
    {
        public Insect(string breed, string animalName, string favouriteFood) : base(breed, animalName)
        {
            FavouriteFood = favouriteFood;
            CanBeGroomed = false;
        }
    }
}