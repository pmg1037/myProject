
Partial Class testCalendar
    Inherits System.Web.UI.Page

    Private Sub testCalendar_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack Then
            Response.Write("PostBack")

        Else
            Response.Write("Not PostBack")
        End If
    End Sub
    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString
    End Sub
End Class
