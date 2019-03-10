Public Class frmReturnItem
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub txttransnoSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txttransnoSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            globalLookup = txttransnoSearch.Text
            getTransctionNo()
        End If
    End Sub

    Private Sub txttransnoSearch_TextChanged(sender As Object, e As EventArgs) Handles txttransnoSearch.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Dim transactionday As DateTime = txttransdate.Text
        Dim datetoday = getServerDate()
        Dim numdays As Int32 = datetoday.Subtract(transactionday).Days
        Dim transobjid As String = Guid.NewGuid().ToString("N")
        POStransobjid = transobjid
        'MsgBox(getServerDate)
        'MsgBox(numdays)
        If numdays <= 30 Then

            If txtreason.Text = "" Then
                MsgBox("Reasons required to return the item/s", vbInformation, "Return Transaction")

            Else
                runReturnItems()
            End If
        Else
            MsgBox("Sorry you cannot return the items it is already beyond the allowed number of days!", vbInformation, "Transaction Date Expired")
        End If

    End Sub



    Private Sub dgtransaction_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgtransaction.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = dgtransaction.Rows(index)
            frmreturnQTY.txtdiscount.Text = row.Cells(11).Value
            frmreturnQTY.txtprodcode.Text = row.Cells(4).Value
            frmreturnQTY.txtprodname.Text = row.Cells(5).Value
            frmreturnQTY.txtqty.Text = "-" + row.Cells(6).Value.ToString
            frmreturnQTY.returnqty = "-" + row.Cells(6).Value.ToString
            frmreturnQTY.txtunitprice.Text = row.Cells(7).Value
            frmreturnQTY.ShowDialog()


        End If
    End Sub

    Private Sub txtprodcode_ret_TextChanged(sender As Object, e As EventArgs) Handles txtprodcode_ret.TextChanged

    End Sub

    Private Sub txtprodcode_ret_KeyDown(sender As Object, e As KeyEventArgs) Handles txtprodcode_ret.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtprodcode_ret.Text = "" Then
                MsgBox("Please Input Barcode / Product Name")

            Else

                checkproductcode_exchangeitem()
            End If
        End If
    End Sub
End Class