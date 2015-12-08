using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace approve_or_block_the_user_admin__project
{
    public partial class Display_user_details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Project"].ConnectionString);
        LinkButton linkbtn;
        string status = "Disable";
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();

        }

        private void BindData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Login", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            MainData();
        }
        private void MainData()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                linkbtn = (LinkButton)row.FindControl("linkStatus");
                if (linkbtn.Text == "Pending")
                {
                    linkbtn.Text = "Approve";
                }
                else if (linkbtn.Text == "Enable")
                {
                    linkbtn.Text = "Block";
                }
                else
                {
                    linkbtn.Text = "Blocked";
                }

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string st = " ";
            int id = 0;
            string name = "Enable";
            if(e.CommandName=="Status")
            {
                id = Convert.ToInt32(e.CommandArgument);
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Status From Login where LoginId=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                st = dr[0].ToString();
            }
            con.Close();
            if(st=="Enable")
            {
                name = "Disable";
            }
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update Login set Status=@name where LoginId=@id", con);
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@name",name);
            cmd1.ExecuteNonQuery();
            con.Close();
            BindData();
            MainData();

            

            
        }

        

      
    }
}