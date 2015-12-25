<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
        .auto-style1 {
            width: 186px;
        }
        .auto-style2 {
            width: 695px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table style="width: 100%; margin-bottom: 32px;">
                 <tr>
                     <td class="auto-style1">
                         <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/11048649_10154028329543676_6954127731734143355_n.jpg"  Width="200" Height="200"/></td>
                     <td class="auto-style2"><p style="width: 724px">
                         <i>.Net Community is a Community Website for .NET users that can help widespread, disparate offline communites to come-together,connect and share thougths, ideas and valuable information. .Net community websites allow users to communicate through a single platform and share/contributes/process data to an individual or a wide network of users.</i>
                         </p></td>
                    
                 </tr>
                
                 <tr>
                     <td class="auto-style1">&nbsp;</td>
                     <td class="auto-style2">&nbsp;</td>
                    
                 </tr>
             </table>
</asp:Content>
