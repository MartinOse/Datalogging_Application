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
    public partial class Retrieving_Data_Form : Form
    {
        public Retrieving_Data_Form()
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
            string strResponse = "";
            strResponse = rClient.makeRequest();

            List<string[]> responseValues = new List<string[]>();

            responseValues = dTransform.UnpackXML(strResponse.ToString());
            DataExporter.ExportData(responseValues);

            debugOutput(strResponse);

            txtResponse.AppendText(Environment.NewLine);

            int i = 0;
            foreach (var item in responseValues)
            {
                var textBox1 = new TextBox();
                var label = new Label();


                textBox1.Width = 300;
                textBox1.Height = 50;
                textBox1.Name = "txtData" + i;
                textBox1.Location = new System.Drawing.Point(200, 90 + i * 25);
                label.Text = item.ToString();
                label.Location = new System.Drawing.Point(60, 90 + i * 25);
                textBox1.Text = item.ToString();
                this.Controls.Add(textBox1);
                this.Controls.Add(label);
                textBox1.BackColor = Color.AliceBlue;
                i++;

            }


        }

        private void lbHttp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtRequestURL.Text = "http://128.39.35.253/latestsampledata.xml";
            lbURL.Visible = false;
            lbResponse.Visible = false;
            txtRequestURL.Visible = false;
            txtResponse.Visible = false;
            txtRequestURL.Visible = false;

           
            

            timer1.Enabled = true;
        }
    }
}
