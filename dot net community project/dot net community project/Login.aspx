<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="dot_net_community_project.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="PanelUserLogin" runat="server" GroupingText="User Login"  align="center" Height="303px" Font-Bold="False" Font-Size="Medium">
        <br />
        <table class="auto-style1" align="center">
           

            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtUserName" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="186px"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
               <td>
                    <asp:HyperLink ID="HyperLinkForgetPassword" runat="server" NavigateUrl="ForgetPassword.aspx">Forget Password</asp:HyperLink></td>
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
         </asp:Panel>
</asp:Content>
