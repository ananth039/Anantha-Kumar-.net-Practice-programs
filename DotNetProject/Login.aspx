<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 11px;
        }
        .auto-style3 {
            width: 188px;
        }
        .auto-style4 {
            width: 65px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <table align="left">
           <tr><td>
               <asp:Image ID="imgUserLogin" ImageUrl="~/Images/user_login.png" runat="server" Width="112px" Height="148px" />
               </td></tr>
       </table>   
        <table class="auto-style1" align="center">
            <caption>Login</caption>
           

            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUserName" runat="server" Width="186px" style="margin-left: 7px"></asp:TextBox><asp:RequiredFieldValidator ID="RfvUserName" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="please enter user Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="186px" style="margin-left: 0px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVPassword" runat="server" Display="Dynamic" ControlToValidate="txtPassword" ErrorMessage="please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
               <td class="auto-style4">
                    <asp:HyperLink ID="HyperLinkForgetPassword" runat="server" NavigateUrl="ForgetPassword.aspx" TabIndex="4">Forget Password</asp:HyperLink></td>
                <td class="auto-style3">
                    <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Button ID="btnLogin" runat="server" Text="Login" Height="30px" Width="76px" OnClick="btnLogin_Click" />
                   
                </td>

            </tr>
            <tr>
                <td colspan="2"> 
                     <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
           
        </table>
       
</asp:Content>


