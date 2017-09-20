using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class PetStore
    {
        public List<Animal> Animals { get; set; }

        public PetStore()
        {
            Animals = new List<Animal>
            {
                new Dog("Dusty"),
                new Cat("Charlie"),
                new Mouse("Greg")
            };
        }

        public string StoreNoise()
        {
            string noise = "";

            foreach (Animal a in Animals)
            {
                noise += $"{a.Name} says: {a.Speak()}" + Environment.NewLine;
            }

            return noise;
        }

        public string GetAllAnimalTypes()
        {
            string returnString = "";
            foreach (Animal a in Animals)
            {
                returnString += $"{a.Name} is a: {a.GetType().Name}" + Environment.NewLine;
            }

            return returnString; 
        }




    }
}
