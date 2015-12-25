using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace insert_images_into_database
{
 
    public partial class Display_Images : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ImagConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da2 = new SqlDataAdapter("select * from Images ", con);
            DataSet ds = new DataSet();
            da2.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            SqlDataAdapter da = new SqlDataAdapter("select Image from Images where imgid=1 ", con);
            DataTable dt = new DataTable();
           da.Fill(dt);
            


            byte[] bytes = (byte[])dt.Rows[0]["Image"];
            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            Image1.ImageUrl = "data:image/jpg;base64," + base64String;

        }
    }
}