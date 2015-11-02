<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Empdetails.aspx.cs" Inherits="Empdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
            <asp:BoundField DataField="DateOfBirth" HeaderText="DateOfBirth" SortExpression="DateOfBirth" />
            <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="MobilNo" HeaderText="MobilNo" SortExpression="MobilNo" />
            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="ConformPasword" HeaderText="ConformPasword" SortExpression="ConformPasword" />
            <asp:BoundField DataField="SecuityQuestion" HeaderText="SecuityQuestion" SortExpression="SecuityQuestion" />
            <asp:BoundField DataField="Answer" HeaderText="Answer" SortExpression="Answer" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString2 %>" DeleteCommand="DELETE FROM [EmpRegistration] WHERE [ID] = @ID" InsertCommand="INSERT INTO [EmpRegistration] ([FullName], [Gender], [DateOfBirth], [Designation], [Email], [MobilNo], [Address], [Username], [Password], [ConformPasword], [SecuityQuestion], [Answer]) VALUES (@FullName, @Gender, @DateOfBirth, @Designation, @Email, @MobilNo, @Address, @Username, @Password, @ConformPasword, @SecuityQuestion, @Answer)" SelectCommand="SELECT * FROM [EmpRegistration]" UpdateCommand="UPDATE [EmpRegistration] SET [FullName] = @FullName, [Gender] = @Gender, [DateOfBirth] = @DateOfBirth, [Designation] = @Designation, [Email] = @Email, [MobilNo] = @MobilNo, [Address] = @Address, [Username] = @Username, [Password] = @Password, [ConformPasword] = @ConformPasword, [SecuityQuestion] = @SecuityQuestion, [Answer] = @Answer WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="FullName" Type="String" />
            <asp:Parameter Name="Gender" Type="String" />
            <asp:Parameter Name="DateOfBirth" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="MobilNo" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Password" Type="String" />
            <asp:Parameter Name="ConformPasword" Type="String" />
            <asp:Parameter Name="SecuityQuestion" Type="String" />
            <asp:Parameter Name="Answer" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="FullName" Type="String" />
            <asp:Parameter Name="Gender" Type="String" />
            <asp:Parameter Name="DateOfBirth" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="MobilNo" Type="String" />
            <asp:Parameter Name="Address" Type="String" />
            <asp:Parameter Name="Username" Type="String" />
            <asp:Parameter Name="Password" Type="String" />
            <asp:Parameter Name="ConformPasword" Type="String" />
            <asp:Parameter Name="SecuityQuestion" Type="String" />
            <asp:Parameter Name="Answer" Type="String" />
            <asp:Parameter Name="ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

   

</asp:Content>

