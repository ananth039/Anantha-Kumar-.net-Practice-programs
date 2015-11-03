<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Employee_Registartion.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
           
            <asp:Label ID="lblcalculator" runat="server" style=" background-color:darkgreen;color:white;font-size:large">Calculator</asp:Label>
        </div>
    <div>
        <asp:TextBox ID="txtStatus" runat="server" ReadOnly="True" Width="275px" style="background-color:silver;color:white" ></asp:TextBox>
     </div>
        <div>
            <asp:TextBox ID="TxtResult" runat="server" ReadOnly="True" Width="276px">0</asp:TextBox>
        </div>
        <div >
            <asp:Button ID="btn1" runat="server" OnClick="UserInput" Text="1" Width="54px" style="background-color:orange" />
            <asp:Button ID="btn2" runat="server" OnClick="UserInput" Text="2" Width="54px" style="background-color:orange"/>
            <asp:Button ID="btn3" runat="server" OnClick="UserInput" Text="3" Width="54px" style="background-color:orange"/>
            <asp:Button ID="btnClearEntry" runat="server" Text="CE" Width="54px" OnClick="ClearResult" style="background-color:indianred"/>
            <asp:Button ID="btnClear" runat="server" Text="C" Width="54px" OnClick="ClearResult" style="background-color:indianred"/>
        </div>
        <div>
            <asp:Button ID="btn4" runat="server" OnClick="UserInput" Text="4" Width="54px" style="background-color:orange" />
            <asp:Button ID="btn5" runat="server" OnClick="UserInput" Text="5" Width="54px" style="background-color:orange"/>
            <asp:Button ID="btn6" runat="server" OnClick="UserInput" Text="6" Width="54px" style="background-color:orange"/>
            <asp:Button ID="btndivide" runat="server" OnClick="Divide" Text="/" Width="54px" style="background-color:lightpink"/>
            <asp:Button ID="btnSubtract" runat="server" Text="-" Width="54px" OnClick="Subtarct" style="background-color:lightpink" />
     </div>
        <div>
            <asp:Button ID="btn7" runat="server" OnClick="UserInput" Text="7" Width="54px" style="background-color:orange" />
            <asp:Button ID="btn8" runat="server" OnClick="UserInput" Text="8" Width="54px" style="background-color:orange"/>
            <asp:Button ID="btn9" runat="server" OnClick="UserInput" Text="9" Width="54px" style="background-color:orange"/>
            <asp:Button ID="btnMultiply" runat="server" Text="*" Width="54px" OnClick="Multiply" style="background-color:lightpink"/>
            <asp:Button ID="btnAddition" runat="server" Height="25px" Text="+" Width="54px" OnClick="Addition" style="background-color:lightpink" />
        </div>
        <div>
            <asp:Button ID="btn0" runat="server" OnClick="UserInput" Text="0" Width="110px" style="background-color:orange"/>
            <asp:Button ID="btnPercentage" runat="server" Text="%" Width="54px" OnClick="Percentage" style="background-color:lightpink"/>
            <asp:Button ID="btnEqualto" runat="server" Text="=" Width="106px" OnClick="btnEqualto_Click" style="background-color:lightblue"/>
        </div>

</asp:Content>
