using Invokewebservice.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Invokewebservice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            mymebservice emp = new mymebservice();
            GridView1.DataSource = emp.getemp(Convert.ToInt32(TextBox1.Text));
            GridView1.DataBind();
        }
    }
}