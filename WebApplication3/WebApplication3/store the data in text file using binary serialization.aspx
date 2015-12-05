<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="store the data in text file using binary serialization.aspx.cs" Inherits="WebApplication3.store_the_data_in_text_file_using_binary_serialization" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lbleno" runat="server" Text="Eno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEname" runat="server" Text="Ename"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnSerialize" runat="server" Text="Serialize" OnClick="btnSerialize_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnDeserialize" runat="server" Text="Deserialize" OnClick="btnDeserialize_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
