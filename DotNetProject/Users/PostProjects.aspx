<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="PostProjects.aspx.cs" Inherits="Users_PostProjects_aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
        width: 322px;
            height: 115px;
        }
    .auto-style2 {
        height: 23px;
        width: 117px;
    }
    .auto-style3 {
        height: 26px;
        width: 117px;
    }
    .auto-style4 {
        height: 23px;
        width: 217px;
    }
    .auto-style5 {
        height: 26px;
        width: 217px;
    }
        .auto-style8 {
            width: 217px;
        }
        .auto-style9 {
            width: 117px;
        }
        .auto-style10 {
            width: 117px;
            height: 42px;
        }
        .auto-style11 {
            width: 217px;
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div align="center">

    <table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblProjectId" runat="server" Text="Project Id" ></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:Label ID="lblDisplayProjectId" runat="server" Text="" ></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="lblProjectType" runat="server" Text="Projet Type"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="txtProjectType" runat="server" style="margin-left: 0px" Width="204px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">
            <asp:Label ID="lblUploadaProject" runat="server" Text="Upload Project"></asp:Label>
        </td>
        <td class="auto-style11">
            <asp:FileUpload ID="FileUploadProject" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style8">
            <asp:Button ID="btnUploadProject" runat="server" Text="Upload Project" OnClick="btnUploadProject_Click" Width="141px" />
        </td>
    </tr>
</table>
           <br />    <br />    <br />    <br />    <br />    <br />    <br />    <br />    <br />
       </div>

</asp:Content>

