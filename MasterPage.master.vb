Imports System.Data
Imports System.Data.SqlClient

Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Dim Con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings _
                                 ("RoomConnectionString").ConnectionString)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If

        Dim sqlstrl As String = "select * from User1 where UserId='" + UserIdTextBox.Text.Trim +
            "' and UserPassword='" + UserPasswordTextBox.Text.Trim + "'"
        Dim myAdap As New SqlDataAdapter(sqlstrl, Con)
        Dim myDs As New DataSet
        myAdap.Fill(myDs, "mb")

        If myDs.Tables("mb").Rows.Count > 0 Then
            Session("UserId") = UserIdTextBox.Text.Trim
            Session("UserPassword") = UserPasswordTextBox.Text.Trim
            Response.Redirect("Page2.aspx?ชื่อผู้ใช้=" & UserIdTextBox.Text.Trim.ToString & "&รหัสผ่าน=" & UserPasswordTextBox.Text.Trim.ToString)
        Else
            Dim sMsg As String = "รหัสผ่านไม่ถูกต้อง"

            ScriptManager.RegisterStartupScript(Page, Page.GetType, Guid.NewGuid().ToString(), "alert('" & sMsg & "')", True)

        End If


    End Sub
End Class

