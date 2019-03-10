Public Class frmAddPayment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        modepayment = "Collection"
        If MsgBox("You are about to save the transaction. Are you sure you want to save?", vbYesNo + vbQuestion, "Save") = vbYes Then
            runAddPaymentCollection()

        Else
            Button2.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newNumber As String
        newNumber = transno.Text + lblPaymentTransNo.Text
        MsgBox(newNumber)
    End Sub
End Class