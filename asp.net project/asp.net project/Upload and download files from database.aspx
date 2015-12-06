<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload and download files from database.aspx.cs" Inherits="asp.net_project.Upload_and_download_files_from_database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
        <br />
        <br />
        <asp:GridView ID="GridViewFiles" runat="server" AutoGenerateColumns="False" DataKeyNames="Id">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="FileName" HeaderText="FileName" />
                
                <asp:TemplateField HeaderText="FilePath">
                   <ItemTemplate>
                       <asp:LinkButton ID="LinkDownload" runat="server" Text="Download" OnClick="LinkDownload_Click" />
                   </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
