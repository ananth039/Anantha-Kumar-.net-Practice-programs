<%@ Page Language="C#" AutoEventWireup="true"  Inherits="client_side_function_in_htm.html_anchor_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script language="C#" runat="server">
        public void page_Load(Object obj,EventArgs args)
        {
            anchorgoogle.HRef = "http://www.google.com";
            anchoryahoo.HRef = "http://www.yahoo.com";
            anchormicrosoft.HRef = "http://www.microsoft.com";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a id="anchorgoogle" runat="server">Visit Google</a><br />
        <a id="anchoryahoo" runat="server">Visit yahoo</a><br />
        <a id="anchormicrosoft" runat="server">Visit Microsoft</a><br />
    
    </div>
    </form>
</body>
</html>
