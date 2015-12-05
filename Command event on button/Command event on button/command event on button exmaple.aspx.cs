using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Command_event_on_button
{
    public partial class command_event_on_button_exmaple : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnclick_Command(object sender, CommandEventArgs e)
        {
            Response.Write("I am button");

        }

       
       
    }
}