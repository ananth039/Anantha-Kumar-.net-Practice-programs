<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistartion.aspx.cs" Inherits="approve_or_block_the_user_admin__project.UserRegistartion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 363px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 526px;
        }
        .auto-style4 {
            height: 23px;
            width: 526px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblLoginId" runat="server" Text="Login Id"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtLoginId" runat="server" ReadOnly="true" ToolTip=" User LoginId" Width="182px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtName" runat="server" Width="182px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUserName" runat="server" Height="21px" Width="182px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="182px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSecQuestion" runat="server" Text="SecurityQuestion"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownListSecQuestion" runat="server">
                         <asp:ListItem>select
                        </asp:ListItem>
                        <asp:ListItem>What is your pet name?
                        </asp:ListItem>
                         <asp:ListItem>What is  Your Nickname?
                        </asp:ListItem>
                         <asp:ListItem>What is  Your Father?
                        </asp:ListItem>
                         <asp:ListItem>who is Your Childhood Hero?
                        </asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtAnswer" runat="server" Width="182px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
              <td class="auto-style3">
                  <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
              </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
