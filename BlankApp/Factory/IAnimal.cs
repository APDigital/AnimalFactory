using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankApp.Factory
{
    public interface IAnimal
    {
        string Name { get; }
        string GetFavouriteFood(string name);
        bool CanBeGroomed(string name);
        void Groom(string name);


    }
    public abstract class Animal : IAnimal
    {
        public Animal()
        {

        }
        public string Name { get; set; }

        public string FavouriteFood { get; set; }
        public abstract string GetFavouriteFood(string name);

        public abstract bool CanBeGroomed(string name);
        public abstract void Groom(string name);
    }

    public class BigCat : Animal
    {
        public BigCat(string animalName)
        {
            Name = animalName;
        }

        public override bool CanBeGroomed(string name)
        {
            return true;
        }

        public override string GetFavouriteFood(string name)
        {
            Name = name;
            FavouriteFood = "Fish";
            return FavouriteFood;
        }

        public override void Groom(string name) { Name = name; }
    }
    public class Bear : Animal
    {
        public Bear(string animalName)
        {
            Name = animalName;
        }

        public override bool CanBeGroomed(string name)
        {
            return true;
        }

        public override string GetFavouriteFood(string name)
        {
            Name = name;
            FavouriteFood = "Mango";
            return FavouriteFood;
        }

        public override void Groom(string name) { Name = name; }
    }
    public class Insect : Animal
    {
        public Insect(string animalName)
        {
            Name = animalName;
        }

        public override bool CanBeGroomed(string name)
        {
            return false;
        }

        public override string GetFavouriteFood(string name)
        {
            Name = name;
            FavouriteFood = "Other Insects";
            return FavouriteFood;
        }
        public override void Groom(string name) { Name = name; }
    }

}
