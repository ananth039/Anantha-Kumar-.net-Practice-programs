<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users Regustration.aspx.cs" Inherits="Hostel_Managment_system.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            height: 26px;
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table>
            <tr><th colspan="2">User Registration</th></tr>
            <tr>
                <th class="auto-style2"><asp:Label ID="lblFirstname" runat="server" Text="First Name"></asp:Label> </th>
                <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <th class="auto-style2"><asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label> </th>
                <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th class="auto-style2"><asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label></th>
                <td><asp:RadioButton ID="rbmale" runat="server" Text="Male" />&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="rbfemale" runat="server" Text="Female" /></td>
              
            </tr>
             <tr>
                <th class="auto-style2"><asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label> </th>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <th class="auto-style2"><asp:Label ID="lblPhonenumber" runat="server" Text="Phone Number"></asp:Label> </th>
                <td><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <th class="auto-style2"><asp:Label ID="lblUsername" runat="server" Text="User Name"></asp:Label> </th>
                <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <th class="auto-style3"><asp:Label ID="lblPwd" runat="server" Text="password"></asp:Label> </th>
                <td class="auto-style1"><asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <th class="auto-style2"><asp:Label ID="lblcPwd" runat="server" Text="Conform password"></asp:Label> </th>
                <td><asp:TextBox ID="txtcpwd" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td><td></td>
            </tr>
             <tr align="center">
                 <td><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></td>
                <td><asp:Button ID="btnReset" runat="server" Text="Reset" /></td>
            </tr>


           
            <tr>
                <td>
                    &nbsp;</td>
            </tr>


           
        </table>
    
    </div>
        <p>
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
