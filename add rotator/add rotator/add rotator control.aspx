﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add rotator control.aspx.cs" Inherits="add_rotator.add_rotator_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Add.xml" />
        
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>