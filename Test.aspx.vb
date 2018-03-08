Imports System.Data
Imports System.Data.SqlClient
Partial Class test
    Inherits System.Web.UI.Page

    Function GetData(ByVal cmdString As String) As DataTable
        Dim constr As String = ConfigurationManager.ConnectionStrings("RoomConnectionString").ConnectionString
        Dim conn As New SqlConnection(constr)
        'conn.Open()
        Dim dt As DataTable = Nothing
        Using da As New System.Data.SqlClient.SqlDataAdapter(cmdString, conn)
            dt = New DataTable
            'If params.Length > 0 Then
            '    da.SelectCommand.Parameters.AddRange(params)
            'End If
            If da.SelectCommand.Connection.State <> ConnectionState.Open Then da.SelectCommand.Connection.Open()
            da.Fill(dt)
        End Using
        Return dt

    End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim selectRoomSql As String = "select * from room"
            Dim dt As DataTable
            dt = GetData(selectRoomSql)

            GridView1.DataSource = dt
            GridView1.DataBind()

    End Sub
    Public Shared Sub DeleteRoom(roomId As Integer)
        Dim constr As String = ConfigurationManager.ConnectionStrings("RoomConnectionString").ConnectionString

        Using conn As New SqlConnection(constr)
            Using cmd As New SqlCommand("DELETE FROM room WHERE RoomNo = @roomId")
                cmd.Parameters.AddWithValue("@roomId", roomId)
                cmd.Connection = conn
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Protected Sub DeleteCustomer(ByVal sender As Object, ByVal e As EventArgs)
        Dim constr As String = ConfigurationManager.ConnectionStrings("RoomConnectionString").ConnectionString
        Dim lnkRemove As LinkButton = DirectCast(sender, LinkButton)

        Using conn As New SqlConnection(constr)
            Using cmd As New SqlCommand("DELETE FROM room WHERE RoomNo = @roomId")
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@roomId", SqlDbType.VarChar).Value = lnkRemove.CommandArgument
                cmd.Connection = conn
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using

        Dim selectRoomSql As String = "select * from room"
        Dim dt As DataTable
        dt = GetData(selectRoomSql)

        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then

            BindData()

        End If
    End Sub
    Private Sub BindData()

        Dim selectRoomSql As String = "select * from room"
        Dim dt As DataTable
        dt = GetData(selectRoomSql)

        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub
End Class
