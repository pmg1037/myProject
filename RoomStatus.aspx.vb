Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Partial Class RoomStatus
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("RoomConnectionString").ConnectionString)

    Private Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        txtDate.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd", New CultureInfo("en-US"))

        Dim div As System.Web.UI.Control = Page.FindControl("divCalendar")

        If TypeOf div Is HtmlGenericControl Then
            CType(div, HtmlGenericControl).Style.Add("display", "none")
        End If
    End Sub
    'Protected Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged
    '    txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy", New CultureInfo("en-US"))
    'End Sub
    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim dt As New DataTable
        Dim adapter1 As New SqlDataAdapter
        Dim str1 As String

        str1 = "SELECT RS.RoomNo, RS.RoomRsId, Rs.DateUse, R.Building FROM RoomReserve RS LEFT JOIN room R ON RS.RoomNo=R.RoomNo where RS.DateUse='" & txtDate.Text.Trim & "' and R.Building='" & ddlAddBuilding.Text.Trim & "'"
        'MsgBox(str1)
        'Exit Sub
        adapter1 = New SqlDataAdapter(str1, con)
        adapter1.Fill(dt)

        If dt.Rows.Count > 0 Then
            GridView1.DataSource = dt
            GridView1.DataBind()
        Else

        End If


    End Sub

End Class
