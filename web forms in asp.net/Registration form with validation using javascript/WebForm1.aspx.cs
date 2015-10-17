using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_form_with_validation_using_javascript
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string uname = txtUserName.Text;
            string pwd = txtpassword.Text;
            string cpwd = txtConformPassword.Text;
            string email = txtEmail.Text;
            string var="/[0-9]/";
            if(string.IsNullOrWhiteSpace(name))
            {
                lblstatus.Text = "please enter name";
                txtName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(uname))
            {
                lblstatus.Text = "please enter user name";
                txtUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(pwd))
            {
                lblstatus.Text = "please enter user pwd";
                txtpassword.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cpwd))
            {
                lblstatus.Text = "please enter user cpwd";
                txtConformPassword.Focus();
            }
            if(pwd.Length>8)
            {
                lblstatus.Text = "password should be minum 8  characters";
            }
            if(pwd.Contains("@"))
            {
                lblstatus.Text = "password should be contain @ symbols";

            }
          if(pwd.Contains(var))
          {
              lblstatus.Text = "password should be contain one number";
          }

        }
    }
}