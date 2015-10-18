using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace application_form
{
    public partial class Quality_Thought_Appllication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblstatus.Visible = false;
          imagecorrect.Visible = false;
            
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
            string doj=txtDateOfJoin.Text;
            int bno=int.Parse(txtbatchno.Text);
            string idno=txtIdNo.Text;
            string fname=txtfirstName.Text;
            string lname=txtlastname.Text;
            string parentname=txtparentname.Text;
            string dob=txtdob.Text;
            Int64 phno=Int64.Parse(txtphonenumber.Text);
            string qualifcation=txtQualification.Text;
            string email=txtEmail.Text;
            Int64 parentphno = Int64.Parse(txtparentphonenumber.Text);

            string prmdrno=txtperdrno.Text;
            string prmstreet=txtperstate.Text;
            string prmcity=txtpercity_vilage.Text;
            string prmdistrict=txtpersdistrict.Text;
            string prmstate=txtperstate.Text;
          int prmzipcode=int.Parse(txtperszipcode.Text);

            string prsdrno=txtpredrno.Text;
            string prsstreet=txtprestreet.Text;
            string prscity=txtprecity_village.Text;
            string prsdistrict=txtpredistrict.Text;
            string prsstate=txtprestate.Text;
            int  prszipcode=int.Parse(txtprezipcode.Text);

            //retrive the all courses from course list

            string courseslist="";

            for(int i=0;i<=chbCoursesList.Items.Count-1;i++)
            {
                if(chbCoursesList.Items[i].Selected)
                {
                    if(courseslist=="")
                    {
                        courseslist=chbCoursesList.Items[i].Text;
                    }
                    else
                    {
                        courseslist+=","+chbCoursesList.Items[i].Text;
                    }
                }
            }

            //retrive the all type of batcgh check box values

            string typeofbatchList="";
            for(int i=0;i<=ChbTypeOfbatchList.Items.Count-1;i++)
            {
                if(ChbTypeOfbatchList.Items[i].Selected)
                {
                    if(courseslist=="")
                    {
                       typeofbatchList=ChbTypeOfbatchList.Items[i].Text;
                    }
                    else
                    {
                        typeofbatchList+=","+ChbTypeOfbatchList.Items[i].Text;
                    }
                }
            }



           

            string connectionstring = ConfigurationManager.ConnectionStrings["QualityThought"].ConnectionString;
         


                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    string insertCommand = "insert into StudentRegistration (FirstName,LastName,ParentName,DateOfbirth,PhoneNo,Qualification,EmailId,ParentPhNo,Perdrno,perStreet,percityVillage,perDistrict,perState,perZipcode,Prsdrno,prsStreet,prscityvillage,prsDistrict,prsState,prsZipcode,Courses,typeofbatch) values('{0}',{1},'{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}',{10},'{11}','{12}','{13}','{14}','{15}','{16}',{17},'{18}','{19}','{20}','{21}','{22}',{23},'{24}'";
                    SqlCommand command1 = new SqlCommand(string.Format(insertCommand, doj, bno, idno, fname, lname, parentname, dob, email, parentphno, prmdrno, prmstreet, prmcity, prmdistrict, prmstate, prmzipcode, prsdrno, prsstreet, prscity, prsdistrict, prsstate, prszipcode, courseslist, typeofbatchList), connection);
                    int status = command1.ExecuteNonQuery();
                    lblstatus.Visible = true;
                    imagecorrect.Visible = true;
                    lblstatus.Text = "1 record is inserted successfully";
                }
            }catch(Exception ex)
            {
                lblstatus.Visible = true;
                lblstatus.Text = ex.Message;
               
            }
        }
    }
}