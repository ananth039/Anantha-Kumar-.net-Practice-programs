using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rkFontSize_Scroll(object sender, EventArgs e)
        {
            int n = trkFontSize.Value;
            lblMyText.Font = new Font("Tahoma", n);
        }
    }
}
