Imports System.Configuration
Imports System.Data.Common
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Ocsp

Public Class Form2

    Dim con As New MySqlConnection("server=127.0.0.1;user id=nyalibee_user;password=nyalibee123;database=nyalibee_corp")
    Dim cmd As New MySqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        Me.Text = String.Empty
        Me.ControlBox = False
        Timer1.Enabled = True
        Dim rev As New data
        rev.showdata3(DataGridView3)
        txtemployees.Text = rev.showstaff()
        rev.showdata1(DataGridView1)
        rev.showdata2(DataGridView2)
        txtorders.Text = rev.showorders()
        txttotalrev.Text = rev.totalrev()
        dashpan.BackColor = Color.Red
        btndashboard.ForeColor = Color.Red
        btndashboard.IconColor = Color.Red
        btndashboard.ImageAlign = ContentAlignment.MiddleRight
        Label4.ForeColor = Color.Yellow
        Label4.Text = "Dashboard"
    End Sub



    Private Sub adddata()
        Dim show As New data
        Try
            If txtname.Text = "" Or txtgender.Text = "" Or txtpassword.Text = "" Or Txtusername.Text = "" Or txtdatehired.Text = "" Or txtjob.Text = "" Or txtusertype.Text = "" Then
                MsgBox("All fields are required", MsgBoxStyle.Critical, "Fill Up All The Fields!")
            Else
                con.Open()
                Dim query As String = "INSERT INTO information(Name_, gender, password, username, datehired, job, user_type) VALUES (@Name, @gender, @password, @username, @datehired, @job_role, @user_type)"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", txtname.Text)
                cmd.Parameters.AddWithValue("@gender", txtgender.Text)
                cmd.Parameters.AddWithValue("@password", txtpassword.Text)
                cmd.Parameters.AddWithValue("@username", Txtusername.Text)
                cmd.Parameters.AddWithValue("@datehired", txtdatehired.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@job_role", txtjob.Text)
                cmd.Parameters.AddWithValue("@user_type", txtusertype.Text)

                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Data Inserted Successfully.", MsgBoxStyle.Information, "Success")
                    txtid.Text = ""
                    txtname.Text = ""
                    txtgender.Text = ""
                    txtpassword.Text = ""
                    Txtusername.Text = ""
                    txtdatehired.Text = ""
                    txtjob.Text = ""
                    txtusertype.Text = ""
                Else
                    MsgBox("Insert failed.")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
            show.showdata3(DataGridView3)
        End Try
    End Sub
    Private Sub update()
        Dim show As New data
        Try
            If txtname.Text = "" Or txtgender.Text = "" Or txtpassword.Text = "" Or Txtusername.Text = "" Or txtdatehired.Text = "" Or txtjob.Text = "" Or txtusertype.Text = "" Then
                MsgBox("All fields are required", MsgBoxStyle.Critical, "Fill Up All The Fields!")
            Else
                con.Open()
                Dim query As String = "Update information set Name_ = @Name, gender = @gender, password = @password, username = @username, datehired = @datehired, job = @job_role, user_type = @user_type WHERE id = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", txtid.Text)
                cmd.Parameters.AddWithValue("@Name", txtname.Text)
                cmd.Parameters.AddWithValue("@gender", txtgender.Text)
                cmd.Parameters.AddWithValue("@password", txtpassword.Text)
                cmd.Parameters.AddWithValue("@username", Txtusername.Text)
                cmd.Parameters.AddWithValue("@datehired", txtdatehired.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@job_role", txtjob.Text)
                cmd.Parameters.AddWithValue("@user_type", txtusertype.Text)
                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Data Successfully Updated.", MsgBoxStyle.Information, "Success")
                    txtid.Text = ""
                    txtname.Text = ""
                    txtgender.Text = ""
                    txtpassword.Text = ""
                    Txtusername.Text = ""
                    txtdatehired.Text = ""
                    txtjob.Text = ""
                    txtusertype.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
            show.showdata3(DataGridView3)
        End Try
    End Sub
    Private Sub search()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM information WHERE name_ = @search OR id = @search"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", txtsearch.Text.Trim())

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView3.DataSource = dt

            If dt.Rows.Count > 0 Then
                txtid.Text = dt.Rows(0)("id").ToString()
                txtname.Text = dt.Rows(0)("name_").ToString()
                txtgender.Text = dt.Rows(0)("gender").ToString()
                txtpassword.Text = dt.Rows(0)("password").ToString()
                Txtusername.Text = dt.Rows(0)("username").ToString()
                txtdatehired.Text = dt.Rows(0)("datehired").ToString()
                txtjob.Text = dt.Rows(0)("job").ToString()
                txtusertype.Text = dt.Rows(0)("user_type").ToString()
            Else
                MsgBox("No results found.", MsgBoxStyle.Information, "No Result")
            End If
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dis()
        Dashboardpan.Top = False
        Dashboardpan.Visible = False
        managementpan.Top = False
        managementpan.Visible = False
        btndashboard.ImageAlign = ContentAlignment.MiddleLeft
        btndashboard.IconColor = Color.Black
        btndashboard.ForeColor = Color.Black
        Btnaddstaff.ImageAlign = ContentAlignment.MiddleLeft
        Btnaddstaff.IconColor = Color.Black
        Btnaddstaff.ForeColor = Color.Black
        manpan.BackColor = Color.Transparent
        dashpan.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        Dim tot As New data
        txtemployees.Text = tot.showstaff()
        dis()
        Dashboardpan.Top = True
        Dashboardpan.Visible = True
        dashpan.BackColor = Color.Red
        btndashboard.ForeColor = Color.Red
        btndashboard.IconColor = Color.Red
        btndashboard.ImageAlign = ContentAlignment.MiddleRight
        Label4.ForeColor = Color.Yellow
        Label4.Text = "Dashboard"
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles Btnaddstaff.Click
        dis()
        managementpan.Top = True
        managementpan.Visible = True
        Label4.ForeColor = Color.Yellow
        Label4.Text = "Staff Management"
        Btnaddstaff.ImageAlign = ContentAlignment.MiddleRight
        manpan.BackColor = Color.Red
        Btnaddstaff.IconColor = Color.Red
        Btnaddstaff.ForeColor = Color.Red
    End Sub



    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso DataGridView3.Columns(e.ColumnIndex).Name = "id" Then
                Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
                txtid.Text = row.Cells("id").Value.ToString()
                txtname.Text = row.Cells("colname").Value.ToString()
                txtgender.Text = row.Cells("colgender").Value.ToString()
                txtpassword.Text = row.Cells("colpassword").Value.ToString()
                Txtusername.Text = row.Cells("colusername").Value.ToString()
                txtdatehired.Text = row.Cells("coldatehired").Value.ToString()
                txtjob.Text = row.Cells("coljob").Value.ToString()
                txtusertype.Text = row.Cells("colusertypen").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub del()
        Dim show As New data
        Try
            If txtname.Text = "" Or txtgender.Text = "" Or txtpassword.Text = "" Or Txtusername.Text = "" Or txtdatehired.Text = "" Or txtjob.Text = "" Or txtusertype.Text = "" Then
                MsgBox("All fields are required", MsgBoxStyle.Critical, "Fill Up All The Fields!")
            Else
                con.Open()
                Dim query As String = "delete from information WHERE id = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", txtid.Text)

                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Data Successfully Deleted.", MsgBoxStyle.Information, "Success")
                    txtid.Text = ""
                    txtname.Text = ""
                    txtgender.Text = ""
                    txtpassword.Text = ""
                    Txtusername.Text = ""
                    txtdatehired.Text = ""
                    txtjob.Text = ""
                    txtusertype.Text = ""

                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
            show.showdata3(DataGridView3)
        End Try
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim d As New data()
        d.search(DataGridView3, txtsearch.Text)
    End Sub
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles btndel.Click
        del()
        Dim sho As New data
        sho.showdata1(DataGridView1)
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtid.Text = ""
        txtname.Text = ""
        txtgender.Text = ""
        txtpassword.Text = ""
        Txtusername.Text = ""
        txtdatehired.Text = ""
        txtjob.Text = ""
        txtusertype.Text = ""
        txtsearch.Text = ""
        Dim show As New data
        show.showdata3(DataGridView3)
    End Sub
    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtgender.Focus()
        End If
    End Sub


    Private Sub txtgender_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgender.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Txtusername.Focus()
        End If
    End Sub


    Private Sub Txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtjob.Focus()
        End If
    End Sub

    Private Sub txtjob_KeyDown(sender As Object, e As KeyEventArgs) Handles txtjob.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtusertype.Focus()
        End If
    End Sub

    Private Sub txtusertype_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusertype.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtdatehired.Focus()
        End If
    End Sub

    Private Sub txtdatehired_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdatehired.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtid.Focus()
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim sho As New data
        adddata()
        sho.showdata1(DataGridView1)
    End Sub
    Private Sub xbutton_Click(sender As Object, e As EventArgs) Handles xbutton.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub IconButton322_Click(sender As Object, e As EventArgs) Handles IconButton322.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        update()
    End Sub

End Class