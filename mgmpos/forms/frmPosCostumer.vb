Public Class frmPosCostumer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub frmPosCostumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtamountdue.Text = postotalamount
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        searchCostumer.ShowDialog()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Date3 As DateTime = Now
        lblTermUntil.Text = Date3.AddMonths(ComboBox1.Text).ToString("yyyy-MM-dd")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("You are about to save the transaction. Are you sure you want to save?", vbYesNo + vbQuestion, "Save") = vbYes Then
            runtransaction_termpayment()
            frmPOS.newTrans = False
        Else
            Button2.Focus()
        End If

    End Sub
End Class