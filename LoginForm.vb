Public Class LoginForm
    Dim rollNo As Integer
    Dim password As String

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        rollNo = RollNoTextBox.Text
        password = PasswordTextBox.Text

        MessageBox.Show("ROLL NO: " + Convert.ToString(rollNo) + " password " + password)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class