<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display Images.aspx.cs" Inherits="insert_images_into_database.Display_Images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="ImageName" DataField="ImageName" />
                <asp:TemplateField HeaderText="Image">
                   <ItemTemplate>
                       <asp:Image ID="img1" runat="server" ImageUrl='<%#"data:image/jpg;base64,"+Convert.ToBase64String((byte[])Eval("Image") )%>'  Width="150" Height="150"/>
                   </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
        <asp:Image ID="Image1" runat="server" Height="88px" Width="101px" />
    
    </div>
    </form>
</body>
</html>
