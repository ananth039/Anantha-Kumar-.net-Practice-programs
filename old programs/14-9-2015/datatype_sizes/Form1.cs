using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datatype_sizes
{
    public partial class lblSelectDataType : Form
    {
        public lblSelectDataType()
        {
            InitializeComponent();
           
        }

        private void lblMinSize_Click(object sender, EventArgs e)
        {

        }

        private void lblDataType_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void cmbDataTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        switch (cmbDataTypes.SelectedItem.ToString())
            {
                case "SByte":
                    lblDataType.Text = cmbDataTypes.SelectedItem.ToString()+" 8-bit Signed";
                    rtbMinSize.Text = SByte.MinValue.ToString();  
                    rtbMaxsize.Text = SByte.MaxValue.ToString();
                    break;

                case "Byte":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString()+" 8-bit Unsigned";
                rtbMinSize.Text =byte.MinValue.ToString();
                rtbMaxsize.Text = byte.MaxValue.ToString();
                break;

                case "Short":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString()+" 16-bit Signed";
                rtbMinSize.Text =short.MinValue.ToString();
                rtbMaxsize.Text = short.MaxValue.ToString();
                break;
                
                case "UShort":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString() + " 16-bit Unsigned";
                rtbMinSize.Text =ushort.MinValue.ToString();
                rtbMaxsize.Text = ushort.MaxValue.ToString();
                break;

                
                case "int":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString() + " 32-bit Signed";
                rtbMinSize.Text =int.MinValue.ToString();
                rtbMaxsize.Text = int.MaxValue.ToString();
                break;

                
                case "Uint":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString() + " 32-bit Unsigned";
                rtbMinSize.Text =uint.MinValue.ToString();
                rtbMaxsize.Text = uint.MaxValue.ToString();
                break;



                case "long":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString()+" 64-bit Signed";
                rtbMinSize.Text = long.MinValue.ToString();
                rtbMaxsize.Text = long.MaxValue.ToString();
                break;


                case "Ulong":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString()+" 64-bit Unsigned";
                rtbMinSize.Text = ulong.MinValue.ToString();
                rtbMaxsize.Text = ulong.MaxValue.ToString();
                break;


                case "float":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString()+" 32-bit";
                rtbMinSize.Text = float.MinValue.ToString();
                rtbMaxsize.Text = float.MaxValue.ToString();
                break;

                case "double":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString() + " 64-bit";
                rtbMinSize.Text = double.MinValue.ToString();
                rtbMaxsize.Text = double.MaxValue.ToString();
                break;



                case "decimal":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString();
                rtbMinSize.Text = decimal.MinValue.ToString();
                rtbMaxsize.Text = decimal.MaxValue.ToString();
                break;


                case "char":
                lblDataType.Text = cmbDataTypes.SelectedItem.ToString();
                rtbMinSize.Text = char.MinValue.ToString();
                rtbMaxsize.Text = char.MaxValue.ToString();
                break;
            default:
                MessageBox.Show("please select Data type");
                break;
                
            
            }
        }

        private void lblSelectDataType_Load(object sender, EventArgs e)
        {
            
        }
    }
}
