using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp.Factory
{
    public interface IAnimal
    {
    }
    public abstract class Animal : IAnimal
    {
        public Animal()
        {

        }
        public string Name { get; set; }
        public string FavouriteFood { get; set; }
        public abstract string GetFavouriteFood(string name);
    }

    public class BigCat : Animal
    {
        public BigCat(string animalName)
        {
            Name = animalName;
        }
        
        public override string GetFavouriteFood(string name)
        {
            Name = name;
            FavouriteFood = "Fish";
            return FavouriteFood;
        }
    }
    public class Bear : Animal
    {
        public Bear(string animalName)
        {
            Name = animalName;
        }

        public override string GetFavouriteFood(string name)
        {
            Name = name;
            FavouriteFood = "Mango";
            return FavouriteFood;
        }
    }
    public class Insect : Animal
    {
        public Insect(string animalName)
        {
            Name = animalName;
        }

        public override string GetFavouriteFood(string name)
        {
            Name = name;
            FavouriteFood = "Other Insects";
            return FavouriteFood;
        }
    }

}
