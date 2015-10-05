using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Changing_Property_Values_at_Run_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(150, 400);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(150, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "My test Button";
       
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCoral;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Font = new Font("Showcard Gothic", 17);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Image=Image.FromFile("D:\\th_welcome.gif");
            button1.ImageAlign=ContentAlignment.MiddleLeft;
            button1.TextAlign=ContentAlignment.MiddleRight;
            button1.Size=new Size(310,100);
        }
    }
}