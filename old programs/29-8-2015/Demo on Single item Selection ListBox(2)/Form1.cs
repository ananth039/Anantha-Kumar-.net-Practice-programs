using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Single_item_Selection_ListBox_2_
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

        private void grpOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNewCity.Text!="")
            {
                lstCities.Items.Add(txtNewCity.Text);
                txtNewCity.Clear();
            }
            else
            {
                MessageBox.Show("Enter New City Name");
                txtNewCity.Focus();
            }
        }

        private void btnClearAl_Click(object sender, EventArgs e)
        {
            lstCities.Items.Clear();
            MessageBox.Show("All cities cleared");
        }

        private void btnShowCount_Click(object sender, EventArgs e)
        {
            int count = lstCities.Items.Count;
            MessageBox.Show(count + " Cities Found");
        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            if(lstCities.SelectedIndex>0)
            {
                lstCities.Items.RemoveAt(lstCities.SelectedIndex);

            }
            else
            {
                MessageBox.Show("select any City");
            }
        }
    }
}
