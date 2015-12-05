<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentMarksEntryForm.aspx.cs" Inherits="WebApplication5.StudentMarksEntryForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 31%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 426px;
        }
        .auto-style4 {
            height: 23px;
            width: 426px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>StudentName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtsname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Subject 1 Marks</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtsub1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Subject 2 Marks</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtsub2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Subject 3 Marks</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtsub3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="BtnSave" runat="server" Text="SAVE" OnClick="BtnSave_Click" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:GridView ID="girdviewEmpdetails" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
