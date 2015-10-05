using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Form_Properties
{
    public partial class Demo_on_Window_states : Form
    {
        public Demo_on_Window_states()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Demo_on_Window_states_Load(object sender, EventArgs e)
        {

        }
    }
}
