using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Cat: Animal
    {
        public override string Speak()
        {
            return "Meow";
        }

        public Cat(string name) : base(name) { }

        public override string ToString()
        {
            return $"I am a cat and my name is: {Name}";
        }
    }
}
