using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginDetailsusingADO
{
    public partial class Regestration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into regestration values('" + txtuname.Text + "','" + txtage.Text + "','" + txtemail.Text + "','" + txtpw.Text + "','" + txtcpw.Text + "','" + txtmno.Text + "')",con);
            cmd.ExecuteNonQuery();
            Response.Write("Record Inserted Successfully");
            con.Close();
        }
    }
}