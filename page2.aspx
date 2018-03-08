<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="page2.aspx.vb" Inherits="page2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="nameLb" runat="server" Text="ชื่อผู้ใช้"></asp:Label>
    <br />
    <asp:Label ID="lastnameLb" runat="server" Text="รหัสผ่าน"></asp:Label>
</asp:Content>

