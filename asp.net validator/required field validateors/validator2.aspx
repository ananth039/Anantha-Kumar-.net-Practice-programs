<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator2.aspx.cs" Inherits="required_field_validateors.validator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
</head>
<body>
   <form id="form1" runat="server">
    Your name:<br />
    <asp:TextBox runat="server" id="txtName" />
    <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtName" errormessage="Please enter your name!" Display="Dynamic" />
    <br /><br />
    <asp:Button runat="server" id="btnSubmitForm" text="submit" OnClick="btnSubmitForm_Click1" />
       <p>
           <asp:Label ID="Label1" runat="server"></asp:Label>
       </p>
</form>
</body>
</html>
