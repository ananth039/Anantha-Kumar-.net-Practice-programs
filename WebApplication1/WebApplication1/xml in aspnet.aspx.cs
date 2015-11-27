using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace WebApplication1
{
    public partial class xml_in_aspnet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = Server.MapPath("emp.xml");
            if(!IsPostBack)
            {
                if(File.Exists(str)==false)
                {
                    createXml();
                }
            }
        }

        private void createXml()
        {
            DataTable dt = new DataTable("empTable");
            dt.Columns.Add("EmpNo",Type.GetType("System.Int32"));
            dt.Columns.Add("EmpName", Type.GetType("System.String"));
            dt.Columns.Add("Salary", Type.GetType("System.Int32"));
            DataRow r = dt.NewRow();
            r[0] = 1;
            r[1] = "Rama";
            r[2] = 1000;
            dt.Rows.Add(r);
            string str = Server.MapPath("emp.xml");
            dt.WriteXml(str);


        }
        private void GetXml()
        {
            string str = Server.MapPath("emp.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string str = Server.MapPath("emp.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(str);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = Convert.ToInt32(txtempno.Text);
            dr[1] = txtempname.Text;
            dr[2] = Convert.ToInt32(txsal.Text);
            ds.Tables[0].Rows.Add(dr);
            ds.WriteXml(str);
            GetXml();
            txtempno.Text = " ";
            txtempname.Text = " ";
            txsal.Text = " ";

        }
    }
}