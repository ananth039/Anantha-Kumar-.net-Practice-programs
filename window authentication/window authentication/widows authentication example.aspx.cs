using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace window_authentication
{
    public partial class widows_authentication_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(User.Identity + "<br>");
            Response.Write(User.Identity.Name + "<br>");
            Response.Write(User.IsInRole("Adminstrator"));
        }
    }
}