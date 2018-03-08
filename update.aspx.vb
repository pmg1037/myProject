Imports System.Data
Imports System.Data.SqlClient

Partial Class update
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("RoomConnectionString").ConnectionString)
    Dim strSQL As String
    Dim objCmd As SqlCommand


    Private Sub DropdownInGridview_Load(sender As Object, e As EventArgs) Handles Me.Load

        ''Sub Page_Load(sender As Object, e As EventArgs)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        If Not Page.IsPostBack() Then
            ' MsgBox("first load")
            BindData()
        End If

    End Sub

    Sub BindData()

        Dim strSQL As String = "SELECT * FROM room"

        Dim dtReader As SqlDataReader
        objCmd = New SqlCommand(strSQL, con)
        dtReader = objCmd.ExecuteReader()

        '*** BindData to GridView ***'
        myGridView.DataSource = dtReader
        myGridView.DataBind()

        dtReader.Close()
        dtReader = Nothing

    End Sub

    Sub Page_UnLoad()
        con.Close()
        con = Nothing
    End Sub

    Function DataTableCountryCode() As DataTable
        Dim strConnString As String
        Dim dtAdapter As SqlDataAdapter
        Dim dt As New DataTable

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim strSQL As String
        strSQL = "SELECT * FROM room"

        dtAdapter = New SqlDataAdapter(strSQL, con)
        dtAdapter.Fill(dt)

        dtAdapter = Nothing

        Return dt

    End Function

    Sub modEditCommand(sender As Object, e As GridViewEditEventArgs)
        myGridView.EditIndex = e.NewEditIndex
        myGridView.ShowFooter = False
        BindData()
    End Sub

    Sub modCancelCommand(sender As Object, e As GridViewCancelEditEventArgs)
        myGridView.EditIndex = -1
        myGridView.ShowFooter = True
        BindData()
    End Sub

    Sub modDeleteCommand(sender As Object, e As GridViewDeleteEventArgs)
        strSQL = "DELETE FROM room WHERE RoomNo = '" & myGridView.DataKeys.Item(e.RowIndex).Value & "'"
        objCmd = New SqlCommand(strSQL, con)
        objCmd.ExecuteNonQuery()

        myGridView.EditIndex = -1
        BindData()
    End Sub


    'Sub myGridView_RowCommand(source As Object, e As GridViewCommandEventArgs)
    '    If e.CommandName = "Add" Then



    '        strSQL = "INSERT INTO room (RoomNo,Seat,Type,Status,Building,RoomDetail) " &
    '        " VALUES ('" & txtAddRoomNo.Text & "','" & txtAddSeat.Text & "','" & ddlAddType.SelectedItem.Value & "' " &
    '        " ,'" & ddlAddStatus.SelectedItem.Value & "','" & ddlAddBuilding.Text & "','" & txtAddRoomDetail.Text & "') "

    '        objCmd = New SqlCommand(strSQL, objConn)
    '        Dim rec As Integer = 0
    '        rec = objCmd.ExecuteNonQuery()
    '        If rec > 0 Then


    '        Else

    '        End If

    '        BindData()
    '    End If
    'End Sub

    Sub myGridView_RowDataBound(source As Object, e As GridViewRowEventArgs)

        '*** Footer ***'
        If e.Row.RowType = DataControlRowType.Footer Then

            '*** CountryCode ***'
            Dim ddlCountryCode As DropDownList = CType(e.Row.FindControl("ddlAddStatus"), DropDownList)
            'If Not IsNothing(ddlCountryCode) Then
            '    With ddlCountryCode
            '        .DataSource = DataTableCountryCode()
            '        .DataTextField = "CountryName"
            '        .DataValueField = "CountryCode"
            '        .DataBind()
            '    End With
            'End If

        End If

        '*** Edit ***'
        If e.Row.RowType = DataControlRowType.DataRow Then

            '*** CustomerID ***'
            Dim txtRoomNo As TextBox = CType(e.Row.FindControl("txtEditRoomNo"), TextBox)
            If Not IsNothing(txtRoomNo) Then
                txtRoomNo.Text = e.Row.DataItem("RoomNo")
            End If
            '*** Name ***'
            Dim txtSeat As TextBox = CType(e.Row.FindControl("txtEditSeat"), TextBox)
            If Not IsNothing(txtSeat) Then
                txtSeat.Text = e.Row.DataItem("Seat")
            End If
            '*** Email ***'
            Dim txtType As TextBox = CType(e.Row.FindControl("txtEditType"), TextBox)
            If Not IsNothing(txtType) Then
                txtType.Text = e.Row.DataItem("Type")
            End If
            '*** CountryCode ***'
            Dim ddlStatus As DropDownList = CType(e.Row.FindControl("ddlEditStatus"), DropDownList)
            If Not IsNothing(ddlStatus) Then
                ddlStatus.Text = e.Row.DataItem("Status")

            End If
            '*** Budget ***'
            Dim txtBuilding As TextBox = CType(e.Row.FindControl("txtEditBuilding"), TextBox)
            If Not IsNothing(txtBuilding) Then
                txtBuilding.Text = e.Row.DataItem("Building")
            End If
            '*** Used ***'
            Dim txtRoomDetail As TextBox = CType(e.Row.FindControl("txtEditRoomDetail"), TextBox)
            If Not IsNothing(txtRoomDetail) Then
                txtRoomDetail.Text = e.Row.DataItem("RoomDetail")
            End If

        End If

    End Sub

    Sub modUpdateCommand(s As Object, e As GridViewUpdateEventArgs)

        '*** CustomerID ***'
        Dim txtRoomNo As TextBox = CType(myGridView.Rows(e.RowIndex).FindControl("txtEditRoomNo"), TextBox)
        '*** Name ***'
        Dim txtSeat As TextBox = CType(myGridView.Rows(e.RowIndex).FindControl("txtEditSeat"), TextBox)
        '*** Email ***'
        Dim txtType As TextBox = CType(myGridView.Rows(e.RowIndex).FindControl("txtEditType"), TextBox)
        '*** CountryCode ***'
        Dim ddlStatus As DropDownList = CType(myGridView.Rows(e.RowIndex).FindControl("ddlEditStatus"), DropDownList)
        '*** Budget ***'
        Dim txtBuilding As TextBox = CType(myGridView.Rows(e.RowIndex).FindControl("txtEditBuilding"), TextBox)
        '*** Used ***'
        Dim txtRoomDetail As TextBox = CType(myGridView.Rows(e.RowIndex).FindControl("txtEditRoomDetail"), TextBox)
        strSQL = "UPDATE room SET RoomNo = '" & txtRoomNo.Text & "' " &
        " ,Seat = '" & txtSeat.Text & "' " &
        " ,Type = '" & txtType.Text & "' " &
        " ,Status = '" & ddlStatus.SelectedItem.Value & "' " &
        " ,Building = '" & txtBuilding.Text & "' " &
        " ,RoomDetail = '" & txtRoomDetail.Text & "' " &
        " WHERE RoomNo = '" & myGridView.DataKeys.Item(e.RowIndex).Value & "'"
        objCmd = New SqlCommand(strSQL, con)
        objCmd.ExecuteNonQuery()

        myGridView.EditIndex = -1
        myGridView.ShowFooter = True
        BindData()
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        strSQL = "INSERT INTO room (RoomNo,Seat,Type,Status,Building,RoomDetail) " &
            " VALUES ('" & txtAddRoomNo.Text & "','" & txtAddSeat.Text & "','" & ddlAddType.SelectedItem.Value & "' " &
            " ,'" & ddlAddStatus.SelectedItem.Value & "','" & ddlAddBuilding.Text & "','" & txtAddRoomDetail.Text & "') "

        objCmd = New SqlCommand(strSQL, con)
        Dim rec As Integer = 0
        rec = objCmd.ExecuteNonQuery()
        If rec > 0 Then

        Else

        End If

        BindData()
    End Sub
End Class
