using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlankApp.Factory
{
    public enum AnimalBreed
    {
        BigCat,
        Bear,
        Insect
    }
    public static class AnimalFactory
    {
        public static IAnimal GetAnimalFavourtieFood(AnimalBreed breed, string animalName)
        {
            switch (breed)
            {
                case AnimalBreed.BigCat:
                    return new BigCat(animalName);
                case AnimalBreed.Bear:
                    return new Bear(animalName);
                case AnimalBreed.Insect:
                    return new Insect(animalName);
                default:
                    return null;
            }
        }
    }
}