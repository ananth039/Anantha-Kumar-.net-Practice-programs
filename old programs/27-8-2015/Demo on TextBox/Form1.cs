using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOk.ForeColor = Color.Red;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string message = "welcome " + name;
            lblMessage.Text = message;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Visible = true;
            this.Text = message;
            txtName.Clear();
        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            txtName.ForeColor = Color.Green;
           

        }
    }
}
