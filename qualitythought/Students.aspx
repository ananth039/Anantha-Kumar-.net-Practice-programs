<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="Students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center"><div>
        <asp:Label ID="LblStudentsdetails" runat="server" Text="student Details" CssClass="sideheading"></asp:Label><br /></div>
   <div> 
       <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataSourceID="QualityThought">
           <AlternatingRowStyle BackColor="White" />
           <Columns>
               <asp:BoundField DataField="Dateofjoin" HeaderText="Dateofjoin" SortExpression="Dateofjoin" />
               <asp:BoundField DataField="BatchNO" HeaderText="BatchNO" SortExpression="BatchNO" />
               <asp:BoundField DataField="IdNo" HeaderText="IdNo" SortExpression="IdNo" />
               <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
               <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
               <asp:BoundField DataField="ParentName" HeaderText="ParentName" SortExpression="ParentName" />
               <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
               <asp:BoundField DataField="DateOfbirth" HeaderText="DateOfbirth" SortExpression="DateOfbirth" />
               <asp:BoundField DataField="PhoneNo" HeaderText="PhoneNo" SortExpression="PhoneNo" />
               <asp:BoundField DataField="Qualification" HeaderText="Qualification" SortExpression="Qualification" />
               <asp:BoundField DataField="EmailId" HeaderText="EmailId" SortExpression="EmailId" />
               <asp:BoundField DataField="ParentPhNo" HeaderText="ParentPhNo" SortExpression="ParentPhNo" />
               <asp:BoundField DataField="permanentdrno" HeaderText="permanentdrno" SortExpression="permanentdrno" />
               <asp:BoundField DataField="permanentStreet" HeaderText="permanentStreet" SortExpression="permanentStreet" />
               <asp:BoundField DataField="permanentcityVillage" HeaderText="permanentcityVillage" SortExpression="permanentcityVillage" />
               <asp:BoundField DataField="permanentDistrict" HeaderText="permanentDistrict" SortExpression="permanentDistrict" />
               <asp:BoundField DataField="permanentState" HeaderText="permanentState" SortExpression="permanentState" />
               <asp:BoundField DataField="permanentZipcode" HeaderText="permanentZipcode" SortExpression="permanentZipcode" />
               <asp:BoundField DataField="Presentdrno" HeaderText="Presentdrno" SortExpression="Presentdrno" />
               <asp:BoundField DataField="PresentStreet" HeaderText="PresentStreet" SortExpression="PresentStreet" />
               <asp:BoundField DataField="Presentcityvillage" HeaderText="Presentcityvillage" SortExpression="Presentcityvillage" />
               <asp:BoundField DataField="PresentDistrict" HeaderText="PresentDistrict" SortExpression="PresentDistrict" />
               <asp:BoundField DataField="PresentsState" HeaderText="PresentsState" SortExpression="PresentsState" />
               <asp:BoundField DataField="PresentZipcode" HeaderText="PresentZipcode" SortExpression="PresentZipcode" />
               <asp:BoundField DataField="Courses" HeaderText="Courses" SortExpression="Courses" />
               <asp:BoundField DataField="typeofbatch" HeaderText="typeofbatch" SortExpression="typeofbatch" />
           </Columns>
           <EditRowStyle BackColor="#7C6F57" />
           <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
           <RowStyle BackColor="#E3EAEB" />
           <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
           <SortedAscendingCellStyle BackColor="#F8FAFA" />
           <SortedAscendingHeaderStyle BackColor="#246B61" />
           <SortedDescendingCellStyle BackColor="#D4DFE1" />
           <SortedDescendingHeaderStyle BackColor="#15524A" />
       </asp:GridView>
        <asp:SqlDataSource ID="QualityThought" runat="server" ConnectionString="<%$ ConnectionStrings:QualityThoughtConnectionString %>" SelectCommand="SELECT * FROM [StudentsRegistration]"></asp:SqlDataSource>
        </div>
    </asp:GridView>
    </div>
</asp:Content>

