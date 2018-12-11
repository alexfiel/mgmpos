Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReport2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dbConnection()

            'sql = "SELECT product1.prodname, transaction1.trans_no, transaction1.costumer, transaction1.modeofpayment, transaction1.amountdue, transaction1.vat, transaction1.amounttendered, transaction1.Cash_change, transdetails1.qty, transdetails1.discount, transdetails1.price, transdetails1.amount, transdetails1.transdate FROM (newpost_database.transaction transaction1 INNER JOIN newpost_database.transdetails transdetails1 On transaction1.trans_no=transdetails1.transID) INNER JOIN newpost_database.product product1 On transdetails1.prodcode=product1.prodcode where  transaction1.trans_no=@transno"
            sql = "Select a.trans_no,costumer,a.modeofpayment,a.vat,a.amountdue,a.amounttendered,a.cash_change,a.Date,a.chequeNo,a.BankName,b.prodcode,c.prodname,b.qty,b.discount,b.price,b.amount,b.userid from transaction As a,transdetails As b, product As c where a.trans_no=@transcode And a.trans_no=b.transID And b.prodcode=c.prodcode"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@transcode", TextBox1.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            '  Dim report As New Salestransaction
            ' report.SetDataSource(dt)

            'CrystalReportViewer1.Refresh()
            'CrystalReportViewer1.ReportSource = report
            ' CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub frmReport2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim report As New salereport
        Dim orderdate As String = Me.TextBox2.Text.ToString
        CrystalReportViewer1.ReportSource = report
        Me.CrystalReportViewer1.SelectionFormula = "{transaction1.date} = " & orderdate
        Me.CrystalReportViewer1.Refresh()
        Me.CrystalReportViewer1.RefreshReport()

        'Dim crypt As New ReportDocument
        'crypt.Load("salereport.rpt")

        'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim crParameterFieldDefinition As ParameterFieldDefinition
        'Dim crParameterValues As New ParameterValues
        'Dim crParameterDiscreteValue As New ParameterDiscreteValue

        'crParameterDiscreteValue.Value = TextBox2.Text
        'crParameterFieldDefinitions = crypt.DataDefinition.ParameterFields
        'crParameterFieldDefinition = crParameterFieldDefinitions.Item("orderdate")
        'crParameterValues = crParameterFieldDefinition.CurrentValues


        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'CrystalReportViewer1.ReportSource = crypt
        'CrystalReportViewer1.Refresh()





    End Sub
End Class