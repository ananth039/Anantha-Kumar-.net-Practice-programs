<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="application_form.Quality_Thought_Appllication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="external Style sheet.css" />
    
</head>
<body>
    <form id="form1" runat="server" >
   
       <tr>
                <td class="auto-style1"><img src="4e75eee09dfa778ee05393aed3998ab3.png" /></td>
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
                    <asp:TextBox ID="txtDateOfJoin" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblbatchno" runat="server" Text="BATCH NO" /></td>
                <td> <asp:TextBox ID="txtbatchno" runat="server"></asp:TextBox></td>
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
                <td class="auto-style1"><asp:Label ID="LblDob" runat="server" Text="Date Of birth:" /></td>
                <td><asp:TextBox ID="txtdob" runat="server"></asp:TextBox></td>
           </tr>
        <tr>
                <td class="auto-style1"><asp:Label ID="lblPhone" runat="server" Text="Phone Number:" /></td>
                <td><asp:TextBox ID="txtphonenumber" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="lblqualification" runat="server" Text="Qualification:" /></td>
                <td><asp:TextBox ID="txtQualification" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="lblemail" runat="server" Text="Email Id:" /></td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1"> <asp:Label ID="lblparentphonenumber" runat="server" Text="Parent Phone Number:" /></td>
                <td><asp:TextBox ID="txtparentphonenumber" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th class="auto-style1"><asp:Label ID="lbladdress" runat="server" Text="Address:" /></th>
            </tr>
            <tr>
                <td class="address"><asp:Label ID="lblPermanent" runat="server" Text="Permanent:" /></td>
            </tr>
             <tr>
                <td><asp:Label ID="lblpdrno" runat="server" Text="Dr No:" /></td>
           <td><asp:TextBox ID="txtpdrno" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblpstreet" runat="server" Text="Street" /></td>
                <td><asp:TextBox ID="txtpstreet" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblpcity_village" runat="server" Text="city/village:" /></td>
                <td><asp:TextBox ID="txtcity_vilage" runat="server"></asp:TextBox></td>
            </tr>
          <tr>
                <td><asp:Label ID="lblpdistrict" runat="server" Text="District:" /></td>
                <td><asp:TextBox ID="txtpdistrict" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblpstate" runat="server" Text="State:" /></td>
                <td><asp:TextBox ID="txtpstate" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblpzipcode" runat="server" Text="Zipcode:" /></td>
                <td><asp:TextBox ID="txtpzipcode" runat="server"></asp:TextBox></td>
            </tr>
        <tr>
                <td class="address"><asp:Label ID="lblPresent" runat="server" Text="Persent:" /></td>
            </tr>
             <tr>
                <td><asp:Label ID="lblprdrno" runat="server" Text="Dr No:" /></td>
           <td><asp:TextBox ID="txtprdrno" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprstreet" runat="server" Text="Street" /></td>
                <td><asp:TextBox ID="txtprstreet" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprcity_village" runat="server" Text="city/village:" /></td>
                <td><asp:TextBox ID="txtprcity_village" runat="server"></asp:TextBox></td>
            </tr>
          <tr>
                <td><asp:Label ID="lblprdistrict" runat="server" Text="District:" /></td>
                <td><asp:TextBox ID="txtprdistrict" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprstate" runat="server" Text="State:" /></td>
                <td><asp:TextBox ID="txtprstate" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblprzipcode" runat="server" Text="Zipcode:" /></td>
                <td><asp:TextBox ID="txtprzipcode" runat="server"></asp:TextBox></td>
            </tr>
       <tr>
           <td></td><td></td>
           <td>
               <asp:Button ID="btnSubmit" runat="server" Text="Submit" /></td>
           <td></td>
           <td>
                   <asp:Button ID="btnReset" runat="server" Text="Reset" /></td>
       </tr>

   </table>
    </form>
</body>
</html>
