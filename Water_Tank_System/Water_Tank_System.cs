using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    public class Water_Tank_System : ICloneable
    {
        public Water_Tank_System()
        {
            Tank = new Water_Tank();
            Pump = new Water_Pump();
            Controller = new Pump_Controller();
        }

        Water_Tank Tank
        {
            get { return Tank; }
            set { Tank = value; }
        }

        Water_Pump Pump
        {
            get { return Pump; }
            set { Pump = value; }
        }

        Pump_Controller Controller
        {
            get { return Controller; }
            set { Controller = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
