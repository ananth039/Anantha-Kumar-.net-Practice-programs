using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;


namespace export_pdf_from_gridview
{
    public partial class example_1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["murthi"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from emp", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"emp");
          GridView1.DataSource=ds;
            GridView1.DataBind();

        }

        protected void btnExporttoPdf_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("Content-diposition", "attachment; filename=Employee.xls");
            Response.ContentType="application/excel";
            StringWriter stringwriter = new StringWriter();
            HtmlTextWriter htmltextwriter = new HtmlTextWriter(stringwriter);
            GridView1.RenderControl(htmltextwriter);
            Response.Write(stringwriter.ToString());
           
            Response.End();



        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        
    }
}