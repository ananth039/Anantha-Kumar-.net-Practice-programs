using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace _1_tier_architecture
{
    public partial class ex1 : System.Web.UI.Page
    {
        static string conectionstring = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        SqlConnection con = new SqlConnection(conectionstring);
        
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            BindDropDown();
            }
        }

        private void BindDropDown()
        {
            try
            {

                
                cmd = new SqlCommand("Select * from tblDepartment",con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
              
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlistDeptname.DataTextField = "dname";
                ddlistDeptname.DataValueField = "did";
                ddlistDeptname.DataSource = dt;
                ddlistDeptname.DataBind();
                ddlistDeptname.Items.Insert(0, new ListItem("Select", "0"));

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                
                cmd = new SqlCommand("insert into tblEmployee(ename,Salary,did) values(@name,@sal,@did)",con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@sal",int.Parse( txtsal.Text));
                cmd.Parameters.AddWithValue("@did",int.Parse(ddlistDeptname.SelectedValue) );
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
              con.Close();
            }
            
            ClearControls();
            if(i>0)
            {
                Response.Write("ReCord is inserted");
            }
            else
            {
                 Response.Write("ReCord is not inserted");
            }
        }

private void ClearControls()
{
             txtName.Text="";
            txtsal.Text="";
            ddlistDeptname.SelectedIndex=0;
}
        }
    }