using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx"); 
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string userName = Session["user"].ToString();
            List<string> selectedItems = new List<string>();

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    selectedItems.Add(item.Value);
                }
            }

            Application.Lock();
            Application[userName] = selectedItems;
            Application.UnLock();

            Response.Redirect("WebForm2.aspx");
        }
    }
}