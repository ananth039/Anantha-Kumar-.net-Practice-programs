<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="EditUserDetails.aspx.cs" Inherits="Users_EditUserDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style3 {
            height: 19px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style1 {
            height: 23px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
    <table>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lblName" runat="server" Text="Name :" />
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtName" runat="server" Width="160px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="LblGender" runat="server" Text="Gender :" />
            </td>
            <td class="auto-style2">
                <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
                <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="female" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth :" />
            </td>
            <td>
                <asp:TextBox ID="txtDob" runat="server" TextMode="Date" Width="162px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAddress" runat="server" Text="Address:" />
            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblZipcode" runat="server" Text="Zip code:" />
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtZipcode" runat="server"  Width="171px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPhno" runat="server" Text="Phone No :" />
            </td>
            <td>
                <asp:TextBox ID="txtphno" runat="server" Width="169px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email :" />
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Height="22px" Width="165px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text="UserName :" />
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server" ReadOnly="True" Width="157px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>
        </tr>
    </table>
    </div>
    <br />
    <br />
    <div align="center">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblUploadImage" runat="server" Text="Upload Image"></asp:Label></td><td>
                        <asp:FileUpload ID="FileUploadImage" runat="server" /></td>
            </tr>
            <tr><td colspan="2">
                <asp:Button ID="btnUploadImage" runat="server" Text="UploadImage" OnClick="btnUploadImage_Click" /></td></tr>
        </table>
    </div>

</asp:Content>

