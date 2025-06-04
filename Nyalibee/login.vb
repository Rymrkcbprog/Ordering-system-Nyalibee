Imports MySql.Data.MySqlClient

Public Class loginform

    Private Property username As String
    Private Property password As String

    Public Sub New(user As String, pass As String)
        username = user
        password = pass
    End Sub
    Public Function logincheck(pass As String, username As String) As String
        Dim conn As New MySqlConnection("server=127.0.0.1;user id=nyalibee_user;password=nyalibee123;database=nyalibee_corp")
        Dim query As String = "SELECT * FROM information WHERE username = @Username AND password = @Password"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Username", username)
        cmd.Parameters.AddWithValue("@Password", pass)
        Dim dt As New DataTable()

        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)("User_type").ToString()
            Else
                Return "Invalid"
            End If
        Catch ex As Exception
            MsgBox("Login failed: " & ex.Message, MsgBoxStyle.Critical)
            Return "Error"
        Finally
            conn.Close()
        End Try
    End Function
End Class
