using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Water_Tank_System
{
    /// <summary>
    /// Water Tank
    /// </summary>
    public class Tank : ICloneable
    {
        /// <summary>
        /// Water tank default parameters
        /// </summary>
        public Tank()
        {            
            H = 0.65;
            Dt = 0.1;
            Dout = 0.006;
        }

        /// <summary>
        /// Water tank diameter, m
        /// </summary>
        public double Dt;

        /// <summary>
        /// Water tank height, m
        /// </summary>
        public double H;

        /// <summary>
        /// Outfill oricife diameter, m
        /// </summary>
        public double Dout;

        /// <summary>
        /// Water tank cross-sectional area, m^2
        /// </summary>
        public double At
        {
            get { return Math.PI * Dt * Dt / 4.0; }
        }

        /// <summary>
        /// Outfill cross-sectional area, m^2
        /// </summary>
        public double Aout
        {
            get { return Math.PI * Dout * Dout / 4.0; }
        }

        /// <summary>
        /// Clone
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
