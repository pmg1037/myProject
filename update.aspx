<%@ Page Title="" Language="VB" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="false" CodeFile="update.aspx.vb" Inherits="update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" Runat="Server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">หมายเลขห้อง</td>
                <td class="auto-style7"><%--<input id="txtAddRoomNo" size="5" runat="server" class="auto-style2" />--%>
                    <asp:TextBox id="txtAddRoomNo" size="5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">จำนวนที่นั่ง</td>
                <td class="auto-style7"><asp:TextBox id="txtAddSeat" size="10" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">ประเภทห้อง</td>
                <td class="auto-style7"><asp:DropDownList id="ddlAddType" runat="server">
                <asp:ListItem Value="M">Meeting Room</asp:ListItem>
                <asp:ListItem Value="C">Computer Room</asp:ListItem>
                <asp:ListItem Value="S">Classoom</asp:ListItem>
			</asp:DropDownList></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">สถานะ</td>
                <td class="auto-style7"><asp:DropDownList id="ddlAddStatus" runat="server">
                <asp:ListItem Value="Y">ว่าง</asp:ListItem>
                    <asp:ListItem Value="N">ไม่ว่าง</asp:ListItem>
			</asp:DropDownList></td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1">ตึก</td>
                <td class="auto-style7"><asp:DropDownList id="ddlAddBuilding" runat="server">
                <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
			</asp:DropDownList></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">รายละเอียด</td>
                <td class="auto-style7"><asp:TextBox id="txtAddRoomDetail" size="6" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button id="btnAdd" runat="server" Text="Add" CommandName="Add"></asp:Button></td>
            </tr>
        </table>
        </div>
    <br />
    <div>
    <asp:GridView id="myGridView" runat="server" AutoGenerateColumns="False" 
	ShowFooter="True" 
	DataKeyNames="RoomNo"
	OnRowEditing="modEditCommand"
	OnRowCancelingEdit="modCancelCommand"
	OnRowDeleting="modDeleteCommand"
	OnRowUpdating="modUpdateCommand"
	OnRowDataBound="myGridView_RowDataBound">

	<Columns>

	<asp:TemplateField HeaderText="RoomNo">
		<ItemTemplate>
			<asp:Label id="lblRoomNo" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.RoomNo") %>'></asp:Label>
		</ItemTemplate>
		<EditItemTemplate>
			<asp:TextBox id="txtEditRoomNo" size="5" runat="server"></asp:TextBox>
		</EditItemTemplate>
		
	</asp:TemplateField>

	<asp:TemplateField HeaderText="Seat">
		<ItemTemplate>
			<asp:Label id="lblSeat" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Seat") %>'></asp:Label>
		</ItemTemplate>
		<EditItemTemplate>
			<asp:TextBox id="txtEditSeat" size="10" runat="server"></asp:TextBox>
		</EditItemTemplate>
		
	</asp:TemplateField>

	<asp:TemplateField HeaderText="Type">
		<ItemTemplate>
			<asp:Label id="lblType" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Type") %>'></asp:Label>
		</ItemTemplate>
		<EditItemTemplate>
			<asp:DropDownList id="ddlEditType" runat="server">
                <asp:ListItem Value="M">Meeting Room</asp:ListItem>
                <asp:ListItem Value="C">Computer Room</asp:ListItem>
                <asp:ListItem Value="S">Classoom</asp:ListItem>
			</asp:DropDownList>
		</EditItemTemplate>
		
	</asp:TemplateField>

	<asp:TemplateField HeaderText="Status">
		<ItemTemplate>
			<asp:Label id="lblStatus" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Status") %>'></asp:Label>
		</ItemTemplate>
		<EditItemTemplate>
			<asp:DropDownList id="ddlEditStatus" runat="server">
                <asp:ListItem Value="Y">ว่าง</asp:ListItem>
                <asp:ListItem Value="N">ไม่ว่าง</asp:ListItem>
			</asp:DropDownList>
		</EditItemTemplate>
		
	</asp:TemplateField>

	<asp:TemplateField HeaderText="Building">
		<ItemTemplate>
			<asp:Label id="lblBuilding" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Building") %>'></asp:Label>
		</ItemTemplate>
		<EditItemTemplate>
			<asp:TextBox id="txtEditBuilding" size="6" runat="server"></asp:TextBox>
		</EditItemTemplate>
		
	</asp:TemplateField>

	<asp:TemplateField HeaderText="RoomDeatail">
		<ItemTemplate>
			<asp:Label id="lblRoomDeatail" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.RoomDetail") %>'></asp:Label>
		</ItemTemplate>
		<EditItemTemplate>
			<asp:TextBox id="txtEditRoomDetail" size="6" runat="server"></asp:TextBox>
		</EditItemTemplate>
		
	</asp:TemplateField>

	<asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="Modify"  />
	<asp:CommandField ShowDeleteButton="True" HeaderText="Delete" />
	
	</Columns>
</asp:GridView>
    </div>
</asp:Content>

