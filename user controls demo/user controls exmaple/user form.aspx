<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user form.aspx.cs" Inherits="user_controls_exmaple.user_form" %>

<%@ Register Src="~/usercontrol.ascx" TagPrefix="uc1" TagName="usercontrol" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:usercontrol runat="server" id="usercontrol" inputstring="Read from user" />
    </div>
    </form>
</body>
</html>
