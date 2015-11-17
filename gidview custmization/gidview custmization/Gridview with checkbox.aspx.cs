using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gidview_custmization
{
    public partial class Gridview_with_checkbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            foreach(GridViewRow rows in GridView1.Rows)
            {
                CheckBox mycheckbox = (CheckBox)rows.FindControl("Checkbox1");
                try
                {


                    if (mycheckbox.Checked)
                    {
                        int eid = (int)GridView1.DataKeys[rows.RowIndex].Value;
                        SqlDataSource1.DeleteParameters["eno"].DefaultValue = eid.ToString();
                        SqlDataSource1.Delete();
                        lblmsg.Text = "Record deleted sucessfully";
                    }
                }catch(Exception ex)
                {
                    lblmsg.Text = ex.Message;
                }

            }
        }

        protected void checkall_CheckedChanged(object sender, EventArgs e)
        {
            if(checkall.Checked)
            {
                foreach(GridViewRow rows in GridView1.Rows)
                {
                    CheckBox mycheckbox = (CheckBox)rows.FindControl("checkbox1");
                    mycheckbox.Checked = true;
                }
            }
            else
            {
                foreach(GridViewRow rows in GridView1.Rows)
                {
                    CheckBox mycheckBox = (CheckBox)rows.FindControl("checkbox1");
                    mycheckBox.Checked = false;
                }
            }
        }
    }
}