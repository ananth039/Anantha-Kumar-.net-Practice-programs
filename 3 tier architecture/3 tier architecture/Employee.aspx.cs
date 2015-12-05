using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessAccessLayer;
using System.Data;

namespace _3_tier_architecture
{
    public partial class Employee : System.Web.UI.Page
    {
        DaEmployee daemp = new DaEmployee();
        BlEmployee blemp = new BlEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                LoadDropDown();
            }
        }

        private void LoadDropDown()
        {
            DataTable dt = blemp.GetDeptData();
            ddlDeptName.DataTextField = "dname";
            ddlDeptName.DataValueField = "did";
            ddlDeptName.DataSource = dt;
            ddlDeptName.DataBind();
            ddlDeptName.Items.Insert(0, new ListItem("Select", "0"));
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            int i = 0;
            daemp.Name = txtName.Text;
            daemp.Salary = int.Parse(txtSalary.Text);
            daemp.DepartmentId = int.Parse(ddlDeptName.SelectedValue);
            i = blemp.InsertEmp(daemp);
            if (i > 0)
            {
                Response.Write("Record inserted");
            }
            else
            {
                Response.Write("Record not  inserted");
            }
            ClearControlsData(Page.Controls);

        }
            public void ClearControlsData(ControlCollection ctrl)
            {

            foreach(Control ctr in ctrl)
            {
                if(ctr is TextBox)
               
                    (ctr as TextBox).Text = " ";
                
                if(ctr is DropDownList)
                    (ctr as DropDownList).SelectedIndex=0;

                ClearControlsData(ctr.Controls);
            }
                        
            }
        }
    }

