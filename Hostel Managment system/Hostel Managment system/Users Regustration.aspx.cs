using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace Hostel_Managment_system
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string gender;
            int id = 1; ;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string username = txtUserName.Text;
            string pwd = txtPwd.Text;
            string cpwd = txtcpwd.Text;
            if (rbmale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string conectionstring = ConfigurationManager.ConnectionStrings["ananth"].ConnectionString;
            try
            {

                using (SqlConnection sc = new SqlConnection(conectionstring))
                {
                    sc.Open();
                    string query = "insert into UsersRegistration(FirstName,LastName,Gender,Email,phoneNumber,username,Password,cpwd) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                    SqlCommand insertCommand = new SqlCommand(string.Format(query, fname, lname, gender, email, phone, username, pwd, cpwd), sc);
                    insertCommand.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                lblStatus.Text = ex.Message;
            }

        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {

        }

        protected void btndisplay_Click1(object sender, EventArgs e)
        {
           
        }
    }
}