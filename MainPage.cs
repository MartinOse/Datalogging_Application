using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void parametersInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaminfoForm param_Info = new ParaminfoForm();
            param_Info.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
