using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demo_on_PictureBox
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

        private void lblSizeMode_Click(object sender, EventArgs e)
        {

        }

        private void rbAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string imagepath = txtImagePath.Text;
            FileInfo fobj = new FileInfo(imagepath);
            if (fobj.Exists)
            {
                picBoxImage.Image = Image.FromFile(imagepath);

            }
            else
            {
                MessageBox.Show("Image file not found.");
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            picBoxImage.Image = null;
            txtImagePath.Clear();
        }

        private void rbNoraml_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void rbStrech_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}

