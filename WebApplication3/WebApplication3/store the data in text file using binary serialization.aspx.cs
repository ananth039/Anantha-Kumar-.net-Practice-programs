using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace WebApplication3
{
    public partial class store_the_data_in_text_file_using_binary_serialization : System.Web.UI.Page
    {
        Employee e1;
        FileStream fs;
        BinaryFormatter bfmt = new BinaryFormatter();
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnSerialize_Click(object sender, EventArgs e)
        {
         int eno = int.Parse(txtEno.Text);
            string ename = txtEname.Text;
            double salary =double.Parse(txtSalary.Text);
            e1 = new Employee(eno, ename, salary);
            fs = new FileStream("D://emp.txt", FileMode.Create, FileAccess.Write);
            bfmt.Serialize(fs, e1);
            fs.Flush();
            fs.Close();
            Response.Write("Data is Serialized");
            txtEno.Text = " ";
            txtEname.Text = " ";
            txtSalary.Text = " ";
        }

        protected void btnDeserialize_Click(object sender, EventArgs e)
        {
            fs = new FileStream("D://emp.txt", FileMode.Open, FileAccess.Read);
            e1 = (Employee)bfmt.Deserialize(fs);
            txtEno.Text = e1.eno.ToString();
           txtEname.Text = e1.ename.ToString();
           txtSalary.Text = e1.salary.ToString();
        }

       }
    }
