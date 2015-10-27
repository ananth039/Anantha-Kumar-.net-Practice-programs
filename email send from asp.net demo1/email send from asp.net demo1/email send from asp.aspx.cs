using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace email_send_from_asp.net_demo1
{
    public partial class email_send_from_asp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string To = txtToAddress.Text;
            string From = txtFromAdress.Text;
            string subject = txtBody.Text;
            string body = txtBody.Text;
            string password = "".ToString();
            MailMessage Mail = new MailMessage();
            Mail.To.Add(To);
            Mail.From = new MailAddress(From);
            Mail.Subject = subject;
            Mail.Body = body;
            Mail.IsBodyHtml = true;


            //Attachment imgattch = new Attachment(Server.MapPath("images.jpg"));
            //imgattch.ContentId = "images.jpg";
            //Mail.Attachments.Add(imgattch);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            NetworkCredential credintal = new NetworkCredential(From, password);
            client.Credentials = credintal;

            try
            {

                client.Send(Mail);
                btnSend.Text = "sucess";

            }
            catch
            {

                btnSend.Text = "Fail";
            }


        }
    }
}