using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1_1207
{
    public partial class MC_search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PSQL.Text = "Select * from MC_table order by MC_name";
            MyDataSource.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM;User ID=maki;Password=12345";
            MyDataSource.SelectCommand = PSQL.Text;
    
        }
        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            MyDataSource.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM;User ID=maki;Password=12345";
            MyDataSource.SelectCommand = PSQL.Text;
            MyGridView.PageIndex = e.NewPageIndex;
            MyGridView.DataBind();

        }

        protected void Button_Click(object sender, EventArgs e)
        {

            PSQL.Text = "Select * from MC_table where MC_name like '%" + Wkey.Text + "%' order by MC_name";
            MyDataSource.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PJDM;User ID=maki;Password=12345";
            MyDataSource.SelectCommand = PSQL.Text;

        }

        public String transfer_link(String MC_id)
        {
            String Link1 = "";
            Link1 = "<a href=\"MC_update.aspx?MC_id=" + MC_id + "\" class=\"style1\">修改</a>";
            return Link1;

        }



        public String del_link(String MC_id)
        {
            String Link1 = "";
            Link1 = "<a href=\"MC_del.aspx?MC_id=" + MC_id + "\" class=\"style1\">刪除</a>";
            return Link1;
        }



    }

}