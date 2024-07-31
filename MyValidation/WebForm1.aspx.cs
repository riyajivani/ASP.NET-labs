using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MyValidation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Form submitted");
        }

        protected void CheckboxListValidate(object source, ServerValidateEventArgs args)
        {
                args.IsValid = false;
            
                if(CheckBoxList1.SelectedIndex >= 0){
                    args.IsValid = true;
                }
        }

        protected void DropdownValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false ;

            if(DropDownList1.SelectedIndex >= 0){ args.IsValid = true; }
        }

        protected void DateValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;

            DateTime selectedDate;
            if (DateTime.TryParse(TextBox7.Text, out selectedDate))
            {
                args.IsValid = (selectedDate > DateTime.Now);
            }
        }
    }
}