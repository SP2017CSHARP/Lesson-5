using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Animal
    {
        public string Name { get; set; }

        public Animal() { }

        public Animal(string animalName)
        {
            this.Name = animalName;
        }

        public virtual string Speak()
        {
            return "No sound known";
        }

    }
}
