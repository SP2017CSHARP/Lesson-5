using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Mouse: Animal
    {
        public Mouse(string name) : base(name) { }

        public override string Speak()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"I am a mouse and my name is {Name}";
        }
    }
}
