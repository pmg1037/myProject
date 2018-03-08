<%@ Page Language="VB" AutoEventWireup="false" CodeFile="test.aspx.vb" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" >
                <EmptyDataTemplate>
                    <asp:Label ID="lblRoomNo" runat="server" Text='<%# Eval("RoomNo")%>'></asp:Label>
                </EmptyDataTemplate>
            
              <EmptyDataTemplate>
                 <asp:LinkButton ID="lnkRemove" runat="server" CommandArgument = '<%# Eval("RoomNo")%>' 
                     OnClientClick = "return confirm('Do you want to delete?')" 
                     Text = "Delete" OnClick = "DeleteCustomer"></asp:LinkButton>
                   </EmptyDataTemplate>

            </asp:GridView>

            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="217px">
            <asp:ListItem Value="M">Man</asp:ListItem>
            <asp:ListItem Value="F">Female</asp:ListItem>
            <asp:ListItem Value="T">TranGender</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
