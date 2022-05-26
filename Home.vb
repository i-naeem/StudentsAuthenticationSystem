Imports System.Data.SqlClient

Public Class Home
    Private ReadOnly connectionString As String = "Server=Localhost\SQLExpress;Database=Students;Integrated Security=true"
    Public connection As New SqlConnection(connectionString)

    Private Sub LoginAnchorButton_Click(sender As Object, e As EventArgs) Handles LoginAnchorButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub SignupAnchorButton_Click(sender As Object, e As EventArgs) Handles SignupAnchorButton.Click
        Me.Hide()
        SignupForm.Show()
    End Sub
End Class
