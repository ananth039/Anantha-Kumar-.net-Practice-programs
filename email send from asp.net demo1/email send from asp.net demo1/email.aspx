<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="email.aspx.cs" Inherits="email_send_from_asp.net_demo1.email" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <table align="center" style="width: 519px">
        <caption>Email</caption>
    <tr>
        <td>To</td><td><asp:TextBox runat="server" ID="txtToAddress" Width="413px"></asp:TextBox></td></tr>
        <tr> <td>Subject</td><td><asp:TextBox runat="server" ID="txtSubject" Height="23px" Width="413px"></asp:TextBox></td></tr>
         <tr><td>Body</td><td><asp:TextBox ID="txtBody" runat="server" Height="66px" TextMode="MultiLine" Width="416px"></asp:TextBox></td>
       <tr> <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       

           <asp:Button ID="btnSend" runat="server" Text="Send" Width="153px" OnClick="btnSend_Click" /></td></tr>
</table>
    </form>
</body>
</html>
