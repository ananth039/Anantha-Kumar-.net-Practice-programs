using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Users_ViewAllQuestions : System.Web.UI.Page
{
    DaFourms fourm = new DaFourms();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridViewQuestions.DataSource = fourm.GetAllQuestions();
        GridViewQuestions.DataBind();
    }
}