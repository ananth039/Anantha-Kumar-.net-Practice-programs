<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Employee_Registartion.Home1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <br />
    <asp:GridView ID="GridView1" runat="server" AlternatingRowStyle-HorizontalAlign="Left" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="Employeedetails" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
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
<asp:SqlDataSource ID="Employeedetails" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeConnectionString %>" SelectCommand="SELECT * FROM [EmpRegistration]"></asp:SqlDataSource>
    <div align="center"> <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="30px" Width="68px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server"  Text="Delete" OnClick="btnDelete_Click" Height="32px" Width="74px" />
        </div>
    </asp:Content>
