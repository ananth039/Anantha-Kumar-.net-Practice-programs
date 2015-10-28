using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view_state_managament_demo1
{
    public partial class view_State_managment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==true)
            {
                if(ViewState["name"]!=null)
                {
                    ViewState["name"] =Convert.ToInt32 (ViewState["name"])+1 ;
                    

                }
                else
                {
                    ViewState["name"] = 1;
                    
                }
                Label3.Text = ViewState["name"].ToString(); 
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}