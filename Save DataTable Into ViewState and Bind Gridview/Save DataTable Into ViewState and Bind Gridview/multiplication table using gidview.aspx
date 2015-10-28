<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiplication table using gidview.aspx.cs" Inherits="Save_DataTable_Into_ViewState_and_Bind_Gridview.multiplication_table_using_gidview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
             <h1 align="center">Multiplication</h1>
    <div align="center">
        Enter Number&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"/><br /><br />
Enter Range&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"/><br /><br />
<asp:Button ID="Button1" runat="server" Text="Product table" OnClick="Button1_Click" />
        <br />  <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    
    </form>
</body>
</html>
