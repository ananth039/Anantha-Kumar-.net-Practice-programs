using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

using System.Data.SqlClient;

namespace gridview_demo_examples
{
    public partial class gridview_display_employee_details_based_on_eid_using_drop_down_list : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["employee"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
         
              Bind();

         

        }

        private void Bind()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DropDownList1.Items.Add(dr[0].ToString());

                }
            }
            con.Close();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Employee where eno="+DropDownList1.SelectedItem.ToString(), con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }
    }
}