﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace required_field_validateors
{
    public partial class validator2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
               Button1.Text = "Thank You";
            }
            else
            {
                Button1.Text = "Fill up all the fields";
            }
        }

      


    }
}