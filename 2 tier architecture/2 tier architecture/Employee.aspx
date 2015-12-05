<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="_2_tier_architecture.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
            width: 80px;
        }
        .auto-style3 {
            width: 213px;
        }
        .auto-style4 {
            height: 26px;
            width: 213px;
        }
        .auto-style5 {
            width: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 303px">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblDeptName" runat="server" Text="Department Name"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="ddldeptName" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
           
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
