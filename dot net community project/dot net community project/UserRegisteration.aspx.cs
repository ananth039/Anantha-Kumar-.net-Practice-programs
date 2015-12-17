using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DataAccessLayer;
using System.Drawing;

namespace dot_net_community_project
{
    public partial class Register : System.Web.UI.Page
    {
        DAUsers usr = new DAUsers();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLoginId.Text = usr.AutoGenerateLoginId().ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
         
             usr.LoginId= Convert.ToInt32(txtLoginId.Text);
             usr.Name= txtName.Text;
             usr.Phno = txtphno.Text;
             usr.Email = txtEmail.Text;
             usr.Username = txtUserName.Text;
             usr.Password = txtPassword.Text;
             usr.SecQuestion = DropDownListSecurityquestion.SelectedItem.Value.ToString();
             usr.Answer= txtAnswer.Text;
             int i=usr.insertUserDetails(usr);
            if(i>0)
            {
                Lblmsg.Text="successfully Registered";
                Lblmsg.ForeColor = Color.Green;
            }
                else
                {
                    Lblmsg.Text = "Not Successfully Registered";
                    Lblmsg.ForeColor = Color.Red;
                }

            ClearControls(Page.Controls);
            txtLoginId.Text=usr.AutoGenerateLoginId().ToString();
        }

        public void ClearControls(ControlCollection ctrl)
        {
            foreach (Control ctl in ctrl)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Text = "";
                }
                if (ctl is DropDownList)
                {
                    (ctl as DropDownList).SelectedIndex = 0;
                }
                ClearControls(ctl.Controls);
            }
        }

        protected void CvUserName_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length >= 6)
                args.IsValid = true;
            else
                args.IsValid = false;
        }

      
    }
}