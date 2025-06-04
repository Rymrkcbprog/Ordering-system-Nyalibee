

Imports System.Windows.Controls
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Ocsp
Public Class Form3

    Dim con As New MySqlConnection("server=127.0.0.1;user id=nyalibee_user;password=nyalibee123;database=nyalibee_corp")
    Dim cmd As New MySqlCommand
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        btnnyicken.ForeColor = Color.Red
        btnnyicken.IconColor = Color.Red
        nyickenpan.Visible = True
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False

    End Sub
    Private Sub remove()
        DoubleBuffered = True
        nyickenjoypanel.Top = False
        nyickenjoypanel.Visible = False
        nyumburgerpanel.Top = False
        nyumburgerpanel.Visible = False
        Nyaleespagpanel.Top = False
        Nyaleespagpanel.Visible = False
        burngersteakpanel.Top = False
        burngersteakpanel.Visible = False
        nyupermealpanel.Top = False
        nyupermealpanel.Visible = False
        Nyandwichespanel.Top = False
        Nyandwichespanel.Visible = False
        nyesertandnrinkspanel.Top = False
        nyesertandnrinkspanel.Visible = False
        mriesnsidespanel.Top = False
        mriesnsidespanel.Visible = False
    End Sub

    Private Sub dis()
        nyickenpan.Visible = False
        btnnyicken.ForeColor = Color.Black
        btnnyicken.IconColor = Color.Black
        btnnyum.ForeColor = Color.Black
        btnnyum.IconColor = Color.Black
        btnnyalee.ForeColor = Color.Black
        btnnyalee.IconColor = Color.Black
        btnburnger.ForeColor = Color.Black
        btnburnger.IconColor = Color.Black
        btnnyuper.ForeColor = Color.Black
        btnnyuper.IconColor = Color.Black
        btnnyandwiches.ForeColor = Color.Black
        btnnyandwiches.IconColor = Color.Black
        btnnyesert.ForeColor = Color.Black
        btnnyesert.IconColor = Color.Black
        btnmries.ForeColor = Color.Black
        btnmries.IconColor = Color.Black
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnnyicken.Click
        dis()
        remove()
        btnnyicken.ForeColor = Color.Red
        btnnyicken.IconColor = Color.Red
        nyickenjoypanel.Top = True
        nyickenjoypanel.Visible = True
        nyickenpan.Visible = True
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnnyum.Click
        dis()
        remove()
        btnnyum.ForeColor = Color.Red
        btnnyum.IconColor = Color.Red
        nyumburgerpanel.Top = True
        nyumburgerpanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = True
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btnnyalee.Click
        dis()
        remove()
        btnnyalee.ForeColor = Color.Red
        btnnyalee.IconColor = Color.Red
        Nyaleespagpanel.Top = True
        Nyaleespagpanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = False
        nyaleepan.Visible = True
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles btnburnger.Click
        remove()
        dis()
        btnburnger.ForeColor = Color.Red
        btnburnger.IconColor = Color.Red
        burngersteakpanel.Top = True
        burngersteakpanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = True
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles btnnyuper.Click
        remove()
        dis()
        btnnyuper.ForeColor = Color.Red
        btnnyuper.IconColor = Color.Red
        nyupermealpanel.Top = True
        nyupermealpanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = True
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = False
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles btnnyandwiches.Click
        remove()
        dis()
        btnnyandwiches.ForeColor = Color.Red
        btnnyandwiches.IconColor = Color.Red
        Nyandwichespanel.Top = True
        Nyandwichespanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = True
        nyesertpan.Visible = False
        mriespan.Visible = False
    End Sub
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles btnnyesert.Click
        remove()
        dis()
        btnnyesert.ForeColor = Color.Red
        btnnyesert.IconColor = Color.Red
        nyesertandnrinkspanel.Top = True
        nyesertandnrinkspanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = True
        mriespan.Visible = False
    End Sub
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles btnmries.Click
        remove()
        dis()
        btnmries.ForeColor = Color.Red
        btnmries.IconColor = Color.Red
        mriesnsidespanel.Top = True
        mriesnsidespanel.Visible = True
        nyickenpan.Visible = False
        nyumpan.Visible = False
        nyaleepan.Visible = False
        burngerpan.Visible = False
        nyuperpan.Visible = False
        Nyanpan.Visible = False
        nyesertpan.Visible = False
        mriespan.Visible = True
    End Sub

    Private Sub xbutton_Click(sender As Object, e As EventArgs) Handles xbutton.Click
        homepanel.Top = True
        homepanel.Visible = True
        homepanel.Location = New Point(0, 75)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnstartneworder_Click(sender As Object, e As EventArgs) Handles btnstartneworder.Click
        homepanel.Top = False
        homepanel.Visible = False
    End Sub

    Private Sub lblhome_Click(sender As Object, e As EventArgs) Handles lblhome.Click
        homepanel.Top = True
        homepanel.Visible = True
        homepanel.Location = New Point(0, 75)
    End Sub

    Private Sub btnminmax_Click(sender As Object, e As EventArgs) Handles btnminmax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            homepanel.Size = New Size(2035, 953)
        Else
            homepanel.Size = New Size(1677, 722)
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Function total() As Decimal
        Dim totalPrice As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim price As Object = row.Cells("colPrice").Value
                If price IsNot Nothing AndAlso IsNumeric(price) Then
                    totalPrice += Convert.ToDecimal(price)
                End If
            End If
        Next

        Return totalPrice
    End Function



    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        MsgBox("Are you sure you want to cancel the order?", MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel, "Cancel Order")
        If MsgBoxResult.Ok Then
            DataGridView1.Rows.Clear()
            txttotal.Text = "₱0.00"
            txtquan1.Text = "0"
            txtquan2.Text = "0"
            txtquan3.Text = "0"
            txtquan4.Text = "0"
            txtquan5.Text = "0"
            txtquan6.Text = "0"
            txtquan7.Text = "0"
            txtquan8.Text = "0"
            txtquan9.Text = "0"
            txtquan10.Text = "0"
            txtquan11.Text = "0"
            txtquan12.Text = "0"
            txtquan13.Text = "0"
            txtquan14.Text = "0"
            txtquan15.Text = "0"
            txtquan16.Text = "0"
            txtquan17.Text = "0"
            txtquan18.Text = "0"
            txtquan19.Text = "0"
            txtquan20.Text = "0"
            txtquan21.Text = "0"
            txtquan22.Text = "0"
            txtquan23.Text = "0"
            txtquan24.Text = "0"
            txtquan25.Text = "0"
            txtquan26.Text = "0"
            txtquan27.Text = "0"
            txtquan28.Text = "0"
            txtquan29.Text = "0"
            txtquan30.Text = "0"
            txtquan31.Text = "0"
            txtquan32.Text = "0"
            txtquan33.Text = "0"
            txtquan34.Text = "0"
            txtquan35.Text = "0"
            txtquan36.Text = "0"
            txtquan37.Text = "0"
            txtquan38.Text = "0"
            txtquan39.Text = "0"
            txtquan40.Text = "0"
            txtquan41.Text = "0"
            txtquan42.Text = "0"
            txtquan43.Text = "0"
            txtquan44.Text = "0"
            txtquan45.Text = "0"
            txtquan46.Text = "0"
            txtquan47.Text = "0"
            txtquan48.Text = "0"
            txtquan49.Text = "0"
            txtquan50.Text = "0"
            txtquan51.Text = "0"
            txtquan52.Text = "0"
            txtquan53.Text = "0"
            txtquan54.Text = "0"
            txtquan55.Text = "0"
            txtquan56.Text = "0"
            txtquan57.Text = "0"
            txtquan58.Text = "0"
            txtquan59.Text = "0"
            txtquan60.Text = "0"
            txtquan61.Text = "0"
            txtquan62.Text = "0"
            txtquan63.Text = "0"
            txtquan64.Text = "0"
            txtquan65.Text = "0"
            txtquan66.Text = "0"
            txtquan67.Text = "0"
            txtquan68.Text = "0"
            txtquan69.Text = "0"
            txtquan70.Text = "0"
            txtquan71.Text = "0"
            txtquan72.Text = "0"
            txtquan73.Text = "0"
            txtquan74.Text = "0"
            txtquan75.Text = "0"
            txtquan76.Text = "0"
            txtquan77.Text = "0"
            txtquan78.Text = "0"
            txtquan79.Text = "0"
            txtquan80.Text = "0"
            txtquan81.Text = "0"
            txtquan82.Text = "0"
            txtquan83.Text = "0"
            txtquan84.Text = "0"
            txtquan85.Text = "0"
            txtquan86.Text = "0"
            txtquan87.Text = "0"
        End If

    End Sub

    Private Sub btnmin1_Click(sender As Object, e As EventArgs) Handles btnmin1.Click
        Dim product As New Prices(txtquan1.Text, lblname1.Text, lblprice1.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan1.Text > 0 Then
            txtquan1.Text = Val(txtquan1.Text) - 1
        End If
    End Sub

    Private Sub btnadd1_Click(sender As Object, e As EventArgs) Handles btnadd1.Click
        Dim newItem As New Prices(txtquan1.Text, lblname1.Text, lblprice1.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan1.Text = Val(txtquan1.Text) + 1
    End Sub

    Private Sub btnmin2_Click(sender As Object, e As EventArgs) Handles btnmin2.Click
        Dim product As New Prices(txtquan2.Text, lblname2.Text, lblprice2.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan2.Text > 0 Then
            txtquan2.Text = Val(txtquan2.Text) - 1
        End If
    End Sub

    Private Sub btnadd2_Click(sender As Object, e As EventArgs) Handles btnadd2.Click
        Dim newItem As New Prices(txtquan2.Text, lblname2.Text, lblprice2.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan2.Text = Val(txtquan2.Text) + 1
    End Sub

    Private Sub btnmin3_Click(sender As Object, e As EventArgs) Handles btnmin3.Click
        Dim product As New Prices(txtquan3.Text, lblname3.Text, lblprice3.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan3.Text > 0 Then
            txtquan3.Text = Val(txtquan3.Text) - 1
        End If
    End Sub

    Private Sub btnadd3_Click(sender As Object, e As EventArgs) Handles btnadd3.Click
        Dim newItem As New Prices(txtquan3.Text, lblname3.Text, lblprice3.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan3.Text = Val(txtquan3.Text) + 1
    End Sub

    Private Sub btnmin4_Click(sender As Object, e As EventArgs) Handles btnmin4.Click
        Dim product As New Prices(txtquan4.Text, lblname4.Text, lblprice4.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan4.Text > 0 Then
            txtquan4.Text = Val(txtquan4.Text) - 1
        End If
    End Sub

    Private Sub btnadd4_Click(sender As Object, e As EventArgs) Handles btnadd4.Click
        Dim newItem As New Prices(txtquan4.Text, lblname4.Text, lblprice4.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan4.Text = Val(txtquan4.Text) + 1
    End Sub

    Private Sub btnmin5_Click(sender As Object, e As EventArgs) Handles btnmin5.Click
        Dim product As New Prices(txtquan5.Text, lblname5.Text, lblprice5.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan5.Text > 0 Then
            txtquan5.Text = Val(txtquan5.Text) - 1
        End If
    End Sub

    Private Sub btnadd5_Click(sender As Object, e As EventArgs) Handles btnadd5.Click
        Dim newItem As New Prices(txtquan5.Text, lblname5.Text, lblprice5.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan5.Text = Val(txtquan5.Text) + 1
    End Sub

    Private Sub btnmin6_Click(sender As Object, e As EventArgs) Handles btnmin6.Click
        Dim product As New Prices(txtquan6.Text, lblname6.Text, lblprice6.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan6.Text > 0 Then
            txtquan6.Text = Val(txtquan6.Text) - 1
        End If
    End Sub

    Private Sub btnadd6_Click(sender As Object, e As EventArgs) Handles btnadd6.Click
        Dim newItem As New Prices(txtquan6.Text, lblname6.Text, lblprice6.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan6.Text = Val(txtquan6.Text) + 1
    End Sub

    Private Sub btnmin7_Click(sender As Object, e As EventArgs) Handles btnmin7.Click
        Dim product As New Prices(txtquan7.Text, lblname7.Text, lblprice7.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan7.Text > 0 Then
            txtquan7.Text = Val(txtquan7.Text) - 1
        End If
    End Sub

    Private Sub btnadd7_Click(sender As Object, e As EventArgs) Handles btnadd7.Click
        Dim newItem As New Prices(txtquan7.Text, lblname7.Text, lblprice7.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan7.Text = Val(txtquan7.Text) + 1
    End Sub

    Private Sub btnmin8_Click(sender As Object, e As EventArgs) Handles btnmin8.Click
        Dim product As New Prices(txtquan8.Text, lblname8.Text, lblprice8.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan8.Text > 0 Then
            txtquan8.Text = Val(txtquan8.Text) - 1
        End If
    End Sub

    Private Sub btnadd8_Click(sender As Object, e As EventArgs) Handles btnadd8.Click
        Dim newItem As New Prices(txtquan8.Text, lblname8.Text, lblprice8.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan8.Text = Val(txtquan8.Text) + 1
    End Sub

    Private Sub btnmin9_Click(sender As Object, e As EventArgs) Handles btnmin9.Click
        Dim product As New Prices(txtquan9.Text, lblname9.Text, lblprice9.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan9.Text > 0 Then
            txtquan9.Text = Val(txtquan9.Text) - 1
        End If
    End Sub

    Private Sub btnadd9_Click(sender As Object, e As EventArgs) Handles btnadd9.Click
        Dim newItem As New Prices(txtquan9.Text, lblname9.Text, lblprice9.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan9.Text = Val(txtquan9.Text) + 1
    End Sub

    Private Sub btnmin10_Click(sender As Object, e As EventArgs) Handles btnmin10.Click
        Dim product As New Prices(txtquan10.Text, lblname10.Text, lblprice10.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan10.Text > 0 Then
            txtquan10.Text = Val(txtquan10.Text) - 1
        End If
    End Sub

    Private Sub btnadd10_Click(sender As Object, e As EventArgs) Handles btnadd10.Click
        Dim newItem As New Prices(txtquan10.Text, lblname10.Text, lblprice10.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan10.Text = Val(txtquan10.Text) + 1
    End Sub

    Private Sub btnmin11_Click(sender As Object, e As EventArgs) Handles btnmin11.Click
        Dim product As New Prices(txtquan11.Text, lblname11.Text, lblprice11.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan11.Text > 0 Then
            txtquan11.Text = Val(txtquan11.Text) - 1
        End If
    End Sub

    Private Sub btnadd11_Click(sender As Object, e As EventArgs) Handles btnadd11.Click
        Dim newItem As New Prices(txtquan11.Text, lblname11.Text, lblprice11.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan11.Text = Val(txtquan11.Text) + 1
    End Sub

    Private Sub btnmin12_Click(sender As Object, e As EventArgs) Handles btnmin12.Click
        Dim product As New Prices(txtquan12.Text, lblname12.Text, lblprice12.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan12.Text > 0 Then
            txtquan12.Text = Val(txtquan12.Text) - 1
        End If
    End Sub

    Private Sub btnadd12_Click(sender As Object, e As EventArgs) Handles btnadd12.Click
        Dim newItem As New Prices(txtquan12.Text, lblname12.Text, lblprice12.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan12.Text = Val(txtquan12.Text) + 1
    End Sub

    Private Sub btnmin13_Click(sender As Object, e As EventArgs) Handles btnmin13.Click
        Dim product As New Prices(txtquan13.Text, lblname13.Text, lblprice13.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan13.Text > 0 Then
            txtquan13.Text = Val(txtquan13.Text) - 1
        End If
    End Sub

    Private Sub btnadd13_Click(sender As Object, e As EventArgs) Handles btnadd13.Click
        Dim newItem As New Prices(txtquan13.Text, lblname13.Text, lblprice13.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan13.Text = Val(txtquan13.Text) + 1
    End Sub

    Private Sub btnmin14_Click(sender As Object, e As EventArgs) Handles btnmin14.Click
        Dim product As New Prices(txtquan14.Text, lblname14.Text, lblprice14.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan14.Text > 0 Then
            txtquan14.Text = Val(txtquan14.Text) - 1
        End If
    End Sub

    Private Sub btnadd14_Click(sender As Object, e As EventArgs) Handles btnadd14.Click
        Dim newItem As New Prices(txtquan14.Text, lblname14.Text, lblprice14.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan14.Text = Val(txtquan14.Text) + 1
    End Sub

    Private Sub btnmin15_Click(sender As Object, e As EventArgs) Handles btnmin15.Click
        Dim product As New Prices(txtquan15.Text, lblname15.Text, lblprice15.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan15.Text > 0 Then
            txtquan15.Text = Val(txtquan15.Text) - 1
        End If
    End Sub

    Private Sub btnadd15_Click(sender As Object, e As EventArgs) Handles btnadd15.Click
        Dim newItem As New Prices(txtquan15.Text, lblname15.Text, lblprice15.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan15.Text = Val(txtquan15.Text) + 1
    End Sub

    Private Sub btnmin16_Click(sender As Object, e As EventArgs) Handles btnmin16.Click
        Dim product As New Prices(txtquan16.Text, lblname16.Text, lblprice16.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan16.Text > 0 Then
            txtquan16.Text = Val(txtquan16.Text) - 1
        End If
    End Sub

    Private Sub btnadd16_Click(sender As Object, e As EventArgs) Handles btnadd16.Click
        Dim newItem As New Prices(txtquan16.Text, lblname16.Text, lblprice16.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan16.Text = Val(txtquan16.Text) + 1
    End Sub

    Private Sub btnmin17_Click(sender As Object, e As EventArgs) Handles btnmin17.Click
        Dim product As New Prices(txtquan17.Text, lblname17.Text, lblprice17.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan17.Text > 0 Then
            txtquan17.Text = Val(txtquan17.Text) - 1
        End If
    End Sub

    Private Sub btnadd17_Click(sender As Object, e As EventArgs) Handles btnadd17.Click
        Dim newItem As New Prices(txtquan17.Text, lblname17.Text, lblprice17.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan17.Text = Val(txtquan17.Text) + 1
    End Sub

    Private Sub btnmin18_Click(sender As Object, e As EventArgs) Handles btnmin18.Click
        Dim product As New Prices(txtquan18.Text, lblname18.Text, lblprice18.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan18.Text > 0 Then
            txtquan18.Text = Val(txtquan18.Text) - 1
        End If
    End Sub

    Private Sub btnadd18_Click(sender As Object, e As EventArgs) Handles btnadd18.Click
        Dim newItem As New Prices(txtquan18.Text, lblname18.Text, lblprice18.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan18.Text = Val(txtquan18.Text) + 1
    End Sub

    Private Sub btnmin19_Click(sender As Object, e As EventArgs) Handles btnmin19.Click
        Dim product As New Prices(txtquan19.Text, lblname19.Text, lblprice19.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan19.Text > 0 Then
            txtquan19.Text = Val(txtquan19.Text) - 1
        End If
    End Sub

    Private Sub btnadd19_Click(sender As Object, e As EventArgs) Handles btnadd19.Click
        Dim newItem As New Prices(txtquan19.Text, lblname19.Text, lblprice19.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan19.Text = Val(txtquan19.Text) + 1
    End Sub

    Private Sub btnmin20_Click(sender As Object, e As EventArgs) Handles btnmin20.Click
        Dim product As New Prices(txtquan20.Text, lblname20.Text, lblprice20.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan20.Text > 0 Then
            txtquan20.Text = Val(txtquan20.Text) - 1
        End If
    End Sub

    Private Sub btnadd20_Click(sender As Object, e As EventArgs) Handles btnadd20.Click
        Dim newItem As New Prices(txtquan20.Text, lblname20.Text, lblprice20.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan20.Text = Val(txtquan20.Text) + 1
    End Sub

    Private Sub btnmin21_Click(sender As Object, e As EventArgs) Handles btnmin21.Click
        Dim product As New Prices(txtquan21.Text, lblname21.Text, lblprice21.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan21.Text > 0 Then
            txtquan21.Text = Val(txtquan21.Text) - 1
        End If
    End Sub

    Private Sub btnadd21_Click(sender As Object, e As EventArgs) Handles btnadd21.Click
        Dim newItem As New Prices(txtquan21.Text, lblname21.Text, lblprice21.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan21.Text = Val(txtquan21.Text) + 1
    End Sub

    Private Sub btnmin22_Click(sender As Object, e As EventArgs) Handles btnmin22.Click
        Dim product As New Prices(txtquan22.Text, lblname22.Text, lblprice22.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan22.Text > 0 Then
            txtquan22.Text = Val(txtquan22.Text) - 1
        End If
    End Sub

    Private Sub btnadd22_Click_1(sender As Object, e As EventArgs) Handles btnadd87.Click
        Dim newItem As New Prices(txtquan87.Text, lblname87.Text, lblprice87.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan22.Text = Val(txtquan22.Text) + 1
    End Sub

    Private Sub btnadd22_Click(sender As Object, e As EventArgs) Handles btnadd22.Click
        Dim newItem As New Prices(txtquan22.Text, lblname22.Text, lblprice22.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan22.Text = Val(txtquan22.Text) + 1
    End Sub

    Private Sub btnmin23_Click(sender As Object, e As EventArgs) Handles btnmin23.Click
        Dim product As New Prices(txtquan23.Text, lblname23.Text, lblprice23.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan23.Text > 0 Then
            txtquan23.Text = Val(txtquan23.Text) - 1
        End If
    End Sub

    Private Sub btnadd23_Click(sender As Object, e As EventArgs) Handles btnadd23.Click
        Dim newItem As New Prices(txtquan23.Text, lblname23.Text, lblprice23.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan23.Text = Val(txtquan23.Text) + 1
    End Sub

    Private Sub btnmin24_Click(sender As Object, e As EventArgs) Handles btnmin24.Click
        Dim product As New Prices(txtquan24.Text, lblname24.Text, lblprice24.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan24.Text > 0 Then
            txtquan24.Text = Val(txtquan24.Text) - 1
        End If
    End Sub

    Private Sub btnadd24_Click(sender As Object, e As EventArgs) Handles btnadd24.Click
        Dim newItem As New Prices(txtquan24.Text, lblname24.Text, lblprice24.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan24.Text = Val(txtquan24.Text) + 1
    End Sub

    Private Sub btnmin25_Click(sender As Object, e As EventArgs) Handles btnmin25.Click
        Dim product As New Prices(txtquan25.Text, lblname25.Text, lblprice25.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan25.Text > 0 Then
            txtquan25.Text = Val(txtquan25.Text) - 1
        End If
    End Sub

    Private Sub btnadd25_Click(sender As Object, e As EventArgs) Handles btnadd25.Click
        Dim newItem As New Prices(txtquan25.Text, lblname25.Text, lblprice25.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan25.Text = Val(txtquan25.Text) + 1
    End Sub

    Private Sub btnmin26_Click(sender As Object, e As EventArgs) Handles btnmin26.Click
        Dim product As New Prices(txtquan26.Text, lblname26.Text, lblprice26.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan26.Text > 0 Then
            txtquan26.Text = Val(txtquan26.Text) - 1
        End If
    End Sub

    Private Sub btnadd26_Click(sender As Object, e As EventArgs) Handles btnadd26.Click
        Dim newItem As New Prices(txtquan26.Text, lblname26.Text, lblprice26.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan26.Text = Val(txtquan26.Text) + 1
    End Sub

    Private Sub btnmin27_Click(sender As Object, e As EventArgs) Handles btnmin27.Click
        Dim product As New Prices(txtquan27.Text, lblname27.Text, lblprice27.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan27.Text > 0 Then
            txtquan27.Text = Val(txtquan27.Text) - 1
        End If
    End Sub

    Private Sub btnadd27_Click(sender As Object, e As EventArgs) Handles btnadd27.Click
        Dim newItem As New Prices(txtquan27.Text, lblname27.Text, lblprice27.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan27.Text = Val(txtquan27.Text) + 1
    End Sub

    Private Sub btnmin28_Click(sender As Object, e As EventArgs) Handles btnmin28.Click
        Dim product As New Prices(txtquan28.Text, lblname28.Text, lblprice28.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan28.Text > 0 Then
            txtquan28.Text = Val(txtquan28.Text) - 1
        End If
    End Sub

    Private Sub btnadd28_Click(sender As Object, e As EventArgs) Handles btnadd28.Click
        Dim newItem As New Prices(txtquan28.Text, lblname28.Text, lblprice28.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan28.Text = Val(txtquan28.Text) + 1
    End Sub

    Private Sub btnmin29_Click(sender As Object, e As EventArgs) Handles btnmin29.Click
        Dim product As New Prices(txtquan29.Text, lblname29.Text, lblprice29.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan29.Text > 0 Then
            txtquan29.Text = Val(txtquan29.Text) - 1
        End If
    End Sub

    Private Sub btnadd29_Click(sender As Object, e As EventArgs) Handles btnadd29.Click
        Dim newItem As New Prices(txtquan29.Text, lblname29.Text, lblprice29.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan29.Text = Val(txtquan29.Text) + 1
    End Sub



    Private Sub btnmin30_Click(sender As Object, e As EventArgs) Handles btnmin30.Click
        Dim product As New Prices(txtquan30.Text, lblname30.Text, lblprice30.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan30.Text > 0 Then
            txtquan30.Text = Val(txtquan30.Text) - 1
        End If
    End Sub

    Private Sub btnadd30_Click(sender As Object, e As EventArgs) Handles btnadd30.Click
        Dim newItem As New Prices(txtquan30.Text, lblname30.Text, lblprice30.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan30.Text = Val(txtquan30.Text) + 1
    End Sub

    Private Sub btnmin31_Click(sender As Object, e As EventArgs) Handles btnmin31.Click
        Dim product As New Prices(txtquan28.Text, lblname31.Text, lblprice31.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan31.Text > 0 Then
            txtquan31.Text = Val(txtquan31.Text) - 1
        End If
    End Sub

    Private Sub btnadd31_Click(sender As Object, e As EventArgs) Handles btnadd31.Click
        Dim newItem As New Prices(txtquan28.Text, lblname31.Text, lblprice31.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan31.Text = Val(txtquan31.Text) + 1
    End Sub

    Private Sub btnmin32_Click(sender As Object, e As EventArgs) Handles btnmin32.Click
        Dim product As New Prices(txtquan32.Text, lblname32.Text, lblprice32.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan32.Text > 0 Then
            txtquan32.Text = Val(txtquan32.Text) - 1
        End If
    End Sub

    Private Sub btnadd32_Click(sender As Object, e As EventArgs) Handles btnadd32.Click
        Dim newItem As New Prices(txtquan32.Text, lblname32.Text, lblprice32.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan32.Text = Val(txtquan32.Text) + 1
    End Sub

    Private Sub btnmin33_Click(sender As Object, e As EventArgs) Handles btnmin33.Click
        Dim product As New Prices(txtquan33.Text, lblname33.Text, lblprice33.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan33.Text > 0 Then
            txtquan33.Text = Val(txtquan33.Text) - 1
        End If
    End Sub

    Private Sub btnadd33_Click(sender As Object, e As EventArgs) Handles btnadd33.Click
        Dim newItem As New Prices(txtquan33.Text, lblname33.Text, lblprice33.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan33.Text = Val(txtquan33.Text) + 1
    End Sub

    Private Sub btnmin34_Click(sender As Object, e As EventArgs) Handles btnmin34.Click
        Dim product As New Prices(txtquan34.Text, lblname34.Text, lblprice34.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan34.Text > 0 Then
            txtquan34.Text = Val(txtquan34.Text) - 1
        End If
    End Sub

    Private Sub btnadd34_Click(sender As Object, e As EventArgs) Handles btnadd34.Click
        Dim newItem As New Prices(txtquan34.Text, lblname34.Text, lblprice34.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan34.Text = Val(txtquan34.Text) + 1
    End Sub

    Private Sub btnmin35_Click(sender As Object, e As EventArgs) Handles btnmin35.Click
        Dim product As New Prices(txtquan35.Text, lblname35.Text, lblprice35.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan35.Text > 0 Then
            txtquan35.Text = Val(txtquan35.Text) - 1
        End If
    End Sub

    Private Sub btnadd35_Click(sender As Object, e As EventArgs) Handles btnadd35.Click
        Dim newItem As New Prices(txtquan35.Text, lblname35.Text, lblprice35.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan35.Text = Val(txtquan35.Text) + 1
    End Sub

    Private Sub btnmin36_Click(sender As Object, e As EventArgs) Handles btnmin36.Click
        Dim product As New Prices(txtquan36.Text, lblname36.Text, lblprice36.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan36.Text > 0 Then
            txtquan36.Text = Val(txtquan36.Text) - 1
        End If
    End Sub

    Private Sub btnadd36_Click(sender As Object, e As EventArgs) Handles btnadd36.Click
        Dim newItem As New Prices(txtquan36.Text, lblname36.Text, lblprice36.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan36.Text = Val(txtquan36.Text) + 1
    End Sub

    Private Sub btnmin37_Click(sender As Object, e As EventArgs) Handles btnmin37.Click
        Dim product As New Prices(txtquan37.Text, lblname37.Text, lblprice37.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan37.Text > 0 Then
            txtquan37.Text = Val(txtquan37.Text) - 1
        End If
    End Sub

    Private Sub btnadd37_Click(sender As Object, e As EventArgs) Handles btnadd37.Click
        Dim newItem As New Prices(txtquan37.Text, lblname37.Text, lblprice37.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan37.Text = Val(txtquan37.Text) + 1
    End Sub

    Private Sub btnmin38_Click(sender As Object, e As EventArgs) Handles btnmin38.Click
        Dim product As New Prices(txtquan38.Text, lblname38.Text, lblprice38.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan38.Text > 0 Then
            txtquan38.Text = Val(txtquan38.Text) - 1
        End If
    End Sub

    Private Sub btnadd38_Click(sender As Object, e As EventArgs) Handles btnadd38.Click
        Dim newItem As New Prices(txtquan38.Text, lblname38.Text, lblprice38.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan38.Text = Val(txtquan38.Text) + 1
    End Sub

    Private Sub btnmin39_Click(sender As Object, e As EventArgs) Handles btnmin39.Click
        Dim product As New Prices(txtquan39.Text, lblname39.Text, lblprice39.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan39.Text > 0 Then
            txtquan39.Text = Val(txtquan39.Text) - 1
        End If
    End Sub

    Private Sub btnadd39_Click(sender As Object, e As EventArgs) Handles btnadd39.Click
        Dim newItem As New Prices(txtquan39.Text, lblname39.Text, lblprice39.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan39.Text = Val(txtquan39.Text) + 1
    End Sub

    Private Sub btnmin40_Click(sender As Object, e As EventArgs) Handles btnmin40.Click
        Dim product As New Prices(txtquan40.Text, lblname40.Text, lblprice40.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan40.Text > 0 Then
            txtquan40.Text = Val(txtquan40.Text) - 1
        End If
    End Sub

    Private Sub btnadd40_Click(sender As Object, e As EventArgs) Handles btnadd40.Click
        Dim newItem As New Prices(txtquan40.Text, lblname40.Text, lblprice40.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan40.Text = Val(txtquan40.Text) + 1
    End Sub

    Private Sub btnmin41_Click(sender As Object, e As EventArgs) Handles btnmin41.Click
        Dim product As New Prices(txtquan41.Text, lblname41.Text, lblprice41.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan41.Text > 0 Then
            txtquan41.Text = Val(txtquan41.Text) - 1
        End If
    End Sub

    Private Sub btnadd41_Click(sender As Object, e As EventArgs) Handles btnadd41.Click
        Dim newItem As New Prices(txtquan41.Text, lblname41.Text, lblprice41.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan41.Text = Val(txtquan41.Text) + 1
    End Sub

    Private Sub btnmin42_Click(sender As Object, e As EventArgs) Handles btnmin42.Click
        Dim product As New Prices(txtquan42.Text, lblname42.Text, lblprice42.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan42.Text > 0 Then
            txtquan42.Text = Val(txtquan42.Text) - 1
        End If
    End Sub

    Private Sub btnadd42_Click(sender As Object, e As EventArgs) Handles btnadd42.Click
        Dim newItem As New Prices(txtquan42.Text, lblname42.Text, lblprice42.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan42.Text = Val(txtquan42.Text) + 1
    End Sub

    Private Sub btnmin43_Click(sender As Object, e As EventArgs) Handles btnmin43.Click
        Dim product As New Prices(txtquan43.Text, lblname43.Text, lblprice43.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan43.Text > 0 Then
            txtquan43.Text = Val(txtquan43.Text) - 1
        End If
    End Sub

    Private Sub btnadd43_Click(sender As Object, e As EventArgs) Handles btnadd43.Click
        Dim newItem As New Prices(txtquan43.Text, lblname43.Text, lblprice43.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan43.Text = Val(txtquan43.Text) + 1
    End Sub

    Private Sub btnmin44_Click(sender As Object, e As EventArgs) Handles btnmin44.Click
        Dim product As New Prices(txtquan44.Text, lblname44.Text, lblprice44.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan44.Text > 0 Then
            txtquan44.Text = Val(txtquan44.Text) - 1
        End If
    End Sub

    Private Sub btnadd44_Click(sender As Object, e As EventArgs) Handles btnadd44.Click
        Dim newItem As New Prices(txtquan44.Text, lblname44.Text, lblprice44.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan44.Text = Val(txtquan44.Text) + 1
    End Sub

    Private Sub btnmin45_Click(sender As Object, e As EventArgs) Handles btnmin45.Click
        Dim product As New Prices(txtquan45.Text, lblname45.Text, lblprice45.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan45.Text > 0 Then
            txtquan45.Text = Val(txtquan45.Text) - 1
        End If
    End Sub

    Private Sub btnadd45_Click(sender As Object, e As EventArgs) Handles btnadd45.Click
        Dim newItem As New Prices(txtquan45.Text, lblname45.Text, lblprice45.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan45.Text = Val(txtquan45.Text) + 1
    End Sub

    Private Sub btnmin46_Click(sender As Object, e As EventArgs) Handles btnmin46.Click
        Dim product As New Prices(txtquan46.Text, lblname46.Text, lblprice46.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan46.Text > 0 Then
            txtquan46.Text = Val(txtquan46.Text) - 1
        End If
    End Sub

    Private Sub btnadd46_Click(sender As Object, e As EventArgs) Handles btnadd46.Click
        Dim newItem As New Prices(txtquan46.Text, lblname46.Text, lblprice46.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan46.Text = Val(txtquan46.Text) + 1
    End Sub

    Private Sub btnmin47_Click(sender As Object, e As EventArgs) Handles btnmin47.Click
        Dim product As New Prices(txtquan47.Text, lblname47.Text, lblprice47.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan47.Text > 0 Then
            txtquan47.Text = Val(txtquan47.Text) - 1
        End If
    End Sub

    Private Sub btnadd47_Click(sender As Object, e As EventArgs) Handles btnadd47.Click
        Dim newItem As New Prices(txtquan47.Text, lblname47.Text, lblprice47.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan47.Text = Val(txtquan47.Text) + 1
    End Sub

    Private Sub btnmin48_Click(sender As Object, e As EventArgs) Handles btnmin48.Click
        Dim product As New Prices(txtquan48.Text, lblname48.Text, lblprice48.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan48.Text > 0 Then
            txtquan48.Text = Val(txtquan48.Text) - 1
        End If
    End Sub

    Private Sub btnadd48_Click(sender As Object, e As EventArgs) Handles btnadd48.Click
        Dim newItem As New Prices(txtquan48.Text, lblname48.Text, lblprice48.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan48.Text = Val(txtquan48.Text) + 1
    End Sub

    Private Sub btnmin49_Click(sender As Object, e As EventArgs) Handles btnmin49.Click
        Dim product As New Prices(txtquan49.Text, lblname49.Text, lblprice49.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan49.Text > 0 Then
            txtquan49.Text = Val(txtquan49.Text) - 1
        End If
    End Sub

    Private Sub btnadd49_Click(sender As Object, e As EventArgs) Handles btnadd49.Click
        Dim newItem As New Prices(txtquan49.Text, lblname49.Text, lblprice49.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan49.Text = Val(txtquan49.Text) + 1
    End Sub

    Private Sub btnmin50_Click(sender As Object, e As EventArgs) Handles btnmin50.Click
        Dim product As New Prices(txtquan50.Text, lblname50.Text, lblprice50.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan50.Text > 0 Then
            txtquan50.Text = Val(txtquan50.Text) - 1
        End If
    End Sub

    Private Sub btnadd50_Click(sender As Object, e As EventArgs) Handles btnadd50.Click
        Dim newItem As New Prices(txtquan50.Text, lblname50.Text, lblprice50.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan50.Text = Val(txtquan50.Text) + 1
    End Sub

    Private Sub btnmin51_Click(sender As Object, e As EventArgs) Handles btnmin51.Click
        Dim product As New Prices(txtquan51.Text, lblname51.Text, lblprice51.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan51.Text > 0 Then
            txtquan51.Text = Val(txtquan51.Text) - 1
        End If
    End Sub

    Private Sub btnadd51_Click(sender As Object, e As EventArgs) Handles btnadd51.Click
        Dim newItem As New Prices(txtquan51.Text, lblname51.Text, lblprice51.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan51.Text = Val(txtquan51.Text) + 1
    End Sub

    Private Sub btnmin52_Click(sender As Object, e As EventArgs) Handles btnmin52.Click
        Dim product As New Prices(txtquan52.Text, lblname52.Text, lblprice52.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan52.Text > 0 Then
            txtquan52.Text = Val(txtquan52.Text) - 1
        End If
    End Sub

    Private Sub btnadd52_Click(sender As Object, e As EventArgs) Handles btnadd52.Click
        Dim newItem As New Prices(txtquan52.Text, lblname52.Text, lblprice52.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan52.Text = Val(txtquan52.Text) + 1
    End Sub

    Private Sub btnmin53_Click(sender As Object, e As EventArgs) Handles btnmin53.Click
        Dim product As New Prices(txtquan53.Text, lblname53.Text, lblprice53.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan53.Text > 0 Then
            txtquan53.Text = Val(txtquan53.Text) - 1
        End If
    End Sub

    Private Sub btnadd53_Click(sender As Object, e As EventArgs) Handles btnadd53.Click
        Dim newItem As New Prices(txtquan53.Text, lblname53.Text, lblprice53.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan53.Text = Val(txtquan53.Text) + 1
    End Sub


    Private Sub btnmin54_Click(sender As Object, e As EventArgs) Handles btnmin54.Click
        Dim product As New Prices(txtquan54.Text, lblname54.Text, lblprice54.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan54.Text > 0 Then
            txtquan54.Text = Val(txtquan54.Text) - 1
        End If
    End Sub

    Private Sub btnadd54_Click(sender As Object, e As EventArgs) Handles btnadd54.Click
        Dim newItem As New Prices(txtquan54.Text, lblname54.Text, lblprice54.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan54.Text = Val(txtquan54.Text) + 1
    End Sub

    Private Sub btnmin55_Click(sender As Object, e As EventArgs) Handles btnmin55.Click
        Dim product As New Prices(txtquan55.Text, lblname55.Text, lblprice55.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan55.Text > 0 Then
            txtquan55.Text = Val(txtquan55.Text) - 1
        End If
    End Sub

    Private Sub btnadd55_Click(sender As Object, e As EventArgs) Handles btnadd55.Click
        Dim newItem As New Prices(txtquan55.Text, lblname55.Text, lblprice55.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan55.Text = Val(txtquan55.Text) + 1
    End Sub

    Private Sub btnmin56_Click(sender As Object, e As EventArgs) Handles btnmin56.Click
        Dim product As New Prices(txtquan56.Text, lblname56.Text, lblprice56.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan56.Text > 0 Then
            txtquan56.Text = Val(txtquan56.Text) - 1
        End If
    End Sub

    Private Sub btnadd56_Click(sender As Object, e As EventArgs) Handles btnadd56.Click
        Dim newItem As New Prices(txtquan56.Text, lblname56.Text, lblprice56.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan56.Text = Val(txtquan56.Text) + 1
    End Sub

    Private Sub btnmin57_Click(sender As Object, e As EventArgs) Handles btnmin57.Click
        Dim product As New Prices(txtquan57.Text, lblname57.Text, lblprice57.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan57.Text > 0 Then
            txtquan57.Text = Val(txtquan57.Text) - 1
        End If
    End Sub

    Private Sub btnadd57_Click(sender As Object, e As EventArgs) Handles btnadd57.Click
        Dim newItem As New Prices(txtquan57.Text, lblname57.Text, lblprice57.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan57.Text = Val(txtquan57.Text) + 1
    End Sub

    Private Sub btnmin58_Click(sender As Object, e As EventArgs) Handles btnmin58.Click
        Dim product As New Prices(txtquan58.Text, lblname58.Text, lblprice58.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan58.Text > 0 Then
            txtquan58.Text = Val(txtquan58.Text) - 1
        End If
    End Sub

    Private Sub btnadd58_Click(sender As Object, e As EventArgs) Handles btnadd58.Click
        Dim newItem As New Prices(txtquan58.Text, lblname58.Text, lblprice58.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan58.Text = Val(txtquan58.Text) + 1
    End Sub

    Private Sub btnmin59_Click(sender As Object, e As EventArgs) Handles btnmin59.Click
        Dim product As New Prices(txtquan59.Text, lblname59.Text, lblprice59.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan59.Text > 0 Then
            txtquan59.Text = Val(txtquan59.Text) - 1
        End If
    End Sub

    Private Sub btnadd59_Click(sender As Object, e As EventArgs) Handles btnadd59.Click
        Dim newItem As New Prices(txtquan59.Text, lblname59.Text, lblprice59.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan59.Text = Val(txtquan59.Text) + 1
    End Sub

    Private Sub btnmin60_Click(sender As Object, e As EventArgs) Handles btnmin60.Click
        Dim product As New Prices(txtquan60.Text, lblname60.Text, lblprice60.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan60.Text > 0 Then
            txtquan60.Text = Val(txtquan60.Text) - 1
        End If
    End Sub

    Private Sub btnadd60_Click(sender As Object, e As EventArgs) Handles btnadd60.Click
        Dim newItem As New Prices(txtquan60.Text, lblname60.Text, lblprice60.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan60.Text = Val(txtquan60.Text) + 1
    End Sub

    Private Sub btnmin61_Click(sender As Object, e As EventArgs) Handles btnmin61.Click
        Dim product As New Prices(txtquan61.Text, lblname61.Text, lblprice61.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan61.Text > 0 Then
            txtquan61.Text = Val(txtquan61.Text) - 1
        End If
    End Sub

    Private Sub btnadd61_Click(sender As Object, e As EventArgs) Handles btnadd61.Click
        Dim newItem As New Prices(txtquan61.Text, lblname61.Text, lblprice61.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan61.Text = Val(txtquan61.Text) + 1
    End Sub

    Private Sub btnmin62_Click(sender As Object, e As EventArgs) Handles btnmin62.Click
        Dim product As New Prices(txtquan62.Text, lblname62.Text, lblprice62.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan62.Text > 0 Then
            txtquan62.Text = Val(txtquan62.Text) - 1
        End If
    End Sub

    Private Sub btnadd62_Click(sender As Object, e As EventArgs) Handles btnadd62.Click
        Dim newItem As New Prices(txtquan62.Text, lblname62.Text, lblprice62.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan62.Text = Val(txtquan62.Text) + 1
    End Sub

    Private Sub btnmin63_Click(sender As Object, e As EventArgs) Handles btnmin63.Click
        Dim product As New Prices(txtquan63.Text, lblname63.Text, lblprice63.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan63.Text > 0 Then
            txtquan63.Text = Val(txtquan63.Text) - 1
        End If
    End Sub

    Private Sub btnadd63_Click(sender As Object, e As EventArgs) Handles btnadd63.Click
        Dim newItem As New Prices(txtquan63.Text, lblname63.Text, lblprice63.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan63.Text = Val(txtquan63.Text) + 1
    End Sub

    Private Sub btnmin64_Click(sender As Object, e As EventArgs) Handles btnmin64.Click
        Dim product As New Prices(txtquan64.Text, lblname64.Text, lblprice64.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan64.Text > 0 Then
            txtquan64.Text = Val(txtquan64.Text) - 1
        End If
    End Sub

    Private Sub btnadd64_Click(sender As Object, e As EventArgs) Handles btnadd64.Click
        Dim newItem As New Prices(txtquan64.Text, lblname64.Text, lblprice64.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan64.Text = Val(txtquan64.Text) + 1
    End Sub

    Private Sub btnmin65_Click(sender As Object, e As EventArgs) Handles btnmin65.Click
        Dim product As New Prices(txtquan65.Text, lblname65.Text, lblprice65.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan65.Text > 0 Then
            txtquan65.Text = Val(txtquan65.Text) - 1
        End If
    End Sub

    Private Sub btnadd65_Click(sender As Object, e As EventArgs) Handles btnadd65.Click
        Dim newItem As New Prices(txtquan65.Text, lblname65.Text, lblprice65.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan65.Text = Val(txtquan65.Text) + 1
    End Sub

    Private Sub btnmin66_Click(sender As Object, e As EventArgs) Handles btnmin66.Click
        Dim product As New Prices(txtquan66.Text, lblname66.Text, lblprice66.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan66.Text > 0 Then
            txtquan66.Text = Val(txtquan66.Text) - 1
        End If
    End Sub

    Private Sub btnadd66_Click(sender As Object, e As EventArgs) Handles btnadd66.Click
        Dim newItem As New Prices(txtquan66.Text, lblname66.Text, lblprice66.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan66.Text = Val(txtquan66.Text) + 1
    End Sub

    Private Sub btnmin67_Click(sender As Object, e As EventArgs) Handles btnmin67.Click
        Dim product As New Prices(txtquan67.Text, lblname67.Text, lblprice67.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan67.Text > 0 Then
            txtquan67.Text = Val(txtquan67.Text) - 1
        End If
    End Sub

    Private Sub btnadd67_Click(sender As Object, e As EventArgs) Handles btnadd67.Click
        Dim newItem As New Prices(txtquan67.Text, lblname67.Text, lblprice67.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan67.Text = Val(txtquan67.Text) + 1
    End Sub

    Private Sub btnmin68_Click(sender As Object, e As EventArgs) Handles btnmin68.Click
        Dim product As New Prices(txtquan68.Text, lblname68.Text, lblprice68.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan68.Text > 0 Then
            txtquan68.Text = Val(txtquan68.Text) - 1
        End If
    End Sub

    Private Sub btnadd68_Click(sender As Object, e As EventArgs) Handles btnadd68.Click
        Dim newItem As New Prices(txtquan68.Text, lblname68.Text, lblprice68.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan68.Text = Val(txtquan68.Text) + 1
    End Sub

    Private Sub btnmin69_Click(sender As Object, e As EventArgs) Handles btnmin69.Click
        Dim product As New Prices(txtquan69.Text, lblname69.Text, lblprice69.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan69.Text > 0 Then
            txtquan69.Text = Val(txtquan69.Text) - 1
        End If
    End Sub

    Private Sub btnadd69_Click(sender As Object, e As EventArgs) Handles btnadd69.Click
        Dim newItem As New Prices(txtquan69.Text, lblname69.Text, lblprice69.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan69.Text = Val(txtquan69.Text) + 1
    End Sub

    Private Sub btnmin70_Click(sender As Object, e As EventArgs) Handles btnmin70.Click
        Dim product As New Prices(txtquan70.Text, lblname70.Text, lblprice70.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan70.Text > 0 Then
            txtquan70.Text = Val(txtquan70.Text) - 1
        End If
    End Sub

    Private Sub btnadd70_Click(sender As Object, e As EventArgs) Handles btnadd70.Click
        Dim newItem As New Prices(txtquan70.Text, lblname70.Text, lblprice70.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan70.Text = Val(txtquan70.Text) + 1
    End Sub

    Private Sub btnmin71_Click(sender As Object, e As EventArgs) Handles btnmin71.Click
        Dim product As New Prices(txtquan71.Text, lblname71.Text, lblprice71.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan71.Text > 0 Then
            txtquan71.Text = Val(txtquan71.Text) - 1
        End If
    End Sub

    Private Sub btnadd71_Click(sender As Object, e As EventArgs) Handles btnadd71.Click
        Dim newItem As New Prices(txtquan71.Text, lblname71.Text, lblprice71.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan71.Text = Val(txtquan71.Text) + 1
    End Sub

    Private Sub btnmin72_Click(sender As Object, e As EventArgs) Handles btnmin72.Click
        Dim product As New Prices(txtquan72.Text, lblname72.Text, lblprice72.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan72.Text > 0 Then
            txtquan72.Text = Val(txtquan72.Text) - 1
        End If
    End Sub

    Private Sub btnadd72_Click(sender As Object, e As EventArgs) Handles btnadd72.Click
        Dim newItem As New Prices(txtquan72.Text, lblname72.Text, lblprice72.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan72.Text = Val(txtquan72.Text) + 1
    End Sub

    Private Sub btnmin73_Click(sender As Object, e As EventArgs) Handles btnmin73.Click
        Dim product As New Prices(txtquan73.Text, lblname73.Text, lblprice73.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan73.Text > 0 Then
            txtquan73.Text = Val(txtquan73.Text) - 1
        End If
    End Sub

    Private Sub btnadd73_Click(sender As Object, e As EventArgs) Handles btnadd73.Click
        Dim newItem As New Prices(txtquan73.Text, lblname73.Text, lblprice73.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan73.Text = Val(txtquan73.Text) + 1
    End Sub

    Private Sub btnmin74_Click(sender As Object, e As EventArgs) Handles btnmin74.Click
        Dim product As New Prices(txtquan74.Text, lblname74.Text, lblprice74.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan74.Text > 0 Then
            txtquan74.Text = Val(txtquan74.Text) - 1
        End If
    End Sub

    Private Sub btnadd74_Click(sender As Object, e As EventArgs) Handles btnadd74.Click
        Dim newItem As New Prices(txtquan74.Text, lblname74.Text, lblprice74.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan74.Text = Val(txtquan74.Text) + 1
    End Sub

    Private Sub btnmin75_Click(sender As Object, e As EventArgs) Handles btnmin75.Click
        Dim product As New Prices(txtquan75.Text, lblname75.Text, lblprice75.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan75.Text > 0 Then
            txtquan75.Text = Val(txtquan75.Text) - 1
        End If
    End Sub

    Private Sub btnadd75_Click(sender As Object, e As EventArgs) Handles btnadd75.Click
        Dim newItem As New Prices(txtquan75.Text, lblname75.Text, lblprice75.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan75.Text = Val(txtquan75.Text) + 1
    End Sub

    Private Sub btnmin76_Click(sender As Object, e As EventArgs) Handles btnmin76.Click
        Dim product As New Prices(txtquan76.Text, lblname76.Text, lblprice76.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan76.Text > 0 Then
            txtquan76.Text = Val(txtquan76.Text) - 1
        End If
    End Sub

    Private Sub btnadd76_Click(sender As Object, e As EventArgs) Handles btnadd76.Click
        Dim newItem As New Prices(txtquan76.Text, lblname76.Text, lblprice76.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan76.Text = Val(txtquan76.Text) + 1
    End Sub

    Private Sub btnmin77_Click(sender As Object, e As EventArgs) Handles btnmin77.Click
        Dim product As New Prices(txtquan77.Text, lblname77.Text, lblprice77.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan77.Text > 0 Then
            txtquan77.Text = Val(txtquan77.Text) - 1
        End If
    End Sub

    Private Sub btnadd77_Click(sender As Object, e As EventArgs) Handles btnadd77.Click
        Dim newItem As New Prices(txtquan77.Text, lblname77.Text, lblprice77.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan77.Text = Val(txtquan77.Text) + 1
    End Sub

    Private Sub btnmin78_Click(sender As Object, e As EventArgs) Handles btnmin78.Click
        Dim product As New Prices(txtquan78.Text, lblname78.Text, lblprice78.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan78.Text > 0 Then
            txtquan78.Text = Val(txtquan78.Text) - 1
        End If
    End Sub

    Private Sub btnadd78_Click(sender As Object, e As EventArgs) Handles btnadd78.Click
        Dim newItem As New Prices(txtquan78.Text, lblname78.Text, lblprice78.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan78.Text = Val(txtquan78.Text) + 1
    End Sub

    Private Sub btnmin79_Click(sender As Object, e As EventArgs) Handles btnmin79.Click
        Dim product As New Prices(txtquan79.Text, lblname79.Text, lblprice79.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan79.Text > 0 Then
            txtquan79.Text = Val(txtquan79.Text) - 1
        End If
    End Sub

    Private Sub btnadd79_Click(sender As Object, e As EventArgs) Handles btnadd79.Click
        Dim newItem As New Prices(txtquan79.Text, lblname79.Text, lblprice79.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan79.Text = Val(txtquan79.Text) + 1
    End Sub

    Private Sub btnmin80_Click(sender As Object, e As EventArgs) Handles btnmin80.Click
        Dim product As New Prices(txtquan80.Text, lblname80.Text, lblprice80.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan80.Text > 0 Then
            txtquan80.Text = Val(txtquan80.Text) - 1
        End If
    End Sub

    Private Sub btnadd80_Click(sender As Object, e As EventArgs) Handles btnadd80.Click
        Dim newItem As New Prices(txtquan80.Text, lblname80.Text, lblprice80.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan80.Text = Val(txtquan80.Text) + 1
    End Sub

    Private Sub btnmin81_Click(sender As Object, e As EventArgs) Handles btnmin81.Click
        Dim product As New Prices(txtquan81.Text, lblname81.Text, lblprice81.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan81.Text > 0 Then
            txtquan81.Text = Val(txtquan81.Text) - 1
        End If
    End Sub

    Private Sub btnadd81_Click(sender As Object, e As EventArgs) Handles btnadd81.Click
        Dim newItem As New Prices(txtquan81.Text, lblname81.Text, lblprice81.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan81.Text = Val(txtquan81.Text) + 1
    End Sub

    Private Sub btnmin82_Click(sender As Object, e As EventArgs) Handles btnmin82.Click
        Dim product As New Prices(txtquan82.Text, lblname82.Text, lblprice82.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan82.Text > 0 Then
            txtquan82.Text = Val(txtquan82.Text) - 1
        End If
    End Sub

    Private Sub btnadd82_Click(sender As Object, e As EventArgs) Handles btnadd82.Click
        Dim newItem As New Prices(txtquan82.Text, lblname82.Text, lblprice82.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan82.Text = Val(txtquan82.Text) + 1
    End Sub

    Private Sub btnmin83_Click(sender As Object, e As EventArgs) Handles btnmin83.Click
        Dim product As New Prices(txtquan83.Text, lblname83.Text, lblprice83.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan83.Text > 0 Then
            txtquan83.Text = Val(txtquan83.Text) - 1
        End If
    End Sub

    Private Sub btnadd83_Click(sender As Object, e As EventArgs) Handles btnadd83.Click
        Dim newItem As New Prices(txtquan83.Text, lblname83.Text, lblprice83.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan83.Text = Val(txtquan83.Text) + 1
    End Sub

    Private Sub btnmin84_Click(sender As Object, e As EventArgs) Handles btnmin84.Click
        Dim product As New Prices(txtquan84.Text, lblname84.Text, lblprice84.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan84.Text > 0 Then
            txtquan84.Text = Val(txtquan84.Text) - 1
        End If
    End Sub

    Private Sub btnadd84_Click(sender As Object, e As EventArgs) Handles btnadd84.Click
        Dim newItem As New Prices(txtquan84.Text, lblname84.Text, lblprice84.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan84.Text = Val(txtquan84.Text) + 1
    End Sub

    Private Sub btnmin85_Click(sender As Object, e As EventArgs) Handles btnmin85.Click
        Dim product As New Prices(txtquan85.Text, lblname85.Text, lblprice85.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan85.Text > 0 Then
            txtquan85.Text = Val(txtquan85.Text) - 1
        End If
    End Sub

    Private Sub btnadd85_Click(sender As Object, e As EventArgs) Handles btnadd85.Click
        Dim newItem As New Prices(txtquan85.Text, lblname85.Text, lblprice85.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan85.Text = Val(txtquan85.Text) + 1
    End Sub

    Private Sub btnmin86_Click(sender As Object, e As EventArgs) Handles btnmin86.Click
        Dim product As New Prices(txtquan86.Text, lblname86.Text, lblprice86.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan86.Text > 0 Then
            txtquan86.Text = Val(txtquan86.Text) - 1
        End If
    End Sub

    Private Sub btnadd86_Click(sender As Object, e As EventArgs) Handles btnadd86.Click
        Dim newItem As New Prices(txtquan86.Text, lblname86.Text, lblprice86.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan86.Text = Val(txtquan86.Text) + 1
    End Sub

    Private Sub btnmin87_Click(sender As Object, e As EventArgs) Handles btnmin87.Click
        Dim product As New Prices(txtquan87.Text, lblname87.Text, lblprice87.Text.ToString)
        product.MinusItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        If txtquan87.Text > 0 Then
            txtquan87.Text = Val(txtquan87.Text) - 1
        End If
    End Sub

    Private Sub btnadd87_Click(sender As Object, e As EventArgs) Handles btnadd87.Click
        Dim newItem As New Prices(txtquan87.Text, lblname87.Text, lblprice87.Text.ToString)
        newItem.AddItem(DataGridView1)
        txttotal.Text = total.ToString("C2")
        txtquan87.Text = Val(txtquan87.Text) + 1
    End Sub

    Private Sub pay()
        Dim cash As Decimal
        Dim total As Decimal
        Dim dat As New data
        Try
            If Decimal.TryParse(txtcash.Text.Replace("₱", "").Trim(), cash) AndAlso Decimal.TryParse(txttotal.Text.Replace("₱", "").Trim(), total) Then
                If cash < total Then
                    MsgBox("Insufficient Amount", MsgBoxStyle.Exclamation, "Insufficient Funds")
                Else
                    Dim changeAmount As String = "₱" & (cash - total).ToString("N2")
                    MsgBox("Thanks for your order, please come again!" & vbCrLf & vbCrLf & "Change: " & changeAmount, MsgBoxStyle.Information, "Enjoy Your Order!")
                    con.Open()
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow Then
                            Dim query As String = "INSERT INTO orders(qty, item, price) VALUES (@qty, @item, @price)"
                            Using cmd As New MySqlCommand(query, con)
                                cmd.Parameters.AddWithValue("@qty", row.Cells("colquan").Value)
                                cmd.Parameters.AddWithValue("@item", row.Cells("colitem").Value)
                                cmd.Parameters.AddWithValue("@price", row.Cells("colprice").Value)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next
                    txtquan1.Text = "0"
                    txtquan2.Text = "0"
                    txtquan3.Text = "0"
                    txtquan4.Text = "0"
                    txtquan5.Text = "0"
                    txtquan6.Text = "0"
                    txtquan7.Text = "0"
                    txtquan8.Text = "0"
                    txtquan9.Text = "0"
                    txtquan10.Text = "0"
                    txtquan11.Text = "0"
                    txtquan12.Text = "0"
                    txtquan13.Text = "0"
                    txtquan14.Text = "0"
                    txtquan15.Text = "0"
                    txtquan16.Text = "0"
                    txtquan17.Text = "0"
                    txtquan18.Text = "0"
                    txtquan19.Text = "0"
                    txtquan20.Text = "0"
                    txtquan21.Text = "0"
                    txtquan22.Text = "0"
                    txtquan23.Text = "0"
                    txtquan24.Text = "0"
                    txtquan25.Text = "0"
                    txtquan26.Text = "0"
                    txtquan27.Text = "0"
                    txtquan28.Text = "0"
                    txtquan29.Text = "0"
                    txtquan30.Text = "0"
                    txtquan31.Text = "0"
                    txtquan32.Text = "0"
                    txtquan33.Text = "0"
                    txtquan34.Text = "0"
                    txtquan35.Text = "0"
                    txtquan36.Text = "0"
                    txtquan37.Text = "0"
                    txtquan38.Text = "0"
                    txtquan39.Text = "0"
                    txtquan40.Text = "0"
                    txtquan41.Text = "0"
                    txtquan42.Text = "0"
                    txtquan43.Text = "0"
                    txtquan44.Text = "0"
                    txtquan45.Text = "0"
                    txtquan46.Text = "0"
                    txtquan47.Text = "0"
                    txtquan48.Text = "0"
                    txtquan49.Text = "0"
                    txtquan50.Text = "0"
                    txtquan51.Text = "0"
                    txtquan52.Text = "0"
                    txtquan53.Text = "0"
                    txtquan54.Text = "0"
                    txtquan55.Text = "0"
                    txtquan56.Text = "0"
                    txtquan57.Text = "0"
                    txtquan58.Text = "0"
                    txtquan59.Text = "0"
                    txtquan60.Text = "0"
                    txtquan61.Text = "0"
                    txtquan62.Text = "0"
                    txtquan63.Text = "0"
                    txtquan64.Text = "0"
                    txtquan65.Text = "0"
                    txtquan66.Text = "0"
                    txtquan67.Text = "0"
                    txtquan68.Text = "0"
                    txtquan69.Text = "0"
                    txtquan70.Text = "0"
                    txtquan71.Text = "0"
                    txtquan72.Text = "0"
                    txtquan73.Text = "0"
                    txtquan74.Text = "0"
                    txtquan75.Text = "0"
                    txtquan76.Text = "0"
                    txtquan77.Text = "0"
                    txtquan78.Text = "0"
                    txtquan79.Text = "0"
                    txtquan80.Text = "0"
                    txtquan81.Text = "0"
                    txtquan82.Text = "0"
                    txtquan83.Text = "0"
                    txtquan84.Text = "0"
                    txtquan85.Text = "0"
                    txtquan86.Text = "0"
                    txtquan87.Text = "0"
                    Form2.txttotalrev.Text = dat.totalrev()
                    Form2.txtorders.Text = dat.showorders()
                    dat.showdata2(Form2.DataGridView2)
                    DataGridView1.Rows.Clear()
                    txttotal.Text = "₱0.00"
                    txtcash.Text = ""
                End If
            Else
                MsgBox("Insufficient Amounts, Please enter valid amounts", MsgBoxStyle.Critical, "Invalid Input")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles Btnpay.Click
        pay()
    End Sub
End Class

