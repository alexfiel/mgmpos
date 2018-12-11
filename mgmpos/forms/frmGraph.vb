Imports MySql.Data.MySqlClient
Public Class frmGraph
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dbConnection()
            sql = "SELECT remittancedate,(cashsales)as Cash, sum(checquesales)as Cheque, sum(termsales) as Terms,sum(cashonhand) as COH FROM newpost_database.remiitance group by remittancedate;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read
                Chart1.Series("Cash").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("Cash"))
                Chart1.Series("Cheque").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("Cheque"))
                Chart1.Series("Terms").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("Terms"))
                Chart1.Series("Cash on Hand").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("COH"))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
End Class