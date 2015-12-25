<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert images into database.aspx.cs" Inherits="insert_images_into_database.insert_images_into_database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 27%;
            height: 58px;
        }
        .auto-style2 {
            width: 743px;
        }
        .auto-style3 {
            width: 743px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Photo"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUploadImage" runat="server" style="margin-left: 0px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload Image" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
