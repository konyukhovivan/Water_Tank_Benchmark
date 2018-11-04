using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    /// <summary>
    /// Water pumping
    /// </summary>
    public class Pump : ICloneable
    {
        /// <summary>
        /// Pump default parameters
        /// </summary>
        public Pump()
        {
            Turned_On= false;
            U_min = 0;
            U_max = 12.0;
            q_max = 100 * Math.Pow(10, -6);            
        }

        /// <summary>
        /// Pumping coefficient,  m^3 / (V s)
        /// </summary>
        public double Kp
        {
            get { return q_max / U_max; }
        }
        
        /// <summary>
        /// Minimum voltage,  V
        /// </summary>
        public double U_min;

        /// <summary>
        /// Maximum voltage,  V
        /// </summary>
        public double U_max;
        
        /// <summary>
        /// Maximum flow rate of pump, m^3/s
        /// </summary>
        public double q_max;

        /// <summary>
        /// Is the pump turned On?
        /// </summary>
        public bool Turned_On;

        /// <summary>
        /// Clone
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
