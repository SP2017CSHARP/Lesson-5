using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Airplane: Aircraft
    {
        private int NumberOfWings { get; set; }
        public override string EngineSound()
        {
            return "Vroooooom";
        }

        public override string ToString()
        {
            return base.ToString() + $"Number Of Wings: {NumberOfWings}\n";
        }
    }
}
