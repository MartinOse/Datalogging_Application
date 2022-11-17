using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WeatherSystem_RestAPI
{
    internal class Paraminfo

    {
        public string NameParam { get; set; }
        public string UnitParam { get; set; }
        public string TypeParam { get; set; }


        public List<Paraminfo> GetParam()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            List<Paraminfo> ComponentDatalist = new List<Paraminfo>();
            string selectSQL = "select Name_Param, Unit_Param, Type_Param from Param_info";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Paraminfo paraminfo = new Paraminfo();
                    paraminfo.NameParam = Convert.ToString(dr["Name_Param"]);
                    paraminfo.UnitParam = Convert.ToString(dr["Unit_Param"]);
                    paraminfo.TypeParam = Convert.ToString(dr["Type_Param"]);
                    ComponentDatalist.Add(paraminfo);
                }
            }
            con.Close();
            return ComponentDatalist;
        }




        public void WriteParam(string Name_Param, string User_Name, DateTime Date_Chosen)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Chosen_Param (Name_Param,Unit_Param,Type_Param) VALUES (@Name_Param, @Unit_Param,@Type_Param)";
            cmd.Parameters.Add(new SqlParameter("@Name_Param", NameParam));
            cmd.Parameters.Add(new SqlParameter("@Unit_Param", UnitParam));
            cmd.Parameters.Add(new SqlParameter("@Type_Param", TypeParam));

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

