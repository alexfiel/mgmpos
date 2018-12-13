Imports MySql.Data.MySqlClient
Public Class frmDashboard
    Dim sprice As Double
    Dim rprice As Double
    Dim markup As Double
    Dim empID As String


    Private Sub cmdProduct_Click(sender As Object, e As EventArgs) Handles cmdProduct.Click
        panelContextRegister.Visible = False
        pnlEmployee.Visible = False
        panelProduct.Visible = True
        panelProduct.Dock = DockStyle.Fill
        PnlMain.Visible = False
        lblHEADER.Text = "REGISTER PRODUCT"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelProduct.Visible = False
        pnlEmployee.Visible = False
        panelSupplier.Visible = False
        panelContextRegister.Visible = True
        PnlCustomer.Visible = False
        PnlMain.Visible = False
        pnlReports.Visible = False
        lblHEADER.Text = "REGISTER"

    End Sub

    Private Sub tbproduct_markup_KeyDown(sender As Object, e As KeyEventArgs) Handles tbproduct_markup.KeyDown
        If e.KeyCode = Keys.Enter Then
            sprice = CDbl(tbproduct_supprice.Text)
            markup = CDbl(tbproduct_markup.Text) / 100
            rprice = markup * sprice + sprice
            tbproduct_srp.Text = rprice

        End If
    End Sub



    Private Sub tbproduct_supprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbproduct_supprice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub



    Private Sub tbproduct_srp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbproduct_srp.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub tbproduct_markup_TextChanged(sender As Object, e As EventArgs) Handles tbproduct_markup.TextChanged

    End Sub

    Private Sub tbproduct_markup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbproduct_markup.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub



    Private Sub tbproduct_supprice_TextChanged(sender As Object, e As EventArgs) Handles tbproduct_supprice.TextChanged
        If tbproduct_supprice.Text = "" Then
            MsgBox("Do not leave this empty")
            tbproduct_supprice.Focus()
        Else
            sprice = CDbl(tbproduct_supprice.Text)
            markup = CDbl(tbproduct_markup.Text) / 100
            rprice = markup * sprice + sprice
            tbproduct_srp.Text = rprice
        End If



    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dashTime As DateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        panelContextRegister.Dock = DockStyle.Fill
        retrieveProductsCategory()
        retrieveLocation()
        retrieve_ProdCatList()
        retrieveProducts()
        retrieve_SupplierList()
        retrievesupplier()
        'lblDateTime.Text = dashTime
        getRemittanceforgraph()
        getCategoryforgraph()
        getsalesperformance()
        getCriticalProduct()
    End Sub
    Private Sub getCriticalProduct()
        Try
            dbConnection()
            sql = "SELECT prodcode, prodname,prodsrp,prod_begin_qty FROM newpost_database.product where prod_begin_qty <= prod_reorder_qty; "
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
            homedgproduct.DataSource = dt
            With homedgproduct
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "Product Code"
                .Columns(1).HeaderText = "Name"
                .Columns(2).HeaderText = "SRP"
                .Columns(2).Width = 100
                .Columns(3).HeaderText = "Qty"

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub
    Private Sub getsalesperformance()
        Try
            dbConnection()
            sql = "SELECT date,sum(amountdue)as Amount FROM newpost_database.transaction where status ='remitted'group by date;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read
                Chart3.Series("Collections").Points.AddXY(dr.GetString("date"), dr.GetString("Amount"))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
    Private Sub getCategoryforgraph()
        Try
            dbConnection()
            sql = "select a.prodcode,a.prodname,a.prodcategory,sum(b.qty)as QTY,b.transdate from product as a inner join transdetails as b on a.prodcode = b.prodcode group by a.prodcategory order by prodcategory asc ;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read
                Chart2.Series("Product Category").Points.AddXY(dr.GetString("prodcategory"), dr.GetString("QTY"))
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
    Private Sub getRemittanceforgraph()
        Try
            dbConnection()
            sql = "SELECT remittancedate,sum(cashsales)as Cash,sum(checquesales)as Cheque,sum(termsales)as Terms FROM newpost_database.remiitance group by remittancedate;"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            While dr.Read
                Chart1.Series("Cash").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("Cash"))
                Chart1.Series("Cheque").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("Cheque"))
                Chart1.Series("Terms").Points.AddXY(dr.GetString("remittancedate"), dr.GetString("Terms"))

            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Private Sub btn_prod_cat_add_Click(sender As Object, e As EventArgs) Handles btn_prod_cat_add.Click
        If tb_prod_cat_name.Text = "" Then
            MsgBox("Please input category", vbInformation, "Input Category")
            tb_prod_cat_name.Focus()
        Else
            addCategoryProducts()
            clearproducts()
            retrieveProductsCategory()
            retrieve_ProdCatList()

        End If


    End Sub

    Private Sub btn_prod_cat_edit_Click(sender As Object, e As EventArgs) Handles btn_prod_cat_update.Click
        If tb_prod_cat_name.Text = "" Then
            MsgBox("Please input product category name", vbInformation + vbOKOnly, "Update Category")
        Else
            updatecategoryproducts()
            clearproducts()
            retrieveProductsCategory()

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnlocationAdd.Click
        If tblocationname.Text = "" Then
            MsgBox("Please input location name", vbInformation + vbOK, "Input Location")
            tblocationname.Focus()
        Else
            addlocation()
            clearlocation()
            retrieveLocation()

        End If
    End Sub

    Private Sub dt_prod_cat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_prod_cat.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = dt_prod_cat.Rows(index)
            tbproductcat_id.Text = row.Cells(0).Value.ToString()
            tb_prod_cat_name.Text = row.Cells(1).Value.ToString()
            tb_prod_cat_desc.Text = row.Cells(2).Value.ToString()
            btn_prod_cat_add.Visible = False
            pcbtnNew.Visible = True
            btn_prod_cat_update.Enabled = True
            btnpcdelete.Enabled = True
        End If
    End Sub

    Private Sub btnpcdelete_Click(sender As Object, e As EventArgs) Handles btnpcdelete.Click
        If tb_prod_cat_name.Text = "" Then
            MsgBox("Input product category!")
        ElseIf tbproductcat_id.Text = "" Then
            MsgBox("Select product category to be deleted or updated!")
        Else
            delprodcat()
            clearproducts()
            retrieveProductsCategory()

        End If
    End Sub

    Private Sub pcbtnNew_Click(sender As Object, e As EventArgs) Handles pcbtnNew.Click
        pcbtnNew.Visible = False
        btn_prod_cat_add.Visible = True
        clearproducts()
        tb_prod_cat_name.Focus()

    End Sub

    Private Sub tb_prod_cat_desc_TextChanged(sender As Object, e As EventArgs) Handles tb_prod_cat_desc.TextChanged

    End Sub

    Private Sub dglocation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dglocation.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = dglocation.Rows(index)

            tblocid.Text = row.Cells(0).Value.ToString()
            tblocationname.Text = row.Cells(1).Value.ToString()
            tblocdesc.Text = row.Cells(2).Value.ToString()
            btnlocationAdd.Visible = False
            btnlocationNew.Visible = True
            btn_prod_cat_update.Enabled = True
            btnpcdelete.Enabled = True
            btnlocationDelete.Enabled = True
            btnlocationUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnlocationNew_Click(sender As Object, e As EventArgs) Handles btnlocationNew.Click
        tblocationname.Focus()
        clearlocation()
        btnlocationAdd.Visible = True
        btnlocationNew.Visible = False
        btnlocationDelete.Enabled = False
        btnlocationUpdate.Enabled = False

    End Sub

    Private Sub btnlocationUpdate_Click(sender As Object, e As EventArgs) Handles btnlocationUpdate.Click
        If tblocationname.Text = "" Then
            MsgBox("Please input location name", vbInformation + vbOK, "Input Location")
            tblocationname.Focus()
        Else
            updatelocation()
            clearlocation()
            retrieveLocation()
            retrieveProductsCategory()
            retrieve_ProdCatList()


        End If
    End Sub

    Private Sub btnlocationDelete_Click(sender As Object, e As EventArgs) Handles btnlocationDelete.Click
        If tblocid.Text = "" Then
            MsgBox("Select below!")
        ElseIf tblocdesc.Text = "" Then
            MsgBox("Select location to be deleted or updated!")
        Else
            delLocation()
            clearlocation()
            retrieveLocation()
            retrieveProductsCategory()
            retrieveProducts()
            retrieve_ProdCatList()


        End If
    End Sub

    Private Sub btnprodNew_Click(sender As Object, e As EventArgs) Handles btnprodNew.Click
        btnprodAdd.Visible = True
        btnprodNew.Visible = False
        btnprodDelete.Enabled = False
        btnprodEdit.Enabled = False
        tbproduct_code.Focus()


    End Sub

    Private Sub btnprodAdd_Click(sender As Object, e As EventArgs) Handles btnprodAdd.Click
        If tbproduct_code.Text = "" Then
            MsgBox("Please input product code or barcode", vbInformation + vbOK, "New Product")
        ElseIf tbprodname.Text = "" Then
            MsgBox("Please input product name!", vbInformation + vbOK, "New Product")
        ElseIf tbproduct_supprice.Text = "" Then
            MsgBox("Please input supplier price!", vbInformation + vbOK, "New Product")
        ElseIf tbproduct_srp.Text = "" Then
            MsgBox("Please input Suggested Retail Price!", vbInformation + vbOK, "New Product")
        Else
            addproducts()
            MsgBox(userId, suppID)
            addproduct_inventory()
            clearProducto()
            retrieveProductsCategory()
            retrieveProducts()
            retrieve_ProdCatList()
            retrieve_SupplierList()


        End If
    End Sub

    Private Sub dg_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_product.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = dg_product.Rows(index)
            tbprodID.Text = row.Cells(0).Value
            tbproduct_code.Text = row.Cells(1).Value.ToString()
            tbprodname.Text = row.Cells(2).Value.ToString()
            txtPdesc.Text = row.Cells(3).Value.ToString()
            cboproduct_category.Text = row.Cells(4).Value.ToString()
            cboproduct_supplier.Text = row.Cells(6).Value.ToString()
            cbo_product_uom.Text = row.Cells(5).Value.ToString()
            tbproduct_supprice.Text = row.Cells(7).Value
            tbproduct_markup.Text = row.Cells(8).Value
            tbproduct_srp.Text = row.Cells(9).Value
            txtbegStock.Text = row.Cells(10).Value
            txtReorder.Text = row.Cells(11).Value
            btnprodAdd.Visible = False
            btnprodNew.Visible = True
            btnprodEdit.Enabled = True
            btnprodDelete.Enabled = True

        End If
    End Sub

    Private Sub btnprodEdit_Click(sender As Object, e As EventArgs) Handles btnprodEdit.Click
        If tbproduct_code.Text = "" Then
            MsgBox("Please input product code", vbInformation + vbOK, "Input product code")
            tbproduct_code.Focus()
        ElseIf tbprodname.Text = "" Then
            MsgBox("Please input produc name", vbInformation + vbOK, "Input Product Name")
            tbprodname.Text = ""
        Else
            updateproducts()
            clearProducto()
            retrieveProducts()
            retrieveLocation()
            retrieveProductsCategory()
            retrieve_ProdCatList()


        End If
    End Sub



    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            searchProduct()

        End If
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        searchProduct()
    End Sub



    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.InitialDirectory = "C:\temp"
        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.pbEmp.ImageLocation = fdlg.FileName
            Me.pbEmp.Tag = fdlg.FileName
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles cmdSaveEmp.Click
        If txtfname.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtfname.Focus()
        ElseIf txtlname.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtlname.Focus()
        ElseIf txtmname.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtmname.Focus()
        ElseIf txtuser.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtuser.Focus()
        ElseIf txtpass.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtpass.Focus()
        Else
            Dim x As New cEmployee
            x.fname = txtfname.Text
            x.lname = txtlname.Text
            x.mname = txtmname.Text
            x.user = txtuser.Text
            x.pass = txtpass.Text
            x.designation = cboDesignation.Text
            x.imageloc = pbEmp.Tag
            If pbEmp.Tag = "" Then
                pbEmp.Tag = "NULL"
            Else
                x.addEmployee()
                clearEmployee()
                cmdSaveEmp.Visible = False
                cmdNewEmployee.Visible = True
            End If
        End If



    End Sub

    Private Sub cmdRegisterEmp_Click(sender As Object, e As EventArgs) Handles cmdRegisterEmp.Click
        panelContextRegister.Visible = False
        pnlEmployee.Visible = True
        panelProduct.Visible = False
        panelSupplier.Visible = False
        pnlEmployee.Dock = DockStyle.Fill
        lblHEADER.Text = "REGISTER EMPLOYEE"
        clearEmployee()


    End Sub

    Private Sub txtSearchEmp_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmp.TextChanged


        If txtSearchEmp.Text = "" Then
            clearEmployee()
            cmdUpdateEmp.Enabled = False
            cmdDeleteEmp.Enabled = False
        Else
            '  cmdUpdateEmp.Enabled = True
            ' cmdDeleteEmp.Enabled = True
            retrieveemployee()
        End If
    End Sub

    Private Sub txtSearchEmp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEmp.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtSearchEmp.Text = "" Then
                clearEmployee()
                cmdUpdateEmp.Enabled = False
            Else
                'cmdUpdateEmp.Enabled = True
                retrieveemployee()
            End If
        End If
    End Sub
    Public Sub clearCustomer()
        txtCustOrgName.Text = ""
        txtCustFname.Text = ""
        txtCustLname.Text = ""
        txtCustAdd.Text = ""
        cboCustType.Text = ""
        txtCustEmail.Text = ""
        txtCustAdd.Text = ""
        txtCustContact.Text = ""


    End Sub
    Public Sub clearEmployee()
        txtempid.Text = ""
        txtSearchEmp.Text = ""
        txtfname.Text = ""
        txtlname.Text = ""
        txtmname.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        cboDesignation.Text = ""
        pbEmp.ImageLocation = "C:\Users\alexfieljr\Pictures\icons for hotel\profile.png"
    End Sub

    Private Sub cmdNewEmployee_Click(sender As Object, e As EventArgs) Handles cmdNewEmployee.Click
        clearEmployee()
        cmdSaveEmp.Visible = True
        cmdUpdateEmp.Enabled = False
        cmdNewEmployee.Visible = False

    End Sub

    Private Sub cmdUpdateEmp_Click(sender As Object, e As EventArgs) Handles cmdUpdateEmp.Click

        xupdateEmployee()
        clearEmployee()
        cmdUpdateEmp.Enabled = False
    End Sub

    Private Sub cmdDeleteEmp_Click(sender As Object, e As EventArgs) Handles cmdDeleteEmp.Click
        delEmployee()
        cmdDeleteEmp.Enabled = False
        clearEmployee()

    End Sub

    Private Sub panelContextRegister_Paint(sender As Object, e As PaintEventArgs) Handles panelContextRegister.Paint

    End Sub

    Private Sub cmdRegSupplier_Click(sender As Object, e As EventArgs) Handles cmdRegSupplier.Click
        panelContextRegister.Visible = False
        pnlEmployee.Visible = False
        panelProduct.Visible = False
        panelSupplier.Visible = True
        panelSupplier.Dock = DockStyle.Fill
        lblHEADER.Text = "REGISTER SUPPLIER"
        clearEmployee()
    End Sub

    Private Sub txtSupEmail_TextChanged(sender As Object, e As EventArgs) Handles txtSuppEmail.TextChanged

    End Sub

    Private Sub cmdNewSupp_Click(sender As Object, e As EventArgs) Handles cmdNewSupp.Click
        cmdNewSupp.Visible = False
        cmdAddSupp.Visible = True
        clearSupplier()
        txtsupname.Focus()
        cmdAddSupp.Enabled = True
        cmdSuppDelete.Enabled = False
        cmdupdateSupp.Enabled = False


    End Sub

    Private Sub cmdAddSupp_Click(sender As Object, e As EventArgs) Handles cmdAddSupp.Click
        addSupplier()
        clearSupplier()
        cmdAddSupp.Visible = False
        cmdNewSupp.Visible = True
        retrieve_SupplierList()
        retrievesupplier()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.InitialDirectory = "C:\temp"
        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.pbSupp.ImageLocation = fdlg.FileName
            Me.pbSupp.Tag = fdlg.FileName
        End If
    End Sub

    Private Sub DGSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellContentClick
        If e.RowIndex >= 0 Then
            Dim imgloc As String
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = DGSupplier.Rows(index)
            txtsupId.Text = row.Cells(0).Value.ToString()

            txtsupname.Text = row.Cells(1).Value.ToString()
            txtsuppadd.Text = row.Cells(2).Value.ToString()
            txtsuppcontact.Text = row.Cells(3).Value.ToString()
            txtSuppEmail.Text = row.Cells(4).Value.ToString
            txtsupptin.Text = row.Cells(5).Value.ToString
            imgloc = row.Cells(6).Value.ToString
            pbSupp.ImageLocation = imgloc
            cmdAddSupp.Enabled = False
            cmdSuppDelete.Enabled = True
            cmdupdateSupp.Enabled = True


        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles cmdupdateSupp.Click
        updateSupplier()
        retrievesupplier()
        clearSupplier()
        cmdNewSupp.Visible = True
        cmdAddSupp.Visible = False

    End Sub

    Private Sub txtSearchSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplier.TextChanged
        retrievesupplier()
    End Sub

    Private Sub cmdSuppDelete_Click(sender As Object, e As EventArgs) Handles cmdSuppDelete.Click
        deleteSupplier()
        retrievesupplier()
        clearSupplier()
        cmdNewSupp.Visible = True
        cmdAddSupp.Visible = False

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub

    Private Sub btnprodDelete_Click_1(sender As Object, e As EventArgs) Handles btnprodDelete.Click
        delproduct()
        clearProducto()
        retrieveProducts()
        retrieveLocation()
        retrieveProductsCategory()
        retrieve_ProdCatList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        frmStockDashboard.Show()
    End Sub

    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        panelContextRegister.Visible = False
        pnlEmployee.Visible = False
        panelProduct.Visible = False
        PnlCustomer.Visible = True
        PnlCustomer.Dock = DockStyle.Fill
        lblHEADER.Text = "REGISTER COSTUMER"
    End Sub

    Private Sub cmdCusNew_Click(sender As Object, e As EventArgs) Handles cmdCusNew.Click
        Dim transobjid As String = Guid.NewGuid().ToString("N")
        objid = transobjid

    End Sub

    Private Sub cmdCustSave_Click(sender As Object, e As EventArgs) Handles cmdCustSave.Click
        If txtCustFname.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtCustFname.Focus()
        ElseIf txtCustLname.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtlname.Focus()
        ElseIf txtCustAdd.Text = "" Then
            MsgBox("Data Required", vbInformation, "Data Required")
            txtCustAdd.Focus()

        Else
            Dim Ccustomer As New cEmployee

            'Ccustomer.CustomerID = txtCustId.Text
            Ccustomer.CustomerType = cboCustType.Text
            Ccustomer.OrganizationName = txtCustOrgName.Text
            Ccustomer.fname = txtCustFname.Text
            Ccustomer.lname = txtCustLname.Text
            Ccustomer.address = txtCustAdd.Text
            Ccustomer.ContactNo = txtCustContact.Text
            Ccustomer.E_mail = txtCustEmail.Text
            Ccustomer.imageloc = PBCustomer.Tag
            If PBCustomer.Tag = "" Then
                PBCustomer.Tag = "NULL"
                'MsgBox("PICTUREBOX")
            Else
                Ccustomer.addCostumer()
                clearCustomer()

            End If
        End If

    End Sub

    Private Sub cmdCustBrowse_Click(sender As Object, e As EventArgs) Handles cmdCustBrowse.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.InitialDirectory = "C:\temp"
        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.PBCustomer.ImageLocation = fdlg.FileName
            Me.PBCustomer.Tag = fdlg.FileName
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtcustSearch.TextChanged
        If txtcustSearch.Text = "" Then
            clearCustomer()
            'cmdUpdateEmp.Enabled = False
            'cmdDeleteEmp.Enabled = False
        Else
            retriveCostumer()



            '  cmdUpdateEmp.Enabled = True
            ' cmdDeleteEmp.Enabled = True

        End If
    End Sub

    Private Sub TextBox8_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcustSearch.KeyUp
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub cmdCustEdit_Click(sender As Object, e As EventArgs) Handles cmdCustEdit.Click
        updateCostumer()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmPOS.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        panelProduct.Visible = False
        pnlEmployee.Visible = False
        panelSupplier.Visible = False
        panelContextRegister.Visible = False
        PnlCustomer.Visible = False
        PnlMain.Visible = True
        pnlReports.Visible = False
        lblHEADER.Text = "Main"
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click

        frmSalesReport.Label1.Text = "Sales Report"
        frmSalesReport.GBRemittance.Visible = False
        frmSalesReport.gbSales.Visible = True
        frmSalesReport.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        panelProduct.Visible = False
        pnlEmployee.Visible = False
        panelSupplier.Visible = False
        panelContextRegister.Visible = False
        PnlCustomer.Visible = False
        PnlMain.Visible = False
        pnlReports.Visible = True
        lblHEADER.Text = "Reports"
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles btnRemittance.Click

        frmSalesReport.Label1.Text = "Remittance Report"
        frmSalesReport.GBRemittance.Visible = True
        frmSalesReport.gbSales.Visible = False
        frmSalesReport.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmReport_product.GroupBox1.Visible = False
        frmReport_product.GBProduct.Visible = True
        frmReport_product.ShowDialog()

    End Sub

    Private Sub frmDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class