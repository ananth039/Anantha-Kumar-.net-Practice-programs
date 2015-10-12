using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mobile_form
{
    public partial class Mobles_Registration_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SaveDetailsToDatabase(object sender, EventArgs e)
        {
            int mobileId=int.Parse(txtMobileId.Text);
            string mobileBrand=ddlMobileBrand.SelectedItem.Text;
            string mobileModel=txtmobileModel.Text;
            string operatingsystem=ddlOperatingsystem.SelectedItem.Text;
            int price=int.Parse(txtprice.Text);

            string connectionstring=@"Data Source=ANANTH\ANANTH;Initial Catalog=Anantha Kumar;Integrated Security=True";
            using(SqlConnection connnection=new SqlConnection(connectionstring))
            {
                connnection.Open();
                string query = "insert into Mobiles(mobileId,MobileBrand,MobileModel,OperatingSystem,price) values({0},'{1}','{2}','{3}',{4})";
                using (SqlCommand insertCommand = new SqlCommand(string.Format(query, mobileId, mobileBrand, mobileModel, operatingsystem, price), connnection))
                {
                    try
                    {
                        int status = insertCommand.ExecuteNonQuery();
                        lblStatus.Text = status + "row is inserted sucessfully";
                    }                    catch(Exception ex)
                    {
                        lblStatus.Text ="mobileId is already exist.please enter another id";
                    }
                }

            }
        }
    }
}