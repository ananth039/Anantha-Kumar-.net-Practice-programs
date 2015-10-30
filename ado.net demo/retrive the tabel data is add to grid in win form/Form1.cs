using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retrive_the_tabel_data_is_add_to_grid_in_win_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True")) 
            {
                SqlDataAdapter datadapter = new SqlDataAdapter("Select * from MobileShop", connection);
                DataTable table = new DataTable();
                datadapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
