using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static String A = "a";
        protected void Page_Load(object sender, EventArgs e)
        {
            A += A; // it means page reload on every render.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);
            int c = a + b;
            Response.Write(c);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);
            int c = a - b;
            Response.Write(c);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);
            int c = a * b;
            Response.Write(c);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(TextBox1.Text);
            int b = Convert.ToInt16(TextBox2.Text);
            int c = a / b;
            Response.Write(c);
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