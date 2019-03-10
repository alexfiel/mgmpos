Public Class searchCostumer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCostumer.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = dgCostumer.Rows(index)
            If trans_source = "POS" Then
                frmPosCostumer.txtobjid.Text = row.Cells(0).Value.ToString()
                frmPosCostumer.txtcustorgname.Text = row.Cells(2).Value.ToString()
                frmPosCostumer.txtcustName.Text = row.Cells(3).Value.ToString() + " " + row.Cells(4).Value.ToString()
                frmPosCostumer.txtcustAddress.Text = row.Cells(5).Value.ToString()
                frmPosCostumer.txtcontact.Text = row.Cells(6).Value.ToString()

                Me.Dispose()
            ElseIf trans_source = "COLLECTION" Then
                frmCollection.lblCostId.Text = row.Cells(0).Value.ToString()
                frmCollection.txtcomp.Text = row.Cells(2).Value.ToString()
                frmCollection.txtfname.Text = row.Cells(3).Value.ToString() + " " + row.Cells(4).Value.ToString()
                frmCollection.txtadd.Text = row.Cells(5).Value.ToString()
                frmCollection.txtcontact.Text = row.Cells(6).Value.ToString()
                frmCollection.txtemail.Text = row.Cells(7).Value.ToString()
                Me.Dispose()
                GetCustLedger()

                frmCollection.ShowDialog()

            End If


        End If

    End Sub

    Private Sub txtCustsearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustsearch.TextChanged
        GetCustomerList()
    End Sub
End Class