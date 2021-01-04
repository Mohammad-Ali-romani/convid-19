using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        DBHnadler Allobj = new DBHnadler();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Allobj.GetAllItems();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    TableCell cellID = e.Row.Cells[1];
            //    int Id = int.Parse(cellID.Text);
            //    TableCell cellName = e.Row.Cells[2];
            //    TableCell cellGender = e.Row.Cells[3];
            //    TableCell cellMarks = e.Row.Cells[4];
            //    int Marks = int.Parse(cellMarks.Text);
            //    employee emp = new employee(Id,cellName.Text, cellGender.Text, Marks);
            //    DBHnadler dbemp = new DBHnadler();
            //    dbemp.UpdateItemByID(Id);
            // }
        }
    }
}