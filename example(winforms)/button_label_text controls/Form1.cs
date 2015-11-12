using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_label_text_controls
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
       

        private void validateFields(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if(tb.Text.Trim().Length==0)
            {
                MessageBox.Show("Cannot leave empty");
                e.Cancel = true;
                return;
            }
            if(tb.Name!="txtName")
            {
                if(tb.Text.Trim().Length<8)
                {
                    MessageBox.Show("Password should between 8 to 16 characters");
                    e.Cancel = true;
                    return;
                }
                if(tb.Name=="txtConfmPassword")
                {
                    if(txtPassword.Text.Trim()!=txtConfmPassword.Text.Trim())
                    {
                        MessageBox.Show("Confirm password should match with password");
                        return;
                    }
                }
               
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
