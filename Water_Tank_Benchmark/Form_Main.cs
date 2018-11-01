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
    public partial class Form_Main : Form
    {
        private Form_About frm_about;
        private Form_Settings frm_set;

        public Form_Main()
        {
            InitializeComponent();
            frm_about = new Form_About();
            frm_set = new Form_Settings();
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
