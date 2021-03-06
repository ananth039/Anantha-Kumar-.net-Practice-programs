﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete operation in gridview.aspx.cs" Inherits="gidview_custmization.example_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView runat="server" ID="GridEmp" AutoGenerateColumns="false" AutoGenerateDeleteButton="true" OnRowDeleting="GridEmp_RowDeleting">
        <Columns>
            <asp:TemplateField HeaderText="Employee No">
                <ItemTemplate>
                    <asp:Label ID="lbldelete" runat="server" Text='<%#Eval("empno") %>' />
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Employee Name">
                <ItemTemplate>
                    <asp:Label ID="lblename" runat="server" Text='<%#Eval("empname") %>' />
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Age">
                <ItemTemplate>
                 <asp:Label ID="lblage" runat="server" Text='<%#Eval("sal") %>' />
                </ItemTemplate>
            </asp:TemplateField>
         
           
        </Columns>
    </asp:GridView>
        <br />
        <asp:Label runat="server" ID="lblmsg" />
        
    </div>
    </form>
</body>
</html>
