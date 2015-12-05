using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DataAccessLayer;
using System.Data;

namespace _2_tier_architecture
{
    public partial class Employee : System.Web.UI.Page
    {
        DAEmployee dacobject = new DAEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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
            if(i>0)
            {
                Response.Write("Record is inserted");
            }
            else
            {
                Response.Write("inserted Failed");
            }

        }

        private void clearControls()
        {
            txtName.Text = "";
            txtSalary.Text = " ";
            ddldeptName.SelectedIndex = 0;
        }
    }
}