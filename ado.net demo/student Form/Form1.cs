using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSudentForm_Click(object sender, EventArgs e)
        {

        }

        private void lblStudnetId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateTable();
            FormValidate();
            try
            {
                InsertValues();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            
        
           

        }

        private void InsertValues()
        {
            int stid;
            Int64 stphone;
            string name, fatherName, DateOfbirth, address;
            FormValidate();
            stid = int.Parse(txtStudentId.Text);
            name = txtStudnetName.Text;
            fatherName = txtFatherName.Text;
            DateOfbirth = dtpDob.Text;
            stphone = Int64.Parse(txtPhoneNumber.Text);
            address = rtbAddress.Text;

            DateTime dt = DateTime.Now;
            string connectionString = @"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string insertQuery = "insert into School (studentId,studentName,fatherName,DateOfBirth,PhoneNumber,Address) values({0},'{1}','{2}','{3}',{4},'{5}')";
                    SqlCommand CreateCommand = new SqlCommand(string.Format(insertQuery, stid, name, fatherName, DateOfbirth, stphone, address), connection);
                    connection.Open();
                    CreateCommand.ExecuteNonQuery();
                    MessageBox.Show("yours details are sucessfully submited");
                    txtStudentId.Clear();
                    txtStudnetName.Clear();
                    txtFatherName.Clear();
                    txtPhoneNumber.Clear();
                    dtpDob.Text = dt.ToLongDateString();
                    rtbAddress.Clear();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("your details not subimted");
            }

        }

        private static void CreateTable()
        {
            string connectionString = @"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string createQuery = "create table School(studentId int primary key,studentName Varchar(100) Not Null,fatherName varchar(100) not null,DateOfBirth varchar(20) Not Null,PhoneNumber bigint unique not null,Address varchar(200) not Null)";
                    SqlCommand CreateCommand = new SqlCommand(createQuery, connection);
                    connection.Open();
                    CreateCommand.ExecuteNonQuery();
                    MessageBox.Show("table is created");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormValidate()
        {
            int sid;
            Int64 phone;
            
            DateTime dt = DateTime.Now;
            string date = dt.ToLongDateString();
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("please enter student id");
                txtStudentId.Clear();
                txtStudentId.Focus();
            }
            else if (!int.TryParse(txtStudentId.Text, out sid))
            {
                MessageBox.Show("please enter student Number only");
                txtStudentId.Clear();
                txtStudentId.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtStudnetName.Text))
            {
                MessageBox.Show("please enter student name");
                txtStudnetName.Clear();
                txtStudnetName.Focus();
            }
            else if(rbmale.Checked==false&& rbfemale.Checked==false)
                {
                    MessageBox.Show("please select gender");
                }
            else if (string.IsNullOrWhiteSpace(txtFatherName.Text))
            {
                MessageBox.Show("please enter father Name");
                txtFatherName.Clear();
                txtFatherName.Focus();
            }
            else if (dtpDob.Text == date)
            {
                MessageBox.Show("please select date of birth");
                dtpDob.Focus();  
            }
            else if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("please enter phone Number");
                txtPhoneNumber.Clear();
                txtPhoneNumber.Focus();
            }
            else if (!Int64.TryParse(txtPhoneNumber.Text, out phone))
            {
                MessageBox.Show("please enter digits only");
                txtPhoneNumber.Clear();
                txtPhoneNumber.Focus();
            }
            else if (string.IsNullOrWhiteSpace(rtbAddress.Text))
            {
                MessageBox.Show("please enter your address");
                rtbAddress.Clear();
                rtbAddress.Focus();

            }
 
                  }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
