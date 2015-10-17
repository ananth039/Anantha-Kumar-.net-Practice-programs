<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2.aspx.cs" Inherits="display_text_in__anothetr_textbox_using_postback._2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label> 
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    
    </div>
          <div>
        <asp:Label ID="lbloutput1" runat="server" Text="Output in Lower Case"></asp:Label> 
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    
    </div>
          <div>
        <asp:Label ID="lbloutput2" runat="server" Text="Output in Upper Case"></asp:Label> 
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
