Public Class productlookup

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProduct.CellContentClick
        Dim prodBegQty As Double
        Dim prodcode, prodname, unitprice As String

        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = DGProduct.Rows(index)
            prodcode = row.Cells(0).Value
            prodname = row.Cells(1).Value
            unitprice = row.Cells(4).Value
            prodBegQty = row.Cells(5).Value
            MsgBox(prodcode + " " + prodname + " " + unitprice)


            If prodBegQty <= 0 Then
                MsgBox(prodname + " " + "Has no more inventory!")
            ElseIf unitprice <= 0 Then
                MsgBox(prodname + " " + "The items has no price!")
            Else
                If frmPOS.newTrans = False Then
                    MsgBox("Please click the New Button First to add this item", vbInformation + vbOKOnly, "New Button must be Clicked")
                Else
                    frmQuantity.lblpcode.Text = prodcode
                    frmQuantity.lblpdesc.Text = prodname
                    frmQuantity.lblunitprice.Text = unitprice
                    frmQuantity.lblbegQty.Text = prodBegQty
                    Me.Dispose()

                    frmQuantity.txtquantity.Focus()
                    frmQuantity.ShowDialog()

                    frmQuantity.Dispose()
                    frmPOS.cmdCash.Enabled = True
                    frmPOS.cmdCheque.Enabled = True
                    frmPOS.cmdCharge.Enabled = True
                End If

            End If


        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        GetProductLookup()

    End Sub

    Private Sub productlookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class