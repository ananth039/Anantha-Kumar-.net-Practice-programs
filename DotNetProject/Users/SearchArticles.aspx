<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="SearchArticles.aspx.cs" Inherits="Users_SearchArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 37%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="lblKeyword" runat="server" Text="Keyword"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtkeyword" runat="server"></asp:TextBox>
            </td>
            <td>
                
                <asp:ImageButton ID="imgbtnSearch" runat="server" ImageUrl="~/Images/Search.png"  width="50px" height="37px" OnClick="btnSearch_Click"/>
            </td>
        </tr>
    </table>
        <asp:GridView ID="GridViewArticles" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No Articles Found">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ArticlType" HeaderText="Article Type" SortExpression="ArticlType" />
                <asp:BoundField DataField="ArticleDesc" HeaderText="Article Description" SortExpression="ArticleDesc" />
                <asp:BoundField DataField="CDate" HeaderText="Posted Date" SortExpression="CDate" />
                <asp:BoundField DataField="Time" HeaderText="Posted Time" SortExpression="Time" />
                <asp:BoundField DataField="Username" HeaderText="Posted By" SortExpression="Username" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
      <br />
    
      </div>
</asp:Content>

