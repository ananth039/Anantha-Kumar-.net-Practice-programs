using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace checkbox_list
{
    public partial class checkbox_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 0;
            lblmsg.Text = "your known languages are:<br/>";
            for(int i=0;i<CheckBoxList1.Items.Count;i++)
            {
                if(CheckBoxList1.Items[i].Selected)
                {
                    lblmsg.Text += CheckBoxList1.Items[i].Text + "<br/>";
                    a++;
                }
            }
            if(a==0)
            {
                lblmsg.Text ="please select any one";
            }

        }
    }
}