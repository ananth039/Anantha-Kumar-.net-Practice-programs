<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Employee_Registartion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
   <table>
       <caption>Login</caption>
       <tr>
           <td>
               <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
              </td>
            <td>
           <asp:TextBox ID="txtuserName" runat="server"></asp:TextBox>
           </td>
           <td>
                <asp:RequiredFieldValidator ID="RfvuserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="please enter user Name"></asp:RequiredFieldValidator>
           
           </td>
            
       </tr>
         <tr>
           <td>
               <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
              </td>
            <td>
           <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
           </td>
           <td>
                <asp:RequiredFieldValidator ID="RfvPassword"  runat="server" ControlToValidate="txtPassword" ErrorMessage="please enter passwword"></asp:RequiredFieldValidator>
           
           </td>
            
       </tr>
       <tr>
           <td>
               <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
           <td> <asp:Button ID="btnSignup" runat="server" Text="SignUp" OnClick="btnSignup_Click" />
           </td>
       </tr>

   </table>
        </div>
   
    </form>
</body>
</html>
