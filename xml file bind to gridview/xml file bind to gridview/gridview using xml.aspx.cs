using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

namespace xml_file_bind_to_gridview
{
    public partial class gridview_using_xml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("Employee.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}