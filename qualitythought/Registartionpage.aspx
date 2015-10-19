<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Registartionpage.aspx.cs" Inherits="Registartionpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style5 {
        font-family: Tahoma;
        font-weight: bold;
        font-style: normal;
        font-variant: normal;
        text-transform: none;
        color: #FFFFFF;
        height: 23px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
   
    
         
   <table align="center"  style="border-color:gold;border-style:solid;>
     
        <tr>
            <td colspan="6"><asp:Label ID="lbladmissionform" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ADMISSION FORM OF QUALITY THOUGHT" ForeColor="#1DE2C5" CssClass="headingform"></asp:Label></td>
             </tr>
                         
        
                         
                   <tr>
                <td class="auto-style1"><asp:Label ID="lbldateofjoin" runat="server" Text="DATE OF JOIN" CssClass="fontcolor" /></td>
                <td>
                    <asp:TextBox ID="txtDateOfJoin" runat="server" TextMode="DateTimeLocal" CssClass="txtmodecolor"></asp:TextBox></td>
                <td><asp:Label ID="lblbatchno" runat="server" Text="BATCH NO" CssClass="fontcolor" /></td>
                <td> <asp:TextBox ID="txtbatchno" runat="server" TextMode="Number" CssClass="txtmodecolor"></asp:TextBox></td>
                <td> <asp:Label ID="lblIdno" runat="server" Text="ID NO" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtIdNo" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
                <th class="sideheading">Candidate Details:</th>


            </tr>
       <tr>
                <td class="auto-style1"><asp:Label ID="lblfirstname" runat="server" Text="First Name:" CssClass="fontcolor" /></td>
                <td> <asp:TextBox ID="txtfirstName" runat="server"></asp:TextBox></td>
           <td></td><td></td>
                <td><asp:Label ID="lblLastName" runat="server" Text="LastName Name:" CssClass="fontcolor" /></td>
                <td> <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
                
                <td class="auto-style1"><asp:Label ID="LblparentName" runat="server" Text="Parent/Guradian Name:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtparentname" runat="server"></asp:TextBox></td>

            </tr>
        <tr>
                
                <td class="auto-style1"><asp:Label ID="lblGender" runat="server" Text="Gender:" CssClass="fontcolor" /></td>
                <td>
                    <asp:RadioButton ID="rbmale" runat="server" Text="Male" ForeColor="Aqua" OnCheckedChanged="rbmale_CheckedChanged" /><asp:RadioButton ID="rbfemale" runat="server"  Text="Female" ForeColor="Aqua"/></td>

            </tr>
       <tr>
                <td class="auto-style1"><asp:Label ID="LblDob" runat="server" Text="Date Of birth:" CssClass="fontcolor"  /></td>
                <td><asp:TextBox ID="txtdob" runat="server" TextMode="Date" CssClass="txtmodecolor"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style1"><asp:Label ID="lblPhone" runat="server" Text="Phone Number:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtphonenumber" runat="server" TextMode="Phone" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="lblqualification" runat="server" Text="Qualification:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="lblemail" runat="server" Text="Email Id:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"> <asp:Label ID="lblparentphonenumber" runat="server" Text="Parent Phone Number:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtparentphonenumber" runat="server" TextMode="Phone" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
            <tr>
                <th class="auto-style1"><asp:Label ID="lbladdress" runat="server" Text="Address:" CssClass="sideheading" /></th>
            </tr>
            <tr>
                <td class="address"><asp:Label ID="lblPermanent" runat="server" Text="Permanent:" ForeColor="Yellow" /></td>
            </tr>
             <tr>
                <td><asp:Label ID="lblperdrno" runat="server" Text="Dr No:" CssClass="fontcolor" /></td>
           <td><asp:TextBox ID="txtperdrno" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblperstreet" runat="server" Text="Street" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtperstreet" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblpercity_village" runat="server" Text="city/village:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtpercity_vilage" runat="server"></asp:TextBox></td>
            </tr>
          <tr>
                <td><asp:Label ID="lblperdistrict" runat="server" Text="District:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtpersdistrict" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblperstate" runat="server" Text="State:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtperstate" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblperzipcode" runat="server" Text="Zipcode:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtperszipcode" runat="server" TextMode="Number" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
        <tr>
                <td class="address"><asp:Label ID="lblPresent" runat="server" Text="Persent:" ForeColor="Yellow" /></td>
            </tr>
             <tr>
                <td><asp:Label ID="lblpredrno" runat="server" Text="Dr No:" CssClass="fontcolor" /></td>
           <td><asp:TextBox ID="txtpredrno" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprestreet" runat="server" Text="Street" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtprestreet" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprecity_village" runat="server" Text="city/village:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtprecity_village" runat="server"></asp:TextBox></td>
            </tr>
          <tr>
                <td><asp:Label ID="lblpredistrict" runat="server" Text="District:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtpredistrict" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprestate" runat="server" Text="State:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtprestate" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprezipcode" runat="server" Text="Zipcode:" CssClass="fontcolor" /></td>
                <td><asp:TextBox ID="txtprezipcode" runat="server" TextMode="Number" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
        <tr>
                <th class="auto-style1"><asp:Label ID="lblCourseDetails" runat="server"  Text="Course Details:" CssClass="sideheading" /></th>
            </tr>
            <tr>
                <td class="address"><asp:Label ID="lblCourses" runat="server"  Text="Courses:" ForeColor="Yellow" /></td>
            </tr>
       <tr>
           <td>
               <asp:CheckBoxList ID="chbCoursesList"  runat="server" Width="164px" CssClass="fontcolor">
                <asp:ListItem>MANUAL TESTING</asp:ListItem>
                   <asp:ListItem>QTP</asp:ListItem>
                   <asp:ListItem>SELENIUM</asp:ListItem>
                   <asp:ListItem>ETL TESTING</asp:ListItem>
                   <asp:ListItem>APPIUM</asp:ListItem>
                   <asp:ListItem>VSTA/JMETER</asp:ListItem>
                   <asp:ListItem>SELENIUM-PROJ</asp:ListItem>
                   <asp:ListItem>APPIUM</asp:ListItem>
                   <asp:ListItem>NET</asp:ListItem>
                   <asp:ListItem>C/CRT</asp:ListItem>
                   <asp:ListItem>MANUAL PROJ</asp:ListItem>
                   <asp:ListItem>LOADRUNNER</asp:ListItem>
                  </asp:CheckBoxList>
                   
              </td>
       </tr>
        <tr>
                <td class="address"><asp:Label ID="lblTypeOfBatch"  runat="server" Text="Type Of Batch:" ForeColor="Yellow" /></td>
            </tr>
       <tr>
           <td>
               <asp:CheckBoxList ID="ChbTypeOfbatchList" runat="server" Width="164px" CssClass="fontcolor">
                <asp:ListItem>Regular</asp:ListItem>
                   <asp:ListItem>Fast Tarck</asp:ListItem>
                   <asp:ListItem>Weekend</asp:ListItem>
                   <asp:ListItem>Special class</asp:ListItem>
                   <asp:ListItem>Evening</asp:ListItem>
                   </asp:CheckBoxList>
                   
              </td>
       </tr>
       <tr>
           <td></td><td></td>
           <td>
               <asp:Button ID="btnSubmit" runat="server"  Text="Submit" OnClick="btnSubmit_Click1"/></td>
           <td></td>
           <td>
                   <asp:Button ID="btnReset" runat="server"  Text="Reset" /></td>
       </tr>

   </table>
        <div align="center">
          <asp:Image   src="image\download.png" runat="server" ID="imagecorrect" />  <asp:Label ID="lblstatus" runat="server" Font-Size="Larger" ForeColor="Red" />
        </div>
            
        
            

        </div>

</asp:Content>

