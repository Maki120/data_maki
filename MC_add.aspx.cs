using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace WebApplication1_0921
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void B1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM ; User ID=maki; Password=12345";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into MC_table (MC_pid,MC_pwd,MC_name,MC_tel,MC_email) values('" + MC_pid.Text + "','" + MC_pwd.Text + "','" + MC_name.Text + "','" + MC_tel.Text + "','"  + MC_email.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MC_pid.Text = "";
            MC_pwd.Text = "";
            MC_name.Text = "";
            MC_tel.Text = "";
            MC_email.Text = "";
            Msg1.Text = "新增成功";
        
        }
      
        
    }
}