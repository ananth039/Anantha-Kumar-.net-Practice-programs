<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display images in gridview using image fields.aspx.cs" Inherits="images_in_gridview.display_images_in_gridview_using_image_fields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <Columns>
                <asp:BoundField HeaderText="Employee Id"  DataField="Eid"/>
                <asp:BoundField HeaderText="Employee Name" DataField="Name" />
                <asp:BoundField HeaderText="Gender" DataField="Gender" />
                <asp:BoundField HeaderText="City" DataField="City" />
              
                <asp:ImageField   HeaderText="Photo" AlternateText="Image not found" ControlStyle-Height="100px" ControlStyle-Width="100px" DataImageUrlField="photo" NullDisplayText="Image link null"></asp:ImageField>
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
    </div>
    </form>
</body>
</html>
