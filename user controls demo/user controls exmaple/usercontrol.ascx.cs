using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace user_controls_exmaple
{
    public partial class usercontrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string inputstring
        {
            set
            {
                Label1.Text = value;
              

            }
         
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            inputstring = "Sucesss";
            TextBox2.Text = TextBox1.Text;
            
        }
    }
}