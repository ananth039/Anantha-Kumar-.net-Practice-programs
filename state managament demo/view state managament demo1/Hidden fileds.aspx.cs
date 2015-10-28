using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace view_state_managament_demo1
{
    public partial class Hidden_fileds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int newVal = Convert.ToInt32(HiddenField1.Value) +1;
            HiddenField1.Value = newVal.ToString();
            Label3.Text = HiddenField1.Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}