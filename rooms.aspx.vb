Imports System.Data
Imports System.Data.SqlClient
Partial Class rooms
    Inherits System.Web.UI.Page

    Private Sub rooms_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim mycon As New SqlConnection
        mycon.ConnectionString = "Data Source=(local)\SQLEXPRESS;Initial Catalog=Room;Integrated Security=True;"
        mycon.Open()

        Dim Type As String = Request.QueryString("Type")

        Dim ds1 As New DataSet

        Dim strSql As String
        If Type = "S" Then
            strSQL = "select * from room where Type = 'S'"
        ElseIf Type = "C" Then
            strSQL = "select * from room where Type = 'C'"
        Else
            strSQL = "select * from room"
        End If

        Dim myAdapter As New SqlDataAdapter
        myAdapter = New SqlDataAdapter(strSQL, mycon)
        myAdapter.Fill(ds1, "room")

        If ds1.Tables("room").Rows.Count > 0 Then
            DataList1.DataSource = ds1.Tables("room")
            DataList1.DataBind()
        End If
    End Sub
End Class
