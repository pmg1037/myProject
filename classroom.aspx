﻿<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="classroom.aspx.vb" Inherits="classroom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">ค้นหาห้องว่าง</td>
        </tr>
        <tr>
            <td class="auto-style1">วันที่ใช้</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>

                      <INPUT type="button" value="..." onclick="OnClick()">&nbsp;&nbsp;

                   
                    <br>
<div id="divCalendar" style="DISPLAY: none; POSITION: absolute">
  <asp:Calendar id="Calendar1" runat="server" BorderWidth="2px"
                BackColor="White" Width="200px"
    ForeColor="Black" Height="180px" Font-Size="8pt"
                      Font-Names="Verdana" BorderColor="#999999"
    BorderStyle="Outset" DayNameFormat="FirstLetter" CellPadding="4">
    <TodayDayStyle ForeColor="Black" BackColor="#CCCCCC">
      </TodayDayStyle>
    <SelectorStyle BackColor="#CCCCCC"></SelectorStyle>
    <NextPrevStyle VerticalAlign="Bottom"></NextPrevStyle>
    <DayHeaderStyle Font-Size="7pt" Font-Bold="True"
                    BackColor="#CCCCCC"></DayHeaderStyle>
    <SelectedDayStyle Font-Bold="True" ForeColor="White"
                      BackColor="#666666"></SelectedDayStyle>
    <TitleStyle Font-Bold="True" BorderColor="Black"
                BackColor="#999999"></TitleStyle>
    <WeekendDayStyle BackColor="#FFFFCC"></WeekendDayStyle>
    <OtherMonthDayStyle ForeColor="#808080"></OtherMonthDayStyle>
  </asp:Calendar>
</div>
                    <script>
                        function OnClick() {
                            if (divCalendar.style.display == "none")
                                divCalendar.style.display = "";
                            else
                                divCalendar.style.display = "none";
                        }

</script></td>
            <td class="auto-style1">เวลาที่ใช้</td>
            <td class="auto-style7"><asp:DropDownList id="ddlTimeUse" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
			        </asp:DropDownList></td>
        </tr>
    </table>
</asp:Content>

