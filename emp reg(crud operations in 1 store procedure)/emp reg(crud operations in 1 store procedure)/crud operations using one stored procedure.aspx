﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud operations using one stored procedure.aspx.cs" Inherits="emp_reg_crud_operations_in_1_store_procedure_.crud_operations_using_one_stored_procedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
     <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblEmpNo" runat="server" Text="Enter Employee No"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmpNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblEmpName" runat="server" Text="Enter Employee Name"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSalary" runat="server" Text="Enter Salary"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDeptNo" runat="server" Text="Deptartment No"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDeptno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="58px" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" Width="59px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                </td>
            </tr>
        </table>
   
    
    
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
   
    
    
   
         
     <asp:GridView ID="GridViewEmp" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White" />
         <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
         <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
         <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
         <SortedAscendingCellStyle BackColor="#FDF5AC" />
         <SortedAscendingHeaderStyle BackColor="#4D0000" />
         <SortedDescendingCellStyle BackColor="#FCF6C0" />
         <SortedDescendingHeaderStyle BackColor="#820000" />
     </asp:GridView>
     </form>
        </div>
</body>
</html>
