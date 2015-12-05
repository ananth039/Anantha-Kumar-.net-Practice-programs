using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emp_reg_crud_operations_in_1_store_procedure_
{
    public partial class crud_operations_using_one_stored_procedure : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {

            cmd = new SqlCommand("select * from Employee", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            GridViewEmp.DataSource = ds;
            GridViewEmp.DataBind();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("sp_EmpAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Ename", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@Deptno", txtDeptno.Text);
            cmd.Parameters.AddWithValue("@type", "i");
            int i = cmd.ExecuteNonQuery();
            con.Close();
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtSalary.Text = "";
            txtDeptno.Text = "";
            txtEmpNo.Focus();
            if (i > 0)
            {
                lblmsg.Text = "Record inserted";
            }
            else
            {
                lblmsg.Text = "Record is not inserted";
            }
            Bind();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("sp_EmpAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);
            cmd.Parameters.AddWithValue("@type", "u");
            int i = cmd.ExecuteNonQuery();
            con.Close();
            txtEmpNo.Text = "";
            txtEmpName.Text = "";
            txtSalary.Text = "";
            txtDeptno.Text = "";
            txtEmpNo.Focus();
            if (i > 0)
            {
                lblmsg.Text = "Record Updated";
            }
            else
            {
                lblmsg.Text = "Record is not Updated";
            }
            Bind();
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("sp_EmpAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@type", "f");
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            GridViewEmp.DataSource = ds;
            GridViewEmp.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
             con.Open();
            cmd = new SqlCommand("sp_EmpAll", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Eno", txtEmpNo.Text);
              cmd.Parameters.AddWithValue("@type", "d");
            int i = cmd.ExecuteNonQuery();
            txtEmpNo.Text = "";
            txtEmpNo.Focus();
            if(i>0)
            {
                lblmsg.Text="Record is deleted";
            }
            else
            {
                lblmsg.Text = "Record not deleted";
            }
            Bind();
        }
        }
    }
