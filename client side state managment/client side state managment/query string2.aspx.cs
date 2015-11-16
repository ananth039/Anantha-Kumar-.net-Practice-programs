using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_side_state_managment
{
    public partial class query_string2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblEno.Text = "Emp  No is:" + Request.QueryString["eno"];
            lblEname.Text = "Ename is :" + Request.QueryString["ename"];
        }

        protected void linkprev_Click(object sender, EventArgs e)
        {
            Response.Redirect("query  string.aspx");
        }
    }
}