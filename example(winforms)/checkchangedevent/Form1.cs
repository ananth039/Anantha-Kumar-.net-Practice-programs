using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkchangedevent
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Coursefee(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            int amt = int.Parse(txtFee.Text);
            CheckBox chb = sender as CheckBox;
            if(chb.Checked)
            {
                count += 1;
                amt += Convert.ToInt32(chb.Tag);

            }
            else
            {
                count -= 1;
                amt = -Convert.ToInt32(chb.Tag);
            }
            txtFee.Text = amt.ToString();



        }

        private void TrackofCourse(object sender, EventArgs e)
        {
            int amt = int.Parse(txtFee.Text);
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                amt += (Convert.ToInt32(rb.Tag) * count);
            else
                amt += (Convert.ToInt32(rb.Tag) * count);
            txtFee.Text = amt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in groupBox1.Controls)
            {
                CheckBox cb = ctrl as CheckBox;
                cb.Checked = false;

            }
            foreach(Control ctrl in this.Controls)
            {
                if (ctrl.GetType().Name == "TextBox")
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            txtFee.Text = "0";
            txtName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
