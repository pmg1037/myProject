<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="rooms.aspx.vb" Inherits="rooms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p><asp:DataList ID="DataList1" runat="server" RepeatColumns="2" RepeatLayout="Table">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("RoomNo") %>'></asp:Label>
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("RoomDetail") %>'></asp:Label>
            <asp:Image ID="Image1" runat="server" />
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        </ItemTemplate>
    </asp:DataList></p>
    <p></p>
    <p></p>
</asp:Content>

