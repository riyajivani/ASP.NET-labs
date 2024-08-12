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
            if(FileUpload1.PostedFile.ContentLength < 10000 && Page.IsValid) {
                string result = "Form submitted<br/>";

                result += "Name: " + TextBox1.Text + "<br/>";
                result += "Email: " + TextBox2.Text + "<br/>";
                result += "Ph no.: " + TextBox3.Text + "<br/>";
                result += "Address: " + TextBox4.Text + "<br/>";
                result += "Future Scope: ";

                foreach (ListItem item in CheckBoxList1.Items)
                {
                    if (item.Selected)
                    {
                        result += item.Text + " ";
                    }
                }

                result += "<br/>";
                result += "Age: " + RadioButtonList1.SelectedValue + "<br/>";
                result += "Country: " + DropDownList1.SelectedValue + "<br/>";
                result += "Birthdate: " + TextBox7.Text + "<br/>";

                Label13.Text = result;
            }
            else { 
                if (FileUpload1.PostedFile.ContentLength > 10000) {
                    Label12.Text = "Image size should less than 100MB";
                }
                else  
                    Response.Write("please fill all the details correctly."); }
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

        protected void RadioButtonValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            if (RadioButtonList1.SelectedIndex >= 0) { args.IsValid = true; }
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