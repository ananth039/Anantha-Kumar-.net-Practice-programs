using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hash_table_demo
{
    public partial class Hash_Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Hashtable htable = new Hashtable();

        protected void btnHashTable_Click(object sender, EventArgs e)
        {
            
         
             htable.Add("1","Sunday");
             htable.Add("2", "Monday");
             htable.Add("3", "Tuesday");
             htable.Add("4", "Wednesday");
             htable.Add("5", "Thurday");
             htable.Add("6", "Friday");
             htable.Add("7", "Saturday");
             ListBox1.DataSource = htable;
             ListBox1.DataValueField = "key";
             ListBox1.DataTextField = "value";
            ListBox1.DataBind();

            //Remove the specified Key and corresponding Value . HashTable.Remove(Key)
           // htable.Remove("1");
            foreach (DictionaryEntry item in htable)
            {
                lblhashtable.Text = item.Key + "   -   " + item.Value;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(htable.Contains("1"))
            {
                txtstatus.Text = "key 1 exist in hashtable";

              
            }
            else
            {
                txtstatus.Text = "key 1 not exist in hashtable";
            }
        }
    }
}