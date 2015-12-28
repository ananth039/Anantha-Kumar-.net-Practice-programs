<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="PostArticles.aspx.cs" Inherits="Users_PostArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 34%;
        }
        .auto-style2 {
            height: 23px;
            width: 291px;
        }
        .auto-style3 {
            width: 637px;
        }
        .auto-style4 {
            height: 23px;
            width: 637px;
        }
        .auto-style5 {
            width: 291px;
        }
        .auto-style6 {
            width: 291px;
            height: 39px;
        }
        .auto-style7 {
            width: 637px;
            height: 39px;
        }
    </style>  

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">  <table class="auto-style1">
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lblArticleId" runat="server" Text="Article Id"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:Label ID="LblDisplayArticleId" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="lblArticleType" runat="server" Text="Article Type"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtAricleType" runat="server" Width="358px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFVArticlesType" runat="server" ControlToValidate="txtAricleType" ForeColor="Red" Display="Dynamic" ErrorMessage="please enter Article Type "></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Height="120px" style="margin-left: 0px" Width="397px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFVDescription" Display="Dynamic"  runat="server" ForeColor="Red" ControlToValidate="txtDescription" ErrorMessage="please enter Description"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style4">
                <asp:Button ID="btnPostArticles" runat="server" Text="Post Articles" OnClick="btnPostArticles_Click" style="height: 26px"  />
            </td>
        </tr>

    </table>
        <asp:label runat="server" text="" id="lblmsg"></asp:label>
    </div>
</asp:Content>

