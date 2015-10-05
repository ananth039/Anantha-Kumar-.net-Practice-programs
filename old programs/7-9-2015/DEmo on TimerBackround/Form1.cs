using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEmo_on_TimerBackround
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

        private void tmrBackColor_Tick(object sender, EventArgs e)
        {
            int n = 0;
            n++;
            switch (n)
            {
                case 1: this.BackColor = Color.Black;
                    break;
                case 2: this.BackColor = Color.Blue;
                    break;
                case 3: this.BackColor = Color.LightCoral;
                    break;
                case 4: this.BackColor = Color.LightCyan;
                    break;
                case 5: this.BackColor = Color.Green;
                    break;
                case 6: this.BackColor = Color.Red;
                    break;
                case 7: this.BackColor = Color.Chocolate;
                    break;
                case 8: this.BackColor = Color.DarkKhaki;
                    break;
                case 9: this.BackColor = Color.Firebrick;
                    break;
                case 10: this.BackColor = Color.Gold;
                    break;
                default: n = 0;
                    break;
            }
        }
    }
}
