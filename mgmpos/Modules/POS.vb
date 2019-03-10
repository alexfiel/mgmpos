Imports MySql.Data.MySqlClient
Module POS
    'Private m_frmPOS As frmPOS
    'Public ReadOnly Property frmPOS As frmPOS
    '    Get
    '        If IsNothing(m_frmPOS) Then m_frmPOS = New frmPOS
    '        Return m_frmPOS
    '    End Get
    'End Property
    Public Sub Calculate()
        Dim found As Boolean = False
        If vat = 0.12 Then
            totalunitprice = frmQuantity.lblunitprice.Text * quantity - discount
            vatprice = totalunitprice / 112 * 100 * vat
            newprice = totalunitprice - vatprice

            frmPOS.lbltotalamount.Text = Format((frmPOS.lbltotalamount.Text + newprice), "#,##0.00")
            frmPOS.lblVat.Text = Format((frmPOS.lblVat.Text + vatprice), "#,##0.00")
            frmPOS.lblDiscount.Text = Format((frmPOS.lblDiscount.Text + discount), "#,##0.00")
            postotalamount = Format((frmPOS.lblGrandtotal.Text + totalunitprice), "#,##0.00")
            frmPOS.lblGrandtotal.Text = Format((postotalamount), "#,##0.00")

            'postotalamount = postotal
            If frmPOS.DGProduct.Rows.Count > 0 Then
                'check if product exist
                For Each row As DataGridViewRow In frmPOS.DGProduct.Rows
                    If CType(row.Cells(0).Value, String) = frmQuantity.lblpcode.Text Then
                        row.Cells(3).Value = CType(row.Cells(3).Value, Double) + discount
                        row.Cells(4).Value = CType(row.Cells(4).Value, Double) + quantity
                        row.Cells(5).Value = CType(row.Cells(5).Value, Double) + totalunitprice
                        found = True
                    End If
                Next
                If Not found Then
                    frmPOS.DGProduct.Rows.Add(New String() {frmQuantity.lblpcode.Text, frmQuantity.lblpdesc.Text, frmQuantity.lblunitprice.Text, frmQuantity.txtDiscount.Text, quantity, totalunitprice})
                    frmPOS.txtPOSearch.Text = ""
                    frmPOS.txtPOSearch.Focus()
                End If
            Else
                frmPOS.DGProduct.Rows.Add(New String() {frmQuantity.lblpcode.Text, frmQuantity.lblpdesc.Text, frmQuantity.lblunitprice.Text, frmQuantity.txtDiscount.Text, quantity, totalunitprice})
                frmPOS.txtPOSearch.Text = ""
                frmPOS.txtPOSearch.Focus()
            End If


            frmQuantity.Close()
            'ElseIf vat = 0 Then
            '    totalunitprice = frmQuantity.lblunitprice.Text * quantity
            '    frmPOS.lbltotalamount.Text = Format((frmPOS.lbltotalamount.Text + totalunitprice), "#,##0.00")
            '    frmPOS.lblGrandtotal.Text = Format((frmPOS.lblGrandtotal.Text + totalunitprice), "#,##0.00")


            '    frmPOS.DGProduct.Rows.Add(New String() {frmQuantity.lblpcode.Text, frmQuantity.lblpdesc.Text, frmQuantity.lblunitprice.Text, quantity, totalunitprice})
            '    frmPOS.txtPOSearch.Text = ""
            '    frmPOS.txtPOSearch.Focus()
            '    frmQuantity.Close()
        ElseIf vat = 0 Then
            totalunitprice = frmQuantity.lblunitprice.Text * quantity - discount
            vatprice = 0
            newprice = totalunitprice - vatprice

            frmPOS.lbltotalamount.Text = Format((frmPOS.lbltotalamount.Text + newprice), "#,##0.00")
            frmPOS.lblVat.Text = Format((frmPOS.lblVat.Text + vatprice), "#,##0.00")
            frmPOS.lblDiscount.Text = Format((frmPOS.lblDiscount.Text + discount), "#,##0.00")
            postotalamount = Format((frmPOS.lblGrandtotal.Text + totalunitprice), "#,##0.00")
            frmPOS.lblGrandtotal.Text = Format((postotalamount), "#,##0.00")

            'postotalamount = postotal
            If frmPOS.DGProduct.Rows.Count > 0 Then
                'check if product exist
                For Each row As DataGridViewRow In frmPOS.DGProduct.Rows
                    If CType(row.Cells(0).Value, String) = frmQuantity.lblpcode.Text Then
                        row.Cells(3).Value = CType(row.Cells(3).Value, Double) + discount
                        row.Cells(4).Value = CType(row.Cells(4).Value, Double) + quantity
                        row.Cells(5).Value = CType(row.Cells(5).Value, Double) + totalunitprice
                        found = True
                    End If
                Next
                If Not found Then
                    frmPOS.DGProduct.Rows.Add(New String() {frmQuantity.lblpcode.Text, frmQuantity.lblpdesc.Text, frmQuantity.lblunitprice.Text, frmQuantity.txtDiscount.Text, quantity, totalunitprice})
                    frmPOS.txtPOSearch.Text = ""
                    frmPOS.txtPOSearch.Focus()
                End If
            Else
                frmPOS.DGProduct.Rows.Add(New String() {frmQuantity.lblpcode.Text, frmQuantity.lblpdesc.Text, frmQuantity.lblunitprice.Text, frmQuantity.txtDiscount.Text, quantity, totalunitprice})
                frmPOS.txtPOSearch.Text = ""
                frmPOS.txtPOSearch.Focus()
            End If


            frmQuantity.Close()


        End If
    End Sub

    Public Sub calc()
        postotalamount = CDbl(frmPOS.lblGrandtotal.Text)
        cashtendered = CDbl(frmCash.txtCashTendered.Text)
        change = cashtendered - postotalamount
        frmCash.txtchange.Text = change
        If cashtendered < postotalamount Then
            MsgBox("Amount Insuficient!", vbOKOnly + vbInformation, "Amount Insuficient")
            frmCash.txtCashTendered.Focus()
        Else
            'addTransaction()
            runtransaction()
            frmCash.Dispose()
            frmPOS.lblcashtendered.Visible = True
            frmPOS.lblchange.Visible = True
            frmPOS.lblchange.Text = change
            frmPOS.lblchange2.Text = change
            frmPOS.lblcashtendered.Text = cashtendered
            frmPOS.lblcashtendered2.Text = cashtendered
            frmPOS.DGProduct.Rows.Clear()
            frmPOS.lblcashtendered.Text = "0.00"
            frmPOS.lblcashtendered2.Text = "0.00"
            frmPOS.lblchange.Text = "0.00"
            frmPOS.lblchange2.Text = "0.00"
            frmPOS.lblGrandtotal.Text = "0.00"
            frmPOS.lblDiscount.Text = "0.00"
            frmPOS.lblVat.Text = "0.00"
            frmPOS.lbltotalamount.Text = "0.00"
            frmPOS.lblChequeAmount.Text = "0.00"
            frmPOS.lbltransno.Text = "0000000"

        End If


    End Sub
    Public Sub chequePayment_calc()
        postotalamount = CDbl(frmPOS.lblGrandtotal.Text)
        chequeamount = CDbl(frmCheque.txtcheckamount.Text)
        change = chequeamount - postotalamount
        If chequeamount <> postotalamount Then
            MsgBox("Cheque amount must be equal to Total Amount", vbInformation + vbOKOnly, "Cheque Amount")
        Else
            runtransaction_chequepayment()
            frmCheque.Dispose()
            frmPOS.lblChequeAmount.Text = chequeamount
            frmPOS.DGProduct.Rows.Clear()
            frmPOS.newTrans = False
        End If

    End Sub

    Public Sub generatTransID()
        Dim number As Integer
        Try
            dbConnection()
            sql = "select max(trans_no) from transaction;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql

                If IsDBNull(cmd.ExecuteScalar) Then

                    number = 1000000
                    frmPOS.lbltransno.Text = number
                Else
                    number = cmd.ExecuteScalar + 1
                    frmPOS.lbltransno.Text = number
                End If

            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
    Public Sub runAddPaymentCollection()
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()
        ' Must assign both transaction object and connection
        ' to Command object for a pending local transaction
        ' myCommand.Connection = conn
        'myCommand.Transaction = myTrans

        '*******************************
        'MsgBox(frmPOS.DGProduct.Rows.Count)
        '*******************************

        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`transaction` (`objid`,`trans_no`, `costumer`,`address`, `modeofpayment`,`subtotal`,`vat`,`discount`,`amountdue`, `amounttendered`, `Cash_change`, `date`, `chequeNo`, `BankName`,`userid`,`status`) VALUES (@objid,@transno, @costumer,@address, @modepayment,@subtotal,@vat,@discount, @amountdue,@amounttendered, @change, @datetrans, @checkno, @bankname,@userid,'onhold');"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", POStransobjid)
                .Parameters.AddWithValue("@transno", frmAddPayment.lblPaymentTransNo.Text)
                .Parameters.AddWithValue("@costumer", frmAddPayment.txtcostumer.Text)
                .Parameters.AddWithValue("@address", frmAddPayment.txtadd.Text)
                .Parameters.AddWithValue("@modepayment", modepayment)
                .Parameters.AddWithValue("@subtotal", 0)
                .Parameters.AddWithValue("@vat", 0)
                .Parameters.AddWithValue("@discount", 0)
                .Parameters.AddWithValue("@amountdue", frmAddPayment.txtamounttendered.Text)
                .Parameters.AddWithValue("@amounttendered", frmAddPayment.txtamounttendered.Text)
                .Parameters.AddWithValue("@change", 0)
                .Parameters.AddWithValue("@datetrans", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@checkno", 0)
                .Parameters.AddWithValue("@bankname", "N/A")
                .Parameters.AddWithValue("@userid", userId)
            End With
            myCommand.ExecuteNonQuery()

            myCommand.CommandText = "INSERT INTO `newpost_database`.`costumer_ledger` (`custobjid`, `transactionID`, `terms`, `transactionDate`, `term_due_date`, `trans_type`, `cr`,`dr`) VALUES (@objid, @transactionID, @terms, @transDate, @termDueDate, @transType, @cr,@dr);"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", frmAddPayment.txtobjid.Text)
                .Parameters.AddWithValue("@transactionID", frmAddPayment.lblPaymentTransNo.Text)
                .Parameters.AddWithValue("@terms", "")
                .Parameters.AddWithValue("@transDate", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@termDueDate", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@transType", modepayment)
                .Parameters.AddWithValue("@cr", frmAddPayment.txtamounttendered.Text)
                .Parameters.AddWithValue("@dr", 0)

            End With
            myCommand.ExecuteNonQuery()
            myCommand.CommandText = "update sys_control_counter set value = @CashTransNO  where con_name ='Collection';"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@CashTransNO", getNewTransNo_Collection)
            End With
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            MsgBox("Payment Successfully recorded to database")
            'clear the frmcash

            frmCollection.Dispose()
            'disabled buttons
            With frmPOS
                .cmdCash.Enabled = False
                .cmdCharge.Enabled = False
                .cmdCheque.Enabled = False

            End With
            frmPosCostumer.Dispose()
            retrieveCollectionPaymentReceipt()
            frmReport.ShowDialog()
            frmAddPayment.Dispose()
            frmCash.Dispose()
            frmPOS.lblcashtendered.Visible = True
            frmPOS.lblchange.Visible = True
            frmPOS.lblchange.Text = change
            frmPOS.lblchange2.Text = change
            frmPOS.lblcashtendered.Text = cashtendered
            frmPOS.lblcashtendered2.Text = cashtendered
            frmPOS.DGProduct.Rows.Clear()
            frmPOS.lblcashtendered.Text = "0.00"
            frmPOS.lblcashtendered2.Text = "0.00"
            frmPOS.lblchange.Text = "0.00"
            frmPOS.lblchange2.Text = "0.00"
            frmPOS.lblGrandtotal.Text = "0.00"
            frmPOS.lblDiscount.Text = "0.00"
            frmPOS.lblVat.Text = "0.00"
            frmPOS.lbltotalamount.Text = "0.00"
            frmPOS.lblChequeAmount.Text = "0.00"
            frmPOS.lbltransno.Text = "0000000"
        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub runtransaction_termpayment()
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()
        ' Must assign both transaction object and connection
        ' to Command object for a pending local transaction
        ' myCommand.Connection = conn
        'myCommand.Transaction = myTrans

        '*******************************
        'MsgBox(frmPOS.DGProduct.Rows.Count)
        '*******************************

        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`transaction` (`objid`,`trans_no`, `costumer`,`address`, `modeofpayment`,`subtotal`,`vat`,`discount`,`amountdue`, `amounttendered`, `Cash_change`, `date`, `chequeNo`, `BankName`,`userid`,`status`) VALUES (@objid,@transno, @costumer,@address, @modepayment,@subtotal,@vat,@discount, @amountdue,@amounttendered, @change, @datetrans, @checkno, @bankname,@userid,'onhold');"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", POStransobjid)
                .Parameters.AddWithValue("@transno", frmPOS.lbltransno.Text)
                .Parameters.AddWithValue("@costumer", frmPosCostumer.txtcustName.Text)
                .Parameters.AddWithValue("@address", frmPosCostumer.txtcustAddress.Text)
                .Parameters.AddWithValue("@modepayment", modepayment)
                .Parameters.AddWithValue("@subtotal", CDbl(frmPOS.lbltotalamount.Text))
                .Parameters.AddWithValue("@vat", CDbl(frmPOS.lblVat.Text))
                .Parameters.AddWithValue("@discount", CDbl(frmPOS.lblDiscount.Text))
                .Parameters.AddWithValue("@amountdue", CDbl(frmPOS.lblGrandtotal.Text))
                .Parameters.AddWithValue("@amounttendered", 0)
                .Parameters.AddWithValue("@change", 0)
                .Parameters.AddWithValue("@datetrans", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@checkno", 0)
                .Parameters.AddWithValue("@bankname", "N/A")
                .Parameters.AddWithValue("@userid", userId)
            End With
            myCommand.ExecuteNonQuery()

            For Each row As DataGridViewRow In frmPOS.DGProduct.Rows
                Dim prodcode As String
                Dim qty, price, discount_details, amount As Double
                prodcode = row.Cells(0).Value.ToString
                price = row.Cells(2).Value.ToString
                discount_details = row.Cells(3).Value.ToString
                qty = row.Cells(4).Value.ToString
                amount = row.Cells(5).Value.ToString
                myCommand.CommandText = "INSERT INTO `newpost_database`.`transdetails` (`transID`, `prodcode`, `qty`,`discount`, `price`, `amount`,`transdate`,`userid`) VALUES (@transno, @prodcode, @qty,@discount, @price, @amount,@transDate,@userid);"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@transno", frmPOS.lbltransno.Text)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@discount", discount_details)
                    .Parameters.AddWithValue("@amount", amount)
                    .Parameters.AddWithValue("@transDate", frmPOS.lbldate3.Text)
                    .Parameters.AddWithValue("@userid", userId)
                End With
                myCommand.ExecuteNonQuery()

                myCommand.CommandText = "update product set prod_begin_qty = prod_begin_qty - @qty  where prodcode= @prodcode;"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                End With
                myCommand.ExecuteNonQuery()
            Next
            myCommand.CommandText = "INSERT INTO `newpost_database`.`costumer_ledger` (`custobjid`, `transactionID`, `terms`, `transactionDate`, `term_due_date`, `trans_type`,`cr`, `dr`) VALUES (@objid, @transactionID, @terms, @transDate, @termDueDate, @transType, @cr,@dr);"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", frmPosCostumer.txtobjid.Text)
                .Parameters.AddWithValue("@transactionID", frmPOS.lbltransno.Text)
                .Parameters.AddWithValue("@terms", frmPosCostumer.ComboBox1.Text)
                .Parameters.AddWithValue("@transDate", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@termDueDate", frmPosCostumer.lblTermUntil.Text)
                .Parameters.AddWithValue("@transType", modepayment)
                .Parameters.AddWithValue("@cr", 0)
                .Parameters.AddWithValue("@dr", frmPosCostumer.txtamountdue.Text)

            End With
            myCommand.ExecuteNonQuery()
            myCommand.CommandText = "update sys_control_counter set value = @CashTransNO  where con_name ='Term';"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@CashTransNO", getNewTransNo_Term)
            End With
            myCommand.ExecuteNonQuery()

            myTrans.Commit()
            MsgBox("Items recorded to database")
            'clear the frmcash
            With frmCash
                .txtAddress.Text = ""
                .txtCostumer.Text = ""
                .txtchange.Text = ""
                .txtAmountDue.Text = ""
                .txtCashTendered.Text = ""

            End With
            'disabled buttons
            With frmPOS
                .cmdCash.Enabled = False
                .cmdCharge.Enabled = False
                .cmdCheque.Enabled = False

            End With
            frmPosCostumer.Dispose()
            retrieveTransaction_ChargeInvoice()
            frmCash.Dispose()
            frmPOS.lblcashtendered.Visible = True
            frmPOS.lblchange.Visible = True
            frmPOS.lblchange.Text = change
            frmPOS.lblchange2.Text = change
            frmPOS.lblcashtendered.Text = cashtendered
            frmPOS.lblcashtendered2.Text = cashtendered
            frmPOS.DGProduct.Rows.Clear()
            frmPOS.lblcashtendered.Text = "0.00"
            frmPOS.lblcashtendered2.Text = "0.00"
            frmPOS.lblchange.Text = "0.00"
            frmPOS.lblchange2.Text = "0.00"
            frmPOS.lblGrandtotal.Text = "0.00"
            frmPOS.lblDiscount.Text = "0.00"
            frmPOS.lblVat.Text = "0.00"
            frmPOS.lbltotalamount.Text = "0.00"
            frmPOS.lblChequeAmount.Text = "0.00"
            frmPOS.lbltransno.Text = "0000000"
        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub runtransaction_chequepayment()

        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()
        ' Must assign both transaction object and connection
        ' to Command object for a pending local transaction
        ' myCommand.Connection = conn
        'myCommand.Transaction = myTrans

        '*******************************
        'MsgBox(frmPOS.DGProduct.Rows.Count)
        '*******************************

        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`transaction` (`objid`,`trans_no`, `costumer`,`address`, `modeofpayment`,`subtotal`,`vat`,`discount`,`amountdue`, `amounttendered`, `Cash_change`, `date`, `chequeNo`, `BankName`,`userid`,`status`) VALUES (@objid,@transno, @costumer,@address, @modepayment,@subtotal,@vat,@discount, @amountdue,@amounttendered, @change, @datetrans, @checkno, @bankname,@userid,'onhold');"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", POStransobjid)
                .Parameters.AddWithValue("@transno", frmPOS.lbltransno.Text)
                .Parameters.AddWithValue("@costumer", frmCheque.txtCostumer.Text)
                .Parameters.AddWithValue("@address", frmCheque.txtAddress.Text)
                .Parameters.AddWithValue("@modepayment", modepayment)
                .Parameters.AddWithValue("@subtotal", CDbl(frmPOS.lbltotalamount.Text))
                .Parameters.AddWithValue("@vat", CDbl(frmPOS.lblVat.Text))
                .Parameters.AddWithValue("@discount", CDbl(frmPOS.lblDiscount.Text))
                .Parameters.AddWithValue("@amountdue", CDbl(frmPOS.lblGrandtotal.Text))
                .Parameters.AddWithValue("@amounttendered", 0)
                .Parameters.AddWithValue("@change", 0)
                .Parameters.AddWithValue("@datetrans", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@checkno", frmCheque.txtcheckno.Text)
                .Parameters.AddWithValue("@bankname", frmCheque.txtbankname.Text)
                .Parameters.AddWithValue("@userid", userId)
            End With
            myCommand.ExecuteNonQuery()

            For Each row As DataGridViewRow In frmPOS.DGProduct.Rows
                Dim prodcode As String
                Dim qty, price, discount_details, amount As Double
                prodcode = row.Cells(0).Value.ToString
                price = row.Cells(2).Value.ToString
                discount_details = row.Cells(3).Value.ToString
                qty = row.Cells(4).Value.ToString
                amount = row.Cells(5).Value.ToString
                myCommand.CommandText = "INSERT INTO `newpost_database`.`transdetails` (`transID`, `prodcode`, `qty`,`discount`, `price`, `amount`,`transdate`,`userid`) VALUES (@transno, @prodcode, @qty,@discount, @price, @amount,@transDate,@userid);"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@transno", frmPOS.lbltransno.Text)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@discount", discount_details)
                    .Parameters.AddWithValue("@amount", amount)
                    .Parameters.AddWithValue("@transDate", frmPOS.lbldate3.Text)
                    .Parameters.AddWithValue("@userid", userId)
                End With
                myCommand.ExecuteNonQuery()

                myCommand.CommandText = "update product Set prod_begin_qty = prod_begin_qty - @qty  where prodcode= @prodcode;"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                End With
                myCommand.ExecuteNonQuery()

            Next
            myCommand.CommandText = "update sys_control_counter set value = @CashTransNO  where con_name ='Cash';"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@CashTransNO", getNewTransNo_Cash)
            End With
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            MsgBox("Items recorded to database")
            'clear the frmcash
            With frmCash
                .txtAddress.Text = ""
                .txtCostumer.Text = ""
                .txtchange.Text = ""
                .txtAmountDue.Text = ""
                .txtCashTendered.Text = ""

            End With
            'disabled buttons
            With frmPOS
                .cmdCash.Enabled = False
                .cmdCharge.Enabled = False
                .cmdCheque.Enabled = False

            End With
            retriveTransaction()

        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub runtransaction()
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()
        ' Must assign both transaction object and connection
        ' to Command object for a pending local transaction
        ' myCommand.Connection = conn
        'myCommand.Transaction = myTrans

        '*******************************
        'MsgBox(frmPOS.DGProduct.Rows.Count)
        '*******************************

        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`transaction` (`objid`,`trans_no`, `costumer`,`address`, `modeofpayment`,`subtotal`,`vat`,`discount`,`amountdue`, `amounttendered`, `Cash_change`, `date`, `chequeNo`, `BankName`,`userid`,`status`) VALUES (@objid,@transno, @costumer,@address, @modepayment,@subtotal,@vat,@discount, @amountdue,@amounttendered, @change, @datetrans, @checkno, @bankname,@userid,'onhold');"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", POStransobjid)
                .Parameters.AddWithValue("@transno", frmPOS.lbltransno.Text)
                .Parameters.AddWithValue("@costumer", frmCash.txtCostumer.Text)
                .Parameters.AddWithValue("@address", frmCash.txtAddress.Text)
                .Parameters.AddWithValue("@modepayment", modepayment)
                .Parameters.AddWithValue("@subtotal", CDbl(frmPOS.lbltotalamount.Text))
                .Parameters.AddWithValue("@vat", CDbl(frmPOS.lblVat.Text))
                .Parameters.AddWithValue("@discount", CDbl(frmPOS.lblDiscount.Text))
                .Parameters.AddWithValue("@amountdue", CDbl(frmPOS.lblGrandtotal.Text))
                .Parameters.AddWithValue("@amounttendered", CDbl(frmCash.txtCashTendered.Text))
                .Parameters.AddWithValue("@change", CDbl(frmCash.txtchange.Text))
                .Parameters.AddWithValue("@datetrans", frmPOS.lbldate3.Text)
                .Parameters.AddWithValue("@checkno", 0)
                .Parameters.AddWithValue("@bankname", "N/A")
                .Parameters.AddWithValue("@userid", userId)
            End With
            myCommand.ExecuteNonQuery()

            For Each row As DataGridViewRow In frmPOS.DGProduct.Rows
                Dim prodcode As String
                Dim qty, price, discount_details, amount As Double
                prodcode = row.Cells(0).Value.ToString
                price = row.Cells(2).Value.ToString
                discount_details = row.Cells(3).Value.ToString
                qty = row.Cells(4).Value.ToString
                amount = row.Cells(5).Value.ToString
                myCommand.CommandText = "INSERT INTO `newpost_database`.`transdetails` (`transID`, `prodcode`, `qty`,`discount`, `price`, `amount`,`transdate`,`userid`) VALUES (@transno, @prodcode, @qty,@discount, @price, @amount,@transDate,@userid);"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@transno", frmPOS.lbltransno.Text)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@discount", discount_details)
                    .Parameters.AddWithValue("@amount", amount)
                    .Parameters.AddWithValue("@transDate", frmPOS.lbldate3.Text)
                    .Parameters.AddWithValue("@userid", userId)
                End With
                myCommand.ExecuteNonQuery()

                myCommand.CommandText = "update product set prod_begin_qty = prod_begin_qty - @qty  where prodcode= @prodcode;"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                End With
                myCommand.ExecuteNonQuery()

            Next

            myCommand.CommandText = "update sys_control_counter set value = @CashTransNO  where con_name ='Cash';"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@CashTransNO", getNewTransNo_Cash)
            End With
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            frmPOS.newTrans = False
            MsgBox("Items recorded to database")
            'clear the frmcash
            With frmCash
                .txtAddress.Text = ""
                .txtCostumer.Text = ""
                .txtchange.Text = ""
                .txtAmountDue.Text = ""
                .txtCashTendered.Text = ""

            End With
            'disabled buttons
            With frmPOS
                .cmdCash.Enabled = False
                .cmdCharge.Enabled = False
                .cmdCheque.Enabled = False

            End With
            retriveTransaction()

        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try

    End Sub
    Public Sub runSavePO()
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()

        '*******************************

        Try
            For Each row As DataGridViewRow In frmPurchaseOrder.dgSelectedItems.Rows 'frmPOS.DGProduct.Rows
                Dim prodcode, name, desc As String
                Dim porno As Integer = frmPurchaseOrder.lblpono.Text
                Dim purDate As Date = getServerDate()
                Dim qty As Double
                prodcode = row.Cells(0).Value.ToString
                name = row.Cells(1).Value.ToString
                desc = row.Cells(2).Value.ToString
                qty = row.Cells(3).Value.ToString

                myCommand.CommandText = "INSERT INTO `newpost_database`.`purchaseorder` (`purno`, `prodcode`, `prodname`, `desc`, `qty`, `userid`, `podate`) VALUES (@purno, @prodcode,@name,@desc, @qty,@userid,@podate);"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@purno", porno)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                    .Parameters.AddWithValue("@name", name)
                    .Parameters.AddWithValue("@desc", desc)
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@userid", userId)
                    .Parameters.AddWithValue("@podate", purDate)
                End With
                myCommand.ExecuteNonQuery()
            Next
            myTrans.Commit()
            MsgBox("Items recorded to database")
            'clear the frmcash

            'reports must be here


        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try

    End Sub
    Public Sub runReturnItems()
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()
        '******************************

        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`voidtransaction` (`objid`, `transno`, `amount`, `returndate`, `reasons`, `userid`) VALUES (@objid, @transno, @amount, @returndate, @reasons, @user);"

            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", POStransobjid)
                .Parameters.AddWithValue("@transno", frmReturnItem.txttransno.Text)
                .Parameters.AddWithValue("@amount", frmReturnItem.txtamountdue.Text)
                .Parameters.AddWithValue("@returndate", frmReturnItem.txttransdate.Text)
                .Parameters.AddWithValue("@reasons", frmReturnItem.txtreason.Text)
                .Parameters.AddWithValue("@user", userId)
            End With
            myCommand.ExecuteNonQuery()

            'updating the database setting the transaction status to VOID
            myCommand.CommandText = "UPDATE `newpost_database`.`transaction` Set `status`='void',`modeofpayment`='void',`userid`=@user where trans_no= @transno;"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@transno", frmReturnItem.txttransno.Text)
                .Parameters.AddWithValue("@user", userId)
            End With
            myCommand.ExecuteNonQuery()

            'update costumer ledger database
            myCommand.CommandText = "UPDATE `newpost_database`.`costumer_ledger` set `trans_type`='void',`transactionDate`=@voiddate,`dr`='0' where transactionID= @transno;"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@voiddate", frmReturnItem.txttransdate.Text)
                .Parameters.AddWithValue("@transno", frmReturnItem.txttransno.Text)
            End With
            myCommand.ExecuteNonQuery()


            'updating the database setting the transaction status to VOID
            myCommand.CommandText = "UPDATE `newpost_database`.`transdetails` Set userid=@user where transID= @transno;"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@transno", frmReturnItem.txttransno.Text)
                .Parameters.AddWithValue("@user", userId)
            End With
            myCommand.ExecuteNonQuery()

            'returning the items to inventory
            For Each row In frmReturnItem.dgtransaction.Rows
                Dim prodcode, name As String
                Dim qty As Double
                prodcode = row.Cells(0).Value.ToString
                name = row.Cells(5).Value.ToString
                qty = row.Cells(6).Value

                myCommand.CommandText = "update product set prod_begin_qty = prod_begin_qty + @qty  where prodcode= @prodcode;"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@qty", qty)
                    .Parameters.AddWithValue("@prodcode", prodcode)
                End With
                myCommand.ExecuteNonQuery()

            Next



            myTrans.Commit()

            retrieveVoidedTransaction()
            frmReport.ShowDialog()

            frmReturnItem.Dispose()
            MsgBox("Database updated!")



        Catch e As Exception
            Try
                myTrans.Rollback()
            Catch ex As MySqlException
                If Not myTrans.Connection Is Nothing Then
                    MsgBox("An exception of type " + ex.GetType().ToString() +
" was encountered while attempting to roll back the transaction.")
                End If
            End Try

            MsgBox("An exception of type " + e.GetType().ToString() +
"was encountered while inserting the data.")
            MsgBox("Neither record was written to database.")
        Finally
            conn.Close()
        End Try
    End Sub
End Module
