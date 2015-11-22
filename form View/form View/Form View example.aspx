<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form View example.aspx.cs" Inherits="form_View.Form_View_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" AllowPaging="true" OnPageIndexChanging="FormView1_PageIndexChanging">
        <ItemTemplate>
            Emp Id:<%#Eval("eno") %><br />
            Emp Name:<%#Eval("ename") %><br />
            Emp Age:<%#Eval("age") %><br />
            Emp Address:<%#Eval("address") %><br />
            Emp Salary:<%#Eval("salary") %><br />
            Emp Designation:<%#Eval("desigation")%>
        </ItemTemplate>
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
