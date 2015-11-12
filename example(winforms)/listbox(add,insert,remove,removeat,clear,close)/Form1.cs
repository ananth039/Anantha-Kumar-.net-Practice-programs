using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_add_insert_remove_removeat_clear_close_
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbCities.Items.Add(txtCity.Text);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lbCities.Items.Insert(Convert.ToInt32(txtIndexvalue.Text), txtCity.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbCities.Items.Remove(txtCity.Text);
        }

        private void btnRemoveat_Click(object sender, EventArgs e)
        {
            lbCities.Items.RemoveAt(Convert.ToInt32(txtIndexvalue.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbCities.Items.Clear();
            txtCity.Text = string.Empty;
            txtIndexvalue.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
