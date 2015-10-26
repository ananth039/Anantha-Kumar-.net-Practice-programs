<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Save_DataTable_Into_ViewState_and_Bind_Gridview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #0000FF">  
    <form id="form1" runat="server">  
    <table style="color: White;margin-top:30px;margin-left:10px">  
        <tr>  
            <td>  
                Author Name  
            </td>  
            <td>  
                Book Name  
            </td>  
            <td>  
                Book Type  
            </td>  
            <td>  
                Publisher  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
            </td>  
            <td>  
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>  
            </td>  
            <td>  
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>  
            </td>  
            <td>  
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td>  
            </td>  
            <td>  
            </td>  
            <td>  
            </td>  
            <td>  
                <asp:Button ID="AddProduct" runat="server" Style="color: White" Text="Add Product"  
                    OnClick="AddProduct_Click" BackColor="#999966" />  
            </td>  
        </tr>  
    </table>  
     
    <div style="margin-left:10px;margin-top:10px">  
     <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" CellPadding="4"  
        ForeColor="#333333" GridLines="None">  
        <AlternatingRowStyle BackColor="White" />  
        <Columns>  
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="Author  Name" DataField="AuthorName" />  
            <asp:BoundField HeaderStyle-Width="120px" HeaderText=" Book Name" DataField="BookName" />  
            <asp:BoundField HeaderStyle-Width="120px" HeaderText=" Book Type" DataField="BookType" />  
            <asp:BoundField HeaderStyle-Width="120px" HeaderText="Publisher" DataField="Publisher" />  
        </Columns>  
        <EditRowStyle BackColor="#2461BF" />  
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />  
        <RowStyle BackColor="#EFF3FB" />  
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />  
        <SortedAscendingCellStyle BackColor="#F5F7FB" />  
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />  
        <SortedDescendingCellStyle BackColor="#E9EBEF" />  
        <SortedDescendingHeaderStyle BackColor="#4870BE" />  
    </asp:GridView>  
    </div>  
    </form>  
</body>  
</html>
