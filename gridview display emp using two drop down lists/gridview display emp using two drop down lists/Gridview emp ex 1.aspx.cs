using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace gridview_display_emp_using_two_drop_down_lists
{
    public partial class Gridview_emp_ex_1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["empDetails"].ConnectionString);
        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                BindData();
            }
            
        }

        private void BindData()
        {
            SqlCommand cmd = new SqlCommand("select dname from tblDepartment", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DropDownListDname.Items.Add(dr[0].ToString());

                }
                con.Close();
            }
        }

        protected void DropDownListDname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            con.Open();
            try
            {


                string deptname = DropDownListDname.SelectedItem.Value.ToString();
                string query = " select ename from tblEmployee where did in(select did from tblDepartment where dname=@deptname)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@deptname", deptname);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DropDownListEname.Items.Add(dr[0].ToString());
                    }
                    con.Close();
                }
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void DropDownListEname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Connection oriented architecture
            string empname=DropDownListEname.SelectedItem.Value.ToString();
            SqlCommand cmd=new SqlCommand("select * from tblEmployee where ename=@empName",con);
            con.Open();
            cmd.Parameters.AddWithValue("@empName", empname);
            SqlDataReader dr = cmd.ExecuteReader();
          
            GridViewEmpdetails.DataSource = dr;
            GridViewEmpdetails.DataBind();
            con.Close();
            DropDownListEname.Items.Clear();
            //Disconnected  oriented architecture
            //SqlDataAdapter da = new SqlDataAdapter("select * from tblEmployee where ename=" + DropDownListEname.SelectedItem.ToString(), con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //GridViewEmpdetails.DataSource = ds;
            //GridViewEmpdetails.DataBind();
        }
    }
}