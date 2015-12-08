<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display user details.aspx.cs" Inherits="approve_or_block_the_user_admin__project.Display_user_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" >
            <Columns>
               
                <asp:TemplateField HeaderText="LoginId">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("LoginId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="User Name">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("Password") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Security Question">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%#Eval("SecQuestion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Answer">
                                        <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Answer") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                <asp:LinkButton ID="linkStatus" runat="server" Text='<%#Eval("Status")%>' CommandArgument='<%#Eval("LoginId") %>' CommandName="Status" />
                    </ItemTemplate>
                </asp:TemplateField>
               
            </Columns>
        </asp:GridView>
    
      
    </div>
    </form>
</body>
</html>
