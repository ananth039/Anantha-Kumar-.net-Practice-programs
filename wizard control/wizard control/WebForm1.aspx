<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="wizard_control.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="EmailWizard" runat="server" ActiveStepIndex="4" OnFinishButtonClick="EmailWizard_FinishButtonClick">
            <WizardSteps>
                <asp:WizardStep runat="server" title="UserInfo" StepType="Start">

                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
                     <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />

                     <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label><asp:RadioButton ID="rbMale" runat="server" GroupName="gender"  Text="Male" /><asp:RadioButton ID="rnfemal" runat="server"  Text="Female" GroupName="gender"/><br />
                 <asp:Label ID="lblState" runat="server" Text="State" />
                     <asp:DropDownList ID="dropState" runat="server">
                         <asp:ListItem>
                             Andhra Pradesh
                         </asp:ListItem>
                         <asp:ListItem>
                             Telengana
                         </asp:ListItem>
                     </asp:DropDownList><br />
                    <asp:Label ID="lblPincode" runat="server" Text="Pin code"></asp:Label><asp:TextBox ID="txtpincode" runat="server"></asp:TextBox><br />
                    <asp:Label ID="lblAlternativeEmail" runat="server" Text="Alternative Email"></asp:Label><asp:TextBox ID="txtAlternativeEmail" runat="server"></asp:TextBox><br />

                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Email Details">
                     <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
                     <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
                     <asp:Label ID="lblReenterPassword" runat="server" Text="Re Enterpassword"></asp:Label><asp:TextBox ID="txtReeneterPassword" runat="server"></asp:TextBox><br />
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Forgot Password">

 <asp:Label ID="lblHintanswerquestion" runat="server" Text="Hint:Answer Question"></asp:Label><asp:DropDownList ID="ddlisthintquestion" runat="server">
                         <asp:ListItem>
                             what is your Nick Name?
                         </asp:ListItem>
                         <asp:ListItem>
                             What is your favourite Hero?
                         </asp:ListItem>
                     </asp:DropDownList><br />
                     <asp:Label ID="lblAnswer" runat="server" Text="Answer"></asp:Label><asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox><br />
                   
               
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="hobbies">

                 <asp:Label ID="Hobbies" runat="server" Text="Hint:Answer Question" />
                     <asp:CheckBoxList ID="chblHobbies" runat="server">
                         <asp:ListItem>Reading</asp:ListItem>
                            <asp:ListItem>Browsing</asp:ListItem>
                            <asp:ListItem>Gardening</asp:ListItem>
                     </asp:CheckBoxList>
               
                </asp:WizardStep>
                
                <asp:WizardStep runat="server" title="Terms And conditions" StepType="Finish">
                  <asp:TextBox ID="txtTerms" runat="server" TextMode="MultiLine" Text="Terms and Conditions" Font-Bold="true" ForeColor="Blue" Font-Size="X-Large" ></asp:TextBox><br />
                     <asp:Label ID="lblmsg" runat="server" />
                         </asp:WizardStep>
                 

            </WizardSteps> 
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
