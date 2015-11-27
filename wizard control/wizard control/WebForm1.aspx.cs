using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wizard_control
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EmailWizard_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            lblmsg.Text = txtUsername.Text + "Email Registration completed Sucessfully";
        }
    }
}