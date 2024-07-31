using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageDemo
{
    public partial class contentpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.cbl.SelectedIndexChanged += checkboxlist_selected;
        }

        protected void checkboxlist_selected(object sender, EventArgs e)
        {
            label1.Text = "Hello, ";

            foreach (ListItem item in Master.cbl.Items)
            {
                if (item.Selected)
                {
                    switch (item.Value)
                    {
                        case "IT":
                            label1.Text = "IT faculty: " + "ANV" + " , " + "HBP";
                            break;
                        case "CE":
                            label1.Text = "CE faculty: " + "CKB" + "" + "BSB";
                            break;
                        case "EC":
                            label1.Text = "EC faculty: " +  "NVC" + " , " + "PGT";
                            break;
                    }
                }
            }
            if (Master.cbl.SelectedIndex == 0)
            {
                label1.Text = "IT faculty: " + "ANV" + " , " + "HBP";
            }
            if(Master.cbl.SelectedIndex == 1){
                label1.Text = "CE faculty: " +  "CKB" + " , " + "BSB";
            }
            if(Master.cbl.SelectedIndex == 2)
            {
                label1.Text = "EC faculty: " +  "NVC" + " , " + "PGT";
            }
        }
    }
}