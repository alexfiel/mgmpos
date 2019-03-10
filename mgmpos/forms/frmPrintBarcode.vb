Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmPrintBarcode
    Private Sub frmPrintBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim count As Integer
        count = 1

        If txtbarcode.Text = "" Then
                MsgBox("Please input barcode", vbInformation, "Input barcode")
                txtbarcode.Focus()
            Else
            Try


                dbConnection()
                ' sql = "select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.date from product a left outer join invetory_in b on a.prodcode = b.prodcode;"
                'sql = "select idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product where concat(prodcode,prodname) like '%' @ProdName '%'"
                'sql = "select * from product where prodcode= @ProdCode;" --> specific
                'sql = "select * from product where concat(prodcode,prodname)like '%' @ProdName '%' order by prodname asc;"
                sql = "select * from product where prodcode= '" & txtbarcode.Text & "'"

                If txtcopy.Text = 1 Then

                    sql = "select * from product where prodcode= '" & txtbarcode.Text & "'"
                    cmd = New MySqlCommand(sql, conn)
                    With cmd
                        .Connection = conn
                        .CommandText = sql
                        .Parameters.Clear()
                        '.Parameters.AddWithValue("@ProdName", txtbarcode.Text)
                        .ExecuteNonQuery()
                    End With
                Else
                    While count < Integer.Parse(txtcopy.Text)
                        sql = sql + "UNION All Select * from product where prodcode= '" & txtbarcode.Text & "'"
                        count += 1
                        cmd = New MySqlCommand(sql, conn)
                        With cmd
                            .Connection = conn
                            .CommandText = sql
                            .Parameters.Clear()
                            '.Parameters.AddWithValue("@ProdName", txtbarcode.Text)
                            .ExecuteNonQuery()
                        End With

                    End While
                End If


                da = New MySqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                ' reportsDGV.DataSource = dt
                Dim report As New productBarcode
                report.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = report
                CrystalReportViewer1.Refresh()


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()



            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dbConnection()
            ' sql = "Select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.Date from product a left outer join invetory_in b On a.prodcode = b.prodcode;"
            'sql = "Select idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product where concat(prodcode,prodname) Like '%' @ProdName '%'"
            sql = "select * from product order by prodname asc;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                ' .Parameters.AddWithValue("@ProdCode", txtbarcode.Text)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New productBarcode
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()



        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            dbConnection()
            ' sql = "select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.date from product a left outer join invetory_in b on a.prodcode = b.prodcode;"
            'sql = "select idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product where concat(prodcode,prodname) like '%' @ProdName '%'"
            'sql = "select * from product where prodcode= @ProdCode;" --> specific
            sql = "select * from product where concat(prodname,prod_description)like '%' @ProdName '%' order by prodname asc;"
            ' sql = "select * from product where prodcode= '" & txtbarcode.Text & "'"

            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProdName", txtSproductName.Text)
                .ExecuteNonQuery()
            End With

            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New productBarcode
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