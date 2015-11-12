<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkbox control.aspx.cs" Inherits="checkbox_control.checkbox_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
    
        <asp:Label ID="lbllanguages" runat="server" Text="Select your Language"></asp:Label>
    
    </div>
        <asp:CheckBox ID="chbTelugu" runat="server" Text="Telugu" /><br />
    
        <asp:CheckBox ID="chbEnglish" runat="server" Text="English" /><br />
        <asp:CheckBox ID="chbHindi" runat="server" Text="Hindi" /><br />
        <asp:CheckBox ID="chbaTamil" runat="server"  Text="Tamil"/><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/><br />
        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
