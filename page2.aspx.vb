
Partial Class page2
    Inherits System.Web.UI.Page

    Private Sub page2_Load(sender As Object, e As EventArgs) Handles Me.Load
        nameLb.Text = Request.QueryString("ชื่อผู้ใช้=")
        lastnameLb.Text = Request.QueryString("รหัสผ่าน=")
    End Sub
End Class
