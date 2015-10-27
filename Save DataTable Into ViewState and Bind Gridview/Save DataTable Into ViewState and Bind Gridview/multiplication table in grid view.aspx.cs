using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;

namespace Save_DataTable_Into_ViewState_and_Bind_Gridview
{
    public partial class multiplication_table_in_grid_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMupltiply_Click(object sender, EventArgs e)
        {
            double number = 0;
            double range = 0;
            double answer;
            
            List<string> multiplication = new List<string>();
            GridView1.DataSource = null;
            if (double.TryParse(txtenterNumber.Text, out number) && double.TryParse(txtRange.Text, out range))
            {
                for(double i=1;i<=range;i++)
                {
                    answer = i * number;
                    multiplication.Add(string.Format("{0} x {1} = {2} ", i, number, answer.ToString()));
                  
                }
                GridView1.DataSource = multiplication;
            }
            else
            {
                txtstatus.Text = "please enter values in text fields";
            }
        }
    }
}