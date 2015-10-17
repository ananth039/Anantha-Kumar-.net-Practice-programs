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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtphonenumber.Text;
            string connectionstring=@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using(SqlConnection connection=new SqlConnection(connectionstring))
            {
                connection.Open();
                string query="insert into sample values('{0}','{1}')";
                SqlCommand cmd = new SqlCommand(string.Format(query,name,phone), connection);
                int state=cmd.ExecuteNonQuery();
                MessageBox.Show(state + " row is inserted");

               
            } 
        }
    }
}
