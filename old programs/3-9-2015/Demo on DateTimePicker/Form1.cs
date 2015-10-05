using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dtpDOB.Value;
            DateTime now = DateTime.Now;
            if(now>dob)
            {
                TimeSpan ts = now - dob;
                int age = ts.Days / 365;
                lblAge.Text = age + " Years"; 
            }
            else
            {
                lblAge.Text = "Invalid DOB";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDOB.Value = DateTime.Now.AddYears(-20);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
