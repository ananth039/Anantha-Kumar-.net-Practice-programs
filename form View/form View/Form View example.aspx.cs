using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace form_View
{
    public partial class Form_View_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetData();

            }
        }

        private void GetData()
        {
            string connectionstring = @"Data Source=ANANTH\ANANTH;Initial Catalog=Sql queries Practice;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            string s = "Select * from employee";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Empnew");
            con.Close();
            FormView1.DataSource = ds;
            FormView1.DataBind();
        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex = e.NewPageIndex;
            GetData();
           
        }
    }
}