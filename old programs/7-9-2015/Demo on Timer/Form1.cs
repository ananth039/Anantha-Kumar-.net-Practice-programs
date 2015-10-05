using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_on_Timer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
      
         

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            
             tmrTime.Stop();
            lblRemaindaer.Text = "Your Time is Expire";
          DialogResult result=MessageBox.Show(this,"Do you want to continue?","qestion",MessageBoxButtons.YesNo);
          bool isContinue=false;
          if (DialogResult.Yes == result)
          {
              MessageBox.Show("Your time extend to 2  seconds");
              isContinue = true;

              while (isContinue)
              {

                  start();
                  isContinue = false;
                  MessageBox.Show("Your Time is expire", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

          }
          else
          {
              lblRemaindaer.Text = "Your Time is Expire";
              isContinue = false;
              tmrTime.Stop();
              MessageBox.Show("Your Time is expire","Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
         } 

        }
        public void start()
        {
           
            tmrTime.Interval = 2000;
            tmrTime.Stop();

        }
         
    }
}
