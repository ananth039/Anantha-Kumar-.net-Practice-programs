<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usercontrol.ascx.cs" Inherits="user_controls_exmaple.usercontrol" %>
<div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</div>
<asp:Label ID="Label2" runat="server" Text="Enter your name"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
<p>
    <asp:Label ID="Label3" runat="server" Text="your name is"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" ></asp:TextBox>
</p>
<p>
    &nbsp;</p>

