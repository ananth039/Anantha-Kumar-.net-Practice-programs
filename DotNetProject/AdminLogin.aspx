<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
        .auto-style2 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
          <br />
        <table class="auto-style1" align="center">
            <caption>Admin Login</caption>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtUserName" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="186px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
               <td>
                   </td>
                <td class="auto-style18">
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

