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
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
    
        public Calculator()
        {
            InitializeComponent();
            txtResult.Text = "0";
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || isOperationPerformed)
            {
                txtResult.Clear();
            }
            isOperationPerformed = false;
            Button bt = (Button)sender;
            if (bt.Text==".")
            {
                if(!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + bt.Text;

            }
            else
            txtResult.Text = txtResult.Text + bt.Text;
        }

        private void btn_operation(object sender, EventArgs e)
        {
            Button bto = (Button)sender;
            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = bto.Text;
                lblResultDisplay.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;

            }
            else
            {
                operationPerformed = bto.Text;
                resultValue = Double.Parse(txtResult.Text);
                lblResultDisplay.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                txtResult.Clear();
            }
        }
        private void btn_clear(object sender, EventArgs e)
        {
            txtResult.Text="0";
            resultValue = 0;
            lblResultDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    txtResult.Text = (resultValue + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (resultValue - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (resultValue * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (resultValue / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(txtResult.Text);
            lblResultDisplay.Text = "";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}

