using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;
using System.Data;
public partial class Users_PersonalDetails : System.Web.UI.Page
{
    DAUsers usrs = new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {

        DisplayUserData();

    }
    private void DisplayUserData()
    {
        usrs.Username = Session["UserName"].ToString();
        DataTable dt = usrs.GetUserDetails(usrs);
        FormView1.DataSource = dt;
            
        FormView1.DataBind();

    }
    
    protected void LinkButtonEditpersonalDetails_Click(object sender, EventArgs e)
    {
        
      Response.Redirect("~/Users/EditUserDetails.aspx");
    }

   
    }