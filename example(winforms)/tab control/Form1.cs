using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tab_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnPrevious.ForeColor = Color.Pink;
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Red;
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Green;
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Blue;
        }

        private void rbwhite_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.White;
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            btnPrevious.ForeColor = Color.Orange;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            btnPrevious.ForeColor = Color.Black;
        }

        private void rbGray_CheckedChanged(object sender, EventArgs e)
        {
            btnPrevious.ForeColor = Color.Gray;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tbBackColor.SelectedIndex = tbBackColor.SelectedIndex - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbBackColor.SelectedIndex = tbBackColor.SelectedIndex + 1;
        }
    }
}
