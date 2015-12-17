<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="dot_net_community_project.ForgetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelUserRegitstration" runat="server" GroupingText="Forget Password"  align="center" Height="303px" Font-Bold="False" Font-Size="Medium">
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
                <td class="auto-style18">
                    <asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:DropDownList ID="DropDownListSecurityquestion" runat="server">
                        <asp:ListItem>select yourQuestion</asp:ListItem>
                        <asp:ListItem>What is your nick Name?</asp:ListItem>
                        <asp:ListItem>What is your father Name?</asp:ListItem>
                        <asp:ListItem>What is your pet Name?</asp:ListItem>
                        <asp:ListItem>Who is your childhood friend?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtAnswer" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
           
            <tr>
                <td class="auto-style18" colspan="2">
                    <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="30px" Width="94px" OnClick="btnSubmit_Click" /></td>

          
                  </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
                </td>
            </tr>
           
        </table>
       </asp:Panel>
        
                
         <br />
         <br />
</asp:Content>
