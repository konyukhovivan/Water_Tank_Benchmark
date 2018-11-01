using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Tank_Benchmark
{
    public partial class form_Main : Form
    {
        private form_About frm_about;
        private form_Settings frm_set;

        public form_Main()
        {
            InitializeComponent();
            frm_about = new form_About();
            frm_set = new form_Settings();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_set.ShowDialog();

    }

    }
}
