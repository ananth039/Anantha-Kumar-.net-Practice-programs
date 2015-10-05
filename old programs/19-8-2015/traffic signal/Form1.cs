using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic_signal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInpusignalNumber.Text))
            {
                MessageBox.Show(this, "please enter traffic signal number", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtInpusignalNumber.Clear();
            }
            else
            {
                try
                { 
                int a = int.Parse(txtInpusignalNumber.Text);
                switch (a)
                {
                    case 0:
                        txtTrafficSignaloutput.Clear();
                        txtTrafficSignaloutput.AppendText("Red");
                        MessageBox.Show(this, "Red", "Traffic signal status");
                      
                        break;
                    case 1:
                        txtTrafficSignaloutput.Clear();
                        txtTrafficSignaloutput.AppendText("Orange");
                        MessageBox.Show(this, "Orange", "Traffic signal status");
                        break;
                    case 2:
                        txtTrafficSignaloutput.Clear();
                        txtTrafficSignaloutput.AppendText("Green");
                        MessageBox.Show(this, "Green", "Traffic signal status");
                        break;
                    default:
                        
                        MessageBox.Show(this, "Invalid value,please enter only 0 or 1 or 2 only", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        txtTrafficSignaloutput.Clear();
                        txtInpusignalNumber.Clear();
                        break;

                }
                }
                catch (FormatException)
                {
                    MessageBox.Show(this, "please enter digits only", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInpusignalNumber.Clear();
                    txtInpusignalNumber.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
