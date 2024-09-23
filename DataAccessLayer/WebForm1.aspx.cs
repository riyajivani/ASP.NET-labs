using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataAccessLayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        FacultyDAL facultyDAL = new FacultyDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            GridView1.DataSource = facultyDAL.GetAllFaculties();
            GridView1.DataBind();
        }

        protected void ButtonInsert_Click(object sender, EventArgs e)
        {
            Faculty fac = new Faculty()
            {
                Id = Convert.ToInt32(TextBoxId.Text),
                Name = TextBoxName.Text,
                Desg = TextBoxDesg.Text,
                Dept = TextBoxDept.Text
            };

            facultyDAL.InsertFaculty(fac);
            BindGrid();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Faculty fac = new Faculty()
            {
                Id = Convert.ToInt32(TextBoxId.Text),
                Name = TextBoxName.Text,
                Desg = TextBoxDesg.Text,
                Dept = TextBoxDept.Text
            };

            facultyDAL.UpdateFaculty(fac);
            BindGrid();
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            int facId = Convert.ToInt32(TextBoxId.Text);
            facultyDAL.DeleteFaculty(facId);
            BindGrid();
        }
    }
}