using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlankApp.Factory
{
    public class RetrieveAnimals
    {
        public List<Tiger> ListOfTigers { get; set; }
        public List<Bear> ListOfBears { get; set; }
        public List<Insect> ListOfInsects { get; set; }
        public void GetAvailableAnimalsByClass<T>(string breed) where T : Animal
        {
            
            if (breed == "Tiger")
            {
                Tiger tigger = new Tiger(breed, "Tigger", "Fish");
                ListOfTigers.Add(tigger);
            }
            else if (breed == "Bear")
            {
                Bear Winnie = new Bear(breed, "Winnie", "Honey");
                ListOfBears.Add(Winnie);
            }
            else
            {
                Insect Queenie = new Insect(breed, "Queenie", "Nectar");
                ListOfInsects.Add(Queenie);
            }
        }
    }
}