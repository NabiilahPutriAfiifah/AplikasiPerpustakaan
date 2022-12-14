Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Registrasi
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'login.users.GSusername = TextBoxUsername.Text
        'login.users.GSPassword = TextBoxPassword.Text
        'login.users.add_user(TextBoxUsername.Text, TextBoxPassword.Text)

        'login.Show()
        'Me.Close()

        If TextBoxUsername.Text.Length > 0 And TextBoxPassword.Text.Length > 0 Then
            login.users.AddUsersDatabase(TextBoxUsername.Text, TextBoxPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        TextBoxPassword.PasswordChar = "*"c
    End Sub
End Class