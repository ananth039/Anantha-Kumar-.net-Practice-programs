<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
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
           <td> <asp:Button ID="btnSignup" runat="server" Text="SignUp" OnClick="btnSignup_Click" /></td>
       </tr>

   </table>
        </div>
   
    
</asp:Content>

