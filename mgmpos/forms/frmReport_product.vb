Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReport_product
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Gremittanceid = txtremitno.Text
        retrieveRemittance()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Try
            dbConnection()
            ' sql = "select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.date from product a left outer join invetory_in b on a.prodcode = b.prodcode;"
            'sql = "select idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product where concat(prodcode,prodname) like '%' @ProdName '%'"
            sql = "select * from product where concat(prodcode,prodname)like '%' @ProdName '%' order by prodname asc;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProdName", txtsearch.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New ProductoLista
            report.SetDataSource(dt)
            GBRemittance.ReportSource = report
            GBRemittance.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()



        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            dbConnection()
            sql = "select trans_no,costumer,modeofpayment,subtotal,vat,discount,amountdue,date from newpost_database.transaction where date between @transDate and @transDateto order by trans_no asc;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@transDate", dtfrom.Text)
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
            GBRemittance.ReportSource = report
            GBRemittance.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub frmReport_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class