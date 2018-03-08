
Partial Class login
    Inherits System.Web.UI.Page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Page2.aspx?ชื่อผู้ใช้=" & UserIdTextBox.Text.Trim.ToString & "&รหัสผ่าน=" & UserPasswordTextBox.Text.Trim.ToString)
    End Sub
End Class
