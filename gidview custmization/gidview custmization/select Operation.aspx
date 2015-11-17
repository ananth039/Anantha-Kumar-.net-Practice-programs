<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select Operation.aspx.cs" Inherits="gidview_custmization.select_Operation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridEmp" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" HorizontalAlign="Center" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="Employee No">
                  <ItemTemplate>
                      <asp:Label ID="lbleno" runat="server" Text='<%#Eval("eno")%>'></asp:Label>
                  </ItemTemplate>
                  
                    
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Employee Name">
                  <ItemTemplate>
                      <asp:Label ID="lblename" runat="server" Text='<%#Eval("ename")%>'></asp:Label>
                  </ItemTemplate>
                       </asp:TemplateField>
                <asp:TemplateField HeaderText=" Age">
                  <ItemTemplate>
                      <asp:Label ID="lblage" runat="server" Text='<%#Eval("age")%>'></asp:Label>
                  </ItemTemplate>
                       </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                  <ItemTemplate>
                      <asp:Label ID="lbladdress" runat="server" Text='<%#Eval("address")%>'></asp:Label>
                  </ItemTemplate>
                       </asp:TemplateField>
                   <asp:TemplateField HeaderText="Salary">
                  <ItemTemplate>
                      <asp:Label ID="lblsal" runat="server" Text='<%#Eval("salary")%>'></asp:Label>
                  </ItemTemplate>
                       </asp:TemplateField>
                  <asp:TemplateField HeaderText="Designation">
                  <ItemTemplate>
                      <asp:Label ID="lbldesigation" runat="server" Text='<%#Eval("desigation")%>'></asp:Label>
                  </ItemTemplate>
                       </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <div align="center">
        <asp:Label ID="lblEmpno" Text="" runat="server"></asp:Label><br />
         <asp:Label ID="lblEname" Text="" runat="server"></asp:Label><br />
         <asp:Label ID="lblage" Text="" runat="server"></asp:Label><br />
         <asp:Label ID="lbladdress" Text="" runat="server"></asp:Label><br />
         <asp:Label ID="lblsalary" Text="" runat="server"></asp:Label><br />
         <asp:Label ID="lbldesignation" Text="" runat="server"></asp:Label>
    </div>
    </div>
    </form>
</body>
</html>
