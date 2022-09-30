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
    public partial class Retrieving_Data : Form
    {
        public Retrieving_Data()
        {
            InitializeComponent();
        }


        #region UI Handlers

        #endregion
        #region Debug Function
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
        #endregion

        private void txtRequestURL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            DataTransform dTransform = new DataTransform();

            rClient.endPoint = txtRequestURL.Text;

            debugOutput("Rest Client Created.");
            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();

            string[] responseValues = dTransform.UnpackXML(strResponse);
            DataExporter.ExportData(responseValues);

            debugOutput(strResponse);

            txtResponse.AppendText(Environment.NewLine);


        }

        private void lbHttp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRequestURL.Text = "http://128.39.35.253/latestsampledata.xml";
            timer1.Enabled = true;
        }
    }
}
