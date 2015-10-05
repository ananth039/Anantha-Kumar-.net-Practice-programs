using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = a * b;
            string ab = c.ToString();
            MessageBox.Show(ab);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = a + b;
            string ab = c.ToString();
            MessageBox.Show(ab);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = a - b;
            string ab = c.ToString();
            MessageBox.Show(this, ab, "subtraction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
