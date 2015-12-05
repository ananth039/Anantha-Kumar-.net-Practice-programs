<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="command event on button exmaple.aspx.cs" Inherits="Command_event_on_button.command_event_on_button_exmaple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnclick" runat="server" Text="ClickMe" OnClick="btnclick_Click" OnCommand="btnclick_Command" />
        <asp:Button ID="btnClickMe" runat="server" Text="ClickMe" OnCommand="btnclick_Command" />
    
    </div>
    </form>
</body>
</html>
