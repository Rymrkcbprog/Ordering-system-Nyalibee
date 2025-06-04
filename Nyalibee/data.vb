Imports MySql.Data.MySqlClient

Public Class data
    Dim con As New MySqlConnection("server=127.0.0.1;user id=nyalibee_user;password=nyalibee123;database=nyalibee_corp")
    Public Function totalrev() As String
        Dim total As Decimal
        Try
            con.Open()
            Dim query As String = "SELECT SUM(price) FROM Orders"
            Dim cmd As New MySqlCommand(query, con)
            total = Convert.ToDecimal(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return "₱" & total.ToString("N2")
    End Function

    Public Function showorders() As Integer
        Dim totalorders As Integer = 0
        Try
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM orders"
            Dim cmd As New MySqlCommand(query, con)
            totalorders = cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return totalorders
    End Function


    Public Function showstaff() As Integer
        Dim totalStaff As Integer
        Try
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM information WHERE job IN ('Service Crew', 'Cashier', 'Production Crew', 'Manager')"
            Dim cmd As New MySqlCommand(query, con)
            totalStaff = totalStaff.ToString(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return totalStaff
    End Function
    Public Sub showdata1(dg1 As DataGridView)
        Try
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter("select name_, job from information", con)
            da.Fill(dt)
            dg1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub showdata2(dg2 As DataGridView)
        Try
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT qty, item FROM orders", con)
            da.Fill(dt)
            dg2.DataSource = dt
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub showdata3(dg3 As DataGridView)
        Try
            Dim da As New MySqlDataAdapter("SELECT * FROM information", con)
            Dim dt As New DataTable()
            da.Fill(dt)
            dg3.DataSource = dt
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub search(dg As DataGridView, searcha As String)
        Try
            con.Open()
            Dim query As String = "SELECT * FROM information WHERE LOWER(name_) LIKE CONCAT('%', LOWER(@search), '%') OR id = @search"
            Dim da As New MySqlDataAdapter(query, con)
            da.SelectCommand.Parameters.AddWithValue("@search", searcha)
            Dim dt As New DataTable()
            da.Fill(dt)
            dg.DataSource = dt

            If dt.Rows.Count = 0 Then
                MsgBox("No results found.", MsgBoxStyle.Information, "No Result")
            End If
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub


End Class
