Imports MySql.Data.MySqlClient
Imports Ordering_System_Nyalibee.loginform
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = String.Empty
        Me.ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim login As New loginform(txtuser.Text, txtpass.Text)
        Dim result As String = login.logincheck(txtpass.Text, txtuser.Text)
        If result = "Admin" Then
            Form2.Show()
            Me.Hide()
            txtuser.Text = ""
            txtpass.Text = ""
        ElseIf result = "Cashier" Then
            Form3.Show()
            Me.Hide()
            txtuser.Text = ""
            txtpass.Text = ""
        ElseIf result = "Invalid" Then
            MsgBox("Wrong Username or Password", MsgBoxStyle.Critical, "Login Error")
        End If
    End Sub

    Private Sub xbutton_Click_1(sender As Object, e As EventArgs) Handles xbutton.Click
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtpass.PasswordChar = If(CheckBox1.Checked, ControlChars.NullChar, "●"c)
    End Sub



    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtpass.Focus()
        End If
    End Sub


    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Btnlogin.Focus()
        End If
    End Sub
End Class
