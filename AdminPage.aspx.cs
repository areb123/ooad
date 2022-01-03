using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Managment_System
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from " + DropDownList1.SelectedItem.Text;
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (DropDownList1.SelectedItem.Text == "Coursetable")
            {
                GdCourse.Visible = true;
                GdStudent.Visible = false;
                GdTutor.Visible = false;
                GdCourse.DataSource = dt;
                GdCourse.DataBind();
            }
            else if(DropDownList1.SelectedItem.Text == "student")
            {
                GdStudent.Visible = true;
                GdCourse.Visible = false;
                GdTutor.Visible = false;
                GdStudent.DataSource = dt;
                GdStudent.DataBind();
            }
            else
            {
                GdTutor.Visible = true;
                GdStudent.Visible = false;
                GdCourse.Visible = false;
                GdTutor.DataSource = dt;
                GdTutor.DataBind();
            }
            sqlconn.Close();
        }

        protected void GdCourse_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GdCourse.EditIndex = -1;
        }

        protected void GdCourse_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdCourse.Rows[e.RowIndex];

            int courseid =Convert.ToInt32(GdCourse.DataKeys[e.RowIndex].Values[0]);
            string cname = (row.Cells[2].Controls[0] as TextBox).Text;
            string Duration = (row.Cells[3].Controls[0] as TextBox).Text;
            string Fees = (row.Cells[4].Controls[0] as TextBox).Text;

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update Coursetable set Cname=@Cname,Duration=@Duration,Cfees=@Cfees where Cid=@Cid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Cid", courseid);
            sqlcomm.Parameters.AddWithValue("@Cname", cname);
            sqlcomm.Parameters.AddWithValue("@Duration", Duration);
            sqlcomm.Parameters.AddWithValue("@Cfees", Fees);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdCourse_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdCourse.EditIndex = e.NewEditIndex;
        }

        protected void GdCourse_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int courseid = Convert.ToInt32(GdCourse.DataKeys[e.RowIndex].Values[0]);

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from Coursetable where Cid=@Cid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Cid", courseid);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

        }

        protected void GdStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GdStudent.EditIndex = -1;
        }

        protected void GdStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdStudent.Rows[e.RowIndex];

            int Stid = Convert.ToInt32(GdStudent.DataKeys[e.RowIndex].Values[0]);
            string Stfname = (row.Cells[2].Controls[0] as TextBox).Text;
            string Stlname = (row.Cells[3].Controls[0] as TextBox).Text;
            string StFathername = (row.Cells[4].Controls[0] as TextBox).Text;
            string StFatherphone = (row.Cells[5].Controls[0] as TextBox).Text;
            string StEmail = (row.Cells[6].Controls[0] as TextBox).Text;
            string Stphone = (row.Cells[7].Controls[0] as TextBox).Text;
            string Coursejoin = (row.Cells[8].Controls[0] as TextBox).Text;
            string CourseFees = (row.Cells[9].Controls[0] as TextBox).Text;
            string Firstinstallment = (row.Cells[10].Controls[0] as TextBox).Text;
            string FeesDue = (row.Cells[11].Controls[0] as TextBox).Text;
           // string Joindate = (row.Cells[12].Controls[0] as TextBox).Text;


            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update student set Stfname=@Stfname,Stlname=@Stlname,StFathername=@StFathername,StFatherphone=@StFatherphone,StEmail=@StEmail,Stphone=@Stphone,Coursejoin=@Coursejoin,CourseFees=@CourseFees,Firstinstallment=@Firstinstallment,FeesDue=@FeesDue where Stid=@Stid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Stid", Stid);
            sqlcomm.Parameters.AddWithValue("@Stfname", Stfname);
            sqlcomm.Parameters.AddWithValue("@Stlname", Stlname);
            sqlcomm.Parameters.AddWithValue("@StFathername", StFathername);
            sqlcomm.Parameters.AddWithValue("@StFatherphone", StFatherphone);
            sqlcomm.Parameters.AddWithValue("@StEmail", StEmail);
            sqlcomm.Parameters.AddWithValue("@Stphone", Stphone);
            sqlcomm.Parameters.AddWithValue("@Coursejoin", Coursejoin);
            sqlcomm.Parameters.AddWithValue("@CourseFees", CourseFees);
            sqlcomm.Parameters.AddWithValue("@Firstinstallment", Firstinstallment);
            sqlcomm.Parameters.AddWithValue("@FeesDue", FeesDue);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Stid = Convert.ToInt32(GdStudent.DataKeys[e.RowIndex].Values[0]);

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from student where Stid=@Stid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Stid", Stid);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();


        }

        protected void GdStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdStudent.EditIndex = e.NewEditIndex;
        }

        protected void GdTutor_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GdTutor.EditIndex = -1;
        }

        protected void GdTutor_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GdTutor.Rows[e.RowIndex];

            int Tid = Convert.ToInt32(GdTutor.DataKeys[e.RowIndex].Values[0]);
            string Tname = (row.Cells[2].Controls[0] as TextBox).Text;
            string Temail = (row.Cells[3].Controls[0] as TextBox).Text;
            string Tphone = (row.Cells[4].Controls[0] as TextBox).Text;
            string Tcourse = (row.Cells[5].Controls[0] as TextBox).Text;
            string Tqualification = (row.Cells[6].Controls[0] as TextBox).Text;


            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "update tutor set Tname=@Tname,Temail=@Temail,Tphone=@Tphone,Tcourse=@Tcourse,Tqualification=@Tqualification where Tid=@Tid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Tname", Tname);
            sqlcomm.Parameters.AddWithValue("@Temail", Temail);
            sqlcomm.Parameters.AddWithValue("@Tphone", Tphone);
            sqlcomm.Parameters.AddWithValue("@Tcourse", Tcourse); 
            sqlcomm.Parameters.AddWithValue("@Tqualification", Tqualification);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
        }

        protected void GdTutor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Tid = Convert.ToInt32(GdTutor.DataKeys[e.RowIndex].Values[0]);

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "delete from tutor where Tid=@Tid";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Tid", Tid);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

        }

        protected void GdTutor_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GdTutor.EditIndex = e.NewEditIndex;
        }
    }
}