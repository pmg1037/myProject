
Imports System.Globalization

Partial Class classroom
    Inherits System.Web.UI.Page

    Private Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        txtDate.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd", New CultureInfo("en-US"))

        Dim div As System.Web.UI.Control = Page.FindControl("divCalendar")

        If TypeOf div Is HtmlGenericControl Then
            CType(div, HtmlGenericControl).Style.Add("display", "none")
        End If
    End Sub

End Class
