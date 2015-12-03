<%@ Page Language="C#" AutoEventWireup="true"  Inherits="In_page_Technique_to_invoke_server_side_function.ex_11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
    <script language="c#" runat="server">
    public void fun(Object obj,EventArgs args)
        {
            Response.Write("This message is from server");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" value="Display" id="btnDisplay" runat="server" onserverclick="fun" />
    
    </div>
    </form>
</body>
</html>
