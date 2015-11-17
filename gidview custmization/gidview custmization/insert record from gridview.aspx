<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert record from gridview.aspx.cs" Inherits="gidview_custmization.insert_record_from_gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowFooter="true" OnRowCommand="GridView1_RowCommand"> 
            <Columns>
                <asp:TemplateField HeaderText="employe no">
                    <ItemTemplate>
                    <%#Eval("eno") %>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtEmpno" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee name">
                    <ItemTemplate>
                        <%#Eval("ename") %>
                    </ItemTemplate>
                      <FooterTemplate>
                        <asp:TextBox ID="txtEmpname" runat="server"></asp:TextBox>
                    </FooterTemplate>

                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Age">
                    <ItemTemplate>
                        <%#Eval("age") %>
                    </ItemTemplate>
                      <FooterTemplate>
                        <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
                    </FooterTemplate>


                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <%#Eval("address") %>
                    </ItemTemplate>
                      <FooterTemplate>
                        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                    </FooterTemplate>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Salary">
                    <ItemTemplate>
                        <%#Eval("salary") %>
                    </ItemTemplate>
                      <FooterTemplate>
                        <asp:TextBox ID="txtsal" runat="server"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Desigation">
                    <ItemTemplate>
                        <%#Eval("desigation") %>
                    </ItemTemplate>
                      <FooterTemplate>
                        <asp:TextBox ID="txtdesigation" runat="server"></asp:TextBox>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Add/Save" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:Button ID="btnadd" runat="server" Text="Add" CommandName="Add" CausesValidation="false" />
                         </ItemTemplate>
                   <FooterTemplate>
                      <asp:Button ID="btnSave" runat="server" Text="Save" CommandName="Save" CausesValidation="false" />

                      
                   </FooterTemplate>
                </asp:TemplateField>
              
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
