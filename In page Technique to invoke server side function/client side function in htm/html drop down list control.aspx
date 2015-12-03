<%@ Page Language="C#" AutoEventWireup="true"  Inherits="client_side_function_in_htm.html_drop_down_list_control" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script runat="server" language="C#">

    public void DisplayImage(object sender, EventArgs e)
    {
        myimage.Src = ddlimage.Value;
    }
</script>
</head>
<body>
    <form id="form1">
    <div>
        Select Your choice<select id="ddlimage" runat="server">
            <option value="12270446_842770725844605_2244402_n.jpg"></option>
            <option value="12282802_842642852524059_691168745_n.jpg"></option>
            
          </select><br />
        <input type="button" value="Display image" runat="server" onserverclick="DisplayImage" />
        <br />
       
      <img alt=" no image" id="myimage" runat="server" src="" />
    </div>
        
    </form>
</body>
</html>
