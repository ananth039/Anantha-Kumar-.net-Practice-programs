<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="html_form_validation_using_jquery.WebForm1" %>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.net How to use Jquery</title>
    <script src="jquery-2.1.4.min.js"></script>
    <!-- You need to include Jquery library -->
    <script src="jquery-1.8.2.js" type="text/javascript"></script>
    <script type="text/javascript">
        //This will run once the page is loaded on client
        $(document).ready(function () {
            alert('Page has been loaded');

            BindButtonClickEvent();
        });

        function BindButtonClickEvent() {
            $("#<%= btnSubmit.ClientID %>").click(function () {
                //Inorder to access server control you need to use # with the control id
                var content = $("#<%= pnlContent1.ClientID %>").html();

                //Swap the panel 1 content to panel 2
                $("#<%= pnlContent2.ClientID %>").html(content);

                return false;
            });
        }
    </script>
    <style type="text/css">
        #divContent div
        {
            margin:10px; 
            padding:10px;
            border:solid 1px green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <div id="divContent">
                <h3>How to Use Jquery with Server Control</h3>
                <asp:Panel ID="pnlContent1" runat="server">
                    This is content for the panel 1 <br /> When you will click the button <br /> 
                    it will be show in Panel 2.
                </asp:Panel>

                <asp:Panel ID="pnlContent2" runat="server">
                    Panel 2 content ...
                </asp:Panel>
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="Click to swap content via Jquery" 
                OnClientClick="return false;" />               
        </fieldset>
    </div>
    </form>
</body>
</html>
