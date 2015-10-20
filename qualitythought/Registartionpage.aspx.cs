using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registartionpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblstatus.Visible = false;
        imagecorrect.Visible = false;
    }
  
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        lblstatus.Visible = true;
        imagecorrect.Visible = true;

        string Doj = txtDateOfJoin.Text;
        string batchno = txtbatchno.Text;
        string id = txtIdNo.Text;
        string fname = txtfirstName.Text;
        string lname = txtlastname.Text;
        string parentname = txtparentname.Text;
        string gender=null;
        string dob = txtdob.Text;
        string phno = txtphonenumber.Text;
        string qualification = txtQualification.Text;
        string email = txtEmail.Text;
        string parentphno = txtparentphonenumber.Text;

        //permanaent address fields values
        string permdrno = txtperdrno.Text;
        string permstreet = txtperstreet.Text;
        string permcity = txtpercity_vilage.Text;
        string permdistrict = txtpersdistrict.Text;
        string permState = txtperstate.Text;
        string permZipcode = txtperszipcode.Text;

        //Present address fields values
        string prsedrno = txtpredrno.Text;
        string prsestreet = txtprestreet.Text;
        string prsecity = txtprecity_village.Text;
        string prsedistrict = txtpredistrict.Text;
        string prseState = txtprestate.Text;
        string prseZipcode = txtprezipcode.Text;

        if(rbmale.Checked == true||rbfemale.Checked==true)
        {
            lblstatus.Text = "please select one of them";
        }
            
        else if (rbmale.Checked == true)
        {
            gender = rbmale.Text;
        }
        else
        {
            gender =rbfemale.Text;
        }
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
            for(int j=0;j<=ChbTypeOfbatchList.Items.Count-1;j++)
            {
                if(ChbTypeOfbatchList.Items[j].Selected)
                {
                    if(courseslist=="")
                    {
                       typeofbatchList=ChbTypeOfbatchList.Items[j].Text;
                    }
                    else
                    {
                        typeofbatchList+=","+ChbTypeOfbatchList.Items[j].Text;
                    }
                }
            }

            try
            {
            string connectionstring = ConfigurationManager.ConnectionStrings["QualityThought"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    string insertCommand = "insert into StudentsRegistration (Dateofjoin,BatchNO,IdNo,FirstName,LastName,ParentName,gender,DateOfbirth,PhoneNo,Qualification,EmailId,ParentPhNo,permanentdrno,permanentStreet,permanentcityVillage,permanentDistrict,permanentState,permanentZipcode,Presentdrno,PresentStreet,Presentcityvillage,PresentDistrict,PresentsState,PresentZipcode,Courses,typeofbatch) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}')";
                    SqlCommand command1 = new SqlCommand(string.Format(insertCommand,Doj,batchno,id,fname,lname,parentname,gender,dob,phno,qualification,email,parentphno,permdrno,permstreet,permcity,permdistrict,permState,permZipcode,prsedrno,prsestreet,prsecity,prsedistrict,prseState,prseZipcode,courseslist,typeofbatchList), connection);
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
    
    protected void rbmale_CheckedChanged(object sender, EventArgs e)
    {


    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtbatchno.Text = string.Empty;
        txtDateOfJoin.Text="";
        txtdob.Text = string.Empty;

        txtEmail.Text = string.Empty;
        txtfirstName.Text = string.Empty;
        txtIdNo.Text = string.Empty;
        txtlastname.Text = string.Empty;
        txtparentname.Text = string.Empty;
        txtparentphonenumber.Text = string.Empty;
        txtpercity_vilage.Text = string.Empty;
        txtperdrno.Text = string.Empty;

        txtpersdistrict.Text = string.Empty;
        txtperstate.Text = string.Empty;

        txtperstreet.Text = string.Empty;
        txtperszipcode.Text = string.Empty;
        txtphonenumber.Text = string.Empty;
        txtprecity_village.Text = string.Empty;
        txtpredistrict.Text = string.Empty;
       txtpredrno.Text = string.Empty;
       txtprestate.Text = string.Empty;
       txtprestreet.Text = string.Empty;
       txtprezipcode.Text = string.Empty;
       txtQualification.Text = string.Empty;
       rbfemale.Checked = false;
       rbmale.Checked = false;
        
        
        
    }
}