<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table id="MyTable" runat="server" cellspacing="0" cellpadding="5" border="0">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    <asp:Label ID="Label1" runat="server" Text="ชื่อผู้ใช้"></asp:Label>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:Label ID="Label2" runat="server" Text="รหัสผ่าน"></asp:Label>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="UserPasswordTextBox" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:Button ID="Button1" runat="server" Text="เข้าสู่ระบบ" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>