<%@ Page Language="C#" AutoEventWireup="true"  Inherits="client_side_function_in_htm.html_image_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Html image contol in server side function</title>
    <script language="C#" runat="server">
    public void page_Load(Object obj,EventArgs args)
        {
       image1.Src=@"images\12282802_842642852524059_691168745_n.jpg";
      
        
        }
    </script>
</head>
<body>
    <form id="form1">
    <div>
        <img  runat="server" id="image1"/>
    </div>
    </form>
</body>
</html>
