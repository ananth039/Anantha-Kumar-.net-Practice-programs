<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview emp ex 1.aspx.cs" Inherits="gridview_display_emp_using_two_drop_down_lists.Gridview_emp_ex_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 19%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblDname" runat="server" Text="Select Dname"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListDname" runat="server" OnSelectedIndexChanged="DropDownListDname_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEname" runat="server" Text="Select Ename"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListEname" runat="server" OnSelectedIndexChanged="DropDownListEname_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridViewEmpdetails" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
