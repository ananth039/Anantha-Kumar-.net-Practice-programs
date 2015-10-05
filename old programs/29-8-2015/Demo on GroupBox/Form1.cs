using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Orange;

        }

        private void grptxtForeGroundcolor_Enter(object sender, EventArgs e)
        {
            grptxtForeGroundcolor.BackColor = Color.Green;
        }

        private void grpBackgroundColor_Enter(object sender, EventArgs e)
        {
            
        }

        private void grpBackgroundColor_MouseHover(object sender, EventArgs e)
        {
            grpBackgroundColor.BackColor = Color.Red;
        }

        private void grptxtForeGroundcolor_MouseHover(object sender, EventArgs e)
        {
          grptxtForeGroundcolor.BackColor = Color.Green;
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void rbYellow_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;

        }
    }
}
