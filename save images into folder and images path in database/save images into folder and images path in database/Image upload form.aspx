<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image upload form.aspx.cs" Inherits="save_images_into_folder_and_images_path_in_database.Image_upload_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Save Images In Folder and  image path in database</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center"><table><caption>Upload Image</caption>
        <tr><td>Photo</td><td><asp:FileUpload ID="fileuploadImage" runat="server" /></td></tr>
        <tr><td colspan="2"><asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click"/></td></tr>
         </table>
    
<br />

    </div>
    </form>
</body>
</html>
