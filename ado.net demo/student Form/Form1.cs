using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           
            FormValidate();

            //int sid;
            //int phone;
            //if(!int.TryParse(txtStudentId.Text,out sid))
            //{
            //    MessageBox.Show("please enter student Number only"); 
            //}
            

            
        
           

        }

        private void FormValidate()
        {
            int sid;
            int phone;
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
            else if (!int.TryParse(txtPhoneNumber.Text, out phone))
            {
                MessageBox.Show("please enter digits only");
            }
            else if (string.IsNullOrWhiteSpace(rtbAddress.Text))
            {
                MessageBox.Show("please enter your address");
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
