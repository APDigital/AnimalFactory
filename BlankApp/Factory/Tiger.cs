using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlankApp.Factory
{
    public class Tiger: Animal
    {
        public Tiger(string breed, string animalName, string favouritefood):base(breed, animalName)
        {
            FavouriteFood = favouritefood;
            CanBeGroomed = true;
        }
    }
}