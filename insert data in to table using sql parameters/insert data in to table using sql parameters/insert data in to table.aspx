<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert data in to table.aspx.cs" Inherits="insert_data_in_to_table_using_sql_parameters.insert_data_in_to_table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" GroupingText="Employee Details" HorizontalAlign="Center">
            <asp:Label ID="lblEmpno" runat="server" Text="Emp No"></asp:Label>
            <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmpName" runat="server" Text="Emp Name"></asp:Label>
            <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtsalary" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
