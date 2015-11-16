<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image button control.aspx.cs" Inherits="image_button_control.Image_button_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="58px" Width="153px" ImageUrl="yahoo.jpg"  AlternateText="Yahoo" ToolTip="yahoo" OnClick="ImageButton1_Click" />
      <br />  <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    <div>
    
    </div>
    </form>
</body>
</html>
