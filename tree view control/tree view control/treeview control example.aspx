<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="treeview control example.aspx.cs" Inherits="tree_view_control.treeview_control_example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="Treeview1" runat="server">
            <Nodes>
                <asp:TreeNode Text="My computer" >

               
                <asp:TreeNode Text="C" NavigateUrl="~/treeview control example.aspx">

                </asp:TreeNode> 
                 <asp:TreeNode Text="D" NavigateUrl="~/treeview control example.aspx">

                </asp:TreeNode> 
                 <asp:TreeNode Text="E" NavigateUrl="~/treeview control example.aspx">

                </asp:TreeNode> 
                     </asp:TreeNode> 

                 <asp:TreeNode Text="MyDocuments">
                    <asp:TreeNode Text="Mypictures"  NavigateUrl="~/treeview control example.aspx"></asp:TreeNode>
                      <asp:TreeNode Text="Mypictures"  NavigateUrl="~/treeview control example.aspx"></asp:TreeNode>

                </asp:TreeNode> 
            </Nodes>
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
