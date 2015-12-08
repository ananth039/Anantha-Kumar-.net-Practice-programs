using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Grdview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
         SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
          
        public void Fill()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("sp_getemp", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
      
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
             SqlCommand cmd = new SqlCommand("sp_emp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ename", TextBox2.Text);
            cmd.Parameters.AddWithValue("@designation", TextBox3.Text);
            cmd.Parameters.AddWithValue("@sal", TextBox4.Text);
            cmd.Parameters.AddWithValue("@qualification", TextBox5.Text);
            cmd.Parameters.AddWithValue("@mobile", TextBox6.Text);
            cmd.Parameters.AddWithValue("@email", TextBox7.Text);
            cmd.Parameters.AddWithValue("@mid", TextBox8.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Fill();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            con.Open();
            int eid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            SqlCommand cmd = new SqlCommand("sp_delemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", eid);
            cmd.ExecuteNonQuery();
            con.Close();
            Fill();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;


        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Fill();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox t1 = (TextBox)row.FindControl("TextBox1");
            int eno =int.Parse( t1.Text);
            TextBox t2 = (TextBox)row.FindControl("TextBox2");
            string ename = t2.Text;
            TextBox t3 = (TextBox)row.FindControl("TextBox3");
            string des =t3.Text;
            TextBox t4 = (TextBox)row.FindControl("TextBox4");
            double sal = double.Parse(t4.Text);
            TextBox t5 = (TextBox)row.FindControl("TextBox5");
            string qual = t5.Text;
            TextBox t6 = (TextBox)row.FindControl("TextBox6");
            long mbl = long.Parse(t6.Text);
            TextBox t7 = (TextBox)row.FindControl("TextBox7");
            string email= t7.Text;
            TextBox t8 = (TextBox)row.FindControl("TextBox8");
            int mid = int.Parse(t8.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("upemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", eno);
            cmd.Parameters.AddWithValue("@ename",ename);
            cmd.Parameters.AddWithValue("@designation", des);
            cmd.Parameters.AddWithValue("@sal", sal);
            cmd.Parameters.AddWithValue("@qualification", qual);
            cmd.Parameters.AddWithValue("@mobile", mbl);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            Fill();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select eid from emp", con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while(dr.Read())
            { 
                if(dr[0].ToString().Equals(TextBox1.Text))
                {
                    Label9.Text = "";
                    Label9.Text = "Eid " + dr[0].ToString() + " is already exist";
                   
                   
                }
               
            }

            con.Close();
            Displayempid();
        }

        private void Displayempid()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select MAX(eid) from emp", con);
            int i = (int)cmd1.ExecuteScalar();
            i++;
            Label9.Text = Label9.Text + " please enter this eid : " + i;
            con.Close();


        }
    }
}