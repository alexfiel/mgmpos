Imports MySql.Data.MySqlClient
Public Class frmSalesReport
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            dbConnection()
            sql = "select trans_no,costumer,modeofpayment,subtotal,vat,discount,amountdue,date from newpost_database.transaction where date between @transDate and @transDateto order by trans_no asc;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@transDate", dtFrom.Text)
                .Parameters.AddWithValue("@transDateto", dtTo.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New salereport
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnRemitView_Click(sender As Object, e As EventArgs) Handles btnRemitView.Click
        Try
            dbConnection()
            sql = "select remiitanceid,userid,cashsales,checquesales,termsales,cashonhand,grandtotal,remittancedate from newpost_database.remiitance where remittancedate between @remitdatefrom and @remitdateto order by remiitanceid asc;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@remitdatefrom", dtRemitFrom.Text)
                .Parameters.AddWithValue("@remitdateto", dtRemitTo.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New salesremittance
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Class