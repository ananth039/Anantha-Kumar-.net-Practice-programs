<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee details with image.aspx.cs" Inherits="images_in_gridview.Employee_details_with_image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <Columns>
                <asp:BoundField HeaderText="Employee Id"  DataField="Eid"/>
                <asp:BoundField HeaderText="Employee Name" DataField="Name" />
                <asp:BoundField HeaderText="Gender" DataField="Gender" />
                <asp:BoundField HeaderText="City" DataField="City" />
                <asp:TemplateField HeaderText="Photo">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" AlternateText="Image Not Found"  ImageUrl='<%# bind("Photo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </form>
</body>
</html>
