<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample form.aspx.cs" Inherits="user_control_example1.sample_form" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:WebUserControl1 runat="server" id="WebUserControl1" Header="students details" />
        </div>
    </form>
</body>
</html>
