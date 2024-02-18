using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_1207
{
    public partial class MC_WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            int k = 0;
            double S = 999999.959845865358;
            k = 8;
            k = k + Convert.ToInt32(S);

            string str1 = "";
            str1 = "這是測試" + k + "apcs";
            Response.Write(str1);

            // Response.Write(k)

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Response.Write("判斷");
        }

        protected void Button1_Click3(object sender, EventArgs e)
        {

            Response.Redirect("https://www.youtube.com/watch?v=qGk4E9ss95s");

        }

        protected void Button1_Click4(object sender, EventArgs e)
        {

            double w = 0, l = 0, BMI = 0;
            w = 85;
            l = 172;
            BMI = w / (l / 100) * (l / 100);

            if (BMI < 18.5)
            {
                Response.Write("體重過輕A");
            }
            else if (BMI >= 18.5 && BMI < 24)
            {
                Response.Write("健康體重B");

            }
            else if (BMI >= 24 && BMI < 27)
            {
                Response.Write("體重過重");

            }

            else if (BMI >= 27)
            {
                Response.Write("肥胖");

            }

        }
        protected void Button1_Click5(object sender, EventArgs e)
        {
            int i = 0, n = 0, sum = 0;

            for (i = 1; i <= 9; i++)
            {
                for (n = 1; n <= 9; n++)
                {
                    sum = i * n;

                    Response.Write(i + "*" + n + "=" + sum + ",");
                }
                Response.Write("<br>");
            }


        }
        protected void Button1_Click6(object sender, EventArgs e)
        {

            string p = "maki", w = "12355";
            if (pid.Text == p && pvd.Text == w)
            {

                msg3.Text = "登入成功";
            }
            else
            {
                msg3.Text = "登入失敗";
            }
        }



        }
}