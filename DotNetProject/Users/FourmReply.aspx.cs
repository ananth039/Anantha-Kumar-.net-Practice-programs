using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Users_FourmReply : System.Web.UI.Page
{
    DaFourms fourms = new DaFourms();
    DAUsers usrs = new DAUsers();
    protected void Page_Load(object sender, EventArgs e)
    {
       fourms.QuestionId=Convert.ToInt32(Request.QueryString["QuestionId"]);
       lblDisplayQuestion.Text = fourms.GetQuestion(fourms);
     
    }

    protected void btnPostReply_Click(object sender, EventArgs e)
    {
        usrs.Username = Session["UserName"].ToString();
        fourms.LoginId = Convert.ToInt32(usrs.GetLoginId(usrs).ToString());
        fourms.Reply = txtAnswer.Text;

        int status = fourms.InsertFourmsReply(fourms);
        if(status>0)
        {
            Response.Write("<script>alert('your answer is sucessfully posted');</script>");
        }
        txtAnswer.Text = "";
        lblDisplayQuestion.Text = "";

    }
}