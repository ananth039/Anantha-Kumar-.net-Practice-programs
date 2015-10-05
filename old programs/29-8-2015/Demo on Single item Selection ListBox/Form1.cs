using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Single_item_Selection_ListBox
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void blSelectedCoursePrompt_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectedCourse_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectedCourseIndex_Click(object sender, EventArgs e)
        {

        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedCourse.Text = Convert.ToString(lstCourses.SelectedItem);
           lblSelectedCourseIndex.Text = Convert.ToString(lstCourses.SelectedIndex);
        }

    }
}
