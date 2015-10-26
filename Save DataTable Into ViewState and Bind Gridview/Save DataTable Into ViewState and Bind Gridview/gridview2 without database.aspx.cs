using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Save_DataTable_Into_ViewState_and_Bind_Gridview
{
    public partial class gridview2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void BindGrid(int rowcount)
        {
            int number = int.Parse(TextBox1.Text);
            int range = int.Parse(TextBox2.Text);
            DataTable dt = new DataTable();
            DataRow dr;

            dt.TableName = "Multiplication table";
            dt.Columns.Add(new System.Data.DataColumn("number", typeof(int)));
            dt.Columns.Add(new System.Data.DataColumn("multiply", typeof(int)));
            dt.Columns.Add(new System.Data.DataColumn("result", typeof(int)));

            if (ViewState["Multiplication table"] != null)
            {
                for (int i = 0; i < rowcount + 1; i++)
                {
                    dt = (DataTable)ViewState["Multiplication table"];
                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.NewRow();
                        dr[0] = dt.Rows[0][0].ToString();

                    }
                }

                for (int j = 1; j <= range; j++)
                {
                    dr = dt.NewRow();
                    dr[0] = number;
                    dr[1] = j;
                    dr[2] = j * number;
                    dt.Rows.Add(dr);
                }
            }
            else
            {
                for (int j = 1; j <= range; j++)
                {
                    dr = dt.NewRow();
                    dr[0] = number;
                    dr[1] = j;
                    dr[2] = j * number;
                    dt.Rows.Add(dr);
                }

            }

            // If ViewState has a data then use the value as the DataSource
            if (ViewState["Multiplication table"] != null)
            {
                GridView1.DataSource = (DataTable)ViewState["Multiplication table"];
                GridView1.DataBind();
            }
            else
            {
                // Bind GridView with the initial data assocaited in the DataTable
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
            // Store the DataTable in ViewState to retain the values
            ViewState["Multiplication table"] = dt;

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            // Check if the ViewState has a data assoiciated within it. If
            if (ViewState["Multiplication table"] != null)
            {
                DataTable dt = (DataTable)ViewState["Multiplication table"];
                int count = dt.Rows.Count;
                BindGrid(count);
            }
            else
            {
                BindGrid(1);
            }
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;


            TextBox1.Focus();
        }


    }
}