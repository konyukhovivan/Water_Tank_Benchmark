using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    /// <summary>
    /// Pump controller
    /// </summary>
    public class Controller : ICloneable
    {
        public Controller()
        {
            Turned_On = true;
            delay = 50;
        }

        /// <summary>
        /// Controller delay, ms
        /// </summary>
        public int delay;

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
