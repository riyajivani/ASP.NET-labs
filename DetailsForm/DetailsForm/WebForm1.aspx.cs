using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DetailsForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HandleSubmit(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();

            Table detailsTable = new Table();
            detailsTable.BorderWidth = 1;
            detailsTable.BorderColor = Color.White;
            detailsTable.GridLines=GridLines.Both;
            detailsTable.CellPadding = 8;
            //detailsTable.CssClass = "detailsTable"; // Optional: Add CSS class for styling

            AddTableRow(detailsTable, "Name", TextBox1.Text);
            AddTableRow(detailsTable, "Email", TextBox2.Text);
            AddTableRow(detailsTable, "Phone no.", TextBox3.Text);
            AddTableRow(detailsTable, "Country", DropDownList1.SelectedItem.Text);
            AddTableRow(detailsTable, "State", DropDownList2.SelectedItem.Text);
            AddTableRow(detailsTable, "City", DropDownList3.SelectedItem.Text);

            TableRow certRow = new TableRow();
            TableCell certLabelCell = new TableCell { Text = "<b>Certificates:</b>" };
            TableCell certValueCell = new TableCell();
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    certValueCell.Controls.Add(new Literal { Text = item.Text + ", " });
                }
            }
            certRow.Cells.Add(certLabelCell);
            certRow.Cells.Add(certValueCell);
            detailsTable.Rows.Add(certRow);

            string gender = RadioButton1.Checked ? RadioButton1.Text : RadioButton2.Checked ? RadioButton2.Text : "Not specified";
            AddTableRow(detailsTable, "Gender", gender);

            Panel1.Controls.Add(detailsTable);
            Panel1.BackColor= Color.Brown;
            Panel1.ForeColor= Color.White;
        }
        private void AddTableRow(Table table, string label, string value)
        {
            TableRow row = new TableRow();

            TableCell labelCell = new TableCell { Text = $"<b>{label}:</b>" };
            TableCell valueCell = new TableCell { Text = value };

            row.Cells.Add(labelCell);
            row.Cells.Add(valueCell);

            table.Rows.Add(row);
        }

        protected void CountryChange(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add(new ListItem("select state"));

            switch (DropDownList1.SelectedValue)
            {
                case "INDIA":
                    DropDownList2.Items.Add(new ListItem("Gujarat"));
                    DropDownList2.Items.Add(new ListItem("Maharashtra"));
                    break;

                case "USA":
                    DropDownList2.Items.Add(new ListItem("California"));
                    DropDownList2.Items.Add(new ListItem("Florida"));
                    break;

                case "UK":
                    DropDownList2.Items.Add(new ListItem("England"));
                    DropDownList2.Items.Add(new ListItem("Texas"));
                    break;
            }
        }
            protected void StateChnaged(object sender, EventArgs e)
            {
                DropDownList3.Controls.Clear();
                DropDownList3.Items.Add(new ListItem("select city"));

                switch (DropDownList2.SelectedValue)
                {
                    case "Gujarat":
                        DropDownList3.Controls.Clear();
                        DropDownList3.Items.Add(new ListItem("Ahmedabad"));
                        DropDownList3.Items.Add(new ListItem("Rajkot"));
                        break;

                    case "Maharashtra":
                        DropDownList3.Controls.Clear();
                        DropDownList3.Items.Add(new ListItem("Bombay"));
                        DropDownList3.Items.Add(new ListItem("Pune"));
                        break;

                    case "California":
                        DropDownList3.Controls.Clear();
                        DropDownList3.Items.Add(new ListItem("Los Angeles"));
                        DropDownList3.Items.Add(new ListItem("San Francisco"));
                        break;

                    case "Florida":
                        DropDownList3.Controls.Clear();
                        DropDownList3.Items.Add(new ListItem("Miami"));
                        DropDownList3.Items.Add(new ListItem("Orlando"));
                        break;

                    case "England":
                        DropDownList3.Controls.Clear();
                        DropDownList3.Items.Add(new ListItem("London"));
                        DropDownList3.Items.Add(new ListItem("Manchester"));
                        break;

                    case "Texas":
                        DropDownList3.Controls.Clear();
                        DropDownList3.Items.Add(new ListItem("Houston"));
                        DropDownList3.Items.Add(new ListItem("Dallas"));
                        break;

                }
            }
        }
    }