using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view_state_managament_demo1
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int postbacks = 0;
            if(Request.Cookies["number"]!=null)
            {
                postbacks = Convert.ToInt32(Request.Cookies["number"].Value) + 1;
            }
            else
            {
                postbacks = 1;
            }
            Response.Cookies["number"].Value = postbacks.ToString();
            Label3.Text = Response.Cookies["number"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["number"].Expires = DateTime.Now.AddSeconds(10);
          
           
        }
    }
}