using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    /// <summary>
    /// Water Tank
    /// </summary>
    public class Water_Tank : ICloneable
    {
        /// <summary>
        /// Water tank default parameters
        /// </summary>
        public Water_Tank()
        {
            Dt = 0.1;
            H = 0.65;
            Dout = 0.006;
        }
       
        /// <summary>
        /// Water tank diameter, m
        /// </summary>
        public double Dt
        {
            get { return Dt; }
            set { Dt = value; }
        }

        /// <summary>
        /// Water tank height, m
        /// </summary>
        public double H
        {
            get { return H; }
            set { H = value; }
        }

        /// <summary>
        /// Outfill oricife diameter, m
        /// </summary>
        public double Dout
        {
            get { return Dout; }
            set { Dout = value; }
        }

        /// <summary>
        /// Water tank crass-sectional area, m^2
        /// </summary>
        public double At
        {
            get { return Math.PI * Dt * Dt / 4.0; }
        }

        /// <summary>
        /// Outfill crass-sectional area, m^2
        /// </summary>
        public double Aout
        {
            get { return Math.PI * Dout * Dout / 4.0; }
        }

        /// <summary>
        /// Current water level, m
        /// </summary>
        public double x;


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
