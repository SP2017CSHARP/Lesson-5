using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string Speak()
        {
            return "Woof";
        }

        public override string ToString()
        {
            return $"I am a dog and my name is {Name}";
        }

        
    }
}
