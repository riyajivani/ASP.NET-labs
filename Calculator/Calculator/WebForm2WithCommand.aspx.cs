using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm2WithCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Command(object sender, CommandEventArgs e)
        {
            String cr =  (String)e.CommandArgument;
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);

            switch (cr)
            {
                case "+":
                    Response.Write(a + b);
                    break;

                 case "-":
                    Response.Write(a - b);
                    break;

                case "*":
                    Response.Write(a * b);
                    break;

                case "/":
                    Response.Write(a / b);
                    break;
            }

            if (e.CommandName.ToString() == "clear")
            {
                if (e.CommandArgument.ToString() == "clear")
                {
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(TextBox2.Text) == 0)
            {
                TextBox1.BackColor = Color.Red;
                Button4.Enabled = false;
                return;
            }
            TextBox1.BackColor = Color.Transparent;
            Button4.Enabled = true;
        }
    }
}