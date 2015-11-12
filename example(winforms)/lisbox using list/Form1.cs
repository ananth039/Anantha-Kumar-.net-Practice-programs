using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lisbox_using_list
{
    public partial class Form1 : Form
    {
        List<string> items = new List<string>();
        public Form1()
        {
            InitializeComponent();
            items.Add("one");
            items.Add("two");
            items.Add("Three");
            listBox1.DataSource = items;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            items.Add("New item"+ DateTime.Now.Second);
            listBox1.DataSource = null;
            listBox1.DataSource = items;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndexs = listBox1.SelectedIndex;
            try
            {
                items.RemoveAt(selectedIndexs);
            }
            catch(Exception ex)
            {

            }
            listBox1.DataSource = null;
            listBox1.DataSource = items;
        }
    }
}
