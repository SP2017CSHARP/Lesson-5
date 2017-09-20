using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Mouse: Animal
    {
        public Mouse(string name) : base(name) { }

        public override string Speak()
        {
            return "Squeek";
        }

        public override string ToString()
        {
            return $"I am a hamster and my name is {Name}";
        }
    }
}
