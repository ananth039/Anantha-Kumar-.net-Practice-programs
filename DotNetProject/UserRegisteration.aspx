<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="UserRegisteration.aspx.cs" Inherits="UserRegisteration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .auto-style1 {
            width: 48%;
        margin-right: 19px;
    }
        .auto-style9 {
            height: 24px;
            width: 67px;
        }
        .auto-style12 {
            height: 24px;
            width: 91px;
        }
        .auto-style14 {
            width: 67px;
        }
        .auto-style15 {
            height: 23px;
            width: 67px;
        }
        .auto-style18 {
        }
        .auto-style19 {
            height: 23px;
            width: 91px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">
        <table class="auto-style1">
          <caption>User Registration</caption>
            <tr>

                <td class="auto-style18">
                    <asp:Label ID="lblLoginId" runat="server" Text="Login Id"></asp:Label>
                </td>
                <td class="auto-style14">
                   <asp:TextBox ID="txtLoginId" runat="server" ReadOnly="true" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
          
                <td class="auto-style12">
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtName" runat="server" Width="186px"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" Display="Dynamic" ControlToValidate="txtName" ForeColor="Red" ErrorMessage="Please enter text name"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="lblphno" runat="server" Text="Phno"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtphno" runat="server" TextMode="Phone"  Width="186px" OnTextChanged="txtphno_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVPhno" Display="Dynamic" runat="server" ControlToValidate="txtphno" ErrorMessage="please enter Phone Number" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblerrormsg" runat="server" ForeColor="Red"></asp:Label>
                   </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtEmail" runat="server" Width="186px" OnTextChanged="txtEmail_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVEmail" Display="Dynamic" ControlToValidate="txtEmail" runat="server" ErrorMessage="Please enter Email Id" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblerrormsg2" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtUserName" runat="server" Width="186px" OnTextChanged="txtUserName_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage ="Please enter user name" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CvUserName" Display="Dynamic" ValidateEmptyText="true" runat="server" ControlToValidate="txtUserName" ErrorMessage="user name should have minimum 6 characters" ForeColor="Red" OnServerValidate="CvUserName_ServerValidate"></asp:CustomValidator>
                    <asp:Label ID="lblerrormsg3" runat="server" ForeColor="Red"></asp:Label>
                     </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="186px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVPassword"  Display="Dynamic" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Width="186px" style="margin-left: 0px"></asp:TextBox>
                    <asp:CompareValidator ID="cmpvConfirmpassword" Display="Dynamic" runat="server" ControlToValidate="txtPassword" ControlToCompare="txtConfirmPassword" ForeColor="Red" ErrorMessage="both passwords are should be match"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblSecurityQuestion" runat="server" Text="Security Question"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:DropDownList ID="DropDownListSecurityquestion" runat="server">
                        <asp:ListItem>select yourQuestion</asp:ListItem>
                        <asp:ListItem>What is your nick Name?</asp:ListItem>
                        <asp:ListItem>What is your father Name?</asp:ListItem>
                        <asp:ListItem>What is your pet Name?</asp:ListItem>
                        <asp:ListItem>Who is your childhood friend?</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txtAnswer" runat="server" Width="186px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RFVAnswer" Display="Dynamic" ControlToValidate="txtAnswer" runat="server" ErrorMessage="Please enter Answer" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
           
            <tr>
                <td class="auto-style18" colspan="2">
                    <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Height="30px" Width="76px" OnClick="btnSubmit_Click" /></td>

            </tr>
            <tr><td colspan="2"><asp:Label ID="Lblmsg" runat="server" Text=""></asp:Label></td></tr>
           
        </table>
          </div>
                
         <br />
         <br />

  


  
    
       

  
    
      
  
  


  
    
       

  
    
</asp:Content>


