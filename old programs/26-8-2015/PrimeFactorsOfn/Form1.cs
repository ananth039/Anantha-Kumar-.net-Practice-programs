using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeFactorsOfn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInputNumber.Clear();
                txtInputNumber.Focus();
            }
            else
            {
                txtInputNumber.Focus();
                try
                {
                  
                    int a = int.Parse(txtInputNumber.Text);
                    int x;
                    lboutput.Items.Clear();
                    bool isPrime=true;

                    for (x =2;x<a/2; x++)
                    {
                        if (a % x == 1)
                        {
                            x = PrimeFactor(a);
                        }

                    }

                   
                }
                catch (FormatException fe)
                {
                    MessageBox.Show(this, "please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInputNumber.Clear();
                    txtInputNumber.Focus();
                }
            }
        }

        private int PrimeFactor(int a)
        {
            int x;
            for (x = 2; x <= a/2; x++)
            {
                if (a % x == 0)
                {


                    lboutput.Items.Add("\n" + x.ToString());

                }
            }
            return x;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
