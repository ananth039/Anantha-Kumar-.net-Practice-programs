using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace email_send_from_asp.net_demo1
{
    public partial class email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string HostAdd = ConfigurationManager.AppSettings["Host"].ToString();
            string FromMailId = ConfigurationManager.AppSettings["FromMail"].ToString();
            string passsword = ConfigurationManager.AppSettings["password"].ToString();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(FromMailId);
            mail.Subject = txtSubject.Text;
            mail.Body = txtBody.Text;
            mail.IsBodyHtml = true;
            mail.To.Add(new MailAddress(txtToAddress.Text));


            SmtpClient smtp = new SmtpClient();
            smtp.Host = HostAdd;
             
            //attachments to add to mail
            Attachment imgattch = new Attachment(Server.MapPath("images.jpg"));
            imgattch.ContentId = "images.jpg";
            mail.Attachments.Add(imgattch);

            //Network and security relatedn credential
            smtp.EnableSsl = true;
            NetworkCredential Networkedcred = new NetworkCredential();
            Networkedcred.UserName = mail.From.Address;
            Networkedcred.Password = passsword;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = Networkedcred;
            smtp.Port = 587;

            try
            {
                //send email
                smtp.Send(mail);
                btnSend.Text = "sucess";
            }
            catch(Exception ex)
            {
                btnSend.Text = "fail";
            }


        }
    }
}