using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicTable
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                       int row = Convert.ToInt16(DropDownList1.SelectedItem.Text);
                       int col = Convert.ToInt16(DropDownList2.SelectedItem.Text);
                        
                       Table table = new Table();

                        for(int i=0; i<row; i++)
                        {
                            TableRow tableRow = new TableRow();
                                    for(int j=0; j<col; j++)
                                    {
                                              TableCell cell = new TableCell();
                                                cell.Text = "(" + i.ToString() + " , " + j.ToString() + ")";
                                                cell.BorderStyle = BorderStyle.Dotted;
                                                cell.BorderColor = Color.Black;
                                                cell.BorderWidth = 1;
                                                tableRow.Cells.Add(cell);
                                    }
                                    table.Rows.Add(tableRow);
                        }

                           table.BackColor = Color.Pink;
                           table.CellPadding = 10;
                           table.BorderColor = Color.Black;
                           table.BorderWidth = 3;
                         Panel1.Controls.Add(table);
        }
    }
}