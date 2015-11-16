using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace generate_database
{
    public partial class create_database_using_program : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtngenerateDatabase_Click(object sender, EventArgs e)
        {
            string Connectstring = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            SqlConnection con = new SqlConnection(Connectstring);
            con.Open();
            
            try
            {
                if(string.IsNullOrWhiteSpace(txtdbname.Text))
                {
                    lblmsg.Text="please enter database name";
                }

                else
                {

               
                SqlCommand cmd = new SqlCommand("create database "+txtdbname.Text+" ", con);
                cmd.ExecuteNonQuery();
               
                lblmsg.Text = txtdbname.Text+" Database is created";
                }
            }
            catch(Exception error)
            {
                lblmsg.Text = txtdbname.Text + " Database is already exist" ;
            }
            finally
            {
                con.Close();
                txtdbname.Text = "";
            }

        }
    }
}