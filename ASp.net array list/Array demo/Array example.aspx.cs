using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Array_demo
{
    public partial class Array_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] array = new string[7];
            array[0] = "Sunday";
            array[1] = "Monday";
            array[2] = "Tuesday";
            array[3] = "Wednsday";
            array[4] = "Thursday";
            array[5] = "friday";
            array[6] = "Saturday";

            ListBox1.DataSource = array;
            ListBox1.DataBind();
        }
    }
}