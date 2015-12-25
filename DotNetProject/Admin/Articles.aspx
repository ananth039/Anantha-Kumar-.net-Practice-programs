<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminHomePage.master" AutoEventWireup="true" CodeFile="Articles.aspx.cs" Inherits="Admin_Articles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <asp:GridView ID="GridViewAllArticles" Caption="Article List" runat="server" AutoGenerateColumns="False" DataKeyNames="ArticleId" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" >
        <Columns>
            <asp:BoundField DataField="ArticleId" HeaderText="Article Id" SortExpression="ArticleId" />
            <asp:BoundField DataField="ArticlType" HeaderText="Article Type" SortExpression="ArticlType" />
            <asp:BoundField DataField="ArticleDesc" HeaderText="Article Description" SortExpression="ArticleDesc" />
            <asp:BoundField DataField="CDate" HeaderText="Posted Date" SortExpression="CDate" />
            <asp:BoundField DataField="Time" HeaderText="Posted Time" SortExpression="Time" />
            <asp:BoundField DataField="Username" HeaderText="User Name" SortExpression="Username" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButtonDelete" runat="server" ImageUrl="~/Images/delete.png" ToolTip="Delete Article" OnClick="ImageButtonDelete_Click"  Width="50" Height="50"/>
                      </ItemTemplate>

            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
        </div>
</asp:Content>


