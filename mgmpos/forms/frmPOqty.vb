Public Class frmPOqty
    Dim qty As Double
    Dim found As Boolean
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        qty = CDbl(txtqty.Text)
        If frmPurchaseOrder.dgSelectedItems.RowCount > 0 Then
            'check whether the product already added in the selection
            For Each row As DataGridViewRow In frmPurchaseOrder.dgSelectedItems.Rows
                If CType(row.Cells(0).Value, String) = Me.txtprodcode.Text Then
                    row.Cells(3).Value = CType(row.Cells(3).Value, Double) + qty
                    found = True
                    Me.Dispose()
                End If
            Next
            If Not found Then
                frmPurchaseOrder.dgSelectedItems.Rows.Add(New String() {Me.txtprodcode.Text, Me.txtProductName.Text, Me.txtdesc.Text, Me.txtqty.Text})
                Me.Dispose()
            End If
        Else
            frmPurchaseOrder.dgSelectedItems.Rows.Add(New String() {Me.txtprodcode.Text, Me.txtProductName.Text, Me.txtdesc.Text, Me.txtqty.Text})
            Me.Dispose()
        End If

    End Sub
End Class