using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webervice
{
    /// <summary>
    /// Summary description for mymebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class mymebservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet getemp(int id)
        {
                    DataSet ds = new DataSet();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=RIYA\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True;";
                    con.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Employee where Id=" + id;
                    cmd.Connection = con;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = cmd;

                    dataAdapter.Fill(ds);

                    return ds;
        }
    }
}
