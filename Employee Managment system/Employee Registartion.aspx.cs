using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee_Registartion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void rbmale_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtFullName.Text = string.Empty;
        rbmale.Checked= false;
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

      StringBuilder Errors = new StringBuilder();
        
        if(rbmale.Checked==true)
        {
            Gender ="Male";
        }
        else if(rbmale.Checked==true)
        {
            Gender = "female";
        }
        else
        {
            Errors.Append("please select any one of the field");
        }

        if(Errors.Length==0)
        {
            SaveEmpDetails(Gender);
        }
        else
        {
            Response.Write(Errors);
        }
     

    }

    private void SaveEmpDetails(string Gender)
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["Employee"].ConnectionString;


        using (SqlConnection connection = new SqlConnection(connectionstring))
        {
            connection.Open();
            SqlCommand insertCommand = new SqlCommand("insert into  EmpRegistration (FullName,Gender,DateOfBirth,Designation,Email,MobilNo,Address,Username,Password,ConformPasword,SecuityQuestion,Answer)  values(@FullName,@gender,@dateofBirth,@Designation,@Email,@MobileNo,@address,@username,@password,@conformpassword,@SecurityQuestion,@Answer)", connection);


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
                Response.Write("sucessfully inserted");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        using (SqlConnection connection2 = new SqlConnection(connectionstring))
        {
            connection2.Open();
            SqlCommand insertCommand2 = new SqlCommand("insert into users (FullName,Email,MobilNo,Username,Password,ConformPasword,SecuityQuestion,Answer)  values(@FullName,@Email,@MobileNo,@username,@password,@conformpassword,@SecurityQuestion,@Answer)", connection2);


            //dd new SqlParameters to the insertCommand.

            insertCommand2.Parameters.Add(new SqlParameter("FullName", txtFullName.Text));
            insertCommand2.Parameters.Add(new SqlParameter("Email", txtEmail.Text));
            insertCommand2.Parameters.Add(new SqlParameter("MobileNo", txtphno.Text));
            insertCommand2.Parameters.Add(new SqlParameter("username", txtUserName.Text));
            insertCommand2.Parameters.Add(new SqlParameter("password", txtPassword.Text));
            insertCommand2.Parameters.Add(new SqlParameter("conformpassword", txtConformPassword.Text));
            insertCommand2.Parameters.Add(new SqlParameter("SecurityQuestion", DdlSecurityQuestion.SelectedItem.Value));
            insertCommand2.Parameters.Add(new SqlParameter("Answer", txtSecurityQuestionanswer.Text));

            try
            {


                insertCommand2.ExecuteNonQuery();
                Response.Write(" users sucessfully inserted");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}