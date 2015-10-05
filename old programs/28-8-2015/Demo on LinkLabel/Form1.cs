using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "ananth039@gmail.com";
           
            
            linkLabel1.ActiveLinkColor = Color.Cyan;
            linkLabel1.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.VisitedLinkColor = Color.Green;
        }
    }
}
