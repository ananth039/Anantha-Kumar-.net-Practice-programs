using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Form_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "This is load event.";
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Text = "This is move event.";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "This is click event.";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "This is double click event.";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye. Thank you.");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Text = "This is resize event.";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "This is key press event.";
        }
    }
}
