using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputFirstNumber.Text))
            {
                MessageBox.Show(this, "please enter  first value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInputSecondNumber.Text))
            {
                MessageBox.Show(this, "please enter Second value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int a = int.Parse(txtInputFirstNumber.Text);
                    int b = int.Parse(txtInputSecondNumber.Text);
                    int c = a - b;
                    txtResult.Clear();
                    txtResult.AppendText(c.ToString());
                    MessageBox.Show(this, a + "-" + b + "=" + c.ToString(), "Subtaraction operation", MessageBoxButtons.OK);
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputFirstNumber.Clear();
                    txtInputSecondNumber.Clear();
                    txtResult.Clear();
                }
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputFirstNumber.Text))
            {
                MessageBox.Show(this, "please enter  first value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInputSecondNumber.Text))
            {
                MessageBox.Show(this, "please enter Second value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                { 
                int a = int.Parse(txtInputFirstNumber.Text);
                int b = int.Parse(txtInputSecondNumber.Text);
                int c = a + b;
                txtResult.Clear();
                 txtResult.AppendText(c.ToString());
                MessageBox.Show(this, a + "+" + b + "=" + c.ToString(), "Additon operation", MessageBoxButtons.OK);
                }
                
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputFirstNumber.Clear();
                    txtInputSecondNumber.Clear();
                    txtResult.Clear();
                }
               }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtInputFirstNumber.Text))
            {
                MessageBox.Show(this, "please enter  first value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInputSecondNumber.Text))
            {
                MessageBox.Show(this, "please enter Second value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    int a = int.Parse(txtInputFirstNumber.Text);
                    int b = int.Parse(txtInputSecondNumber.Text);
                    int c = a * b;
                    txtResult.Clear();
                    txtResult.AppendText(c.ToString());
                    MessageBox.Show(this, a + "*" + b + "=" + c.ToString(), "Multiplication operation", MessageBoxButtons.OK);

                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputFirstNumber.Clear();
                    txtInputSecondNumber.Clear();
                    txtResult.Clear();
                }
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputFirstNumber.Text))
            {
                MessageBox.Show(this, "please enter  first value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInputSecondNumber.Text))
            {
                MessageBox.Show(this, "please enter Second value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
               try
              {
                int a = int.Parse(txtInputFirstNumber.Text);
                int b = int.Parse(txtInputSecondNumber.Text);
                int c = a / b;
                txtResult.Clear();
                txtResult.AppendText(c.ToString());
                MessageBox.Show(this, a + "/" + b + "=" + c.ToString(), "Division operation", MessageBoxButtons.OK);
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputFirstNumber.Clear();
                    txtInputSecondNumber.Clear();
                    txtResult.Clear();
                }
            }
        }

        private void btnpercentage_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtInputFirstNumber.Text))
            {
                MessageBox.Show(this, "please enter  first value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInputSecondNumber.Text))
            {
                MessageBox.Show(this, "please enter Second value", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
              try
              {                     
                int a = int.Parse(txtInputFirstNumber.Text);
                int b = int.Parse(txtInputSecondNumber.Text);
                int c = a % b;
                txtResult.Clear();
                txtResult.AppendText(c.ToString());
                MessageBox.Show(this, a + "%" + b + "=" + c.ToString(), "Percentage operation", MessageBoxButtons.OK);
               }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputFirstNumber.Clear();
                    txtInputSecondNumber.Clear();
                    txtResult.Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputFirstNumber.Clear();
            txtInputSecondNumber.Clear();
            txtResult.Clear();
        }
    }
}
