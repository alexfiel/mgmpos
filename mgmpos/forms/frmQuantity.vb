Imports System
Public Class frmQuantity
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        quantity = txtquantity.Text
        discount = txtDiscount.Text
        Calculate()
    End Sub




    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged

    End Sub

    Private Sub txtquantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtquantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtquantity.Text = "" Then
                MsgBox("Please enter quantity!")
                txtquantity.Focus()
            ElseIf CDbl(txtquantity.Text) > CDbl(lblbegQty.Text) Then
                MsgBox("Insufficient Product Inventory, lower the quantity", vbInformation, "Insufficient Inventory!")
                txtquantity.Focus()
            Else

                quantity = txtquantity.Text
                discount = txtDiscount.Text
                Calculate()
            End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtquantity.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class