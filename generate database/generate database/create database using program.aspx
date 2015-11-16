<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create database using program.aspx.cs" Inherits="generate_database.create_database_using_program" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
    <asp:Label ID="lbldbname" runat="server" Text="Enter Database" ></asp:Label>
    
        <asp:TextBox ID="txtdbname" runat="server"></asp:TextBox><br />
        
        <asp:Button ID="BtngenerateDatabase" runat="server" Text="Create Database" OnClick="BtngenerateDatabase_Click" />
    
       <br /> <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
