using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show(this, "please enter User Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtUserName.Focus();

            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(this, "please enter Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
              
            }

            else
            {
               if(txtUserName.Text=="admin"|txtUserName.Text=="ADMIN" && txtPassword.Text=="admin")
               {
                   MessageBox.Show(this, "login Sucessfully", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   txtUserName.Clear();
                   txtPassword.Clear();

               }
               else
               {
                   MessageBox.Show(this, "Inalid user Name And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtUserName.Clear();
                   txtPassword.Clear();
                   txtUserName.Focus();
               }
            }

        }

        private void lblHint_Click(object sender, EventArgs e)
        {
        }      
    }
}

 