<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator2.aspx.cs" Inherits="required_field_validateors.validator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <script src="Scripts/jquery-2.1.4.js"></script>
 
</head>
<body>
   <form id="form1" runat="server">
    Your name:<br />
    <asp:TextBox runat="server" id="txtName"  />
    <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtName" errormessage="Please enter your name!" ForeColor="Red" Display="Dynamic" />
       <br />
       <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
       <br />
       
     
</form>
</body>
</html>
