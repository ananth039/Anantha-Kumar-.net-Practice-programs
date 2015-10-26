<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calendar demo.aspx.cs" Inherits="calendar.calendar_demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server" Caption="my Calendar" CaptionAlign="Top" CellPadding="2" CellSpacing="2" DayNameFormat="Full" DayStyle-BorderColor="window" FirstDayOfWeek="Sunday" NextMonthText=">" NextPrevFormat="ShortMonth" OtherMonthDayStyle-BackColor="Yellow"  selectedDates="25" SelectedDayStyle-BorderColor="WindowFrame" SelectionMode="DayWeek" SelectorStyle-BackColor="blue" ShowGridLines="true" ShowTitle="true" TitleFormat="Month" TodayDayStyle-BackColor="Red" VisibleDate=""> </asp:Calendar>
    
    </div>
    </form>
</body>
</html>
