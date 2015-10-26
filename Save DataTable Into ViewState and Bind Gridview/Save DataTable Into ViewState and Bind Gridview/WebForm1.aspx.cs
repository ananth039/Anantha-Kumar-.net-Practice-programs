using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Save_DataTable_Into_ViewState_and_Bind_Gridview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddDefaultFirstRecord();
            }
        }
        protected void AddProduct_Click(object sender, EventArgs e)
        {
            AddNewRecordRowToGrid();
        }

        private void AddDefaultFirstRecord()
        {
            //creating dataTable   
            DataTable dt = new DataTable();
            DataRow dr;
            dt.TableName = "AuthorBooks";
            dt.Columns.Add(new DataColumn("AuthorName", typeof(string)));
            dt.Columns.Add(new DataColumn("BookName", typeof(string)));
            dt.Columns.Add(new DataColumn("BookType", typeof(string)));
            dt.Columns.Add(new DataColumn("Publisher", typeof(string)));
            dr = dt.NewRow();
            dt.Rows.Add(dr);
            //saving databale into viewstate   
            ViewState["AuthorBooks"] = dt;
            //bind Gridview  
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        private void AddNewRecordRowToGrid()
        {
            // check view state is not null  
            if (ViewState["AuthorBooks"] != null)
            {
                //get datatable from view state   
                DataTable dtCurrentTable = (DataTable)ViewState["AuthorBooks"];
                DataRow drCurrentRow = null;

                if (dtCurrentTable.Rows.Count > 0)
                {

                    for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                    {

                        //add each row into data table  
                        drCurrentRow = dtCurrentTable.NewRow();
                        drCurrentRow["AuthorName"] = TextBox1.Text;
                        drCurrentRow["BookName"] = TextBox2.Text;
                        drCurrentRow["BookType"] = TextBox3.Text;
                        drCurrentRow["Publisher"] = TextBox4.Text;


                    }
                    //Remove initial blank row  
                    if (dtCurrentTable.Rows[0][0].ToString() == "")
                    {
                        dtCurrentTable.Rows[0].Delete();
                        dtCurrentTable.AcceptChanges();

                    }

                    //add created Rows into dataTable  
                    dtCurrentTable.Rows.Add(drCurrentRow);
                    //Save Data table into view state after creating each row  
                    ViewState["AuthorBooks"] = dtCurrentTable;
                    //Bind Gridview with latest Row  
                    GridView1.DataSource = dtCurrentTable;
                    GridView1.DataBind();
                }
            }
        }
    }
}