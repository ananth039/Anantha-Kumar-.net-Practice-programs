﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server_side_state_managament_techniques
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["number"] = Convert.ToInt32(Application["number"]) + 1;
            lblCount.Text = Session["number"].ToString();
            
        }
    }
}