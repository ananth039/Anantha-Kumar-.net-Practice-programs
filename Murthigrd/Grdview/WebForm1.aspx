﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Grdview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 24px;
        }
        .auto-style4 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        
        
        
        
        +9<table class="auto-style1">
            <tr>
                <td>Eid</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Must not be empty"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Ename</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Must not be empty"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Designtion</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Must not be empty"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Salary</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td>Qualification</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Must not be empty"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobile</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="Only numbers" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox7" ErrorMessage="Incorrect Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Mid</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox8" ErrorMessage="Must not be empty"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" OnClick="Button2_Click" Text="Getdetails" />
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" DataKeyNames="eid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
            <Columns>
                <asp:TemplateField HeaderText="Eid">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("eid") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("eid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ename">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ename") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ename") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Designation">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("designation") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("designation") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Salary">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("sal") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("sal") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Qualification">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("qualification") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("qualification") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mobile">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("mobile") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("mobile") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mid">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("mid") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("mid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="send details">
                    <ItemTemplate>
                   <asp:HyperLink runat="server" NavigateUrl='<%# Eval("eid", "~/WebForm2.aspx?eid={0}") %>' Text='Send Details' />
                </ItemTemplate>
                </asp:TemplateField>
               
                   
                   
               
                
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
