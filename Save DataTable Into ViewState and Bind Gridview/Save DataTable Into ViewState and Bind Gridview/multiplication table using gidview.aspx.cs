using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Save_DataTable_Into_ViewState_and_Bind_Gridview
{
    public partial class multiplication_table_using_gidview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(TextBox1.Text);
            int range = int.Parse(TextBox2.Text);
            DataTable table = new DataTable();
            DataRow dr;
            table.TableName = "Multiplication table";
           
            table.Columns.Add(new DataColumn("Multiply", typeof(int)));
            table.Columns.Add(new DataColumn("Number", typeof(int)));
            table.Columns.Add(new DataColumn("Result", typeof(int)));
            for(int i=1;i<=range;i++)
            {
                dr=table.NewRow();
                dr["Multiply"] = i;
                dr["number"] = number; 
                dr["Result"] = i * number;
                table.Rows.Add(dr);
            }
            GridView1.DataSource = table;
            GridView1.DataBind();
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
        }
    }
}