using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_Number
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

        private void btnReverseNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInputNumber.Clear();
            }
            else
            {
                try
                {
                    int a = int.Parse(txtInputNumber.Text);
                    int b = a;
                    int reverse = 0;
                    while (a != 0)
                    {
                        reverse = (reverse * 10) + (a % 10);
                        a = a / 10;
                    }
                    txtoutputNumber.Clear();
                    txtoutputNumber.AppendText(reverse.ToString());
                    if (reverse == b)
                    {
                        MessageBox.Show(this, reverse + " is palindrome", "Palindrome");
                    }
                }catch(FormatException)
                {
                    MessageBox.Show(this,"please enter digits only","Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtInputNumber.Clear();
                    txtoutputNumber.Clear();
                }
            }

        }
        
    }
}
