using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string courses = "";
            if(chbCsharpdotnet.Checked)
            {
                courses += chbCsharpdotnet.Text + "\r\n";

            }
            if (chbaspdotnet.Checked)
            {
                courses += chbaspdotnet.Text + "\r\n";

            }
            if (chbadodotnet.Checked)
            {
                courses += chbadodotnet.Text + "\r\n";

            }
            if (chbSqlserver.Checked)
            {
                courses += chbSqlserver.Text + "\r\n";

            }
            MessageBox.Show("Selected courses:\r\n" + courses);
        }
    }
}
