using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;

namespace WebApplication5
{
    public partial class StudentMarksEntryForm : System.Web.UI.Page
    {
        DaStudent dastd = new DaStudent();
        BlStudent bstd = new BlStudent();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            dastd.Sname = txtsname.Text;
            dastd.Subject1 = int.Parse(txtsub1.Text);
            dastd.Subject2 = int.Parse(txtsub1.Text);
            dastd.Subject3 = int.Parse(txtsub3.Text);
            i = bstd.InsertStudentDetails(dastd);
            if (i > 0)
                Response.Write("Record is inserted");
            else
                Response.Write("Record is not inserted");
            ClearControls(Page.Controls);

            DisplayStudentDetails();

        }

        private void DisplayStudentDetails()
        {
            girdviewEmpdetails.DataSource = dastd.GetSudentStdetails();
            girdviewEmpdetails.DataBind();
        }
        public void ClearControls(ControlCollection cntrl)
        {
           foreach(Control ctl in cntrl)
           {
               if(ctl is TextBox)
               {
                   (ctl as TextBox).Text = " ";
               }
               ClearControls(ctl.Controls);
           }
        }
    }
}