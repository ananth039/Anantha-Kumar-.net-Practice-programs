using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true && checkBox2.Checked==true)
            {
      
                label1.Text = "car is checked";
            }
            else
            {
                label1.Text = "car is unchecked";
            }
        
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label1.Text = "bike is checked";

            }
            else
            {
                label1.Text = "bike is unchecked";
            }
        }
    }
}
