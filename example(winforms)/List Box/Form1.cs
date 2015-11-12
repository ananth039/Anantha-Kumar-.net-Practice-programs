using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbweeks.Items.Add("Sunday");
            lbweeks.Items.Add("Monday");
            lbweeks.Items.Add("Tuesday");
            lbweeks.Items.Add("Wednesday");
            lbweeks.Items.Add("Thursday");
            lbweeks.Items.Add("Friday");
            lbweeks.Items.Add("Saturday");
            lbweeks.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string weeks = "";
            foreach(object obj in lbweeks.SelectedItems)
            {
                weeks +="\n"+obj.ToString();
                
            }
            MessageBox.Show(weeks,"Weeks");
        }
    }
}
