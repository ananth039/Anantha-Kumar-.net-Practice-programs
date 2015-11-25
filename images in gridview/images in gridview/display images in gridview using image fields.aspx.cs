using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace images_in_gridview
{
    public partial class display_images_in_gridview_using_image_fields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = EmployeeDataAccessLayer.GetAllEmployee();
            GridView1.DataBind();

        }
    }
}