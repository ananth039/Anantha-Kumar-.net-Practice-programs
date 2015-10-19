<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="gridview_delete.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="StudentId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="StudentId" HeaderText="StudentId" ReadOnly="True" SortExpression="StudentId" />
                <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />
                <asp:BoundField DataField="phoneNumber" HeaderText="phoneNumber" SortExpression="phoneNumber" />
                <asp:BoundField DataField="DateOfJoin" HeaderText="DateOfJoin" SortExpression="DateOfJoin" />
                <asp:BoundField DataField="DateOfExpire" HeaderText="DateOfExpire" SortExpression="DateOfExpire" />
                <asp:BoundField DataField="RoomType" HeaderText="RoomType" SortExpression="RoomType" />
                <asp:BoundField DataField="RoomNo" HeaderText="RoomNo" SortExpression="RoomNo" />
                <asp:BoundField DataField="laptop" HeaderText="laptop" SortExpression="laptop" />
                <asp:BoundField DataField="Fee" HeaderText="Fee" SortExpression="Fee" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Anantha KumarConnectionString %>" DeleteCommand="DELETE FROM [HostelStudnetInformation] WHERE [StudentId] = @StudentId" InsertCommand="INSERT INTO [HostelStudnetInformation] ([StudentId], [StudentName], [phoneNumber], [DateOfJoin], [DateOfExpire], [RoomType], [RoomNo], [laptop], [Fee]) VALUES (@StudentId, @StudentName, @phoneNumber, @DateOfJoin, @DateOfExpire, @RoomType, @RoomNo, @laptop, @Fee)" SelectCommand="SELECT * FROM [HostelStudnetInformation]" UpdateCommand="UPDATE [HostelStudnetInformation] SET [StudentName] = @StudentName, [phoneNumber] = @phoneNumber, [DateOfJoin] = @DateOfJoin, [DateOfExpire] = @DateOfExpire, [RoomType] = @RoomType, [RoomNo] = @RoomNo, [laptop] = @laptop, [Fee] = @Fee WHERE [StudentId] = @StudentId">
            <DeleteParameters>
                <asp:Parameter Name="StudentId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="StudentId" Type="Int32" />
                <asp:Parameter Name="StudentName" Type="String" />
                <asp:Parameter Name="phoneNumber" Type="Int64" />
                <asp:Parameter Name="DateOfJoin" Type="String" />
                <asp:Parameter Name="DateOfExpire" Type="String" />
                <asp:Parameter Name="RoomType" Type="String" />
                <asp:Parameter Name="RoomNo" Type="String" />
                <asp:Parameter Name="laptop" Type="String" />
                <asp:Parameter Name="Fee" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="StudentName" Type="String" />
                <asp:Parameter Name="phoneNumber" Type="Int64" />
                <asp:Parameter Name="DateOfJoin" Type="String" />
                <asp:Parameter Name="DateOfExpire" Type="String" />
                <asp:Parameter Name="RoomType" Type="String" />
                <asp:Parameter Name="RoomNo" Type="String" />
                <asp:Parameter Name="laptop" Type="String" />
                <asp:Parameter Name="Fee" Type="Int32" />
                <asp:Parameter Name="StudentId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
