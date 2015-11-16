using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace client_side_state_managment
{
    public partial class view_state : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(ViewState["clicks"]==null)
                {
                    ViewState["clicks"] = 0;

                }
                txtRequest.Text = ViewState["clicks"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int clickcount = (int)ViewState["clicks"] + 1;
            txtRequest.Text = clickcount.ToString();
            ViewState["clicks"] = clickcount;
        }
    }
}