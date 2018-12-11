﻿Imports MySql.Data.MySqlClient

Module retrieve
    Public Sub getUnremitted()
        Try
            dbConnection()
            sql = "SELECT trans_no,costumer,modeofpayment,subtotal,vat,discount,amountdue,date FROM newpost_database.transaction where status='onhold' and userid=@userid group by modeofpayment, trans_no; "
            cmd = New MySqlCommand(sql, conn)
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@userid", userId)
            End With
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                frmRemit.dgCollections.DataSource = dt
                With frmRemit.dgCollections
                    .RowHeadersVisible = False
                    .Columns(0).HeaderCell.Value = "Trans #"
                    .Columns(0).Width = 100

                    .Columns(1).HeaderCell.Value = "Costumer Type"
                    .Columns(1).Width = 200
                    .Columns(2).HeaderCell.Value = "Mode of Payment"
                    .Columns(2).Width = 50
                    .Columns(3).HeaderCell.Value = "Subtotal"
                    .Columns(3).Width = 100
                    .Columns(4).HeaderCell.Value = "Vat"
                    .Columns(5).Width = 100
                    .Columns(5).HeaderCell.Value = "Discount"
                    .Columns(5).Width = 100
                    .Columns(6).HeaderCell.Value = "Amount Due"
                    .Columns(6).Width = 100
                    .Columns(7).Visible = False

                End With
                frmRemit.ShowDialog()
            Else
                MsgBox("Nothing to Remit")
            End If


        Catch ex As Exception

        End Try
    End Sub


    Public Sub checkproductCode()
        Try
            dbConnection()
            sql = "select prodcode,prodname,prodcategory,uom,prodsrp,prod_begin_qty from product where concat(prodcode,prodname) like '%' @PRODLOOKUP '%';"
            cmd = New MySqlCommand(sql, conn)
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@PRODLOOKUP", frmPOS.txtPOSearch.Text)
            End With

            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                'frmPOS.ComboBox1.Text = frmPOS.txtPOSearch.Text

                Dim prodBegQty As Double
                Dim prodcode, prodname, unitprice As String
                prodcode = dt.Rows(0).Item(0)
                prodname = dt.Rows(0).Item(1)
                unitprice = dt.Rows(0).Item(4)
                prodBegQty = dt.Rows(0).Item(5)
                If prodBegQty <= 0 Then
                    MsgBox("Sorry no more inventory of" + prodname)
                ElseIf unitprice <= 0 Then
                    MsgBox("The items has no price" + prodname)
                Else
                    frmQuantity.lblpcode.Text = prodcode
                    frmQuantity.lblpdesc.Text = prodname
                    frmQuantity.lblunitprice.Text = unitprice
                    frmQuantity.lblbegQty.Text = prodBegQty

                    frmQuantity.ShowDialog()
                    frmQuantity.Dispose()
                    frmPOS.cmdCash.Enabled = True
                    frmPOS.cmdCheque.Enabled = True
                    frmPOS.cmdCharge.Enabled = True
                End If


            Else
                MsgBox("No Product Found! ")
                frmPOS.txtPOSearch.Text = ""
                frmPOS.txtPOSearch.Focus()


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()

        End Try
    End Sub

    Public Sub searchProductIN_txtbox()
        Try
            dbConnection()
            sql = "select p.prodcode,p.prodname,p.prodcategory, i.qtyin,i.qtyOut, p.prod_begin_qty from product p left outer join inventory_product i on p.prodcode = i.prodcode where concat(p.prodname,p.prodcode) like  '%' @ProdName2 '%' ;"
            'cmd = New MySqlCommand
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProdName2", frmStockDashboard.txtSPin.Text)
            End With
            dr = cmd.ExecuteReader
            While dr.Read
                frmStockDashboard.txtSpcode.Text = dr.GetString("prodcode")
                frmStockDashboard.txtSpname.Text = dr.GetString("prodname")
                frmStockDashboard.txtSpCategory.Text = dr.GetString("prodcategory")
                frmStockDashboard.txtstockonhand.Text = dr.GetDouble("prod_begin_qty")


            End While
            frmStockDashboard.txtqtyreceived.Focus()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
    Public Sub GetCustomerList()
        Try
            dbConnection()
            sql = "select objid,costumerType,orgName,firstname,lastname,address,contact,email from customer where concat(firstname,lastname,orgName) like '%' @COSTUMERLIST '%';"
            cmd = New MySqlCommand
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@COSTUMERLIST", searchCostumer.txtCustsearch.Text)
                .ExecuteNonQuery()

            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")

            End If
            searchCostumer.dgCostumer.DataSource = dt

            With searchCostumer.dgCostumer
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Objid"
                .Columns(0).Width = 200
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Costumer Type"
                .Columns(1).Width = 80
                .Columns(2).HeaderCell.Value = "Org. Name"
                .Columns(2).Width = 200
                .Columns(3).HeaderCell.Value = "First Name"
                .Columns(3).Width = 200
                .Columns(4).HeaderCell.Value = "Last Name"
                .Columns(4).Width = 200
                .Columns(5).HeaderCell.Value = "Address"
                .Columns(5).Width = 300
                .Columns(6).HeaderCell.Value = "Contact"
                .Columns(6).Width = 100
                .Columns(7).HeaderCell.Value = "Email"
                .Columns(7).Width = 100




            End With
        End Try
    End Sub
    Public Sub GetProductLookup()
        Try
            dbConnection()
            sql = "select prodcode,prodname,prodcategory,uom,prodsrp,prod_begin_qty from product where concat(prodcode,prodname) like '%' @PRODLOOKUP '%';"
            cmd = New MySqlCommand
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@PRODLOOKUP", productlookup.txtsearch.Text)
                .ExecuteNonQuery()

            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")

            End If
            productlookup.DGProduct.DataSource = dt
            With productlookup.DGProduct
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Product Code"
                .Columns(0).Width = 100
                .Columns(1).HeaderCell.Value = "Product Name"
                .Columns(1).Width = 500
                .Columns(2).HeaderCell.Value = "Category"
                .Columns(2).Width = 150
                .Columns(3).HeaderCell.Value = "Units"
                .Columns(3).Width = 50
                .Columns(4).HeaderCell.Value = "Price"
                .Columns(4).Width = 50
                .Columns(5).HeaderCell.Value = "Qty On Hand"
                .Columns(5).Width = 50




            End With
        End Try
    End Sub

    Public Sub searchProductIn()
        Try
            dbConnection()
            sql = "select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.date from product a left outer join invetory_in b on a.prodcode = b.prodcode where trasno=@transno order by trasno desc;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@transno", frmStockDashboard.lbltransaction.Text)
                .ExecuteNonQuery()

            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")

            End If
            frmStockDashboard.DGSTOCK.DataSource = dt


        End Try
    End Sub
    Public Sub searchProduct()
        Try
            dbConnection()
            sql = "select idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product where concat(prodcode,prodname) like '%' @ProdName '%'"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProdName", frmDashboard.tbSearch.Text)
                .ExecuteNonQuery()

            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")

            End If
            frmDashboard.dg_product.DataSource = dt
        End Try
    End Sub
    Public Sub retrieveProductsCategory()
        Try
            dbConnection()
            sql = "SELECT * FROM category_database;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            frmDashboard.dt_prod_cat.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub
    'Private m_FRMDASHBOARD As frmDashboard
    'Public ReadOnly Property frmDashboard As frmDashboard
    '    Get
    '        If IsNothing(m_FRMDASHBOARD) Then m_FRMDASHBOARD = New frmDashboard
    '        Return m_FRMDASHBOARD
    '    End Get
    'End Property


    Public Sub retrievesupplier()
        Try
            dbConnection()
            sql = "SELECT Supplier_ID,Name, Address, Contact_Number, emailadd, TIN, imgloc from suppliers_database where concat(Name,emailadd) like '%' @supName '%' ; "
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@supName", frmDashboard.txtSearchSupplier.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            frmDashboard.DGSupplier.DataSource = dt
            With frmDashboard.DGSupplier
                .RowHeadersVisible = False
                .Columns(0).Visible = False
                .Columns(1).HeaderText = "Name"
                .Columns(2).HeaderText = "Address"
                .Columns(2).Width = 100

                .Columns(3).HeaderText = "Contact"
                .Columns(4).HeaderText = "Email"
                .Columns(5).HeaderText = "TIN"
                .Columns(6).Visible = False

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub retriveTransaction() 'reports on salesinvoice

        Dim report As New sales
        Dim transno As Int64 = frmPOS.lbltransno.Text
        frmReport.CrystalReportViewer1.ReportSource = report
        frmReport.CrystalReportViewer1.SelectionFormula = "{transaction1.trans_no} = " & transno
        frmReport.CrystalReportViewer1.Refresh()
        frmReport.CrystalReportViewer1.RefreshReport()
        frmReport.ShowDialog()



    End Sub
    Public Sub retrieveTransaction_ChargeInvoice()
        Dim report As New chargeInvoice
        Dim transno As Int64 = frmPOS.lbltransno.Text
        frmReport.CrystalReportViewer1.ReportSource = report
        frmReport.CrystalReportViewer1.SelectionFormula = "{transaction1.trans_no} = " & transno
        frmReport.CrystalReportViewer1.Refresh()
        frmReport.CrystalReportViewer1.RefreshReport()
        frmReport.ShowDialog()
    End Sub

    Public Sub retrieveCashonHand() 'report
        'MsgBox(cashonhandobjid)
        Try
            dbConnection()
            ' sql = "Select a.prodcode, a.prodname, a.prodcategory,a.prod_begin_qty,a.uom,b.qtyin,b.trasno,b.refno,b.locid,b.date from product a left outer join invetory_in b On a.prodcode = b.prodcode;"
            'sql = "Select idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product where concat(prodcode,prodname) Like '%' @ProdName '%'"
            sql = "select * from newpost_database.cashonhand where objid=@cashobjid;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@cashobjid", cashonhandobjid)
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            ' reportsDGV.DataSource = dt
            Dim report As New receivecashonhand
            report.SetDataSource(dt)
            frmReport.CrystalReportViewer1.ReportSource = report
            frmReport.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()



        End Try
    End Sub
    Public Sub retrieveCOH()
        Try
            dbConnection()

            sql = "select sum(amount)amount,date,origin from cashonhand where status='onhold' and userid=@userid group by userid;"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@userid", userId)
            End With
            dr = cmd.ExecuteReader

            While dr.Read
                frmPOS.txtcashonhand.Text = dr.GetDouble("amount")
                frmPOS.txtorigin.Text = dr.GetString("origin")
                frmPOS.txtdate.Text = dr.GetString("date")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub



    Public Sub retrieveProducts()
        Try
            dbConnection()
            sql = "SELECT idproduct,prodcode,prodname,prod_description,prodcategory,uom,prodsupplier,prodsupprice,prodmarkup,prodsrp,prod_begin_qty,prod_reorder_qty from product; "
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            frmDashboard.dg_product.DataSource = dt
            With frmDashboard.dg_product
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "Prod ID"
                .Columns(1).HeaderText = "Code"
                .Columns(2).HeaderText = "Name"
                .Columns(2).Width = 100
                .Columns(3).HeaderText = "Description"
                .Columns(4).HeaderText = "Category"
                .Columns(5).HeaderText = "UOM"
                .Columns(6).HeaderText = "Supplier"
                .Columns(7).HeaderText = "Price"
                .Columns(8).HeaderText = "Mark Up"
                .Columns(9).HeaderText = "SRP"
                .Columns(10).HeaderText = "Begin Stock"
                .Columns(11).HeaderText = "Re Order Level"


            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieve_ProdCatList()
        Try
            dbConnection()
            sql = "SELECT * FROM category_database;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            frmDashboard.cboproduct_category.Items.Clear()
            While dr.Read
                frmDashboard.cboproduct_category.Items.Add(dr.GetString("Name"))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
    Public Sub retrieve_SupplierList()

        Try
            dbConnection()
            sql = "SELECT * FROM suppliers_database;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            frmDashboard.cboproduct_supplier.Items.Clear()
            While dr.Read
                frmDashboard.cboproduct_supplier.Items.Add(dr.GetString("Name"))
                suppID = dr.GetInt32("Supplier_ID")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try

    End Sub
    Public Sub retrievelocationlist()
        Try
            dbConnection()
            sql = "SELECT * FROM location;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            frmStockDashboard.cbolocation.Items.Clear()
            While dr.Read
                frmStockDashboard.cbolocation.Items.Add(dr.GetString("locationname"))
                locationid = dr.GetInt32("locationId")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub retrieveLocation()

        Try
            dbConnection()
            sql = "SELECT * FROM location;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            frmDashboard.dglocation.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub retriveCostumer()
        Try
            dbConnection()

            sql = "select objid,costumerType,orgName,firstname,lastname,address,contact,email,imglocation from customer where concat(firstname,lastname,orgName) like '%' @customer '%'"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@customer", frmDashboard.txtcustSearch.Text)
            End With
            dr = cmd.ExecuteReader

            While dr.Read
                frmDashboard.lblobjid.Text = dr.GetString("objid")
                frmDashboard.txtCustFname.Text = dr.GetString("firstname")
                frmDashboard.txtCustLname.Text = dr.GetString("lastname")
                frmDashboard.txtCustAdd.Text = dr.GetString("address")
                frmDashboard.txtCustContact.Text = dr.GetString("contact")
                frmDashboard.cboCustType.Text = dr.GetString("costumerType")
                frmDashboard.txtCustEmail.Text = dr.GetString("email")
                frmDashboard.txtCustOrgName.Text = dr.GetString("orgName")
                frmDashboard.PBCustomer.ImageLocation = dr.GetString("imglocation")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub retrieveemployee()
        Try
            dbConnection()

            sql = "select Employee_ID,First_Name,Middle_Name,Last_Name,Username,Password,User_Level,img_location from employees_database where concat(First_Name,Last_Name,Username) like '%' @Employee '%'"
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@Employee", frmDashboard.txtSearchEmp.Text)
            End With
            dr = cmd.ExecuteReader

            While dr.Read
                frmDashboard.txtempid.Text = dr.GetInt32("Employee_ID")
                frmDashboard.txtfname.Text = dr.GetString("First_Name")
                frmDashboard.txtlname.Text = dr.GetString("Last_Name")
                frmDashboard.txtmname.Text = dr.GetString("Middle_Name")
                frmDashboard.txtuser.Text = dr.GetString("Username")
                frmDashboard.txtpass.Text = dr.GetString("Password")
                frmDashboard.cboDesignation.Text = dr.GetString("User_Level")
                frmDashboard.pbEmp.ImageLocation = dr.GetString("img_location")
                frmDashboard.cmdUpdateEmp.Enabled = True
                frmDashboard.cmdDeleteEmp.Enabled = True
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try

    End Sub
    '=================================================================================================
    'get transaction no and increment by 1

    Public Sub retriveTransactionNo()
        Dim dte As DateTime = Now
        ' Dim combinedatenumber As String
        Dim xyear As Integer
        xyear = dte.Year

        Dim number As Integer
        Try
            dbConnection()
            sql = "select max(trans_no) from transaction;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql

                If IsDBNull(cmd.ExecuteScalar) Then

                    number = xyear + "100000"

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
    Public Sub getPOno()
        Dim number As Integer
        Try
            dbConnection()
            sql = "select max(purno) from purchaseorder;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql

                If IsDBNull(cmd.ExecuteScalar) Then

                    number = 1
                    frmPurchaseOrder.lblpono.Text = number
                Else
                    number = cmd.ExecuteScalar + 1
                    frmPurchaseOrder.lblpono.Text = number
                End If

            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
    '===================================================================



    Public Function getServerDate() As Date
        Dim currentdate As Date
        Try
            dbConnection()
            sql = "select date(now()) datenow;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    If dr.IsDBNull(0) Then
                        MsgBox("Can't get the Server Date. Program will exit.")
                        currentdate = ""
                        Application.Exit()

                    Else
                        currentdate = dr("datenow")
                    End If
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
        Return currentdate
    End Function

End Module