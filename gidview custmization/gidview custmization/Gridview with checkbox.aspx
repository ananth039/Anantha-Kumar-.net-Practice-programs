<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridview with checkbox.aspx.cs" Inherits="gidview_custmization.Gridview_with_checkbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Server=ANANTH\ANANTH;Database=Sql queries Practice;Integrated Security=True" SelectCommand="select * from employee" DeleteCommand="delete employee where eno=@eno">
            <DeleteParameters>
                <asp:Parameter Name="eno" />
            </DeleteParameters>
        </asp:SqlDataSource>
         <asp:GridView ID="GridView1" runat="server" DataSourceId="SqlDataSource1" AutoGenerateColumns="false" DataKeyNames="eno">
             <Columns>

                 <asp:TemplateField HeaderText="select">
                     <ItemTemplate>
                         <asp:CheckBox ID="Checkbox1" runat="server" />
                     </ItemTemplate>
                     
                 </asp:TemplateField>
                 <asp:BoundField HeaderText="Employee No" DataField="eno" />
                 <asp:BoundField HeaderText="employee Name" DataField="ename" />
                  <asp:BoundField HeaderText="Age" DataField="age" />
                 <asp:BoundField HeaderText="Address" DataField="address" />
                  <asp:BoundField HeaderText="Designation" DataField="desigation" />
                 
                 <asp:BoundField HeaderText="salary" DataField="salary" />
             </Columns>
             
        </asp:GridView>
    <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click"  Text="Delete" /><br/>
       <asp:CheckBox ID="checkall" Text="Select all" runat="server" AutoPostBack="true" OnCheckedChanged="checkall_CheckedChanged" />
        <br />
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
