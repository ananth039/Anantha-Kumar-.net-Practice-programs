using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Configuration;
using System.Net.Mail;
using System.Net;

using DataAcessLayer;


public partial class UserRegisteration : System.Web.UI.Page
{
    DAUsers usr = new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtLoginId.Text = usr.AutoGenerateLoginId().ToString();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        usr.LoginId = Convert.ToInt32(txtLoginId.Text);
        usr.Name = txtName.Text;
        usr.Phno = txtphno.Text;
        usr.Email = txtEmail.Text;
        usr.Username = txtUserName.Text;
        usr.Password = txtPassword.Text;
        usr.SecQuestion = DropDownListSecurityquestion.SelectedItem.Value.ToString();
        usr.Answer = txtAnswer.Text;
        int i = usr.insertUserDetails(usr);
        if (i > 0)
        {
            Lblmsg.Text = "successfully Registered";
            Lblmsg.ForeColor = Color.Green;
        }
        else
        {
            Lblmsg.Text = "Not Successfully Registered";
            Lblmsg.ForeColor = Color.Red;
        }
        SendPasswordtoEmail();

        ClearControls(Page.Controls);
        txtLoginId.Text = usr.AutoGenerateLoginId().ToString();
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
    private void SendPasswordtoEmail()
    {

        string email = txtEmail.Text;

        string HostAdd = ConfigurationManager.AppSettings["Host"].ToString();  //host name is  gmail or yahoo or outlook
        string FromMailId = ConfigurationManager.AppSettings["FromMail "].ToString(); //sender email addresss
        string Password = ConfigurationManager.AppSettings["Password"].ToString();  //sender email password

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(FromMailId);

        mail.Subject = "You are Succesfully Registerd in .Net Community Project";  //subject of email

        mail.Body = "hello " + txtName.Text + " you are sucessfully Registerd in .Net Community Project <br/>" + " your User Credential are <br /> UserName: " + txtUserName.Text + "<br/> Password: " + txtPassword.Text + " <br/> thank you for Registartion <br/> Click here to Login http://localhost:1033/Login.aspx ";
        mail.IsBodyHtml = true;
        mail.To.Add(new MailAddress(email));

        SmtpClient smtp = new SmtpClient();
        smtp.Host = HostAdd;


        smtp.EnableSsl = true;
        NetworkCredential networkcred = new NetworkCredential();
        networkcred.UserName = mail.From.Address;
        networkcred.Password = Password;
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = networkcred;
        smtp.Port = 587;

        try
        {
            smtp.Send(mail);
            //lblmsg.Text = "your password is send to Registerd email";
            //lblmsg.ForeColor = Color.Green;
            ClearControls(Page.Controls);

        }
        catch (Exception ex)
        {
            Lblmsg.Text = ex.Message;

            ClearControls(Page.Controls);
        }
    }

    protected void txtphno_TextChanged(object sender, EventArgs e)
    {
        usr.Phno = txtphno.Text;
        int checkphnoValid = usr.CheckedPhno(usr);
        if(checkphnoValid>0)
        {
            lblerrormsg.Text = "This phno is already exist";
           
            txtphno.Focus();
        }
        else
        {
            lblerrormsg.Visible = false;
        }
    }
     
           protected void txtEmail_TextChanged(object sender, EventArgs e)
           {
               usr.Email = txtEmail.Text;
               int checkEmailValid = usr.CheckedUserEmail(usr);
               if (checkEmailValid > 0)
               {
                   lblerrormsg2.Text = "This Email is already Exist";

                   lblerrormsg2.Focus();
               }
               else
               {
                   lblerrormsg2.Visible = false;
               }
       
           }
           protected void txtUserName_TextChanged(object sender, EventArgs e)
           {
               usr.Username = txtUserName.Text;
               int checkEmailValid = usr.CheckedUserName(usr);
               if (checkEmailValid > 0)
               {
                   lblerrormsg3.Text = "This User Name is already Exist";

                   lblerrormsg3.Focus();
               }
               else
               {
                   lblerrormsg3.Visible = false;
               }
       
           }
}