<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quality Thought Appllication.aspx.cs" Inherits="application_form.Quality_Thought_Appllication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="external Style sheet.css" />
    
</head>
<body>
    <form id="form1" runat="server" >
    
        
       
   <table align="center" style="height: 1150px">
       <tr>
                <td class="auto-style1"><img src="images/QT-Logo.png" /></td>
                <td></td>
           
                <td colspan="3"><h1> <asp:Label ID="LblInstituteName" runat="server" Text="QUALITY THOUGHT"></asp:Label></h1></td>

            </tr>
        <tr>
             
           <td></td><td></td>
                <th colspan="4"> <asp:Label ID="lbladmissionform" runat="server" Text="ADMISSION FORM OF QUALITY THOUGHT"></asp:Label></th>

            </tr>
                   <tr>
                <td class="auto-style1"><asp:Label ID="lbldateofjoin" runat="server" Text="DATE OF JOIN" /></td>
                <td>
                    <asp:TextBox ID="txtDateOfJoin" runat="server" TextMode="DateTimeLocal" CssClass="txtmodecolor"></asp:TextBox></td>
                <td><asp:Label ID="lblbatchno" runat="server" Text="BATCH NO" /></td>
                <td> <asp:TextBox ID="txtbatchno" runat="server" TextMode="Number" CssClass="txtmodecolor"></asp:TextBox></td>
                <td> <asp:Label ID="lblIdno" runat="server" Text="ID NO" /></td>
                <td><asp:TextBox ID="txtIdNo" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
                <th class="auto-style1"><asp:Label ID="lblCandidatetails" runat="server" Text="Candidate Details:" /></th>


            </tr>
       <tr>
                <td class="auto-style1"><asp:Label ID="lblfirstname" runat="server" Text="First Name:" /></td>
                <td> <asp:TextBox ID="txtfirstName" runat="server"></asp:TextBox></td>
           <td></td><td></td>
                <td><asp:Label ID="lblLastName" runat="server" Text="LastName Name:" /></td>
                <td> <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
                
                <td class="auto-style1"><asp:Label ID="LblparentName" runat="server" Text="Parent/Guradian Name:" /></td>
                <td><asp:TextBox ID="txtparentname" runat="server"></asp:TextBox></td>

            </tr>
        <tr>
                
                <td class="auto-style1"><asp:Label ID="lblGender" runat="server" Text="Gender:" /></td>
                <td>
                    <asp:RadioButton ID="rbmale" runat="server" Text="Male" /><asp:RadioButton ID="rbfemale" runat="server"  Text="Female"/></td>

            </tr>
       <tr>
                <td class="auto-style1"><asp:Label ID="LblDob" runat="server" Text="Date Of birth:"  /></td>
                <td><asp:TextBox ID="txtdob" runat="server" TextMode="Date" CssClass="txtmodecolor"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style1"><asp:Label ID="lblPhone" runat="server" Text="Phone Number:" /></td>
                <td><asp:TextBox ID="txtphonenumber" runat="server" TextMode="Phone" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="lblqualification" runat="server" Text="Qualification:" /></td>
                <td><asp:TextBox ID="txtQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="lblemail" runat="server" Text="Email Id:" /></td>
                <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"> <asp:Label ID="lblparentphonenumber" runat="server" Text="Parent Phone Number:" /></td>
                <td><asp:TextBox ID="txtparentphonenumber" runat="server" TextMode="Phone" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
            <tr>
                <th class="auto-style1"><asp:Label ID="lbladdress" runat="server" Text="Address:" /></th>
            </tr>
            <tr>
                <td class="address"><asp:Label ID="lblPermanent" runat="server" Text="Permanent:" /></td>
            </tr>
             <tr>
                <td><asp:Label ID="lblperdrno" runat="server" Text="Dr No:" /></td>
           <td><asp:TextBox ID="txtperdrno" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblperstreet" runat="server" Text="Street" /></td>
                <td><asp:TextBox ID="txtperstreet" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblpercity_village" runat="server" Text="city/village:" /></td>
                <td><asp:TextBox ID="txtpercity_vilage" runat="server"></asp:TextBox></td>
            </tr>
          <tr>
                <td><asp:Label ID="lblperdistrict" runat="server" Text="District:" /></td>
                <td><asp:TextBox ID="txtpersdistrict" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblperstate" runat="server" Text="State:" /></td>
                <td><asp:TextBox ID="txtperstate" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblperzipcode" runat="server" Text="Zipcode:" /></td>
                <td><asp:TextBox ID="txtperszipcode" runat="server" TextMode="Number" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
        <tr>
                <td class="address"><asp:Label ID="lblPresent" runat="server" Text="Persent:" /></td>
            </tr>
             <tr>
                <td><asp:Label ID="lblpredrno" runat="server" Text="Dr No:" /></td>
           <td><asp:TextBox ID="txtpredrno" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprestreet" runat="server" Text="Street" /></td>
                <td><asp:TextBox ID="txtprestreet" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprecity_village" runat="server" Text="city/village:" /></td>
                <td><asp:TextBox ID="txtprecity_village" runat="server"></asp:TextBox></td>
            </tr>
          <tr>
                <td><asp:Label ID="lblpredistrict" runat="server" Text="District:" /></td>
                <td><asp:TextBox ID="txtpredistrict" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprestate" runat="server" Text="State:" /></td>
                <td><asp:TextBox ID="txtprestate" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprezipcode" runat="server" Text="Zipcode:" /></td>
                <td><asp:TextBox ID="txtprezipcode" runat="server" TextMode="Number" CssClass="txtmodecolor"></asp:TextBox></td>
            </tr>
        <tr>
                <th class="auto-style1"><asp:Label ID="lblCourseDetails" runat="server" Text="Course Details:" /></th>
            </tr>
            <tr>
                <td class="address"><asp:Label ID="lblCourses" runat="server" Text="Courses:" /></td>
            </tr>
       <tr>
           <td>
               <asp:CheckBoxList ID="chbCoursesList" runat="server" Width="164px">
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
                <td class="address"><asp:Label ID="lblTypeOfBatch" runat="server" Text="Type Of Batch:" /></td>
            </tr>
       <tr>
           <td>
               <asp:CheckBoxList ID="ChbTypeOfbatchList" runat="server" Width="164px">
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
               <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
           <td></td>
           <td>
                   <asp:Button ID="btnReset" runat="server" Text="Reset" /></td>
       </tr>

   </table>
        <div align="center">
          <asp:Image  runat="server" src="image\download.png"  ID="imagecorrect" />  <asp:Label ID="lblstatus" runat="server" Font-Size="Larger" ForeColor="Red" />
        </div>
            
     
            
    </form>
    
</body>
</html>
