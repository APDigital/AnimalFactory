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


    }
    public interface ICareingForAnimals
    {
        bool CanBeGroomed(string name);
        void Groom(string name);

    }

}
