Imports MySql.Data.MySqlClient
Public Class frmRemit
    Dim remittanceid As String
    Public Function getnewremittanceno(ByVal number As Integer)

        Try
            dbConnection()
            sql = "select max(controlno) from remitcontrol;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql

                If IsDBNull(cmd.ExecuteScalar) Then

                    number = 1

                Else
                    number = cmd.ExecuteScalar + 1

                End If

            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        getnewremittanceno = number
    End Function

    Private Sub frmRemit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cash As Double = 0.00
        Dim tcash As Double = 0.00
        Dim cheque As Double = 0.00
        Dim term As Double = 0.00
        Dim voided As Double = 0.00
        Dim total As Double = 0.00
        Dim collection As Double = 0.00
        Dim Lcashonhand As Double = 0.00
        If dgCollections.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgCollections.Rows
                If CType(row.Cells(2).Value, String) = "cash" Then
                    cash = CDbl(lbltotalcash.Text)
                    lbltotalcash.Text = CType(row.Cells(6).Value, Double) + cash

                ElseIf CType(row.Cells(2).Value, String) = "cheque" Then
                    cheque = CDbl(lbltotalcheque.Text)
                    lbltotalcheque.Text = CType(row.Cells(6).Value, Double) + cheque

                ElseIf CType(row.Cells(2).Value, String) = "term" Then
                    term = CDbl(lbltotalterm.Text)
                    lbltotalterm.Text = CType(row.Cells(6).Value, Double) + term

                ElseIf CType(row.Cells(2).Value, String) = "void" Then
                    voided = CDbl(lblvoided.Text)
                    lblvoided.Text = CType(row.Cells(6).Value, Double) + voided

                ElseIf CType(row.Cells(2).Value, String) = "Collection" Then
                    collection = CDbl(lblcollection.Text)
                    lblcollection.Text = CType(row.Cells(6).Value, Double) + collection
                End If

            Next
            total = CDbl(lbltotalcash.Text) + CDbl(lbltotalcheque.Text) + CDbl(lbltotalterm.Text)

            lbltotalsalesremittance.Text = total

            Lcashonhand = frmPOS.txtcashonhand.Text
            lbltotalcashonhand.Text = Lcashonhand

            tcash = CDbl(lbltotalcash.Text) + CDbl(lblcollection.Text)
            lblcashlessvoid.Text = tcash - CDbl(lblvoided.Text)
            lblgrandtotal.Text = total + CDbl(lblcollection.Text) + CDbl(lbltotalcashonhand.Text) - CDbl(lblvoided.Text)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(getServerDate)
        Dim remitobjid As String = Guid.NewGuid.ToString("N")
        Call getnewremittanceno(0)
        ' MsgBox(getnewremittanceno(0))
        Dim newnumber As Integer = getnewremittanceno(0)
        'MsgBox(newnumber)

        Dim remittanceno As String
        Dim first2char As String = frmPOS.lbluser.Text.Substring(0, 3)

        remittanceno = first2char + "-" + "00" + newnumber.ToString
        ' MsgBox(remittanceno)
        Gremittanceid = remittanceno 'will be used in the reporting
        '********************************************************************************
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

        Dim servdate As Date = getServerDate()
        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`remiitance` (`remiitanceid`, `userid`, `cashsales`, `checquesales`, `termsales`,`collection`, `cashonhand`,`voided`, `grandtotal`,`remittancedate`) VALUES (@remitid, @userid, @cashsales, @chequesales, @termsales,@collection, @cashonhand,@voided, @grandtotal,@servDate);"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@remitid", remittanceno)
                .Parameters.AddWithValue("@userid", userId)
                .Parameters.AddWithValue("@cashsales", CDbl(lbltotalcash.Text))
                .Parameters.AddWithValue("@chequesales", CDbl(lbltotalcheque.Text))
                .Parameters.AddWithValue("@termsales", CDbl(lbltotalterm.Text))
                .Parameters.AddWithValue("@collection", CDbl(lblcollection.Text))
                .Parameters.AddWithValue("@cashonhand", CDbl(lbltotalcashonhand.Text))
                .Parameters.AddWithValue("@voided", CDbl(lblvoided.Text))
                .Parameters.AddWithValue("@grandtotal", CDbl(lblgrandtotal.Text))
                .Parameters.AddWithValue("@servDate", servdate)
            End With
            myCommand.ExecuteNonQuery()

            For Each row As DataGridViewRow In dgCollections.Rows
                Dim rem_transno As Integer
                Dim rem_amountdue As Double
                Dim rem_mode As String
                rem_transno = row.Cells(0).Value.ToString
                rem_mode = row.Cells(2).Value.ToString
                rem_amountdue = row.Cells(6).Value.ToString
                myCommand.CommandText = "INSERT INTO `newpost_database`.`remittancedetails` (`objid`, `remiitanceid`, `transno`,`modeofpayment`,`amountdue`) VALUES (@objid, @remitid, @transno,@mode,@amountdue);"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@objid", remitobjid)
                    .Parameters.AddWithValue("@remitid", remittanceno)
                    .Parameters.AddWithValue("@transno", rem_transno)
                    .Parameters.AddWithValue("@mode", rem_mode)
                    .Parameters.AddWithValue("@amountdue", rem_amountdue)

                End With
                myCommand.ExecuteNonQuery()

                myCommand.CommandText = "UPDATE `newpost_database`.`transaction` SET `status`='remitted',remitID=@remitid WHERE `trans_no`=@transno;"
                With myCommand
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@transno", rem_transno)
                    .Parameters.AddWithValue("@remitid", remittanceno)
                End With
                myCommand.ExecuteNonQuery()
            Next

            myCommand.CommandText = "UPDATE `newpost_database`.`remitcontrol` SET `controlNo`=@control;"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@control", newnumber)

            End With
            myCommand.ExecuteNonQuery()

            myCommand.CommandText = "UPDATE `newpost_database`.`cashonhand` SET `status`='remitted' WHERE `userid`=@userid;"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@userid", userId)

            End With
            myCommand.ExecuteNonQuery()

            myTrans.Commit()
            MsgBox("Remittance saved", vbOKOnly + vbInformation, "Remittance Succesfully Saved")
            retrieveRemittance()
            Me.Dispose()

            frmReport_product.ShowDialog()
            retrieveCOH()
            frmPOS.txtcashonhand.Text = "0.00"
            frmPOS.txtorigin.Text = ""
            frmPOS.txtdate.Text = ""


        Catch exrem As Exception
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
        retrieveCOH()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        'retrieveRemittance()
        ' frmReport.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'rptRemitance()
        'Gremittanceid = TextBox1.Text
        retrieveRemittance()
        frmReport.ShowDialog()

    End Sub

    Private Sub frmRemit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class