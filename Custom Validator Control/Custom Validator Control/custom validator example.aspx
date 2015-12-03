<%@ Page  Language="C#" AutoEventWireup="true" CodeBehind="custom validator example.aspx.cs" Inherits="Custom_Validator_Control.custom_validator_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblenterYourpassword" runat="server" Text="Enter Your Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CustomValidator ID="cvPassword" runat="server" ForeColor="Red" ErrorMessage="*password should be minmum 6 characters" ControlToValidate="txtPassword" OnServerValidate="cvPassword_ServerValidate"></asp:CustomValidator>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    </div>
    </form>
</body>
</html>
