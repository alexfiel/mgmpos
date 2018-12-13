Imports MySql.Data.MySqlClient
Module reports
    Public Sub rptRemitance()
        Dim report As New remittancereport
        Dim remitid As String = frmRemit.TextBox1.Text.ToString 'remittanceid
        frmReport.CrystalReportViewer1.ReportSource = report
        frmReport.CrystalReportViewer1.SelectionFormula = "{remiitance1.remiitanceid} = " & remitid
        frmReport.CrystalReportViewer1.Refresh()
        frmReport.CrystalReportViewer1.RefreshReport()
        frmReport.ShowDialog()
    End Sub

    Public Sub retrieveRemittance()
        MsgBox(Gremittanceid)
        Try
            dbConnection()
            sql = "SELECT distinct a.*,b.*,c.* from remiitance as a left join remittancedetails as b on a.remiitanceid = b.remiitanceid right join employees_database as c on a.userid = c.Employee_ID where a.remiitanceid=@remitid;"

            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@remitid", Gremittanceid)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New remittancereport
            report.SetDataSource(dt)
            frmReport_product.GBRemittance.ReportSource = report
            frmReport_product.GBRemittance.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub
End Module
