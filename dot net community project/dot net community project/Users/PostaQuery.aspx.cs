using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DataAccessLayer;
using System.Drawing;

namespace dot_net_community_project.Users
{
    public partial class PostaQuery : System.Web.UI.Page
    {
        DAUsers usrs = new DAUsers();
        DaFourms fourms = new DaFourms();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            AutogenerateQuestionId();
            
        }

        private void AutogenerateQuestionId()
        {
            int QuestionId = fourms.AutoGenerateQuestionId();

            lblDisplayQuestionId.Text = QuestionId.ToString();

        }

        protected void btnPostQuery_Click(object sender, EventArgs e)
        {
            usrs.Username = Session["username"].ToString();
            fourms.QuestionId = Convert.ToInt32(lblDisplayQuestionId.Text);
            fourms.Question = txtQuestion.Text;
          fourms.LoginId=Convert.ToInt32(usrs.GetLoginId(usrs).ToString());
          int statusOfpostQuery = fourms.InsertpostQueries(fourms);
            if(statusOfpostQuery>0)
            {
                lblmsg.Text = "your query is sucessfully posted";
                lblmsg.ForeColor = Color.Green;
                ClearControls(Page.Controls);
                AutogenerateQuestionId();
                
            }
            else
            {
                lblmsg.Text = "your query is not sucessfully posted";
                lblmsg.ForeColor = Color.Red;
                ClearControls(Page.Controls);

            }
            

           
        }
        public void ClearControls(ControlCollection ctrl)
        {
            foreach (Control ctl in ctrl)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Text = "";
                }
               
                ClearControls(ctl.Controls);
            }
        }
    }
}