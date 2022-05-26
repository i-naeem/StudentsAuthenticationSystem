Public Class Home
    Private Sub LoginAnchorButton_Click(sender As Object, e As EventArgs) Handles LoginAnchorButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub SignupAnchorButton_Click(sender As Object, e As EventArgs) Handles SignupAnchorButton.Click
        Me.Hide()
        SignupForm.Show()
    End Sub
End Class
