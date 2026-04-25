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
    }
}