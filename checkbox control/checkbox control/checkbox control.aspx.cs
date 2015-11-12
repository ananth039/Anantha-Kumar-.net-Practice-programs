using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace checkbox_control
{
    public partial class checkbox_control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((chbTelugu.Checked)||(chbEnglish.Checked)||(chbHindi.Checked)||(chbaTamil.Checked))
            {
                string msg="Your selected languages are:<br/>"; 
                if(chbTelugu.Checked)
                {
                    msg=msg+chbTelugu.Text+"<br/>";
                }
                if(chbEnglish.Checked)
                {
                    msg = msg + chbEnglish.Text + "<br/>";
                }
                if(chbHindi.Checked)
                {
                    msg = msg + chbHindi.Text + "<br/>";
                }
                if(chbaTamil.Checked)
                {
                    msg = msg + chbaTamil.Text + "<br/>";
                }
                lblmsg.Text = msg;
            }
        }
    }
}