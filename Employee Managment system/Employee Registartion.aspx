﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Employee Registartion.aspx.cs" Inherits="Employee_Registartion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 43px;
        }
        .ERRORMESSAGE
        {
            color:red;
        }
        
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
            <td>
                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"  placeholder="User Name" Width="239px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RFVuseranme" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please enter user name" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtUserName" ErrorMessage="should be User name contains alphabets and numbers" CssClass="ERRORMESSAGE" ValidationExpression="^[a-z]+[0-9]*$"></asp:RegularExpressionValidator>
                <asp:Label ID="lblusernameExisterror" runat="server" CssClass="ERRORMESSAGE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
             <td>
                <asp:TextBox ID="txtPassword" runat="server"  placeholder="Password" Width="239px" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RFVpassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="please enter your password" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="ERRORMESSAGE" ControlToValidate="txtPassword" runat="server"  ErrorMessage="password should be contain one Captial letter,one small letter,one number,one special symbol and password length between 8 to 20" ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,20}$"></asp:RegularExpressionValidator>
            </td>
            
        </tr>
         <tr>
            <td class="auto-style2">
                <asp:Label ID="lblconformPassword" runat="server" Text="Conform Password"></asp:Label>
            </td>
             <td class="auto-style2">
                <asp:TextBox ID="txtConformPassword" runat="server" placeholder="Conform Password" Width="239px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RFVconformPassword" runat="server" ControlToValidate="txtConformPassword" ErrorMessage="please Re enter your Password" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CVpassword" runat="server" ControlToValidate="txtConformPassword" ControlToCompare="txtPassword" ErrorMessage="password and conform password should be same" CssClass="ERRORMESSAGE"></asp:CompareValidator>
               </td>
            
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question"></asp:Label>
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="DdlSecurityQuestion" runat="server"  Height="16px" Width="245px">
                <asp:ListItem Value=""></asp:ListItem>
                     <asp:ListItem Value="What was your childhood nickname?"></asp:ListItem>
                     <asp:ListItem Value="What is your favorite movie?"></asp:ListItem>
                     <asp:ListItem Value="what is your father name"></asp:ListItem>
                     <asp:ListItem Value="what is your favourite book"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RFVSecurityQuestion" runat="server" ControlToValidate="DdlSecurityQuestion" ErrorMessage="please select any one of the security question" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblanswer" runat="server" Text="Answer"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtSecurityQuestionanswer" placeholder="Answer" runat="server" Width="239px"></asp:TextBox>
            </td>
            <td class="auto-style1">
                <asp:RequiredFieldValidator ID="RFVsecurityquestionanswer" runat="server" ControlToValidate="txtSecurityQuestionanswer" ErrorMessage="Please Enter your Answer" CssClass="ERRORMESSAGE"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <asp:Button ID="btnRegister" runat="server" Text="Register" Width="101px" OnClick="btnRegister_Click" />
                 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button ID="btnReset" runat="server" Text="Reset" Width="90px" OnClick="btnReset_Click" />
            </td>
            <td class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" colspan="3">
                <asp:ValidationSummary   Enabled="false" ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
    </table>
       </div>
</asp:Content>

