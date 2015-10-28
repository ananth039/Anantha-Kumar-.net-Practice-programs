using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace array_list_in_asp.net
{
    public partial class array_list_is_added_to_list_box_control_in_asp_net : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ArrayList aList = new ArrayList();
        protected void btnAddWeeks_Click(object sender, EventArgs e)
        {
           
            aList.Add("Sunday");
            aList.Add("Monday");
            aList.Add("Tuesday");
            aList.Add("Wednesday");
            aList.Add("Thurday");
            aList.Add("Friday");
            aList.Add("Saturday");
            ListBox1.DataSource = aList;
            ListBox1.DataBind();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            aList.Remove("Monday");
            Response.Redirect("array list is added to list box control in asp.net.aspx");
        }

        protected void btnAddmonday_Click(object sender, EventArgs e)
        {
            aList.Insert(1, "week");
        }

        protected void btnsort_Click(object sender, EventArgs e)
        {
            aList.Sort();
        }
    }
}