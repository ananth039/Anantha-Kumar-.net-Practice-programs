<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MENU CONTROL.aspx.cs" Inherits="menu_Control.MENU_CONTROL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        >
        <asp:Menu ID="menu1" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem Text="Forums">
                    <asp:MenuItem Text="post query" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                      <asp:MenuItem Text="View all  queries" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                      <asp:MenuItem Text="Answer queries" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
               <Items>
                <asp:MenuItem Text="articles">
                    <asp:MenuItem Text="post query" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                      <asp:MenuItem Text="View all  queries" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                      <asp:MenuItem Text="Answer queries" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
               <Items>
                <asp:MenuItem Text="Foru">
                    <asp:MenuItem Text="post query" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                      <asp:MenuItem Text="View all  queries" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                      <asp:MenuItem Text="Answer queries" NavigateUrl="~/Postquery.aspx"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
      
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
