<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="cancel.aspx.vb" Inherits="cancel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 199px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
            <tr>
                <td class="auto-style1">เลขที่ใบจอง</td>
                <td class="auto-style7">
                    <asp:TextBox id="txtReserve" size="5" runat="server" Height="22px" Width="195px"></asp:TextBox>
                </td>
            </tr>
        <tr>
                <td class="auto-style1">เบอร์โทรผู้จอง</td>
                <td class="auto-style7">
                    <asp:TextBox id="txtTel" size="5" runat="server" Height="22px" Width="195px"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td class="auto-style1">
            <asp:Button ID="btnCancel" runat="server" Text="ยืนยันการยกเลิก" />
                </td>

        </tr>
        </table>
</asp:Content>

