<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panel control.aspx.cs" Inherits="panel.panel_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
            <asp:Panel ID="pnlLogin" runat="server" DefaultButton="btnsubmit" BackImageUrl="~/scale.jpg" GroupingText="Login" HorizontalAlign="center" Direction="LeftToRight" Wrap="true" ScrollBars="Both" Height="233px" ForeColor="White">
   
    <form id="form1" runat="server">
    <div>
 <asp:Label ID="lblusername" runat="server">UserName:</asp:Label><asp:TextBox runat="server" ID="txtuserName"> </asp:TextBox> <br />
   <asp:Label runat="server" ID="lblpwd">Password:</asp:Label><asp:TextBox runat="server" ID="txtpassword" TextMode="Password"> </asp:TextBox> <br />
        <asp:Button  runat="server" ID="btnsubmit" Text="Submit" /> <asp:Button  runat="server" ID="Cancel" Text="Cancel"/>
        

    </div>
    </form>
                </asp:Panel>
</body>
</html>
