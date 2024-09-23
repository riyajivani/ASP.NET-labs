using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionApplication
{
    public partial class EditDetail : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["mycs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                
                SqlCommand cmd = new SqlCommand("Update [User] set [Username]=@Username where [Username]='"+Session["user"]  + "'",con);
                cmd.Parameters.AddWithValue("@Username", TextBox1.Text);
                Session["user"] = TextBox1.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Username changed");
            }
        }
    }
}