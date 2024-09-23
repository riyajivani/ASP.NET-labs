using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Configuration;

namespace LinqCrud
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        String cs = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                display();
            }
        }

        public void display()
        {
            using(DataClasses1DataContext ctx = new DataClasses1DataContext(cs))
            {
                var res = from a in ctx.Employees
                          select a;

                GridView1.DataSource = res;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext ctx = new DataClasses1DataContext(cs))
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt16(TextBox1.Text);
                emp.Name = TextBox2.Text; 
                emp.Desg = TextBox3.Text;
                emp.Dept = TextBox4.Text;
                emp.Salary = Convert.ToInt32(TextBox5.Text); 
                ctx.Employees.InsertOnSubmit(emp);
                ctx.SubmitChanges();
                display();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext ctx = new DataClasses1DataContext(cs))
            {
                Employee emp = ctx.Employees.SingleOrDefault(x=> x.Name == "Riya");
                if (emp != null)
                {
                    emp.Desg = "Developer"; 
                    ctx.SubmitChanges();
                    display(); 
                }
                else
                {
                    Response.Write("Employee Riya not found.");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext ctx = new DataClasses1DataContext(cs))
            {
                int empId = Convert.ToInt16(TextBox1.Text); 
                string empName = TextBox2.Text;

                Employee emp = ctx.Employees.SingleOrDefault(x => x.Id == empId && x.Name==empName);
                if (emp != null)
                {
                    ctx.Employees.DeleteOnSubmit(emp);  
                    ctx.SubmitChanges();
                    display(); 
                }
                else
                {
                    Response.Write("Employee with provided Id and Name not found.");
                }
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext ctx = new DataClasses1DataContext(cs))
            {
                //var avgSal = (from a in ctx.Employees
                //                    select a.Salary).Average(x=>x.Value);
                var avgSal = ctx.Employees.Average(emp => emp.Salary);
                Response.Write($"The average salary of all employees is: {avgSal}");
            }
        }
    }
}