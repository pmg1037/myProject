<%@ Page Language="VB" AutoEventWireup="false" CodeFile="testCalendar.aspx.vb" Inherits="testCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <div>

            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" 
                TargetControlID="TextBox1"
                Format="MMMM d, yyyy"
                runat="server" />

        </div>

    </form>
</body>
</html>
