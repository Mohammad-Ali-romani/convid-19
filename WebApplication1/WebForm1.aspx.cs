using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
            }
        }
        void show()
        {
            string str = "Data Source=.;Initial Catalog=TCC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str);
            string sql = "select * from tblStudents";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=TCC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str);
            string sql = "insert into tblStudents (Name,Gender,TotalMarks) values('"+txtName.Text+"', '"+txtMarks.Text+"', "+txtMarks.Text+")";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            lblmessage.Text = "Record insert successfully";
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=TCC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str);
            string sql= "update tblStudents set Name = '" + txtName0.Text + "', Gender = '" + txtGender0.Text + "', TotalMarks = " + txtMarks0.Text + " where Name ='" + txtWhere.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            lblmessage.Text = "Record update successfully";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=TCC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str);
            string sql = "delete from tblStudents where Name='" + txtWhereD.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            lblmessage.Text = "Record Delete successfully";
        }
    }
}