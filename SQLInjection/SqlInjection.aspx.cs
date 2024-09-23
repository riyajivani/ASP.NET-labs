using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SQLInjection
{
    public partial class SqlInjection : System.Web.UI.Page
    {

        String cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|Database1.mdf';Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM Login WHERE Username = '{TextBox1.Text} and Password = '{TextBox2.Text}'";

                SqlDataReader sdr;
                con.Open();
                sdr = cmd.ExecuteReader();

                GridView1.DataSource = sdr;
                GridView1.DataBind();

                con.Close();
            }
        }
    }
}