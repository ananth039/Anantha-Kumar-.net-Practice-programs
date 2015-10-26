<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calendar demo2.aspx.cs" Inherits="calendar.calendar_demo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        your birthday<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        to day date:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        our birthday:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> </div>
    </form>
</body>
</html>
