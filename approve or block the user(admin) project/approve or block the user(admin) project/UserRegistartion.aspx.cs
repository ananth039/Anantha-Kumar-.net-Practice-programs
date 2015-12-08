using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace approve_or_block_the_user_admin__project
{
    public partial class UserRegistartion : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Project"].ConnectionString);
       
        protected void Page_Load(object sender, EventArgs e)
        {
            AutogenerateLoginId();
        }

        private void AutogenerateLoginId()
        {
          
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select count(*) from Login", con);
                int loginId = (int)cmd1.ExecuteScalar();
                loginId = loginId + 1;
                txtLoginId.Text = loginId.ToString();
                con.Close();
          
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Login(LoginId,Name,UserName,Password,SecQuestion,Answer) values(@LoginId,@Name,@UserName,@Password,@SecQuestion,@Answer)",con);
            cmd.Parameters.AddWithValue("@LoginId", txtLoginId.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@UserName",txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password",txtPassword.Text);
            cmd.Parameters.AddWithValue("@SecQuestion",DropDownListSecQuestion.SelectedItem.Value.ToString());
            cmd.Parameters.AddWithValue("@Answer",txtAnswer.Text);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("sucessfully Registered");
            }
            else
            {
                Response.Write("Not sucessfuly Registered");
            }
            con.Close();
            AutogenerateLoginId();
        }
    }
}