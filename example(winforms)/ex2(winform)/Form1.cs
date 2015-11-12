using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_winform_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (sender.GetType().Name == "Button")
            {


                Button b = sender as Button;
                if (b.Name == "button1")
                    MessageBox.Show("Button 1 is clicked");
                else
                    MessageBox.Show("Button2 is clicked");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //if (sender.GetType().Name == "Button")

            //    MessageBox.Show("Button is clicked");
            //else if (sender.GetType().Name == "TextBox")
            //    MessageBox.Show("text box clicked");
            //else
            //    MessageBox.Show(" form is clicked");
          
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
