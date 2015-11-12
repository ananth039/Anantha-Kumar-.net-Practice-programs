using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_bar_control
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
        public void fn_bar()
        {
            progressBar1.Increment(1);
            lblProgress.Text = "Connecting to server_" + progressBar1.Value.ToString() + "%";
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Server has been Connected");
                this.Close();
                timer1.Stop();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_bar();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
