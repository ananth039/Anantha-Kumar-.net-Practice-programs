using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace list_demo
{
    public partial class List_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> months = new List<string>();

            //add items in a List collection
            months.Add("January");
            months.Add("Frebruary");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");

            //Remove an Item from list
            months.Remove("March");

            //insert an item in the list
            months.Insert(2, "March");

            ListBox1.DataSource = months;
            ListBox1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<int> days = new List<int>();

            //add items in a List collection
            days.Add(1);
            days.Add(2);
            days.Add(3);
            days.Add(4);
            days.Add(5);
            days.Add(6);
            days.Add(7);
            days.Add(8);
            days.Add(9);
            days.Add(10);

            //Remove an Item from list
            days.Remove(10);

            //insert an item in the list
            days.Insert(9, 10);

            ListBox2.DataSource = days;
            ListBox2.DataBind();
        }
    }
}