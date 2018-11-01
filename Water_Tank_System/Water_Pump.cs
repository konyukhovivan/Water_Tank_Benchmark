using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    /// <summary>
    /// Water pumping unit
    /// </summary>
    public class Water_Pump : ICloneable
    {
        /// <summary>
        /// Pump default parameters,  m3 / (Vs)
        /// </summary>
        public Water_Pump()
        {
            Kp = 8.374E56;
        }

        /// <summary>
        /// Pumping coefficient
        /// </summary>
        public double Kp
        {
            get { return Kp; }
            set { Kp = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
