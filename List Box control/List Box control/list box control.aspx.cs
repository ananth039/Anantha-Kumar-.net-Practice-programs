using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace List_Box_control
{
    public partial class list_box_control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.SelectionMode = ListSelectionMode.Single;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = "Your selected Location is: " + ListBox1.SelectedItem.ToString();
        }
    }
}