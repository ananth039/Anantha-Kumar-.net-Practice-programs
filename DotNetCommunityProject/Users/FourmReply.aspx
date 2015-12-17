<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="FourmReply.aspx.cs" Inherits="Users_FourmReply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
        .auto-style1 {
            width: 445px;
            z-index: 1;
            left: 386px;
            top: 139px;
            position: absolute;
            height: 120px;
        }
        .auto-style2 {
            width: 323px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server">

    <asp:Image ID="ImageFourm" runat="server" style="z-index: 1; left: 27px; top: 98px; position: absolute; height: 175px; width: 260px; margin-right: 0px"  />
        <br />
        <br />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">
                    <asp:Label ID="lblQuestion" runat="server" Text="Question"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="lblDisplayQuestion" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label>
                </td>
                <td class="auto-style16">
                    <asp:TextBox ID="txtAnswer" runat="server" Width="248px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnPostReply" runat="server" Text="Post Reply" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblmsg" runat="server" style="z-index: 1; left: 552px; top: 279px; position: absolute" Text=""></asp:Label>

</asp:Panel>
 
   
</asp:Content>
