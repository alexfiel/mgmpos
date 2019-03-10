Public Class frmreturnQTY
    Public returnqty As Integer
    Private Sub cmdcancel_Click(sender As Object, e As EventArgs) Handles cmdcancel.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim count As Integer
        count = txtqty.Text
        count += 1
        txtqty.Text = count.ToString

        If txtqty.Text = -1 Then
            Button1.Enabled = False
            Button2.Enabled = True
        End If

    End Sub

    Private Sub frmreturnQTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Integer
        count = txtqty.Text
        count -= 1
        txtqty.Text = count.ToString

        If txtqty.Text = returnqty Then
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub cmdok_Click(sender As Object, e As EventArgs) Handles cmdok.Click
        'Dim TotalGrossAmount, TotalAmountDue, discount As Double

        'discount = txtdiscount.Text
        'If vat = 0 Then
        '    TotalGrossAmount = txtqty.Text * txtunitprice.Text
        '    TotalAmountDue = TotalGrossAmount + discount
        '    vatprice = TotalGrossAmount / 112 * 100 * vat
        '    frmReturnItem.txtReturnSubTotal.Text = frmReturnItem.txtReturnSubTotal.Text + TotalAmountDue
        '    frmReturnItem.txtReturnVat.Text = frmReturnItem.txtReturnVat.Text + vatprice
        '    frmReturnItem.txtReturnDiscount.Text = frmReturnItem.txtReturnDiscount.Text + discount


        'End If
        Dim found As Boolean = False
        quantity = txtqty.Text
        discount = txtdiscount.Text
        If vat = 0.12 Then
            totalunitprice = txtunitprice.Text * quantity + discount
            vatprice = totalunitprice / 112 * 100 * vat
            newprice = totalunitprice - vatprice

            frmReturnItem.txtReturnSubTotal.Text = Format((frmReturnItem.txtReturnSubTotal.Text + newprice), "#,##0.00")
            frmReturnItem.txtReturnVat.Text = Format((frmReturnItem.txtReturnVat.Text + vatprice), "#,##0.00")
            frmReturnItem.txtReturnDiscount.Text = Format((frmReturnItem.txtReturnDiscount.Text + discount), "#,##0.00")
            postotalamount = Format((frmReturnItem.txtReturnTotalAmount.Text + totalunitprice), "#,##0.00")
            frmReturnItem.txtReturnTotalAmount.Text = Format((postotalamount), "#,##0.00")

            'postotalamount = postotal
            If frmReturnItem.dgReturnItems.Rows.Count > 0 Then
                'check if product exist
                For Each row As DataGridViewRow In frmReturnItem.dgReturnItems.Rows
                    If CType(row.Cells(0).Value, String) = txtprodcode.Text Then
                        row.Cells(4).Value = CType(row.Cells(4).Value, Double) + discount
                        row.Cells(3).Value = CType(row.Cells(3).Value, Double) + quantity
                        row.Cells(5).Value = CType(row.Cells(5).Value, Double) + totalunitprice
                        found = True
                    End If
                Next
                If Not found Then
                    frmReturnItem.dgReturnItems.Rows.Add(New String() {txtprodcode.Text, txtprodname.Text, txtunitprice.Text, quantity, txtdiscount.Text, totalunitprice})
                    frmReturnItem.txtprodcode_ret.Text = ""
                    frmReturnItem.txtprodcode_ret.Focus()
                End If
            Else
                frmReturnItem.dgReturnItems.Rows.Add(New String() {txtprodcode.Text, txtprodname.Text, txtunitprice.Text, quantity, txtdiscount.Text, totalunitprice})
                frmReturnItem.txtprodcode_ret.Text = ""
                frmReturnItem.txtprodcode_ret.Focus()
            End If


            Me.Dispose()
            'ElseIf vat = 0 Then
            '    totalunitprice = frmQuantity.lblunitprice.Text * quantity
            '    frmPOS.lbltotalamount.Text = Format((frmPOS.lbltotalamount.Text + totalunitprice), "#,##0.00")
            '    frmPOS.lblGrandtotal.Text = Format((frmPOS.lblGrandtotal.Text + totalunitprice), "#,##0.00")


            '    frmPOS.DGProduct.Rows.Add(New String() {frmQuantity.lblpcode.Text, frmQuantity.lblpdesc.Text, frmQuantity.lblunitprice.Text, quantity, totalunitprice})
            '    frmPOS.txtPOSearch.Text = ""
            '    frmPOS.txtPOSearch.Focus()
            '    frmQuantity.Close()
        ElseIf vat = 0 Then
            totalunitprice = txtunitprice.Text * quantity + discount
            vatprice = totalunitprice / 112 * 100 * vat
            newprice = totalunitprice - vatprice

            frmReturnItem.txtReturnSubTotal.Text = Format((frmReturnItem.txtReturnSubTotal.Text + newprice), "#,##0.00")
            frmReturnItem.txtReturnVat.Text = Format((frmReturnItem.txtReturnVat.Text + vatprice), "#,##0.00")
            frmReturnItem.txtReturnDiscount.Text = Format((frmReturnItem.txtReturnDiscount.Text + discount), "#,##0.00")
            postotalamount = Format((frmReturnItem.txtReturnTotalAmount.Text + totalunitprice), "#,##0.00")
            frmReturnItem.txtReturnTotalAmount.Text = Format((postotalamount), "#,##0.00")

            'postotalamount = postotal
            If frmReturnItem.dgReturnItems.Rows.Count > 0 Then
                'check if product exist
                For Each row As DataGridViewRow In frmReturnItem.dgReturnItems.Rows
                    If CType(row.Cells(0).Value, String) = txtprodcode.Text Then
                        row.Cells(4).Value = CType(row.Cells(4).Value, Double) + discount
                        row.Cells(3).Value = CType(row.Cells(3).Value, Double) + quantity
                        row.Cells(5).Value = CType(row.Cells(5).Value, Double) + totalunitprice
                        found = True
                    End If
                Next
                If Not found Then
                    frmReturnItem.dgReturnItems.Rows.Add(New String() {txtprodcode.Text, txtprodname.Text, txtunitprice.Text, quantity, txtdiscount.Text, totalunitprice})
                    frmReturnItem.txtprodcode_ret.Text = ""
                    frmReturnItem.txtprodcode_ret.Focus()
                End If
            Else
                frmReturnItem.dgReturnItems.Rows.Add(New String() {txtprodcode.Text, txtprodname.Text, txtunitprice.Text, quantity, txtdiscount.Text, totalunitprice})
                frmReturnItem.txtprodcode_ret.Text = ""
                frmReturnItem.txtprodcode_ret.Focus()
            End If


            Me.Dispose()


        End If


    End Sub
End Class