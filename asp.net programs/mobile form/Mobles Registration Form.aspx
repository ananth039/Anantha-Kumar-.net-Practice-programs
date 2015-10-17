<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobles Registration Form.aspx.cs" Inherits="mobile_form.Mobles_Registration_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    
</head>
<body>
    <form  align="center" id="form1" runat="server" style="background-color:teal">
        <asp:Label ID="lblMobileRegistration" runat="server" Text="Mobile Registration"></asp:Label>
        <div></div>
        <div>
            <asp:Label ID="lblmobileId" runat="server" Text="Mobile Id"  style="color:white;text-align:left"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMobileId" runat="server" Width="196px" ></asp:TextBox>
        </div>
    <div>
    
        <asp:Label ID="lblMobileBrand" runat="server" Text="Mobile Brand" style="color:white;text-align:left"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMobileBrand" runat="server">
            <asp:ListItem>Nokia</asp:ListItem>
            <asp:ListItem>Samsung</asp:ListItem>
            <asp:ListItem>Sony</asp:ListItem>
            <asp:ListItem>Lenovo</asp:ListItem>
             <asp:ListItem>Apple</asp:ListItem>

        </asp:DropDownList>
    
    </div>
        <div>
            <asp:Label ID="lblMobileModel" runat="server" Text="Mobile Model" style="color:white;text-align:left"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtmobileModel" runat="server" Width="164px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblMobileOs" runat="server" Text="Mobile Operating System" style="color:white;text-align:left"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlOperatingsystem" runat="server">
                 <asp:ListItem>Android</asp:ListItem>
                 <asp:ListItem>Windows</asp:ListItem>
                 <asp:ListItem>ios</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lblPrice" runat="server" Text="Price" style="color:white;text-align:left"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtprice" runat="server" Width="224px"></asp:TextBox>
        </div>
        <div>

            <asp:Button ID="btnSubmit" runat="server" OnClick="SaveDetailsToDatabase" Text="Submit" />

        </div>
        <div>
             <asp:Label ID="lblStatus" runat="server" Text="Status" style="color:white;text-align:center"></asp:Label>
        </div>
    </form>
</body>
</html>
