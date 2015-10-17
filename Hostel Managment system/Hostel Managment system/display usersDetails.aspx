<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display usersDetails.aspx.cs" Inherits="Hostel_Managment_system.display_usersDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="userDetails">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="cpwd" HeaderText="cpwd" SortExpression="cpwd" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="userDetails" runat="server" ConnectionString="<%$ ConnectionStrings:Anantha KumarConnectionString %>" SelectCommand="SELECT * FROM [UsersRegistration]"></asp:SqlDataSource>
    </form>
</body>
</html>
