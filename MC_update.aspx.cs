using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace WebApplication1_1214
{
    public partial class MC_update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM;User ID=maki;Password=12345";
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * from MC_table where MC_id= " + Request["MC_id"].ToString() + "";
                SqlDataReader Rd = cmd.ExecuteReader();
                if (Rd.Read())
                {

                    MC_pid.Text = Rd["MC_pid"].ToString();
                    MC_pwd.Text = Rd["MC_pwd"].ToString();
                    MC_name.Text = Rd["MC_name"].ToString();
                    MC_tel.Text = Rd["MC_tel"].ToString();
                    MC_email.Text = Rd["MC_email"].ToString();
                }
                Rd.Close();
                conn.Close();
            }



        }


        protected void B1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM;User ID=maki;Password=12345";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update MC_table Set MC_pid='" + MC_pid.Text + "',MC_pwd='" + MC_pwd.Text + "',MC_name='" + MC_name.Text + "',MC_tel='" + MC_tel.Text + "',MC_email='" + MC_email.Text + "' where MC_id=" + Request["MC_id"].ToString() + "";
            cmd.ExecuteNonQuery();
            conn.Close();

            Msg1.Text = "修改成功";

        }

    }
}