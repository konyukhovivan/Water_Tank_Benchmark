using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Water_Tank_System
{
    public class Model_View
    {
        public Model_View (Model iP)
        {
            P = iP;
        }

        public Model P;

        #region Water Tank Parameters

        [DisplayName("H")]
        [Description("Water tank height, m")]
        [Category("1. Tank parameters")]
        public double H
        {
            get { return P.Tank.H; }
            set { P.Tank.H = value; }
        }

        [DisplayName("Dt")]
        [Description("Water tank diameter, m")]
        [Category("1. Tank parameters")]
        public double Dt
        {
            get { return P.Tank.Dt; }
            set { P.Tank.Dt = value; }
        }

        [DisplayName("Dout")]
        [Description("Outfill oricife diameter, m")]
        [Category("1. Tank parameters")]
        public double Dout
        {
            get { return P.Tank.Dout; }
            set { P.Tank.Dout = value; }
        }

        [DisplayName("At")]
        [Description("Water tank cross-sectional area, m²")]
        [Category("1. Tank parameters")]
        public double At
        {
            get { return P.Tank.At; }            
        }

        [DisplayName("Aout")]
        [Description("Outfill cross-sectional area, m²")]
        [Category("1. Tank parameters")]
        public double Aout
        {
            get { return P.Tank.Aout; }
        }

        #endregion Water Tank Parameters

        #region Water Pump Parameters

        [DisplayName("Kp")]
        [Description("Pumping coefficient,  m³ / (V·s)")]
        [Category("2. Pump parameters")]
        public double Kp
        {
            get { return P.Pump.Kp; }            
        }

        [DisplayName("Umin")]
        [Description("Minimum voltage of the pump,  V")]
        [Category("2. Pump parameters")]
        public double U_min
        {
            get { return P.Pump.U_min; }
            //set { P.Pump.U_min = value; }
        }

        [DisplayName("Umax")]
        [Description("Maximum voltage of the pump,  V")]
        [Category("2. Pump parameters")]
        public double U_max
        {
            get { return P.Pump.U_max; }
            set { P.Pump.U_max = value; }
        }

        [DisplayName("Qmax")]
        [Description("Maximum flow rate of pump, m³ / s")]
        [Category("2. Pump parameters")]
        public double Q_max
        {
            get { return P.Pump.q_max; }
            set { P.Pump.q_max = value; }
        }

        #endregion Water Pump Parameters

        #region Pump Controller

        [DisplayName("Td")]
        [Description("Delay of the controller,  ms")]
        [Category("3. Controller parameters")]
        public int T_del
        {
            get { return P.Controller.delay; }
            set { P.Controller.delay = value; }
        }

        #endregion Pump Controller

        #region Physical Constants

        [DisplayName("g")]
        [Description("Gravitaional acceleration,  m / s²")]
        [Category("Physical constants")]
        public double g
        {
            get { return P.g; }            
        }

        [DisplayName("α out")]
        [Description("Torricelli's coefficient")]
        [Category("Physical constants")]
        public double Alpha_out
        {
            get { return P.Alpha_out; }            
        }

        #endregion Water Pump Parameters
    }
}
