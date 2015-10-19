using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registartionpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblstatus.Visible = false;
        imagecorrect.Visible = false;
    }
  
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        lblstatus.Visible = true;
        imagecorrect.Visible = true;

    }
    protected void rbmale_CheckedChanged(object sender, EventArgs e)
    {

    }
}