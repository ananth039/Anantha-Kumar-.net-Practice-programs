using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_managaent_system
{
    public partial class Form1 : Form
    {
                       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime doj = DateTime.Now;
            txtDateOfjoining.Text = doj.ToShortDateString();
            DateTime doe = doj.AddDays(30);
            txtDateOfExpire.Text = doe.ToShortDateString();

        }

        private void rtbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPurpose_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Images (*.jpg)|*.jpg|Icon Images (*.ico)|*.ico|All Files (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imgPath = openFileDialog1.FileName;
                pbstudentimage.ImageLocation = imgPath;
                MessageBox.Show(this, "your picture is loaded sucessfully ", "Uplaod Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            openFileDialog2.Filter = "Jpeg Images (*.jpg)|*.jpg|Icon Images (*.ico)|*.ico|All Files (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imgPath = openFileDialog2.FileName;
                // pbstudentimage.ImageLocation = imgPath;
                MessageBox.Show(this, "your document is loaded sucessfully ", "Uplaod Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSignature_Click(object sender, EventArgs e)
        {

            openFileDialog3.Filter = "Jpeg Images (*.jpg)|*.jpg|Icon Images (*.ico)|*.ico|All Files (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imgPath = openFileDialog3.FileName;
                // pbstudentimage.ImageLocation = imgPath;
                MessageBox.Show(this, "your document is loaded sucessfully ", "Uplaod Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cmbRoomType.SelectedItem.Equals("3 sharing"))
            {
                cmbRoomNo.Items.Clear();
                cmbRoomNo.Text = "3 sharing Rooms";
                cmbRoomNo.Items.Add("101");
                cmbRoomNo.Items.Add("201");
                cmbRoomNo.Items.Add("301");
                cmbRoomNo.Items.Add("401");
                txtfee.Text = "3500";

                
            }
            else if (cmbRoomType.SelectedItem.Equals("4 sharing"))
            {
                cmbRoomNo.Items.Clear();
                cmbRoomNo.Text = "4 sharing Rooms";
                cmbRoomNo.Items.Add("102");
                cmbRoomNo.Items.Add("202");
                cmbRoomNo.Items.Add("302");
                cmbRoomNo.Items.Add("402");
                txtfee.Text = "3400";
               
            }
            else if (cmbRoomType.SelectedItem.Equals("5 sharing"))
            {
                cmbRoomNo.Items.Clear();
                cmbRoomNo.Text = "5 sharing Rooms";
                cmbRoomNo.Items.Add("103");
                cmbRoomNo.Items.Add("203");
                cmbRoomNo.Items.Add("303");
                cmbRoomNo.Items.Add("403");
                txtfee.Text = "3300";
            

            }
            else
            {
                cmbRoomNo.Items.Clear();
            }

        }

       
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {


            if (rbYes.Checked == true)
            {
                int fee = int.Parse(txtfee.Text);
                fee = fee + 100;
                txtfee.Text = fee.ToString();
            }
            else
            {
                int fee = int.Parse(txtfee.Text);
                fee = fee - 100;
                txtfee.Text =fee.ToString();
            }

            
           
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connection=@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
             try
                {
            using(SqlConnection connection1=new SqlConnection(connection))
            {
                connection1.Open();
                string SelectQuery = "select count(*) from HostelStudnetInformation";
                SqlCommand selectcommand = new SqlCommand(SelectQuery, connection1);
               
                    using (SqlDataReader studentIdReader = selectcommand.ExecuteReader())
                    {
                        while (studentIdReader.Read())
                        {
                            string s = string.Format("{0}", studentIdReader["StudentId"]);
                            int id = int.Parse(s);
                            id = id + 1;
                            txtStudentId.Text = id.ToString();
                        }
                    }
              
            }
                }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }
    }
}

