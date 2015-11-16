using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_side_state_managment
{
    public partial class Cookie1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userdetails");
            cookie["Name"] = txtName.Text;
            cookie["EmailId"] = txtEmailid.Text;
            cookie.Expires = DateTime.Now.AddSeconds(20);
            Response.Cookies.Add(cookie);
            Response.Redirect("cookie2.aspx");
        }
    }
}