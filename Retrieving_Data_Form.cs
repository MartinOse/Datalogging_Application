using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;

namespace WeatherSystem_RestAPI
{
    public partial class Retrieving_Data_Form : Form
    {
        //Thread th;

        List<Paraminfo> paramaddinfo = new List<Paraminfo>();
        Paraminfo paramadd = new Paraminfo();

        public Retrieving_Data_Form()
        {
            InitializeComponent();
            paramaddinfo = paramadd.GetParam();
            
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


            List<string> unitlist = new List<string>(new[]
          {
                "","m/s",  "Degree","Degree", "m/s" , "Degree","m/s",  "Degree","m/s", "Degree",
                "Degree", "m/s" ," ", "Degree", "m/s" ," ","Celsius_Degree","PERCENTS(%)", "w/m2", "Celsius_Degree",
                "Celsius_Degree","Celsius_Degree", "Celsius_Degree","Celsius_Degree","", "hPa","hPa","m","Celsius_Degree","Celsius_Degree",
                 "Celsius_Degree", "hPa","hPa", "hPa", "lb/ft3", "lb/ft3", "lb/ft3", "PERCENTS(%)", "nan m","",
                "mm", "mm", "mm","mm","in/hr","hits/in2h","hits/in2h"


                //"Degree", "METERS_PER_SECOND(m/s)", "Degree", "Degree", "METERS_PER_SECOND(m/s)", "", "Degree", "METERS_PER_SECOND(m/s)", "",
                //"Celsius_Degree","Celsius_Degree", "", "Hectopascal(hPa)", "m", "Celsius_Degree", "Celsius_Degree", "Hectopascal(hPa)", "Hectopascal(hPa)", "Hectopascal(hPa)",
                //"lb/ft3", "lb/ft3", "lb/ft3","PERCENTS(%)", "", "", "mm", "mm", "mm", "in/hr",
                //"hits/in2", "Celsius_Degree","Celsius_Degree", "Celsius_Degree", "hits/in2h",""
            });


            DataExporter.ExportData(responseValues);

            debugOutput(strResponse);

            txtResponse.AppendText(Environment.NewLine);

          
            int i = 0;

            foreach (var item in responseValues)
            {
      
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                
                var textBox1 = new TextBox();
                var label1 = new Label();
                var label2 = new Label();


                label1.Width = 250;
                label1.Location = new System.Drawing.Point(60, 90 + i * 25);
                label1.Text = item[0].ToString();
                label1.Font = new Font("Arial", 12, FontStyle.Bold);

                textBox1.Width = 300;
                textBox1.Height = 50;
                textBox1.Font = new Font("Arial", 12, FontStyle.Bold); ;
                textBox1.Name = "txtData" + i;
                textBox1.Location = new System.Drawing.Point(320, 90 + i * 25);
                textBox1.Text = item[1].ToString();


                label2.Width = 200;
                label2.Location = new System.Drawing.Point(700, 90 + i * 25);
                label2.Text = unitlist[i].ToString();
                label2.Font = new Font("Arial", 12, FontStyle.Bold);


                this.Controls.Add(textBox1);
                this.Controls.Add(label1);
                this.Controls.Add(label2);

                textBox1.BackColor = Color.AliceBlue;
                i++;

            }


        }

        private void openretrivform()
        {
            Application.Run(new  Retrieving_Data_Form());
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
            timer2.Enabled = true;
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString();
        }
    }
}
