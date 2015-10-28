using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace view_state_managament_demo1
{
    public partial class query_string : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     if (Request.QueryString["name"] != null) //Lets retrieve, increase and store again
{
         Label2.Text = Request.QueryString["name"];
}
}

        protected void Button1_Click(object sender, EventArgs e)
        {
            //set in query string
          string Names = TextBox1.Text;
            if (Request.QueryString["name"] != null) //Lets retrieve, increase and store again
            {
                Names = Request.QueryString["name"];
            }
            else //First postback, lets store the info
            {
                Names = TextBox1.Text;
            }
            Response.Redirect("display.aspx?name=" + Names);
        

        }
    }
}