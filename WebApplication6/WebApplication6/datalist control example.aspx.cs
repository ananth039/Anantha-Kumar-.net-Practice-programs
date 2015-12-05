using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace WebApplication6
{
    public partial class datalist_control_example : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["emp"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                FillData();

            }

        }

        private void FillData()
        {
           
            con.Open();
            
            SqlDataAdapter da=new SqlDataAdapter("select * from emp", con);
            DataSet ds=new DataSet();
            da.Fill(ds, "emp");
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName.ToString()=="Cmdedit")
            {
                DataList1.EditItemIndex = e.Item.ItemIndex;
                FillData();
            }
            else if(e.CommandName.ToString()=="CmdCancel")
            {
                DataList1.EditItemIndex = -1;
                FillData();
            }
            else if(e.CommandName.ToString()=="CmdUpadate")
            {
                Label leno = (Label)e.Item.FindControl("lblempno");
               string empno =leno.Text;
                Response.Write(empno);
                TextBox t1 = (TextBox)e.Item.FindControl("txtempname");
                string ename = t1.Text;
                TextBox t2 = (TextBox)e.Item.FindControl("txtsalary");
                Double salary =Double.Parse( t2.Text);
                con.Open();
                string query="update emp set Empname='"+ename+"',salary='"+salary+"' where empno='"+empno+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                DataList1.EditItemIndex = -1;
                FillData();
                
            }
        }
    }
}