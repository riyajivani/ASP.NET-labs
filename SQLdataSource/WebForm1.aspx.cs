using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLdataSource
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //if(e.Row.Cells[3].Text == "7")
                //{
                //    e.Row.BackColor = System.Drawing.Color.Aqua;
                //}
                if (DataBinder.Eval(e.Row.DataItem, "Sem").ToString() == "3")
                {
                    e.Row.BackColor = System.Drawing.Color.Yellow;
                }
            }
        }
    }
}