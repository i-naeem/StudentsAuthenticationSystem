Public Class SignupForm
    Dim rollNo As Integer
    Dim fname As String
    Dim password As String

    Private Sub SignupForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles SignupButton.Click
        rollNo = RollNoTextBox.Text
        fname = FullNameTextBox.Text
        password = PasswordTextBox.Text

        Dim query As String = String.Format("INSERT INTO StudentsTable(rollNo, fullName, password) VALUES({0}, {1}, {2})", rollNo, fname, password)
        MessageBox.Show(query)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class