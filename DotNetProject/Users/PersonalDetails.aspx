<%@ Page Title="" Language="C#" MasterPageFile="~/Users/UserHomepage.master" AutoEventWireup="true" CodeFile="PersonalDetails.aspx.cs" Inherits="Users_PersonalDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <br />
    <br />
    <br />
    <br /><br />
    <br /><br />
    <br />
    <div align="right"><asp:LinkButton ID="LinkButtonEditpersonalDetails" runat="server" OnClick="LinkButtonEditpersonalDetails_Click">Edit</asp:LinkButton></div> 
    <div align="center" >
      
     <asp:FormView ID="FormView1" runat="server" >
         
        <ItemTemplate>
            <table>
                <tr>
                    <td> <asp:Label ID="lblName" runat="server" Text="Name :" /></td><td> <asp:Label ID="LbldisplayName" runat="server" Text='<%#Eval("Name") %>' /></td>
                </tr>
                 <tr>
                    <td> <asp:Label ID="LblGender" runat="server" Text="Gender :" /></td><td><asp:Label ID="lblDisplayGender" runat="server" Text='<%#Eval("Gender") %>' /></td>

                </tr>
                  <tr>
                    <td> <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth :" /></td><td><asp:Label ID="lblDisplayDOB" runat="server" Text='<%#Eval("DateOfBirth") %>' /></td>

                </tr>
                 <tr>
                    <td> <asp:Label ID="lblAddress" runat="server" Text="Address:" /></td><td><asp:Label ID="lbldisplayAddress" runat="server" Text='<%#Eval("Address") %>' /></td>

                </tr>
                 <tr>
                    <td> <asp:Label ID="lblZipcode" runat="server" Text="Zip code:" /></td><td><asp:Label ID="lbldisplayZipcode" runat="server" Text='<%#Eval("zipCode") %>' /></td>

                </tr>

                <tr>
                    <td> <asp:Label ID="lblPhno" runat="server" Text="Phone No :" /></td><td><asp:Label ID="LbldisplayPhno" runat="server" Text='<%#Eval("Phno") %>' /></td>
                </tr>
                 <tr>
                    <td> <asp:Label ID="lblEmail" runat="server" Text="Email :" /></td><td><asp:Label ID="lbldisplayEmail" runat="server" Text='<%#Eval("email") %>' /></td>

                </tr>
                <tr>
                    <td> <asp:Label ID="lblUserName" runat="server" Text="UserName :" /></td><td><asp:Label ID="lbldisplayUserName" runat="server" Text='<%#Eval("Username") %>' /></td>

                </tr>
                
               
                 
                
            </table>

        </ItemTemplate>

    </asp:FormView>
     
 
            </div>
  

    

    

    

</asp:Content>

