using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "1234")
            {
                Response.Redirect("WebForm2.aspx");
            }
            else if (TextBox1.Text == "Employee" && TextBox2.Text == "1234")
            {
                Response.Redirect("WebForm3.aspx");
            }
        }
    }
}