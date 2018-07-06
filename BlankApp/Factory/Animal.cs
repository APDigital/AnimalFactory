using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlankApp.Factory
{
    public class Animal
    {
        public Animal(string breed, string animalName)
        {
            switch (breed)
            {
                case "3":
                    Breed = "Insect";
                    break;
                case "2":
                    Breed = "Bear";
                    break;
                default:
                    Breed = "Tiger";
                    break;
            }
            Name = animalName;
            GetFavouriteFood();
            if (CanBeGroomed == true)
            {
                Groom();
            }
        }
        public string Name { get; set; }
        public string Breed { get; set; }

        public string FavouriteFood { get; set; }
        public string GetFavouriteFood() { return FavouriteFood; }

        public bool CanBeGroomed { get; set; }
        public void Groom()
        {
            //do grooming stuff 
        }
    }
}