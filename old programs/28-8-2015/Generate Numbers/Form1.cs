using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generate_Numbers
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

        private void btnGo_Click(object sender, EventArgs e)
        {

            txtFrom.Focus();
            int n1 = Convert.ToInt32(txtFrom.Text);
            int n2 = Convert.ToInt32(txtTo.Text);
           
            txtNumbers.Clear();
            for (int i = n1; i <= n2; i++)
            {
                txtNumbers.Text = txtNumbers.Text + i + "\n ";

            }
           
                txtFrom.Focus();
           
        }
    }
}
