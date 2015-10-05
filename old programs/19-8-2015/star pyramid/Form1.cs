using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace star_pyramid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
          {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(this, "please enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
            else
            {
                listBox1.ClearSelected();
            int a = int.Parse(textBox1.Text);
            char start = '*';
            int currentIteration = 0;
            listBox1.Items.Clear();
            while(currentIteration<a)
            {
                int imediatevalue = 0;
                while(imediatevalue<=currentIteration)
                {
                   
                   listBox1.Items.Add(start);
                
               
                    imediatevalue++;
                }
                listBox1.Items.Add("");
                currentIteration++;
            }

          }

            }catch(FormatException)
                {
                    MessageBox.Show(this,"please enter digits only","Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                   textBox1.Clear();
                }     
            }
        
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }
}
}

