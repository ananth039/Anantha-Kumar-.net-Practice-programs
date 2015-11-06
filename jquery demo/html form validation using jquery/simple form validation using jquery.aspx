<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="simple form validation using jquery.aspx.cs" Inherits="html_form_validation_using_jquery.simple_form_validation_using_jquery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>asp.net form with validation using jquery</title>
    <script src="jquery-2.1.4.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function()
        {
            $("#btnsubmit").click(function ()
            {
                
                if ($("#<%=txtName.ClientID%>").val() =="" && $("#<%=txtPhno.ClientID%>").val() =="")
                {
                    $("#<%=lblnameerror.ClientID%>").text("please enter name");
                    $("#<%=lblphnoerror.ClientID%>").text("please enter phone number");
                    return false;
                }
                else
                {
                    $("#<%=lblstatus.ClientID %>").text("your details  are  submited sucessfully");
                    $("#<%=lblnameerror.ClientID%>").text("");
                    $("#<%=lblphnoerror.ClientID%>").text("");
                    $("#<%=txtName.ClientID%>").val(" ");
                    $("#<%=txtPhno.ClientID%>").val(" ");
                 
                    return false;
                }
                return false;
            })
            })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <table>
        <caption><asp:Label ID="lblLogin" runat="server" Text="Login" Font-Size="Larger" ></asp:Label></caption>
        <tr><td></td><td></td><td></td></tr>
      
             <tr> <td><asp:Label ID="lblName" runat="server" Text="Name"> </asp:Label></td><td> <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td><td> <asp:Label ID="lblnameerror" runat="server" ForeColor="Red" ></asp:Label></td> </tr>
              <tr><td> <asp:Label ID="Lblphno" runat="server" Text="phno" ></asp:Label></td><td>   <asp:TextBox ID="txtPhno" runat="server"></asp:TextBox></td><td> <asp:Label ID="lblphnoerror" runat="server" ForeColor="Red"></asp:Label></td> </tr>
         <tr><td></td><td></td><td></td></tr>     
        <tr> <td colspan="2"><asp:Button ID="btnsubmit" runat="server" Text="Submit"/></td> </tr>
         <tr><td></td><td></td><td></td></tr>  

          
      
        <tr><td colspan="2"> <asp:Label ID="lblstatus" runat="server" ForeColor="Green"></asp:Label></td></tr>
        
    </table> 
    </div>
        
    </form>
</body>
</html>
