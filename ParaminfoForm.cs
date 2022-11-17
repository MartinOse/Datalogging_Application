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
    public partial class ParaminfoForm : Form
    {

        List<Paraminfo> paraminfo = new List<Paraminfo>();
        Paraminfo parami = new Paraminfo();

        public ParaminfoForm()
        {
            InitializeComponent();
            paraminfo = parami.GetParam();
            FillParamdgv();

        }

        private void Param_info_Load(object sender, EventArgs e)
        {
            paraminfo = parami.GetParam();
            FillParamdgv();
        }

        public void FillParamdgv()
        {
            dgvParaminfo.DataSource = paraminfo;
        }

        private void btnckose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

