using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;

namespace WeatherSystem_RestAPI
{
    public partial class Logging_Form : Form
    {
        Thread th;
        public Logging_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txb_user.Text.Length>0 && txb_password.Text.Length>0)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                string command = "Select * From User_info where User_Name= '" + txb_user.Text + "' And User_Password = '" + txb_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(command, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Close();
                    th = new Thread(openmainform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong!", "USN Weather System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Input your username/password","USN Weather System",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void openmainform()
        {
            Application.Run(new MainPage());
        }

        private void Logging_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
