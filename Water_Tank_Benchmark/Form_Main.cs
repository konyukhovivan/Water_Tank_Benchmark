using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Water_Tank_System;

namespace Water_Tank_Benchmark
{
    public partial class form_Main : Form
    {
        private form_About frm_about;
        private form_Settings frm_set;

        private Model m;

        private Computing_States st;
        private bool Draw_Yes_No = true;

        public form_Main()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();

            m = new Model();
            set_initial_condition();

            frm_about = new form_About();
            frm_set = new form_Settings();
        }

        private void set_initial_condition()
        {
            m.Reset();
            trackBar_Xd.Value = (int)Math.Round((m.x_d - m.x_min) / (m.x_max - m.x_min) * 100);
            st = Computing_States.Initial;
            Clear_Graphs();
            Plot_Graphs();
            update_chart_parameters();
        }

        private void update_chart_parameters()
        {
            chart_Characteristics.ChartAreas[0].AxisX.Minimum = 0;
            chart_Characteristics.ChartAreas[0].AxisX.Maximum = (int)numericUpDown_Tmax.Value;
            chart_Characteristics.ChartAreas[0].AxisY.Minimum = 0;
            chart_Characteristics.ChartAreas[0].AxisY.Maximum = m.Tank.H;
            chart_Characteristics.ChartAreas[0].AxisY2.Minimum = 0;
            chart_Characteristics.ChartAreas[0].AxisY2.Maximum = m.Pump.U_max;

            chart_Characteristics.Series[2].Points.Clear();
            chart_Characteristics.Series[3].Points.Clear();
            chart_Characteristics.Series[2].Points.AddXY(0, m.x_min);
            chart_Characteristics.Series[2].Points.AddXY((int)numericUpDown_Tmax.Value, m.x_min);
            chart_Characteristics.Series[3].Points.AddXY(0, m.x_max);
            chart_Characteristics.Series[3].Points.AddXY((int)numericUpDown_Tmax.Value, m.x_max);

            Refresh();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about.ShowDialog();
            Refresh();
        }

        private void toolStripMenuItem_Model_Parameters_Click(object sender, EventArgs e)
        {
            frm_set.Show_Settings(ref m);
            m.Reset();
            Refresh();
        }

        private string ToString(double x, string Title, string Units, string Format)
        {
            return Title + " = " + x.ToString(Format) + " " + Units;
        }

        private void Print_State()
        {
            toolStripStatusLabel_t.Text = ToString(m.t, "t", "s", "F2");
            toolStripStatusLabel_x.Text = ToString(m.x, "X", "m", "F3");
            toolStripStatusLabel_Xd.Text = ToString(m.x_d, "Xd", "m", "F3");
            toolStripStatusLabel_Xmin.Text = ToString(m.x_min, "Xmin", "m", "F3");
            toolStripStatusLabel_Xmax.Text = ToString(m.x_max, "Xmax", "m", "F3");
            toolStripStatusLabel_H.Text = ToString(m.Tank.H, "H", "m", "F3");
        }

        private void Draw_Level(double x, double x_min, double x_max, double H)
        {
            /*double x_min_pic = 154;
            double x_max_pic = 17;
            double x_zero_pic = 172;
            double x_h_pic = 0;*/

            int r_h = 0;

            if (x < x_min)
            {
                double r_x = x / x_min;
                r_h = 172 - (int)Math.Round((172 - 153) * r_x);
            }
            else if ((x >= x_min) & (x <= x_max))
            {
                double r_x = (x - x_min) / (x_max - x_min);
                r_h = 153 - (int)Math.Round((153 - 17) * r_x);
            }
            else if (x > x_max)
            {
                double r_x = (x - x_max) / (H - x_max);
                r_h = 17 - (int)Math.Round(17 * r_x);
            }

            pictureBox_WhiteBar.Height = r_h;
            Refresh();
        }


        private void Plot_Graphs()
        {
            if ((m.t == 0) | (m.t == m.h_t))
                Add_New_Point();
            else
                if (isDifferentEnough())
                {
                    Add_New_Point();
                    Add_New_Point();
                }
                else
                    Change_Last_Point();

            Refresh();
        }

        private double x_o, x_d_o, u_o;

        private bool isDifferentEnough()
        {
            if (Math.Abs(m.x - x_o) / (m.Tank.H) > 0.01)
                return true;
            if (Math.Abs(m.x_d - x_d_o) / (m.x_max- m.x_min) > 0.01)
                return true;            

            return false;
        }

        private void Add_New_Point()
        {
            chart_Characteristics.Series[0].Points.AddXY(m.t, m.x);            
            chart_Characteristics.Series[1].Points.AddXY(m.t, m.x_d);

            chart_Characteristics.Series[4].Points.AddXY(m.t, 0);
            chart_Characteristics.Update();
            x_o = m.x;
            x_d_o = m.x_d;
        }

        private void Change_Last_Point()
        {
            chart_Characteristics.Series[0].Points.Last().SetValueXY(m.t, m.x);
            chart_Characteristics.Series[1].Points.Last().SetValueXY(m.t, m.x_d);

            chart_Characteristics.Series[4].Points.Last().SetValueXY(m.t, 0);            
            chart_Characteristics.Update();            
        }

        private void Clear_Graphs()
        {
            chart_Characteristics.Series[0].Points.Clear();
            chart_Characteristics.Series[1].Points.Clear();
            chart_Characteristics.Series[4].Points.Clear();
            chart_Characteristics.Update();           
        }

        private void trackBar_Xd_ValueChanged(object sender, EventArgs e)
        {
            m.x_d = m.x_min + trackBar_Xd.Value * (m.x_max - m.x_min) / 100.0;
        }


        private void radioButton_Restart_CheckedChanged(object sender, EventArgs e)
        {
            set_initial_condition();
            st = Computing_States.Initial;
        }

        private void radioButton_Start_CheckedChanged(object sender, EventArgs e)
        {
            st = Computing_States.Running;
        }

        private void radioButton_Stop_CheckedChanged(object sender, EventArgs e)
        {
            st = Computing_States.Stopped;
        }

        private void form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            st = Computing_States.Exited;
        }

        private void checkBox_Draw_CheckedChanged(object sender, EventArgs e)
        {
            Draw_Yes_No = !Draw_Yes_No;
        }

        private void numericUpDown_Tmax_ValueChanged(object sender, EventArgs e)
        {
            update_chart_parameters();
        }

        public void running_loop()
        {
            do
            {
                switch (st)
                {
                    case Computing_States.Initial:
                        break;
                    case Computing_States.Running:
                        m.Compute_Next_Step();
                        if (Draw_Yes_No)
                        {
                            Plot_Graphs();
                            Draw_Level(m.x, m.x_min, m.x_max, m.Tank.H);
                        }
                        break;
                    case Computing_States.Stopped:
                        break;
                    case Computing_States.Exited:
                        return;
                }

                Print_State();
                
                Application.DoEvents();
                Thread.Sleep(m.Controller.delay);
            }
            while (true);
        }

        private void form_Main_Shown(object sender, EventArgs e)
        {
            running_loop();
        }
    }
}
