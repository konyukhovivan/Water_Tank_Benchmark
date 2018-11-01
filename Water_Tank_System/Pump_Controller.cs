using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    public class Pump_Controller : ICloneable
    {
        public Pump_Controller()
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
