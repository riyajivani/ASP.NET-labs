using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Application.Lock();
                List<string> allUserSelections = new List<string>();

                foreach (string key in Application.AllKeys)
                {
                    List<string> selectedItems = Application[key] as List<string>;

                    if (selectedItems != null && selectedItems.Count > 0)
                    {
                        allUserSelections.Add($"User: {key}, Selected Items: {string.Join(", ", selectedItems)}");
                    }
                }
                Application.UnLock();

                if (allUserSelections.Count > 0)
                {
                    Label1.Text = string.Join("\n", allUserSelections);
                }
                else
                {
                    Label1.Text = "No items selected by any users.";
                }

            }
        }
    }
}