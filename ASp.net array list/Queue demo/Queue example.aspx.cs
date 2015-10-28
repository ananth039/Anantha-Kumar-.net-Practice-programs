using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Queue_demo
{
    public partial class Queue_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddvalues_Click(object sender, EventArgs e)
        {
            Queue qu = new Queue();
            qu.Enqueue("Nokia");
            qu.Enqueue("Sony");
            qu.Enqueue("Apple");
            qu.Enqueue("Samsung");
            qu.Enqueue("Celkon");
            qu.Enqueue("Acer");
            DropDownList1.DataSource = qu;
            DropDownList1.DataBind();

// remove the values from queue
           // qu.Dequeue();
        }
    }
}