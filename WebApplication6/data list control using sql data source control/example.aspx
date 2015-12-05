<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="example.aspx.cs" Inherits="data_list_control_using_sql_data_source_control.example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="Dlist" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="5" RepeatDirection="Vertical" CellPadding="3" CellSpacing="1" >
            <HeaderTemplate>
                Employee Information
            </HeaderTemplate>
            <ItemTemplate>EmpNo:
                <asp:Label ID="lblEid" runat="server" Text='<%#Eval("empno") %>' /><br />
                EmpName:<asp:Label ID="lblEmpname" runat="server" Text='<%#Eval("Empname") %>' /><br />
                Salary:
                 <asp:Label ID="lblSalary" runat="server" Text='<%#Eval("salary") %>' /><br />
            </ItemTemplate>
        
        </asp:DataList>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=Ananth\Ananth;Initial Catalog=Emp;Integrated Security=True" SelectCommand="select * from emp"></asp:SqlDataSource>
    </form>
</body>
</html>
