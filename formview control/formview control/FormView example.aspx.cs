using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace formview_control
{
    public partial class FormView_example : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
          GetData();


        }

private void GetData()
{
            SqlCommand cmd=new SqlCommand("Select * from emp",con);
           SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
           FormView1.DataSource=ds;
            FormView1.DataBind();
}

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FormView1.PageIndex=e.NewPageIndex;
            GetData();
        }
    }
}