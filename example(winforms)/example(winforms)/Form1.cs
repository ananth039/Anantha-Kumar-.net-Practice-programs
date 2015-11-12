using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace example_winforms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection con;
        string connectionstring = "Data Source=ananth\ananth;Initial Catalog=Anantha Kumar;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {


                con = new SqlConnection(connectionstring);
                cmd = new SqlCommand("select studentName,fatherName,PhoneNumber from School", con);
                con.Open();
                dr = cmd.ExecuteReader();
                lbl1.Text = dr.GetName(0).ToString();
                lbl2.Text = dr.GetName(1).ToString();
                lbl3.Text = dr.GetName(2).ToString();
                ShowData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void ShowData()
        {
            
            try
            {
           
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txt1.Text = dr.GetValue(0).ToString();
                txt2.Text = dr[1].ToString();
                txt3.Text = dr["PhoneNumber"].ToString();

            }
            else
            {
                MessageBox.Show("last record");
            }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnCllose_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();
        }
    }
}
