<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upload and search,download file from db using gridview and form.aspx.cs" Inherits="upload_download_search_file.upload_and_search_download_file_from_db_using_gridview_and_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>upload and search,download file from db using gridview and form</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Panel ID="PanelSearch" runat="server" GroupingText="Search File" HorizontalAlign="Justify" Width="380px">
            <table>
                <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblsearchFileName" runat="server" Text="Search by File Name"></asp:Label>
    
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtSearchFilename" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
                <tr><td><asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                      </td></tr>
            </table>
                </asp:Panel>
        <br />
        <br />

        <asp:Panel ID="PanelUploadFile" runat="server" GroupingText="UploadFile" HorizontalAlign="Justify" Width="378px"> 
            <table class="auto-style1">
            
            <tr>
                <td>
                    <asp:Label ID="lblFileId" runat="server" Text="FileId"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFileId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSelectFile" runat="server" Text="Select File"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                </td>
                
                <td>&nbsp;</td>
            </tr>
        </table>
                    </asp:Panel>
           <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Fileid">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("FileId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("FileId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FileType">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("FileType") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("FileType") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FileName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("FileName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("FileName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="File" Text="download" CommandArgument='<%#Eval("FileId") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
