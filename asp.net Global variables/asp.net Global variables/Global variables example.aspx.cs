using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace asp.net_Global_variables
{
    public partial class Global_variables_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        
        {

            txtxValue.Text = ConfigurationSettings.AppSettings["x"];
            txtYValue.Text = ConfigurationSettings.AppSettings["y"];
        }
           
        
    }
}