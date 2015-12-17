<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="ViewAllQuestions.aspx.cs" Inherits="Users_ViewAllQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:Image ID="Image1" runat="server" style="z-index: 1; left: 42px; top: 95px; position: absolute; height: 144px;"/>
    <asp:GridView ID="GridViewQuestions" runat="server" DataKeyNames="QuestionId" AutoGenerateColumns="False" style="z-index: 1; left: 230px; top: 95px; position: absolute; height: 154px; width: 384px" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
              <asp:HyperLink runat="server" NavigateUrl= '<%# Eval("QuestionId", "~/Users/FourmReply.aspx?QuestionId={0}") %>' Text="Select"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Questions">
               <ItemTemplate>
                   <asp:Label runat="server" Text='<%#Eval("Question") %>' ></asp:Label>
               </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Postedby">
              <ItemTemplate>
                 <asp:Label runat="server" Text='<%#Eval("Username") %>' ></asp:Label>
                  </ItemTemplate>
            </asp:TemplateField>
        </Columns>
      
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
      
    </asp:GridView>

        <br />
          <br />
          <br />
  <br />
  <br />
  <br />
            <br />
          <br />
          <br />
  <br />
  <br />
  <br />
    <br />
          <br />
          <br />
  <br />
  <br />
  <br />
    <br />
          <br />
          <br />
  <br />
  <br />
  <br />
    <br />
          <br />
          <br />
  <br />
  <br />
  <br />



        </asp:Panel>
</asp:Content>

