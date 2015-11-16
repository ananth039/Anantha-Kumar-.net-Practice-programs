using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace types_of_sessions
{
    public partial class Inproc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            Session["id"] = txtName.Text;
            Label1.Text = "Session value is assigned";
            txtName.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Session["id"].ToString();
            Label1.Text = "Session value is retrived";
            txtName.Focus();
        }
    }
}