using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpleInterst_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputAmount.Text))
            {
                MessageBox.Show(this, "please enter amount", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtInputAmount.Clear();
            }
            else if (string.IsNullOrWhiteSpace(txtRateofInterst.Text))
            {
                MessageBox.Show(this, "please enter Rate of Interst", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtRateofInterst.Clear();
            }
            else if (string.IsNullOrWhiteSpace(txtTimeinyears.Text))
            {
                MessageBox.Show(this, "please enter time in years", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtTimeinyears.Clear();
            }
                
            else
            {
                try
                { 
                double amount = double.Parse(txtInputAmount.Text);
                double Interst = double.Parse(txtRateofInterst.Text);
                double years = double.Parse(txtTimeinyears.Text);
                double simpleInterst = ((amount * Interst * years) / 100);
                txtSimpleInterstResult.Clear();
                txtSimpleInterstResult.AppendText(simpleInterst.ToString());
                MessageBox.Show(this, "Simple Interst: " + simpleInterst.ToString(), "Simple Interst");
            
                }catch(FormatException)
                {
                    MessageBox.Show(this,"please enter digits only","Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                    txtInputAmount.Clear();
                    txtRateofInterst.Clear();
                    txtTimeinyears.Clear();
                    txtSimpleInterstResult.Clear();
                }

                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
