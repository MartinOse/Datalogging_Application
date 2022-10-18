using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WeatherSystem_RestAPI
{
    internal class ParamData

    {
        public string ParamName { get; set; }
        public DateTime ParamDate { get; set; }
        public int User_id { get; set; }


        public List<ParamData> GetParam()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            List<ParamData> ComponentDatalist = new List<ParamData>();
            string selectSQL = "select User_Id, Name_Param, Date_Chosen from Chosen_Param";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ParamData paramData = new ParamData();
                    paramData.ParamName = Convert.ToString(dr["Name_Param"]);
                    paramData.ParamDate = Convert.ToDateTime(dr["Date_Chosen"]);
                    paramData.User_id = Convert.ToInt32(dr["User_Id"]);
                    ComponentDatalist.Add(paramData);
                }
            }
            con.Close();
            return ComponentDatalist;
        }




        public void WriteParam(string Name_Param, int User_Id, DateTime Date_Chosen)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Chosen_Param (Name_Param,Date_Chosen,User_Id) VALUES (@ParamName, @ParamDate,@User_id)";
            cmd.Parameters.Add(new SqlParameter("@ParamName", Name_Param));
            cmd.Parameters.Add(new SqlParameter("@ParamDate", Date_Chosen));
            cmd.Parameters.Add(new SqlParameter("@User_id", User_Id));

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

