<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="EditDetails.aspx.cs" Inherits="Employee_Registartion.EditDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style3 {
            height: 43px;
        }
        .ERRORMESSAGE
        {
            color:red;
        }
        
        .auto-style4 {
            height: 42px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center"> <table class="auto-style1" >
        <caption>Employee Registration</caption>
        <tr>
            <td>
                <asp:Label ID="lblFullName" runat="server" Text="Full Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFullName" placeholder="Full Name" runat="server" Width="239px"></asp:TextBox>
            </td>
            <td>
                 <asp:RequiredFieldValidator ID="rfvName" runat="server"  ErrorMessage="please enter full Name" ControlToValidate="txtFullName" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RfvUsername" runat="server" ControlToValidate="txtFullName" ErrorMessage="please enter alphabets only" ValidationExpression="^[a-zA-Z]+$" CssClass="ERRORMESSAGE"></asp:RegularExpressionValidator>
             
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            </td>
            <td>
                <asp:RadioButton ID="rbmale" runat="server" Text="Male"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbFemale" runat="server"  Text="Female"/>
            </td>
            <td>
                <asp:Label ID="lblgenderError" runat="server"  CssClass="ERRORMESSAGE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDateofBirth" runat="server" Text="Date Of Birth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateOfBirth" runat="server" TextMode="Date" Width="239px"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="rfvdob" runat="server" ErrorMessage="please enter date of Birth" ControlToValidate="txtDateOfBirth" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator></td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDesignation" runat="server" Text="Designation"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DdlDesignation" runat="server" Height="16px"  Width="245px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Team leader</asp:ListItem>
                    <asp:ListItem>Quality Testing Officer</asp:ListItem>
                    <asp:ListItem>Software Testing Officer</asp:ListItem>
                    <asp:ListItem>Programmer Analysist</asp:ListItem>
                    <asp:ListItem>Junior developer</asp:ListItem>
                    <asp:ListItem>Software Developer</asp:ListItem>
                    <asp:ListItem>Software Engineer</asp:ListItem>
                    <asp:ListItem>Senior Software Engineer</asp:ListItem>
                    <asp:ListItem>Human Resource manager</asp:ListItem>
                    <asp:ListItem>Project Manager</asp:ListItem>
                    <asp:ListItem>Chief Excutive Officer</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RFVDesignation" runat="server" ControlToValidate="DdlDesignation" ErrorMessage="please select Designation" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"   placeholder="Email" Width="239px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="please enter Email id" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVEmail"  ControlToValidate="txtEmail" runat="server" ValidationExpression="^[a-zA-z0-9]+@+[a-zA-Z]+.+[com]$" ErrorMessage="please enter valid email id" CssClass="ERRORMESSAGE"></asp:RegularExpressionValidator>
                <asp:Label ID="lblEmailExisterror" runat="server" CssClass="ERRORMESSAGE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPhno" runat="server" Text="Mobile No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtphno" runat="server"  placeholder="Phone Number" Width="239px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RFVPhno" ControlToValidate="txtphno" runat="server" ErrorMessage="please enter phone number" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVPhno" runat="server" ControlToValidate="txtphno" CssClass="ERRORMESSAGE" ErrorMessage="phone Number contains only digits and length is 10 digits" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>
                <asp:Label ID="lblMobileexistError" runat="server" CssClass="ERRORMESSAGE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" placeholder="Address" TextMode="MultiLine" Width="239px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RFVAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="please enter Address" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtUserName" runat="server"  placeholder="User Name" Width="239px"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RFVuseranme" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please enter user name" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtUserName" ErrorMessage="should be User name contains alphabets and numbers" CssClass="ERRORMESSAGE" ValidationExpression="^[a-z]+[0-9]*$"></asp:RegularExpressionValidator>
                <asp:Label ID="lblusernameExisterror" runat="server" CssClass="ERRORMESSAGE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="101px" OnClick="btnUpdate_Click"  />
                 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="90px" OnClick="btnCancel_Click"  />
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="3">
                <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
       </div>


</asp:Content>
