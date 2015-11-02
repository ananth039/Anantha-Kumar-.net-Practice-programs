using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Registartion
{
    public partial class EmpRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Text = string.Empty;
            rbmale.Checked = false;
            rbFemale.Checked = false;
            txtDateOfBirth.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtConformPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtphno.Text = string.Empty;
            txtSecurityQuestionanswer.Text = string.Empty;
            txtUserName.Text = string.Empty;
            DdlDesignation.ClearSelection();
            DdlSecurityQuestion.ClearSelection();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string Gender = null;

            StringBuilder sb = new StringBuilder();


            if (rbmale.Checked == true)
            {
                Gender = "Male";

            }
            else if (rbmale.Checked == true)
            {
                Gender = "female";

            }
            else
            {

                lblgenderError.Text = "please select any one of the field";
            }

            string connectionstring = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand comand2 = new SqlCommand("select Email,MobilNo,Username from EmpRegistration", connection);
                using (SqlDataReader reader = comand2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if ((txtEmail.Text == reader["Email"].ToString()) && txtphno.Text == reader["MobilNo"].ToString() && txtUserName.Text == reader["Username"].ToString())
                        {
                            lblEmailExisterror.Text = "Email is already exist";
                            lblMobileexistError.Text = "mobile Number is already exist";
                            lblusernameExisterror.Text = "user name is already exist";
                            sb.Append("error");


                        }

                  
                    }
                }
            }
            if(sb.Length==0)
            {
                SaveDetails(Gender, connectionstring);
            }
        }

        private void SaveDetails(string Gender, string connectionstring)
        {


            using (SqlConnection connection2 = new SqlConnection(connectionstring))
            {
                connection2.Open();
                SqlCommand insertCommand = new SqlCommand("insert into  EmpRegistration (FullName,Gender,DateOfBirth,Designation,Email,MobilNo,Address,Username,Password,ConformPasword,SecuityQuestion,Answer)  values(@FullName,@gender,@dateofBirth,@Designation,@Email,@MobileNo,@address,@username,@password,@conformpassword,@SecurityQuestion,@Answer)", connection2);


                //dd new SqlParameters to the insertCommand.

                insertCommand.Parameters.Add(new SqlParameter("FullName", txtFullName.Text));
                insertCommand.Parameters.Add(new SqlParameter("gender", Gender));
                insertCommand.Parameters.Add(new SqlParameter("dateofBirth", txtDateOfBirth.Text));
                insertCommand.Parameters.Add(new SqlParameter("Designation", DdlDesignation.SelectedItem.Value));
                insertCommand.Parameters.Add(new SqlParameter("Email", txtEmail.Text));
                insertCommand.Parameters.Add(new SqlParameter("MobileNo", txtphno.Text));
                insertCommand.Parameters.Add(new SqlParameter("address", txtAddress.Text));
                insertCommand.Parameters.Add(new SqlParameter("username", txtUserName.Text));
                insertCommand.Parameters.Add(new SqlParameter("password", txtPassword.Text));
                insertCommand.Parameters.Add(new SqlParameter("conformpassword", txtConformPassword.Text));
                insertCommand.Parameters.Add(new SqlParameter("SecurityQuestion", DdlSecurityQuestion.SelectedItem.Value));
                insertCommand.Parameters.Add(new SqlParameter("Answer", txtSecurityQuestionanswer.Text));

                try
                {


                    insertCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }

           
    }

     





        


      