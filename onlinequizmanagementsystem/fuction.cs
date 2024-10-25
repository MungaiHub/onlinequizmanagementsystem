using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlinequizmanagementsystem
{
    internal class fuction
    {
        protected SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-G0K29VJ\\SQLEXPRESS; database = mypraticumdatabase;integrated security = True";
            return con;
        }

        public DataSet GetData(string query)
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;



        }
        public void setData(string query, string msg, bool showMessage)
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            if (showMessage)
            {
                MessageBox.Show(msg); 
            }
        }
        public SqlDataReader getForCombo(string query)
        { 
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr=cmd.ExecuteReader();
            return sdr;
           
        }
    }
}
