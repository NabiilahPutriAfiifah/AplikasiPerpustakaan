Public Class login
    Public Shared users As users
    Public Shared Perpustakaan As Perpustakaan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Perpustakaan = New Perpustakaan()
        users = New users()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.GSusername = data_user(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If

        'Dim plainUsername As String = TextBoxUsername.Text
        'Dim plainPassword As String = TextBoxPassword.Text

        'Dim AuthStatus As Boolean = users.checkAuth(plainUsername, plainPassword)
        ''MessageBox.Show(AuthStatus)
        'If AuthStatus Then
        '    MessageBox.Show("Login Success !!")
        '    Perpustakaan.Show()
        'End If

        'Try
        '    If AuthStatus = False Then
        '        Throw New System.Exception()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Wrong Username or Password")
        'End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim regist_form = New Registrasi()
        regist_form.Show()
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        TextBoxPassword.PasswordChar = "*"c
    End Sub
End Class