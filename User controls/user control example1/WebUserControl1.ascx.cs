using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace user_control_example1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblheading.Text = "Heading";
        }

        private string header
        {
            set
            {
                header = value;

            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblheading.Text =;

        }
    }
}