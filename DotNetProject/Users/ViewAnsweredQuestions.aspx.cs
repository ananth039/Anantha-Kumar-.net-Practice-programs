using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Users_ViewAnsweredQuestions : System.Web.UI.Page
{
    DaFourms fourms = new DaFourms();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = fourms.GetAllAnsweredQuestions();
        GridView1.DataBind();
    }

  
}