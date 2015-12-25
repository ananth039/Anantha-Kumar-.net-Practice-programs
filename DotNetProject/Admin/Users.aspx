<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminHomePage.master" AutoEventWireup="true" CodeFile="Users.aspx.cs" Inherits="Admin_Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div align="center">
    <asp:GridView ID="GridViewAllUsersDetails" runat="server" Caption="Users List" AutoGenerateColumns="False" OnRowCommand="GridViewAllUsersDetails_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="LoginId"> 
                <ItemTemplate>
                    <asp:Label ID="lblLoginId" runat="server" Text='<%#Eval("LoginId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    
              <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="User Name">
                <ItemTemplate>    
                    <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("Username") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Security Question">
                <ItemTemplate>
                    <asp:Label ID="lblSecurityQuestion" runat="server" Text='<%#Eval("SecQuestion") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Answer">
                <ItemTemplate>
                    <asp:Label ID="lblAnswer" runat="server" Text='<%#Eval("Answer") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField >
                <ItemTemplate>
                    <asp:LinkButton ID="LinkbtnStatus" runat="server" Text='<%#Eval("Status") %>' CommandName="Status" CommandArgument='<%#Eval("LoginId") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
       </div>

    

</asp:Content>

