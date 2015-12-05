<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormView example.aspx.cs" Inherits="formview_control.FormView_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="FormView1" runat="server" AllowPaging="true" OnPageIndexChanging="FormView1_PageIndexChanging">
            <ItemTemplate>
                Emp Id:<%#Eval("empno") %><br />
                Emp Name:<%#Eval("Empname") %><br />
                Salary:<%#Eval("Salary") %><br />
            </ItemTemplate>
        </asp:FormView>
    <div>
    
    </div>
    </form>
</body>
</html>
