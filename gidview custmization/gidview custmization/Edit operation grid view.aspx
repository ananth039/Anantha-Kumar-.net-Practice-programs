<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit operation grid view.aspx.cs" Inherits="gidview_custmization.Edit_operation_grid_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridViewempEdit" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="GridViewempEdit_RowCancelingEdit" OnRowEditing="GridViewempEdit_RowEditing" OnRowUpdating="GridViewempEdit_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
       <Columns>
            <asp:TemplateField HeaderText="Employee No">
                  <ItemTemplate>
                      <asp:Label ID="lbleno" runat="server" Text='<%#Eval("eno")%>'></asp:Label>
                  </ItemTemplate>
                  
                    
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Employee Name">
              
                    <ItemTemplate>
                      <asp:Label ID="lblename" runat="server" Text='<%#Eval("ename")%>' />
                </ItemTemplate>
                       </asp:TemplateField>
                <asp:TemplateField HeaderText=" Age">
               <ItemTemplate>
                      <asp:Label ID="lblage" runat="server" Text='<%#Eval("age")%>' />
                  </ItemTemplate>
               
                       </asp:TemplateField>

                <asp:TemplateField HeaderText="Address">

               <ItemTemplate>
                      <asp:Label ID="lbladdress" runat="server" Text='<%#Eval("address")%>' />
                 
                           </ItemTemplate>

                    </asp:TemplateField>

                   <asp:TemplateField HeaderText="Salary">

                        <ItemTemplate>
                     <asp:Label ID="lblsal" runat="server" Text='<%#Eval("salary")%>' />
                 </ItemTemplate>
                <EditItemTemplate>
                     <asp:TextBox ID="txtsal" runat="server" Text='<%#Eval("salary")%>' />
                 </EditItemTemplate>

                       </asp:TemplateField>

                  <asp:TemplateField HeaderText="Designation">

                 <ItemTemplate>

                    <asp:Label ID="lbldesigation" runat="server" Text='<%#Eval("desigation")%>'/>
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
    
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
