<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hash Table.aspx.cs" Inherits="Hash_table_demo.Hash_Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnHashTable" runat="server" Text="Add hash table values to listbox" OnClick="btnHashTable_Click" />
    
    </div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
       <br /> <asp:Label ID="lblhashtable" runat="server" Text=""></asp:Label>
       <br /> <asp:Button ID="Button1" runat="server" Text="check  key 1 exist or not" OnClick="Button1_Click" />
       <br /> <asp:Label ID="txtstatus" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
