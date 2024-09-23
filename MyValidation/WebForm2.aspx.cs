using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyValidation
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string cs = ConfigurationManager.ConnectionStrings["my-db"].ConnectionString;

                using(SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Details (Name, Email, Phone, Gender, Scope, Country, Password, Birthdate) VALUES (@Name, @Email, @Phone, @Gender, @FutureScope, @Country, @Password, @Birthdate)", con);

                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Phone", long.Parse(TextBox3.Text));
                    cmd.Parameters.AddWithValue("@Gender", RadioButtonList1.SelectedValue);

                    string selectedScopes = "";
                    foreach (ListItem item in CheckBoxList1.Items)
                    {
                        if (item.Selected)
                        {
                            if (selectedScopes == "")
                            {
                                selectedScopes = item.Text;
                            }
                            else
                            {
                                selectedScopes += "," + item.Text;
                            }
                        }
                    }
                    cmd.Parameters.AddWithValue("@FutureScope", selectedScopes);

                    cmd.Parameters.AddWithValue("@Country", DropDownList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@Password", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", DateTime.Parse(TextBox7.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                Response.Write("Data successfully saved to the database.");
            }
            else
            {
                    Response.Write("please fill all the details correctly.");
            }
        }

        protected void CheckboxListValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;

            if (CheckBoxList1.SelectedIndex >= 0)
            {
                args.IsValid = true;
            }
        }

        protected void DropdownValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;

            if (DropDownList1.SelectedIndex >= 0) { args.IsValid = true; }
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