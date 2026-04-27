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
    public partial class Logindata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindgrid();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into logins values('" + txtuname.Text + "','" + txtpw.Text + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("Record Inserted Successfully");
            con.Close();
            bindgrid();
        }
        protected void bindgrid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("Select * from logins",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            gvdata.DataSource = ds;
            gvdata.DataBind();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update logins set password='" + txtpw.Text + "' where username='" + txtuname.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            bindgrid();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from logins where username='" + txtuname.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close ();
            bindgrid();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("select * from logins where username Like '%" + txtsearch.Text + "%'", con);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill (ds);
            gvdata.DataSource = ds;
            gvdata.DataBind ();
        }

        protected void gvdata_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvdata.PageIndex = e.NewPageIndex;
            bindgrid();
        }

        protected void gvdata_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdata.EditIndex= e.NewEditIndex;
            bindgrid ();
        }

        protected void gvdata_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdata.EditIndex = -1;
            bindgrid();
        }

        protected void gvdata_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            GridViewRow gvr = gvdata.Rows[e.RowIndex];
            int uid = Convert.ToInt32(gvdata.DataKeys[e.RowIndex].Value);
            string username = ((TextBox)gvr.FindControl("txtu1name")).Text;
            string password = ((TextBox)gvr.FindControl("txtpwd")).Text;
            SqlCommand cmd = new SqlCommand("update logins set Username=@username,Password=@password where uid=@uid", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.ExecuteNonQuery();
            con.Close();
            bindgrid();
        }
        protected void gvdata_RowDeleting(object sender,GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            GridViewRow gvr = gvdata.Rows[e.RowIndex];
            int uid = Convert.ToInt32(gvdata.DataKeys[e.RowIndex].Value);
            SqlCommand cmd = new SqlCommand("Delete from logins where uid=@uid", con);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.ExecuteNonQuery();
            con.Close();
            bindgrid();
        }
    }
}