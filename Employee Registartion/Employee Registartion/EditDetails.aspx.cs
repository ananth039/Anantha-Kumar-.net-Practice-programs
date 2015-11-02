using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Registartion
{
    public partial class EditDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand comand2 = new SqlCommand("select * from EmpRegistration", connection);
                using (SqlDataReader reader = comand2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtFullName.Text = reader["FullName"].ToString();
                        if (reader["Gender"].ToString() == "Male")
                        {
                            rbmale.Checked=true;
                        }
                        else
                        {
                            rbFemale.Checked=true;
                        }
                        txtDateOfBirth.Text=reader["DateOfBirth"].ToString();
                        DdlDesignation.SelectedItem.Value=reader["Designation"].ToString();
                        txtEmail.Text=reader["Email"].ToString();
                        txtphno.Text=reader["MobilNo"].ToString();
                        txtUserName.Text=reader["Username"].ToString();
                        txtAddress.Text=reader["Address"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        txtConformPassword.Text=reader["ConformPasword"].ToString();
                       DdlSecurityQuestion.SelectedItem.Value=reader["SecuityQuestion"].ToString();
                        txtSecurityQuestionanswer.Text=reader["Answer"].ToString();
                 }
                }
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            string Gender = null;



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
        
            string LoginUserName=Session["username"].ToString();

            using (SqlConnection connection2 = new SqlConnection(connectionstring))
            {
                connection2.Open();
                SqlCommand UpdateCommand = new SqlCommand("update  EmpRegistration set FullName=@FullName,Gender=@gender,DateOfBirth=@dateofBirth,Designation=@Designation,Email=@Email,MobilNo=@MobileNo,Address=@address,Username=@username,Password=@password,ConformPasword=@conformpassword,SecuityQuestion=@SecurityQuestion,Answer=@Answer  where username=@LoginUserName" , connection2);


                //dd new SqlParameters to the insertCommand.

                UpdateCommand.Parameters.Add(new SqlParameter("FullName", txtFullName.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("gender", Gender));
                UpdateCommand.Parameters.Add(new SqlParameter("dateofBirth", txtDateOfBirth.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("Designation", DdlDesignation.SelectedItem.Value));
                UpdateCommand.Parameters.Add(new SqlParameter("Email", txtEmail.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("MobileNo", txtphno.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("address", txtAddress.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("username", txtUserName.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("password", txtPassword.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("conformpassword", txtConformPassword.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("SecurityQuestion", DdlSecurityQuestion.SelectedItem.Value));
                UpdateCommand.Parameters.Add(new SqlParameter("Answer", txtSecurityQuestionanswer.Text));
                UpdateCommand.Parameters.Add(new SqlParameter("LoginUserName",LoginUserName));

                try
                {


                    UpdateCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }

           
        }
    }
}
      