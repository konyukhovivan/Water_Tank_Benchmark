using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_System
{
    public class Model : ICloneable
    {
        public Tank Tank;
        public Pump Pump;
        public Controller Controller;

        public Model()
        {
            Tank = new Tank();
            Pump = new Pump();
            Controller = new Controller();

            x_min = 0.1;
            x_max = 0.5;
            x_0 = 0.2;
            x_d = 0.3;                     

            Reset();
        }

        public void Reset()
        {
            t = 0;
            x = x_0;            
        }

         /// <summary>
        /// Time step, s
        /// </summary>
        public double h_t
        {
            get { return Controller.delay / 1000.0; }
        }

        /// <summary>
        /// Current time, s
        /// </summary>
        public double t;
        
        /// <summary>
        /// Current water level, m
        /// </summary>
        public double x;

        /// <summary>
        /// Initial water level, m
        /// </summary>
        public double x_0;

        /// <summary>
        /// Current desired water level, m
        /// </summary>
        public double x_d;

        /// <summary>
        /// Minimum water level, m
        /// </summary>
        public double x_min;

        /// <summary>
        /// Maximum water level, m
        /// </summary>
        public double x_max;
       

        public void Compute_Next_Step()
        {
            //X_i_to_X_im1();

            x += h_t / Tank.At * (Pump.Kp * 0/*Controller.GetU()*/ - Alpha_out * Tank.Aout * Math.Sqrt(2 * g * x));
            t += h_t;

            if (x < 0) x = 0;
            if (x > Tank.H) x = Tank.H;            
        }

        /// <summary>
        /// Gravitational acceleration, m/s^2
        /// </summary>
        public double g
        {
            get { return 9.81; }
        }

        /// <summary>
        /// Torricelli's coefficient
        /// </summary>
        public double Alpha_out
        {
            get { return 0.7; }
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
