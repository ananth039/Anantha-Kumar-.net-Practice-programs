using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace display_text_in__anothetr_textbox_using_postback
{
    public partial class simple_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtYourText_TextChanged(object sender, EventArgs e)
        {
            string text=txtYourText.Text;
            txtOutput1.Text = text.ToLower();
            txtoutput2.Text = text.ToUpper();
        }
    }
}