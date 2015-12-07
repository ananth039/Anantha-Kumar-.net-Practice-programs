using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Forms_Authentication
{
    public partial class UserHomepage1 : System.Web.UI.MasterPage
    {
       
           
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.RedirectToLoginPage();
            FormsAuthentication.SignOut();
        }
    }
}