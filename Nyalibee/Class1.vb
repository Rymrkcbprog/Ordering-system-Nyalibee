Imports MySql.Data.MySqlClient

Public Class Prices

    Private Property Quantity As Integer
    Private Property Item As String
    Private Property Prices As Integer


    Public Sub New(qty As Integer, items As String, price As Integer)
        Quantity = qty
        Item = items
        Prices = price
    End Sub
    Public Sub AddItem(dgv As DataGridView)
        Dim found As Boolean = False
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow AndAlso row.Cells(1).Value = Item Then
                Dim qty As Integer = (row.Cells(0).Value)
                qty += 1
                row.Cells(0).Value = qty
                row.Cells(2).Value = qty * Prices
                found = True
                Exit For
            End If
        Next

        If Not found Then
            Dim qty As Integer = 1
            Dim total As Integer = qty * Prices
            dgv.Rows.Add(qty, Item, total)
        End If
    End Sub

    Public Sub MinusItem(dgv As DataGridView)
        Dim found As Boolean = False

        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow AndAlso row.Cells(1).Value?.ToString() = Item Then
                Dim qty As Integer = (row.Cells(0).Value)
                qty -= 1

                If qty <= 0 Then
                    dgv.Rows.Remove(row)
                Else
                    row.Cells(0).Value = qty
                    row.Cells(2).Value = qty * Prices
                End If

                found = True
                Exit For
            End If
        Next
    End Sub
End Class
