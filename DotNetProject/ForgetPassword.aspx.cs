using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using DataAcessLayer;



public partial class ForgetPassword : System.Web.UI.Page
{
    DAUsers usrs = new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //retrive the password from Users table and sent passsword to user registered mail address
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        usrs.Username = txtUserName.Text;
        usrs.SecQuestion = DropDownListSecurityquestion.SelectedItem.Value.ToString();
        usrs.Answer = txtAnswer.Text;
        int countUserCheck = usrs.checkUser(usrs);
        if (countUserCheck > 0)
        {

            string password = usrs.GetPassword(usrs); //retrive the password from users table 

            SendPasswordtoEmail(usrs);  //send email to user email address

            ClearControlsData(Page.Controls); //clear controls values
        }
        else
        {
            //if user credentials like username,secquestion,answer are not matched to displayed friendly message(error message)

            lblmsg.Text = "Invalid UserName and Security question ,Answer";
            lblmsg.ForeColor = Color.Red;
            ClearControlsData(Page.Controls);
        }


    }

    //if clear the  values in form controls
    private void ClearControlsData(ControlCollection ctrl)
    {
        foreach (Control ctr in ctrl)
        {
            if (ctr is TextBox)
                (ctr as TextBox).Text = " ";
            if (ctr is DropDownList)
                (ctr as DropDownList).SelectedIndex = 0;
            ClearControlsData(ctr.Controls);

        }


    }


    //if three user inputs are matched with users table and password is sent  to user registerd email address.
    private void SendPasswordtoEmail(DAUsers usrs)
    {

        string email = usrs.GetEmailId(usrs);

        string HostAdd = ConfigurationManager.AppSettings["Host"].ToString();  //host name is  gmail or yahoo or outlook
        string FromMailId = ConfigurationManager.AppSettings["FromMail "].ToString(); //sender email addresss
        string Password = ConfigurationManager.AppSettings["Password"].ToString();  //sender email password

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(FromMailId);



        mail.Subject = " Your  Login password in .Net Community Project";  //subject of email

        mail.Body = "Hello " + usrs.Username + " <br/> Your Login password: " + usrs.GetPassword(usrs) + "  <br /> Click here go to Login Page  <br />" + "http://localhost:1033/Login.aspx";
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
            lblmsg.Text = "your password is send to Registerd email";
            lblmsg.ForeColor = Color.Green;
            ClearControlsData(Page.Controls);

        }
        catch (Exception ex)
        {

            lblmsg.Text = "your password is not sent to registerd email address";
            lblmsg.ForeColor = Color.Red;
            ClearControlsData(Page.Controls);
        }
    }
    protected void txtUserName_TextChanged(object sender, EventArgs e)
    {
        usrs.Username = txtUserName.Text;
        int checkEmailValid = usrs.CheckedUserName(usrs);
        if (checkEmailValid > 0)
        {
            lblerrormsg.Visible = false;
        }
        else
        {
            
            lblerrormsg.Text = "This username is not exist.please enter valid username";

            lblerrormsg.Focus();
        }
    }
}