<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="simple form.aspx.cs" Inherits="display_text_in__anothetr_textbox_using_postback.simple_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       .A
        {
            border:1px solid green;
            font-family:Lucida Sans;
        }
       .B
       {
           color:brown;
           background-color:cyan;
               font-family:Tahoma;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    
        <asp:Label ID="lblEnterYourText" runat="server" Text="Enter Your Text" class="B"></asp:Label>
        <asp:TextBox ID="txtYourText" runat="server" OnTextChanged="txtYourText_TextChanged" AutoPostBack="true" class="A"></asp:TextBox>
       
    
    </div>
        <div>
            <asp:Label ID="lblOutput1" runat="server" Text="Output-1" class="B"></asp:Label>
            <asp:TextBox ID="txtOutput1" runat="server" class="A"></asp:TextBox>
        </div>
        <div>
             <asp:Label ID="lblOutput2" runat="server" Text="Output-2" class="B"></asp:Label>
            <asp:TextBox ID="txtoutput2" runat="server" class="A"></asp:TextBox>
        </div>
    </form>
</body>
</html>
