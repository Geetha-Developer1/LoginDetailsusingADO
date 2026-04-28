using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginDetailsusingADO
{

    public partial class StudentRegestrationform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            binddata(); 
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;


            string gender = "";
            if (rbfemale.Checked)
                gender = "Female";
            else if (rbmale.Checked)
                gender = "Male";
            else if (rbothers.Checked)
                gender = "Others";

            string course = "";
            if (chkcshorp.Checked)
                course += "CShorp, ";
             if (chkADO.Checked)
                course += "ADO.net, ";
             if (chkmvc.Checked)
                course += "MVC, ";
             if (chkcore.Checked)
                course += "DOT Net Core, ";
             if (chkangular.Checked)
                course += "Angular. ";


            string dob = ddldob.SelectedValue.ToString();

           
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student_regestration values('"+txtfname.Text+"','"+txtlname.Text+"','"+gender+"','"+course+"','"+dob+"','"+txtemail.Text+"','"+txtpw.Text+"','"+txtcpw.Text+"','"+txtpno.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            binddata();
            Response.Write("Record Inserted Successfully");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("update student_regestration set lname='"+txtlname.Text+"' where fname='"+txtfname.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            binddata();
            Response.Write("Record Updated Successfully");
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from student_regestration where fname='"+txtfname.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            binddata();
            Response.Write("Record Deleted Successfully");
        }

        protected void cvgender_ServerValidate(object source, ServerValidateEventArgs args)
        {
                args.IsValid = rbfemale.Checked || rbmale.Checked || rbothers.Checked;
           
        }

        protected void cvcourse_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(chkADO.Checked||chkangular.Checked||chkcore.Checked||chkcshorp.Checked||chkmvc.Checked)
            {
                args.IsValid= true;
            }
            else
            {
                args.IsValid= false;
            }
        }

        protected void binddata()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from student_regestration", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gvdata.DataSource = ds;
            gvdata.DataBind();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter da = new SqlDataAdapter("Select * from student_regestration where fname Like '%"+txtsearch.Text+"%'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gvdata.DataSource = ds;
            gvdata.DataBind();
        }

      

        protected void gvdata_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdata.EditIndex = e.NewEditIndex;
            binddata();
        }

        protected void gvdata_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvdata.PageIndex = e.NewPageIndex;
            binddata();
        }

        protected void gvdata_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdata.EditIndex = -1;
            binddata() ;
        }

        protected void gvdata_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            con.Open();
            GridViewRow gvr = gvdata.Rows[e.RowIndex];
            int sid = Convert.ToInt32(gvdata.DataKeys[e.RowIndex].Value);
            string fname = ((TextBox)gvr.FindControl("txtgvfname")).Text;
            string lname = ((TextBox)gvr.FindControl("txtgvlname")).Text;
            string gender = ((TextBox)gvr.FindControl("txtgvgender")).Text;
            string course = ((TextBox)gvr.FindControl("txtgvcourse")).Text;
            string emailid = ((TextBox)gvr.FindControl("txtgvemail")).Text;
            string phno = ((TextBox)gvr.FindControl("txtgvphno")).Text;
            SqlCommand cmd = new SqlCommand("Update student_regestration set fname=@fname,lname=@lname,gender=@gender,course=@course,emailid=@emailid,phno=@phno where sid=@sid",con);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@emailid", emailid);
            cmd.Parameters.AddWithValue("@phno", phno);
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.ExecuteNonQuery();
            con.Close();
            binddata();
        }

        protected void gvdata_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            con.Open();
            GridViewRow gvr = gvdata.Rows[e.RowIndex];
            int sid = Convert.ToInt32(gvdata.DataKeys[e.RowIndex].Value);
            SqlCommand cmd = new SqlCommand("Delete from student_regestration where sid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.ExecuteNonQuery ();
            con.Close();
            binddata();
        }
    }
}