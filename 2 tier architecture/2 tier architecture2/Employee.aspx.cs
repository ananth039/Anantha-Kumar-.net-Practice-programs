using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_tier_architecture2
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dt = dacobject.GetDepartmentData();
                ddldeptName.DataTextField = "dname";
                ddldeptName.DataValueField = "did";
                ddldeptName.DataSource = dt;
                ddldeptName.DataBind();
                ddldeptName.Items.Insert(0, new ListItem("Select", "0"));


            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int i = 0;
            dacobject.Name = txtName.Text;
            dacobject.Salary = int.Parse(txtSalary.Text);
            dacobject.DepartmentId = int.Parse(ddldeptName.SelectedValue);
            i = dacobject.insertEmployee(dacobject);

            clearControls();
            if (i > 0)
            {
                Response.Write("Record is inserted");
            }
            else
            {
                Response.Write("inserted Failed");
            }

        }
    }
}