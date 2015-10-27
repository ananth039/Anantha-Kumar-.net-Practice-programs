<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="multiplication table in grid view.aspx.cs" Inherits="Save_DataTable_Into_ViewState_and_Bind_Gridview.multiplication_table_in_grid_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div  align="center">
        <asp:Label ID="Label1" runat="server" Text="Multplication Table"></asp:Label><br />
  
    
        <asp:Label ID="Label2" runat="server" Text="Enter Number:"></asp:Label>
       &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtenterNumber" runat="server"></asp:TextBox><br />
    
    
        <asp:Label ID="Label3" runat="server" Text="Enter Range"></asp:Label>
              &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtRange" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnMupltiply" runat="server" Text="Multiply" OnClick="btnMupltiply_Click" />
             
              
             
          <asp:GridView ID="GridView1" runat="server">
          </asp:GridView><br />
              <asp:Label ID="txtstatus" runat="server" Text=""></asp:Label>
               </div>
    </form>
</body>
</html>
