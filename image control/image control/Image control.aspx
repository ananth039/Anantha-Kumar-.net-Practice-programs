<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image control.aspx.cs" Inherits="image_control.Image_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
    
        <asp:Image ID="imgdispaly" runat="server" Height="159px" Width="362px" AlternateText="cook" ToolTip="Cook image" />
    
    </div >
        <asp:Button ID="btndisplayimage" runat="server" Text="Display Image" OnClick="btndisplayimage_Click" />
    </form>
</body>
</html>
