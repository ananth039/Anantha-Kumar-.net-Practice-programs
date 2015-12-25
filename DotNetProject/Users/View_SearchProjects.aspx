<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="View_SearchProjects.aspx.cs" Inherits="Users_View_SearchProjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 24%;
        }
        .auto-style3 {
            width: 49px;
        }
        .auto-style4 {
            width: 112px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">

    <table class="auto-style1">

        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblKeyword" runat="server" Text="Keyword"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" Width="55px" style="margin-left: 0px" OnClick="btnSearch_Click" />
            </td>
            <td>
                <asp:LinkButton ID="LinkButtonViewAllProjects" runat="server" OnClick="LinkButtonViewAllProjects_Click">View All Projects</asp:LinkButton></td>
        </tr>
    </table>
        <br />
        <asp:GridView ID="GridViewProjects" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"  AutoGenerateColumns="False" style="font-weight: 700" DataKeyNames="projectId" EmptyDataText="No Results Found">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProjectType" HeaderText="Project Type" SortExpression="ProjectType" />
                <asp:BoundField DataField="FileName" HeaderText="File Name" SortExpression="FileName" />
                <asp:BoundField DataField="filetype" HeaderText="File Type" SortExpression="filetype" />
                <asp:BoundField DataField="Username" HeaderText="Posted By" SortExpression="Username" />
                <asp:TemplateField>
                    <ItemTemplate> 
                        <asp:LinkButton ID="linkButtonDownloadProject" runat="server" OnClick="linkButtonDownloadProject_Click"><asp:Image runat="server" imageUrl="~/Images/download.png" width="50" height="50"></asp:Image></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
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

