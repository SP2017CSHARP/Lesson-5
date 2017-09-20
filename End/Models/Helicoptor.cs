using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Helicoptor: Aircraft
    {
        public int Blades { get; set; }
        public bool CanLandOnWater { get; set; }
        public string Name { get; set; }
        public int SpeedInKM { get; set; }
        public int YearProduced { get; set; }

        public string EngineSound()
        {
            return "chuka chuka chuka";
        }

        public override string ToString()
        {
            return base.ToString() + " Blades:" + Blades + " LandsOnWater:" + CanLandOnWater.ToString();
        }
    }
}
