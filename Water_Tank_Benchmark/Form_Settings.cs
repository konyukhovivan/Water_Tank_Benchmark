using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Water_Tank_System;

namespace Water_Tank_Benchmark
{
    public partial class form_Settings : Form
    {
        public form_Settings()
        {
            InitializeComponent();
        }

        Model_View view;

        public void Show_Settings(ref Model ip)
        {
            view = new Model_View((Model)ip.Clone());
            propertyGrid_Settings.SelectedObject = view;
            DialogResult = DialogResult.Cancel;
            ShowDialog();
            if (DialogResult == DialogResult.OK)
                ip = (Model)view.P.Clone();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Reject_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button_Default_Click(object sender, EventArgs e)
        {
            view.P = new Model();
            propertyGrid_Settings.Refresh();
        }

        private void propertyGrid_Settings_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            propertyGrid_Settings.Refresh();
        }
    }
}
