Public Class frmReturnItem
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub txttransnoSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txttransnoSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            getTransctionNo()
        End If
    End Sub

    Private Sub txttransnoSearch_TextChanged(sender As Object, e As EventArgs) Handles txttransnoSearch.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transactionday As DateTime = txttransdate.Text
        Dim datetoday = getServerDate()
        Dim numdays As Int32 = datetoday.Subtract(transactionday).Days
        MsgBox(getServerDate)
        MsgBox(numdays)
        If numdays <= 30 Then
            If txtreason.Text = "" Then
                MsgBox("Reasons required to return the item/s", vbInformation, "Return Transaction")

            End If
        Else
            MsgBox("Sorry you cannot return the items it is already beyond the allowed number of days!", vbInformation, "Transaction Date Expired")
        End If

    End Sub



End Class