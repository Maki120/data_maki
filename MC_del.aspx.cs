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
    public partial class MC_del : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM;User ID=maki;Password=12345";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM MC_table where MC_id=" + Request["MC_id"].ToString() + "";
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("MC_search");
        }
    }
}