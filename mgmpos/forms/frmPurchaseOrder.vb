Imports MySql.Data.MySqlClient

Public Class frmPurchaseOrder
    Dim sqlPO As String

    Private Sub showProducts()
        Try
            dbConnection()
            sql = sqlPO
            cmd = New MySqlCommand
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()

                .ExecuteNonQuery()

            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")

            End If
            dgChooseItems.DataSource = dt
            With dgChooseItems
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Product Code"
                .Columns(0).Width = 100
                .Columns(1).HeaderCell.Value = "Name"
                .Columns(1).Width = 200
                .Columns(2).HeaderCell.Value = "Description"
                .Columns(2).Width = 200
                .Columns(3).HeaderCell.Value = "Qty On Hand"
                .Columns(3).Width = 100

            End With
        End Try
    End Sub
    Private Sub btnViewCritical_Click(sender As Object, e As EventArgs) Handles btnViewCritical.Click
        sqlPO = "select prodcode,prodname,prod_description,prod_begin_qty from product where prod_begin_qty <= prod_reorder_qty;"
        showProducts()
    End Sub

    Private Sub btnAllProducts_Click(sender As Object, e As EventArgs) Handles btnAllProducts.Click
        sqlPO = "select prodcode,prodname,prod_description,prod_begin_qty from product order by prod_begin_qty asc;"
        showProducts()
    End Sub

    Private Sub dgChooseItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgChooseItems.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = dgChooseItems.Rows(index)
            frmPOqty.txtprodcode.Text = row.Cells(0).Value
            frmPOqty.txtProductName.Text = row.Cells(1).Value
            frmPOqty.txtdesc.Text = row.Cells(2).Value
            frmPOqty.ShowDialog()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewPO.Click
        getPOno()
        btnSave.Enabled = True
        btnNewPO.Enabled = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgSelectedItems.RowCount <= 0 Then
            MsgBox("Please select item first!", vbInformation + vbOKOnly, "Select Item")
        ElseIf lblpono.Text = "0000" Then
            MsgBox("Please click new button!", vbInformation + vbOKOnly, "New")
        Else
            runSavePO()

            PrintPurchaseOrder()
            frmReport_product.Show()
            btnSave.Enabled = False
            btnNewPO.Enabled = True
        End If
    End Sub
    Private Sub PrintPurchaseOrder()
        Try
            dbConnection()

            'SELECT * FROM newpost_database.purchaseorder where purno='1'
            'Select Case product.prodname, product.prod_description, purchaseorder.prodcode, purchaseorder.qty, employees_database.User_Level, purchaseorder.podate, purchaseorder.purno
            'FROM(newpost_database.purchaseorder purchaseorder INNER JOIN newpost_database.product product On purchaseorder.prodcode=product.prodcode) INNER JOIN newpost_database.employees_database employees_database On purchaseorder.userid= employees_database.Employee_ID where purno='2';
            '"Select Case product.prodname, product.prod_description, purchaseorder.prodcode, purchaseorder.qty, employees_database.User_Level, purchaseorder.podate,purchaseorder.purno FROM(newpost_database.purchaseorder purchaseorder INNER JOIN newpost_database.product product On purchaseorder.prodcode=product.prodcode) INNER JOIN newpost_database.employees_database employees_database On purchaseorder.userid= employees_database.Employee_ID where purno='1';"
            sql = "SELECT * FROM newpost_database.purchaseorder where purno=@purno;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@purno", lblpono.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New purchaseorder
            report.SetDataSource(dt)
            frmReport_product.GBRemittance.ReportSource = report
            frmReport_product.GBRemittance.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Class