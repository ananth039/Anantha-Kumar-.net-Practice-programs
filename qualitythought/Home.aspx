<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <div align="center">
    <asp:Label ID="lblGReeting" runat="server" Text="Welcome to  web Page" CssClass="sideheading" Font-Bold="True" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="#66FF33" ValidateRequestMode="Disabled" font-family="Tahoma"></asp:Label>
   </div> <br />
    <asp:Image ID="imghome"  runat="server" Height="500px" ImageUrl="~/3D-Design-Free-HD-Wallpaper.jpg" Width="100%" />
    </asp:Content>

