<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater Control example.aspx.cs" Inherits="Repeater_Control.Repeater_Control_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1">
        <asp:Repeater ID="Repeater1" runat="server">
            
            <HeaderTemplate>
                <tr>
                    <td>Eno</td><td>Ename</td><td>Salary</td>
                </tr>

            </HeaderTemplate>
           <ItemTemplate>
               <tr><td>
               <%#DataBinder.Eval(Container.DataItem,"empno") %>
                   </td>
                   <td>
                <%#DataBinder.Eval(Container.DataItem,"Empname") %>

                   </td>
                   <td>
                  <%#DataBinder.Eval(Container.DataItem,"salary") %>
                   </td></tr>
           </ItemTemplate>
        </asp:Repeater>
        </table>
    
    </div>
    </form>
</body>
</html>
