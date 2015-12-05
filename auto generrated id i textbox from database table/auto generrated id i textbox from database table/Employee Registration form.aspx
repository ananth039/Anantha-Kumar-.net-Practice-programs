<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee Registration form.aspx.cs" Inherits="auto_generrated_id_i_textbox_from_database_table.Employee_Registration_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 24%;
        }
        .auto-style2 {
            width: 465px;
        }
        .auto-style3 {
            height: 23px;
            width: 79px;
        }
        .auto-style4 {
            width: 465px;
            height: 23px;
        }
        .auto-style5 {
            width: 79px;
        }
        .auto-style6 {
            width: 79px;
            height: 61px;
        }
        .auto-style7 {
            width: 465px;
            height: 61px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lbleno" runat="server" Text="Enter Employee No"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblEname" runat="server" Text="Enter Employee Name"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
