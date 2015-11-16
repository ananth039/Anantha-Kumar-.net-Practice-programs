using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_side_state_managment
{
    public partial class cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userdetails"];
            if(cookie!=null)
            {
                TextBox1.Text = cookie["Name"];
                TextBox2.Text = cookie["EmailId"];
            }
        }
    }
}