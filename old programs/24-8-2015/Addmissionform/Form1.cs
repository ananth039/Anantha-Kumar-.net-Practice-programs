using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission_Firm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt1.Text)) 
          {
              MessageBox.Show(this,"please enter batch no", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
            else if(string.IsNullOrWhiteSpace(txt2.Text))
            {
                MessageBox.Show(this,"please enter student id no","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt3.Text))
            {
                MessageBox.Show(this, "please enter First Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt4.Text))
            {
                MessageBox.Show(this, "please enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt5.Text))
            {
                MessageBox.Show(this, "please enter parent/guardian Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Day.Text=="day")
            {
                MessageBox.Show(this, "please select Day of birth  " ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Month.Text == "Month")
            {
                MessageBox.Show(this, "please select Month of birth  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(year.Text=="year")
            {
                MessageBox.Show(this, "please select year of birth ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
            else if (string.IsNullOrWhiteSpace(txt6.Text))
            {
                MessageBox.Show(this, "please enter your Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt7.Text))
            {
                MessageBox.Show(this, "please enter Qualification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt8.Text))
            {
                MessageBox.Show(this, "please enter email Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt9.Text))
            {
                MessageBox.Show(this, "please enter parent phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt10.Text))
            {
                MessageBox.Show(this, "please enter perment Dr.No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt11.Text))
            {
                MessageBox.Show(this, "please enter perment Street Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt12.Text))
            {
                MessageBox.Show(this, "please enter perment city / Village", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt13.Text))
            {
                MessageBox.Show(this, "please enter perment District", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt14.Text))
            {
                MessageBox.Show(this, "please enter perment State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt15.Text))
            {
                MessageBox.Show(this, "please enter perment Zipcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(txt16.Text))
            {
                MessageBox.Show(this, "please enter present Dr.No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt17.Text))
            {
                MessageBox.Show(this, "please enter present Street Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt18.Text))
            {
                MessageBox.Show(this, "please enter present city / Village", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt19.Text))
            {
                MessageBox.Show(this, "please enter present District", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt20.Text))
            {
                MessageBox.Show(this, "please enter present State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txt21.Text))
            {
                MessageBox.Show(this, "please enter present Zipcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
          
            else
            {
                MessageBox.Show("Successfully submited");
                MessageBox.Show(this,"Batch No: "+txt1.Text+"\n Id No: "+txt2.Text
                    +" \n First Name:"+txt3.Text+" \n Last Name :"+txt4.Text+" \n Date of Birth: "+Day.Text+"-"+Month.Text+"-"+year.Text+"\n Parent gurdian Name: "+txt5.Text+
                    "\n phno :"+txt6.Text+"\n Qualification :"+txt7.Text+"\n Email Id :"+txt8.Text+"\n Parent phno: "+txt9.Text+
                   "\n permanent dr no:"+txt10.Text+"\n permanent street:"+txt11.Text+"\n permanent city /Village:"+txt12.Text
                   +"\n permanent District:"+txt13.Text+"\n permanent State:"+txt14.Text+"\n permanent zip code:"+txt15.Text
                   +"\n present dr no:"+txt16.Text+"\n present street:"+txt17.Text+"\n present city / village:"+txt18.Text
                   +"\n present district:"+txt19.Text+"\n present state:"+txt20.Text+"\n present zip code:"+txt21.Text
                ,"Student Informtion",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
               
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void chb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
