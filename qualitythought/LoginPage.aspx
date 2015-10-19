<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />
    <table align="center" style="border-color:cyan;border-style:solid;">
       <tr>
           <th colspan="2" style="color: #1DE2C5; font-weight: bold; text-transform: uppercase; font-family: Tahoma;">Login</th>
        </tr>   
        <tr><td></td><td></td></tr>
       <tr>
           <td>
               <asp:Label ID="lblusername" runat="server" Text="UserName" ForeColor="LightGreen"></asp:Label></td>
           <td>
               <asp:TextBox ID="txtuserName" runat="server" Width="154px"></asp:TextBox></td>
       </tr>
        <tr>
            <td>
               <asp:Label ID="Lblpwd" runat="server" Text="Password" ForeColor="LightGreen"></asp:Label></td>
           <td>
               <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" CssClass="txtmodecolor" Width="153px"></asp:TextBox></td>
        </tr>
        <tr >
            <td colspan="2">
             <div style="align-items:center">  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="btnLogin" runat="server" Text="Login"/>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="Reset" runat="server" Text="Reset"/>
              </div> </td>
          
         
       </tr>
   </table>
       
</asp:Content>

