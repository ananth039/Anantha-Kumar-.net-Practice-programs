<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="user_control_example1.WebUserControl1" %>
<asp:Label ID="lblheading" runat="server" Text=""></asp:Label>
<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" style="width: 61px" />