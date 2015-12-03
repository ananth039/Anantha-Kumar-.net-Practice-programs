
<html>
<head>
    <title>In page technique in server side function</title>

    <script language="c#" runat="server">
    public void fun(Object obj,EventArgs args)
        {
            Response.Write("This message is from server");
        }
    </script>
</head>
<body>
    <form id="form1" >
    <div>
    <input type="button" value="Display" id="btnDisplay" runat="server" onserverclick="fun" />
    </div>
    </form>
</body>
</html>
