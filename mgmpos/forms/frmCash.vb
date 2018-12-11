Public Class frmCash
    'Dim AmountDue, cashtendered, change As Double

    'Private Sub calc()
    '    AmountDue = txtAmountDue.Text
    '    cashtendered = txtCashTendered.Text
    '    change = cashtendered - AmountDue

    '    txtchange.Text = change

    'End Sub


    Private Sub frmCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = True
        txtCostumer.Focus()
        txtCashTendered.Enabled = False
        txtAmountDue.Text = postotalamount

    End Sub



    Private Sub txtCashTendered_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCashTendered.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtCashTendered.Text = "" Then
                MsgBox("Please enter an amount!", vbOKOnly + vbInformation, "Enter Amount")
            Else
                calc()
                frmPOS.lblcashtendered.Text = txtCashTendered.Text
                frmPOS.lblchange.Text = txtchange.Text
                frmPOS.txtPOSearch.Enabled = False
                'txtCashTendered.Enabled = False

                ' txtAddress.Enabled = False




            End If

        End If
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtCashTendered.Text = "" Then
            MsgBox("Please enter an amount!", vbOKOnly + vbInformation, "Enter Amount")
        Else
            calc()
            frmPOS.lblcashtendered.Text = txtCashTendered.Text
            frmPOS.lblcashtendered2.Text = txtCashTendered.Text

            frmPOS.lblchange.Text = txtchange.Text
            frmPOS.txtPOSearch.Enabled = False
            'txtCashTendered.Enabled = False

            ' txtAddress.Enabled = False







        End If
    End Sub

    Private Sub txtCashTendered_TextChanged(sender As Object, e As EventArgs) Handles txtCashTendered.TextChanged

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtCostumer_TextChanged(sender As Object, e As EventArgs)
        txtAddress.Enabled = True
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs)
        txtCashTendered.Enabled = True


    End Sub




    Private Sub txtCostumer_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCostumer.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtAddress.Enabled = True
            txtAddress.Focus()

        End If
    End Sub

    Private Sub txtAddress_TextChanged_1(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtCashTendered.Enabled = True
            txtCashTendered.Focus()


        End If
    End Sub

    Private Sub txtchange_TextChanged(sender As Object, e As EventArgs) Handles txtchange.TextChanged

    End Sub
End Class