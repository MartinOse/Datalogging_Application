using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherSystem_RestAPI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void chosenParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametersForm parametersForm = new ParametersForm();
            parametersForm.Show();
        }

        private void openRetreivingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retrieving_Data_Form retrievingForm = new Retrieving_Data_Form();
            retrievingForm.Show();
        }
    }
}
