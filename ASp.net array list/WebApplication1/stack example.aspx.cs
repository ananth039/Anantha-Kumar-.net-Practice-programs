using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class stack_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
        }
       
        protected void btnColors_Click(object sender, EventArgs e)
        {
            Stack st = new Stack();
            st.Push("red");
            st.Push("blue");
            st.Push("green");
            st.Push("orange");
            st.Push("yellow");
            ddlColors.DataSource = st;
            ddlColors.DataBind();
            
            //st.Pop();
      
        }

        protected void btnRemoveColor_Click(object sender, EventArgs e)
        {
           
        }
    }
}