using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view_state_managament_demo1
{
    public partial class display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != null) //Lets retrieve, increase and store again
            {
                Label2.Text = Request.QueryString["name"];
            }
        }
    }
}