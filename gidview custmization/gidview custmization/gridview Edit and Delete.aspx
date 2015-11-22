<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridview Edit and Delete.aspx.cs" Inherits="gidview_custmization.gridview_Edit_and_Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridViewempEdit" runat="server" AutoGenerateColumns="False" OnRowCommand="GridViewempEdit_RowCommand">
           
       <Columns>
            <asp:TemplateField HeaderText="Employee No">
                  <ItemTemplate>
                      <asp:Label ID="lbleno" runat="server" Text='<%#Eval("eno")%>'></asp:Label>
                  </ItemTemplate>
                  
                    
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Employee Name">
              
                    <ItemTemplate>
                    <%#Eval("ename")%>
                </ItemTemplate>
                       </asp:TemplateField>
                <asp:TemplateField HeaderText=" Age">
               <ItemTemplate>
                      <%#Eval("age")%>
                  </ItemTemplate>
               
                       </asp:TemplateField>

                <asp:TemplateField HeaderText="Address">

               <ItemTemplate>
                      <%#Eval("address")%>
                 
                           </ItemTemplate>

                    </asp:TemplateField>

                   <asp:TemplateField HeaderText="Salary">

                        <ItemTemplate>
                   <%#Eval("salary")%>
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
           <asp:TemplateField HeaderText="Update">
               <ItemTemplate>
                   <asp:LinkButton ID="linkUpdate" runat="server" Text="Edit" CommandName="Edit" CausesValidation="false"></asp:LinkButton>
                    </ItemTemplate>
             <EditItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update" CausesValidation="false"/>
                  <asp:Button ID="btnCancel" runat="server" Text="Cancel"  CommandName="Update" CausesValidation="false" />
              
              </EditItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="Delete">
              <ItemTemplate>
                  <asp:LinkButton id="linkbtndelete" runat="server" Text="Delete" CommandName="Delete" CausesValidation="false"></asp:LinkButton>
                 
              </ItemTemplate>
           </asp:TemplateField>
       </Columns>
            
             </asp:GridView>
    
        <asp:Label ID="lblmsg" runat="server" align="center"></asp:Label>

    </div>
    </form>
</body>
</html>
