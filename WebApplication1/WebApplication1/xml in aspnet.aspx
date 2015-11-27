<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xml in aspnet.aspx.cs" Inherits="WebApplication1.xml_in_aspnet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
        <asp:Label ID="lblempNo" runat="server" Text="Employee No"></asp:Label>
        <asp:TextBox ID="txtempno" runat="server"></asp:TextBox>
    <div>
    
        <asp:Label ID="lblempname" runat="server" Text="Employee Name"></asp:Label>
        <asp:TextBox ID="txtempname" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="lblsal" runat="server" Text="Salary"></asp:Label>
            <asp:TextBox ID="txsal" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="Employee No">

                    <ItemTemplate>
                        <%#Eval("EmpNo") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee Name">
                    <ItemTemplate>
                        <%#Eval("EmpName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Salary">
                    <ItemTemplate>
                        <%#Eval("salary") %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
