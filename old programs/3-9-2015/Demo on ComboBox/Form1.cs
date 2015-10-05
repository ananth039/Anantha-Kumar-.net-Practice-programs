using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cmbCourse.SelectedIndex == 0)
                txtFee.Text = "Rs. 4,900/-"; 
            else if (cmbCourse.SelectedIndex == 1)
                txtFee.Text = "Rs. 6,200/-"; 
            else if (cmbCourse.SelectedIndex == 2)
                txtFee.Text = "Rs. 1,000/-";
            else if (cmbCourse.SelectedIndex == 3)
                txtFee.Text = "Rs. 1,200/-"; 
            else if (cmbCourse.SelectedIndex == 4)
                txtFee.Text = "Rs. 1,500/-";
        }
    }
}
