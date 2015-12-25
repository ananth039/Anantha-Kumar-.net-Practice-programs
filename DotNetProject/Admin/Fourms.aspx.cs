using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAcessLayer;

public partial class Admin_Fourms : System.Web.UI.Page
{
    DaFourms fourms = new DaFourms();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DisplayFourms();
        }
       
    }

    private void DisplayFourms()
    {
        GridViewAllFourms.DataSource = fourms.GetAllAnsweredQuestions();
        GridViewAllFourms.DataBind();
    }
    
    protected void ImageButtonDeleteFourms_Click1(object sender, ImageClickEventArgs e)
    {
        ImageButton imgbtn = sender as ImageButton;
        GridViewRow grow = imgbtn.NamingContainer as GridViewRow;
        fourms.QuestionId = Convert.ToInt32(GridViewAllFourms.DataKeys[grow.RowIndex].Value.ToString());
        int FourmsDeleteStatus = fourms.DeleteFourms(fourms);
        if (FourmsDeleteStatus > 0)
        {
            Response.Write("<script>alert('" + FourmsDeleteStatus + " is deleted successfully')</script>");
            DisplayFourms();

        }
        else
        {
            Response.Write("<script>alert('" + FourmsDeleteStatus + " is not  deleted')</script>");
            DisplayFourms();

        }

    }
  
}