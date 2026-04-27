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
        protected void Page_Load(object sender, EventArgs e)
        {
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

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into student_regestration values('"+txtfname.Text+"','"+txtlname.Text+"','"+gender+"','"+course+"','"+dob+"','"+txtemail.Text+"','"+txtpw.Text+"','"+txtcpw.Text+"','"+txtpno.Text+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            binddata();
            Response.Write("Record Inserted Successfully");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update student_regestration set lname='"+txtlname.Text+"' where fname='"+txtfname.Text+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            binddata();
            Response.Write("Record Updated Successfully");
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            SqlDataAdapter da = new SqlDataAdapter("Select * from student_regestration", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gvdata.DataSource = ds;
            gvdata.DataBind();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            SqlDataAdapter da = new SqlDataAdapter("Select * from student_regestration where fname Like '%"+txtsearch.Text+"%'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gvdata.DataSource = ds;
            gvdata.DataBind();
        }
    }
}