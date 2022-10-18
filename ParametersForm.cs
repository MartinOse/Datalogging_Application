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

namespace WeatherSystem_RestAPI
{
    public partial class ParametersForm : Form
    {
        List<ParamData> paramlist = new List<ParamData>();
        ParamData param = new ParamData();
        public ParametersForm()
        {
            InitializeComponent();
            paramlist = param.GetParam();
            FillParamdgv();

        }

        private void Parameters_Load(object sender, EventArgs e)
        {
            paramlist = param.GetParam();
            FillParamdgv();
        }

        public void FillParamdgv()
        {
            dgvParam.DataSource = paramlist;
        }

        private void btnAddParam_Click(object sender, EventArgs e)
        {
            if (cbParam.Text == "" )
            {
                MessageBox.Show("Choose a parameter!");
                Refresh();
            }
            else
            {
                
                string ParamName = Convert.ToString(cbParam.Text.ToString());
                DateTime ParamDate = DateTime.Now;
                int User_Id = 1;
                
                param.WriteParam(ParamName, User_Id,ParamDate);
                paramlist = param.GetParam();
                cbParam.Text = null;

                dgvParam.Refresh();
                FillParamdgv();


            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "DELETE [Chosen_Param] ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.Text;
            
            cmd.ExecuteNonQuery();
            paramlist = param.GetParam();
            FillParamdgv();
            cbParam.Text = null;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cbParam.SelectedItem != null)

            {
                string Params =cbParam.SelectedItem.ToString();

                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE [Chosen_Param] WHERE Name_Param=@Name_Param";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Name_Param", Params);
                cmd.ExecuteNonQuery();
                paramlist = param.GetParam();
                FillParamdgv();
                cbParam.Text=null;
                con.Close();
            }
            else
                MessageBox.Show("Select an Id from the combobox!");
        }
    }
}
