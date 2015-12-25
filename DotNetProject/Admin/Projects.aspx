<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminHomePage.master" AutoEventWireup="true" CodeFile="Projects.aspx.cs" Inherits="Admin_Projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
     <asp:GridView ID="GridViewProjects" runat="server" CellPadding="4" ForeColor="#333333" Caption="Projects List" GridLines="None"  AutoGenerateColumns="False" style="font-weight: 700" DataKeyNames="projectId" EmptyDataText="No Results Found" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProjectType" HeaderText="Project Type" SortExpression="ProjectType" />
                <asp:BoundField DataField="FileName" HeaderText="File Name" SortExpression="FileName" />
                <asp:BoundField DataField="filetype" HeaderText="File Type" SortExpression="filetype" />
                <asp:BoundField DataField="Username" HeaderText="Posted By" SortExpression="Username" />
                 <asp:TemplateField>
                    <ItemTemplate> 
                        <asp:ImageButton ID="ImageButtonDeleteProject" runat="server"  ImageUrl="~/Images/delete.png" ToolTip="Delete file"  width="50" height="50" OnClick="ImageButtonDeleteProject_Click"/>
    
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate> 
                        <asp:ImageButton ID="ImageButtonDownloadProject" runat="server"  ImageUrl="~/Images/download.png" ToolTip="Download file" OnClick="ImageButtonDownloadProject_Click" width="50" height="50"/>
    
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
        </div>
</asp:Content>

