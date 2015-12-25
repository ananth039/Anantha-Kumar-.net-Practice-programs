using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Admin_Users : System.Web.UI.Page
{
    Admin admin = new Admin();

    string st = "Disable";
    LinkButton lnkbtn;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();

        MainData();
    }

    private void BindData()
    {
        GridViewAllUsersDetails.DataSource = admin.GetUserDetails();
        GridViewAllUsersDetails.DataBind();
    }

    private void MainData()
    {
        foreach (GridViewRow r in GridViewAllUsersDetails.Rows)
        {
            lnkbtn = (LinkButton)r.FindControl("LinkbtnStatus");
            if (lnkbtn.Text == "pending")
            {
                lnkbtn.Text = "Approve";
            }
            else if (lnkbtn.Text == "Enable")
            {
                lnkbtn.Text = "Block";

            }
            else
            {
                lnkbtn.Text = "Blocked";
            }
        }
    }
    protected void GridViewAllUsersDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        string st = "";
        int id = 0;
        string name = "Enable";
        if(e.CommandName=="Status")
            id = Convert.ToInt32(e.CommandArgument);
        admin.LoginId=id;
        st = admin.GetUserStatus(admin);
        if(st=="Enable")
        {
            name = "Disable";
        }

        admin.Status = name;
        int i = admin.UpdateStatus(admin);
        if(i>0)
        {
            BindData();
            MainData();
        }
      
    }
}