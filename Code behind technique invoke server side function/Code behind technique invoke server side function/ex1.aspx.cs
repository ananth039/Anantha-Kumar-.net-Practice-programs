using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Code_behind_technique_invoke_server_side_function
{
    public partial class ex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_ServerClick(object sender, EventArgs e)
        {
            Response.Write("This message from server");
        }
    }
}