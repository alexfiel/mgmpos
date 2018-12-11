Imports MySql.Data.MySqlClient

Public Class frmReceiveCash
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbConnection()

        Dim myCommand As MySqlCommand = conn.CreateCommand()
        Dim myTrans As MySqlTransaction

        ' Start a local transaction
        myTrans = conn.BeginTransaction()


        '*******************************
        'MsgBox(frmPOS.DGProduct.Rows.Count)
        '*******************************

        Try
            myCommand.CommandText = "INSERT INTO `newpost_database`.`cashonhand` (`objid`,`userid`, `amount`,`date`, `origin`,`description`,`status`) VALUES (@objid,@userid, @amount,@date, @origin,@description,'onhold');"
            With myCommand
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", cashonhandobjid)
                .Parameters.AddWithValue("@userid", userId)
                .Parameters.AddWithValue("@amount", CDbl(txtamount.Text))
                .Parameters.AddWithValue("@date", dtDateCOH.Text)
                .Parameters.AddWithValue("@origin", txtOrigin.Text)
                .Parameters.AddWithValue("@description", txtDescription.Text)

            End With
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            MsgBox("Cash on Hand successfully saved at the Database!")
            'clear the frmreceivecash

            txtamount.Text = ""
            txtcashier.Text = ""
            txtDescription.Text = ""
            txtOrigin.Text = ""
            retrieveCashonHand()
            retrieveCOH()
            frmReport.ShowDialog()
            Me.Dispose()
            retrieveCOH()
        Catch exx As Exception
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged

    End Sub
End Class