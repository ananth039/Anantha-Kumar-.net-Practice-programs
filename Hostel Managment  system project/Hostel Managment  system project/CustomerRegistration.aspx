<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="Hostel_Managment__system_project.CustomerRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 24px;
            width: 183px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            height: 24px;
            width: 267px;
        }
        .auto-style8 {
            width: 100%;
        }
        .auto-style9 {
            height: 26px;
            width: 183px;
        }
        .auto-style10 {
            width: 267px;
            height: 26px;
        }
        .auto-style11 {
            height: 24px;
            width: 341px;
        }
        .auto-style12 {
            height: 26px;
            width: 341px;
        }
        .auto-style15 {
            height: 24px;
            width: 130px;
        }
        .auto-style16 {
            height: 26px;
            width: 130px;
        }
        .auto-style19 {
            width: 183px;
        }
        .auto-style20 {
            height: 23px;
            width: 183px;
        }
        .auto-style22 {
            width: 341px;
        }
        .auto-style24 {
            height: 23px;
            width: 341px;
        }
        .auto-style25 {
            width: 267px;
        }
        .auto-style26 {
            height: 23px;
            width: 267px;
        }
        .auto-style27 {
            width: 130px;
        }
        .auto-style28 {
            height: 23px;
            width: 130px;
        }
        </style>
</head>
<body style="height: 256px">
    <div>
    <form id="form1" runat="server" enctype="multipart/form-data">

    
        <asp:Panel ID="PanelPersonalDetails" runat="server" GroupingText="Personal Details">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblCustomerId" runat="server" Text="CustomerId"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtCustomerId" runat="server" TabIndex="0"></asp:TextBox>
                    </td>
                    <td class="auto-style15">
                        <asp:Label ID="lblName" runat="server" Text="Name" ></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtName" runat="server" TabIndex="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lblFatherName" runat="server" Text="Father Name"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="txtFatherName" runat="server" TabIndex="2"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:RadioButton ID="rbmale" runat="server" GroupName="Gender" Text="Male" TabIndex="3" />
                        <asp:RadioButton ID="rbfemale" runat="server" GroupName="Gender" Text="Female" TabIndex="4" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
                    </td>
                    <td class="auto-style25">
                        <asp:DropDownList ID="DropDownListDob" runat="server" TabIndex="5">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style27">
                        <asp:Label ID="lblphno" runat="server" Text="Phone Number"></asp:Label>
                    </td>
                    <td class="auto-style22">
                        <asp:TextBox ID="txtphno" runat="server" TabIndex="6"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label ID="lblParentPhno" runat="server" Text="Parent phone Number"></asp:Label>
                    </td>
                    <td class="auto-style25">
                        <asp:TextBox ID="txtParentPhno" runat="server" TabIndex="7" Width="169px"></asp:TextBox>
                    </td>
                    <td class="auto-style27">
                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style22">
                        <asp:TextBox ID="txtAddress" runat="server" TabIndex="8" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Label ID="lblPurpose" runat="server" Text="Purpose"></asp:Label>
                    </td>
                    <td class="auto-style26">
                        <asp:TextBox ID="txtPurpose" runat="server" TabIndex="9" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td class="auto-style28">
                        <asp:Label ID="lblAddressProof" runat="server" Text="Address Proof"></asp:Label>
                    </td>
                    <td class="auto-style24">
                        <asp:FileUpload ID="FileUploadAddressProof" runat="server"  TabIndex="10"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style20">
                        <asp:Label ID="lblStudentPhoto" runat="server" Text="Student photo"></asp:Label>
                    </td>
                    <td class="auto-style26">
                        <asp:FileUpload ID="FileUploadStudentPhoto" runat="server" TabIndex="11" />
                    </td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    
   
        <asp:Panel ID="PanelHostelInforamation" runat="server" Height="92px" GroupingText="Hoste Infromation">
            <table class="auto-style8">
                <tr>
                    <td>
                        <asp:Label ID="lblDateOfJoin" runat="server" Text="Date Of join"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDatefOfJoin" runat="server" TabIndex="12"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblRoomType" runat="server" Text="Room Type"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListRoomType" runat="server" TabIndex="13">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="lblRoomNo" runat="server" Text="Room No"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListRoomNo" runat="server" TabIndex="14">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="lblDateOfExpire" runat="server" Text="Date Of Expire"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDateOfExpire" runat="server" TabIndex="15"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblLaptop" runat="server" Text="Laptop"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:RadioButton ID="rbYes" runat="server" GroupName="Laptop" TabIndex="16" Text="yes" />
                        <asp:RadioButton ID="rbNo" runat="server" GroupName="Laptop" TabIndex="17" Text="No" />
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblFee" runat="server" Text="Fee"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txrFee" runat="server" TabIndex="18"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRoomStatus" runat="server" Text="Room Status"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListRoomStatus" runat="server" TabIndex="19">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br /></brZ>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" style="z-index: 1; left: 416px; top: 360px; position: absolute; height: 26px" />
    </form>
         </div>
</body>
</html>
