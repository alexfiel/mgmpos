Public Class frmCheque
    Private Sub frmCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmountDue.Text = postotalamount
        txtCostumer.Focus()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtAmountDue.Text <> txtcheckamount.Text Then
            MsgBox("Cheque Amount must be equal to Amount Due")
        ElseIf txtbankname.Text = "" Then
            MsgBox("Bank Name required")
            txtbankname.Focus()
        ElseIf txtcheckno.Text = "" Then
            MsgBox("Check No required")
            txtcheckno.Focus()
        ElseIf dtcheckdate.Value > Date.Now Then
            MsgBox("Post Dated checks not Allowed!", vbInformation + vbOKOnly, "DATE NOT ALLOWED")
            dtcheckdate.Focus()
        Else

            chequePayment_calc()

        End If
    End Sub

    Private Sub txtcheckamount_TextChanged(sender As Object, e As EventArgs) Handles txtcheckamount.TextChanged

    End Sub

    Private Sub txtcheckamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcheckamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAmountDue.Text <> txtcheckamount.Text Then
                MsgBox("Cheque Amount must be equal to Amount Due")
            ElseIf txtbankname.Text = "" Then
                MsgBox("Bank Name required")
                txtbankname.Focus()
            ElseIf txtcheckno.Text = "" Then
                MsgBox("Check No required")
                txtcheckno.Focus()
            ElseIf dtcheckdate.Value > Date.Now Then
                MsgBox("Post Dated checks not Allowed!", vbInformation + vbOKOnly, "DATE NOT ALLOWED")
                dtcheckdate.Focus()
            Else

                chequePayment_calc()


            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtCostumer_TextChanged(sender As Object, e As EventArgs) Handles txtCostumer.TextChanged

    End Sub

    Private Sub txtCostumer_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCostumer.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtAddress.Enabled = True
            txtAddress.Focus()

        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtbankname.Focus()
        End If
    End Sub

    Private Sub txtbankname_TextChanged(sender As Object, e As EventArgs) Handles txtbankname.TextChanged

    End Sub

    Private Sub txtbankname_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbankname.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtcheckno.Focus()

        End If
    End Sub

    Private Sub txtcheckno_TextChanged(sender As Object, e As EventArgs) Handles txtcheckno.TextChanged

    End Sub

    Private Sub txtcheckno_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcheckno.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtcheckdate.Focus()
        End If
    End Sub

    Private Sub dtcheckdate_ValueChanged(sender As Object, e As EventArgs) Handles dtcheckdate.ValueChanged
        If dtcheckdate.Value > Date.Today Then
            MsgBox("POST DATED CHEQUE'S IS NOT ALLOWED", vbInformation, "POST DATED")
        End If
    End Sub
End Class