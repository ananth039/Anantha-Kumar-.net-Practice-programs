using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Grdview
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        public void Fill()
        {
            int i = Convert.ToInt32(Request.QueryString["eid"].ToString());
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from emp where eid="+i, con);
            SqlDataReader dr=cmd.ExecuteReader();
            if(dr.HasRows)
            {
               if(dr.Read())
               {
                   TextBox1.Text = dr[0].ToString();
                   TextBox2.Text = dr[1].ToString();
                   TextBox3.Text = dr[2].ToString();
                   TextBox4.Text = dr[3].ToString();
                   TextBox5.Text = dr[4].ToString();
                   TextBox6.Text = dr[5].ToString();
                   TextBox7.Text = dr[6].ToString();
                   TextBox8.Text = dr[7].ToString();

               }
            }
            con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                Fill();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            int eno = int.Parse(TextBox1.Text);

            string ename = TextBox2.Text;

            string des = TextBox3.Text;
         
            double sal = double.Parse(TextBox4.Text);

            string qual = TextBox5.Text;

            long mbl = long.Parse(TextBox6.Text);

            string email = TextBox7.Text;

            int mid = int.Parse(TextBox8.Text);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("upemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", eno);
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@designation", des);
            cmd.Parameters.AddWithValue("@sal", sal);
            cmd.Parameters.AddWithValue("@qualification", qual);
            cmd.Parameters.AddWithValue("@mobile", mbl);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.ExecuteNonQuery();
            con.Close();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Response.Write("Successfully updated");
        }
    }
}