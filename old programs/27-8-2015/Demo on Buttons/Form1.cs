using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye....");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt =DateTime.Now;
            MessageBox.Show(dt.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next(1, 500);
            MessageBox.Show(n.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
