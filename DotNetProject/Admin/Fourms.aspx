<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminHomePage.master" AutoEventWireup="true" CodeFile="Fourms.aspx.cs" Inherits="Admin_Fourms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div align="center">
    <asp:GridView ID="GridViewAllFourms" Caption="Fourms List" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  DataKeyNames="QuestionId" EmptyDataText="No Fourms Found" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
            <asp:BoundField DataField="Reply" HeaderText="Reply" SortExpression="Reply" />
            <asp:BoundField DataField="UserName" HeaderText="Posted by" SortExpression="UserName" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButtonDeleteFourms" runat="server" ToolTip="Delete Fourms" ImageUrl="~/Images/delete.png" Width="50" Height="50"  OnClick="ImageButtonDeleteFourms_Click1"  Enabled="true"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />

    </asp:GridView>
        </div>

</asp:Content>

