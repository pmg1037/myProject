
Partial Class index
    Inherits System.Web.UI.Page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("page2.aspx?name=" & nameTextBox.Text.Trim.ToString & "&lastname=" & lastnameTextBox.Text.Trim.ToString)
    End Sub
End Class
