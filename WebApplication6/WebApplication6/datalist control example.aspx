<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalist control example.aspx.cs" Inherits="WebApplication6.datalist_control_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data List Control</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" >
            <HeaderTemplate>
                Edit         eno       Ename     salary
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Button ID="EditButton" runat="server" Text="edit" CommandName="Cmdedit" CausesValidation="false"/>
                <%#DataBinder.Eval(Container.DataItem,"empno")%>
                <%#DataBinder.Eval(Container.DataItem,"Empname")%>
                <%#DataBinder.Eval(Container.DataItem,"salary")%>
            </ItemTemplate>
           <EditItemTemplate>
               <asp:Button ID="btnUpdate" runat="server" CommandName="CmdUpadate"  Text="Update" CausesValidation="false"/>
               <asp:Button ID="btnCancel" runat="server" CommandName="CmdCancel"  Text="Cancel" CausesValidation="false"/>
               <asp:Label ID="lblempno" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"empno")%>' ></asp:Label>
               <asp:TextBox ID="txtempname" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Empname")%>'></asp:TextBox>
               <asp:TextBox ID="txtSalary" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"salary")%>' ></asp:TextBox>         

           </EditItemTemplate>

        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
