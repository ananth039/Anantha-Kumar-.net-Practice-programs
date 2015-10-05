using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isPrime_Iseven_IsOdd_Reverse_number
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

        private void btnEven_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int a = int.Parse(txtInputNumber.Text);

                    if (a > 0)
                    {
                        if (a % 2 == 0)
                        {
                            DialogResult result = MessageBox.Show(this, a + " is Even number", "Even Number operation");
                            MessageBox.Show(this, "you are pressed " + result.ToString() + " button", "Status");
                        }
                        else
                        {
                            MessageBox.Show(this, a + " is not Even number", "Even Number operation");
                        }
                    }
                    else
                    {
                        MessageBox.Show("please enter number is greather than zero");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputNumber.Clear();
                }

            }
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    int a = int.Parse(txtInputNumber.Text);

                    if (a > 0)
                    {
                        if (a % 2 == 1)
                        {
                            MessageBox.Show(this, a + " is Odd number", "Odd Number operation");
                        }
                        else
                        {
                            MessageBox.Show(this, a + " is not Odd number", "Odd Number operation");

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "please enter number is greather than zero", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputNumber.Clear();
                }

            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int a = int.Parse(txtInputNumber.Text);
                    int b = a;
                    int fact;

                    if (a > 0)
                    {
                        fact = 1;
                        while (a >= 2)
                        {

                            fact *= a;
                            a--;


                        }

                        MessageBox.Show(this, b + " factorial :" + fact.ToString(), "Factorial operation");


                    }
                    else
                    {
                        MessageBox.Show("please enter number is greather than zero");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputNumber.Clear();
                }

            }
        }

        private void btnReverseNumber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtInputNumber.Clear();
                    txtInputNumber.AppendText(reverse.ToString());
                    MessageBox.Show(this, b + " reverse number is " + reverse.ToString(), "Reverse Number");
                    if (reverse == b)
                    {
                        MessageBox.Show(this, reverse + " is palindrome", "Palindrome");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputNumber.Clear();
                   
                }
            }
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputNumber.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int a = int.Parse(txtInputNumber.Text);

                    if (a > 0)
                    {
                        if (a % 2 == 1)
                        {
                            MessageBox.Show(this, a + " is prime number", "Prime Number operation");
                        }
                        else
                        {
                            MessageBox.Show(this, a + " is not Prime number", "Prime Number operation");
                        }
                    }
                    else
                    {
                        MessageBox.Show("please enter number is greather than zero");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputNumber.Clear();
                }


            }
        }
    }
}
