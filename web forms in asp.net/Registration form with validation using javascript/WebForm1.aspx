<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registration_form_with_validation_using_javascript.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration form using javascript(regular expressions)</title>
    <script type="text/javascript">
        function check()
        {
            var name,pwd,cpwd,uname,email;
            var emailRegx = /^[A-Za-z0-9._]*\@[A-Za-z]*\.[A-Za-z]{2,5}$/; 
            name = document.getElementById("txtName").value;
            uname = document.getElementById("txtUserName").value;
            pwd = document.getElementById("txt").value;
            cpwd = document.getElementById("txt").value;
            email = document.getElementById("txt").value;
            var symbol = /[@#$]/;
            var lower = /[a-z]/;
            var upper = /[A-Z]/;
            var number = /[0-9]/;
        
            if(nam)
            {
                alert("please enter your name");
              
            }

        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div align:'center'>
        <asp:Label ID="lblRegistrationform" runat="server" Text="Registartin Form"></asp:Label>
    </div>
        <div>
            <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="User Name"></asp:Label>
                   <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </div>
        <div>
                  <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                   <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            
        </div>
         <div>
                  <asp:Label ID="lblConformPassword" runat="server" Text="Conform Password"></asp:Label>
                   <asp:TextBox ID="txtConformPassword" runat="server"></asp:TextBox>
            
        </div>
        <div>
                  <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            
        </div>
         <div>
             <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/> 
            
        </div>
        
        <asp:Label ID="lblstatus" runat="server" Text="Status"></asp:Label>
        
    </form>
</body>
</html>
