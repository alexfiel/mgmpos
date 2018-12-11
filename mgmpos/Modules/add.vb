Imports MySql.Data.MySqlClient

Module add
    'Private m_FRMDASHBOARD As frmDashboard
    'Public ReadOnly Property frmDashboard As frmDashboard
    '    Get
    '        If IsNothing(m_FRMDASHBOARD) Then m_FRMDASHBOARD = New frmDashboard
    '        Return m_FRMDASHBOARD
    '    End Get
    'End Property

    Public Sub addSupplier()
        Try
            dbConnection()
            sql = "INSERT INTO suppliers_database(`Name`, `Address`, `Contact_Number`, `emailadd`, `TIN`, `imgloc`) VALUES (@Name, @Add, @Con, @email, @tin, @imgloc);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", frmDashboard.txtsupname.Text)
                .Parameters.AddWithValue("@Add", frmDashboard.txtsuppadd.Text)
                .Parameters.AddWithValue("@Con", frmDashboard.txtsuppcontact.Text)
                .Parameters.AddWithValue("@email", frmDashboard.txtSuppEmail.Text)
                .Parameters.AddWithValue("@tin", frmDashboard.txtsupptin.Text)
                .Parameters.AddWithValue("@imgloc", frmDashboard.pbSupp.ImageLocation)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new Supplier!")
                Else
                    MsgBox("Successfully added new Supplier!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub
    Public Sub addCategoryProducts()
        Try
            dbConnection()
            sql = "INSERT INTO category_database(`Name`, `description`) VALUES (@Name, @description);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", frmDashboard.tb_prod_cat_name.Text)
                .Parameters.AddWithValue("@description", frmDashboard.tb_prod_cat_desc.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new product category!")
                Else
                    MsgBox("Successfully added new product category!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub
    Public Sub addlocation()
        Try
            dbConnection()
            sql = "INSERT INTO location(`locationname`, `locationdesc`) VALUES (@LocName, @Locdesc);"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@LocName", frmDashboard.tblocationname.Text)
                .Parameters.AddWithValue("@Locdesc", frmDashboard.tblocdesc.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new location!")
                Else
                    MsgBox("Successfully added new location!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub
    Public Sub addproducts()
        Try
            dbConnection()
            'sql="INSERT INTO `newpost_database`.`product` (`prodcode`, `prodname`, `prod_description`, `prodcategory`, `uom`, `prodsupplier`, `prodsupprice`, `prodmarkup`, `prodsrp`, `prod_begin_qty`, `prod_reorder_qty`) VALUES ('4987176601285', 'VICKS VAPORUB', '50g', 'ELECTRICAL', 'piece', 'ABC', '35', '10', '38.5', '10', '5');"
            sql = "INSERT INTO product (`prodcode`, `prodname`, `prod_description`, `prodcategory`, `uom`, `prodsupplier`, `prodsupprice`, `prodmarkup`, `prodsrp`, `prod_begin_qty`, `prod_reorder_qty`) VALUES " &
                "(@pCode, @pname, @pdesc, @pcat, @puom, @psupp, @psprice, @pmarkup, @psrp,@begqty,@preorder);"

            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@pCode", frmDashboard.tbproduct_code.Text)
                .Parameters.AddWithValue("@pname", frmDashboard.tbprodname.Text)
                .Parameters.AddWithValue("@pdesc", frmDashboard.txtPdesc.Text)
                .Parameters.AddWithValue("@pcat", frmDashboard.cboproduct_category.Text)
                .Parameters.AddWithValue("@puom", frmDashboard.cbo_product_uom.Text)
                .Parameters.AddWithValue("@psupp", frmDashboard.cboproduct_supplier.Text)
                .Parameters.AddWithValue("@psprice", frmDashboard.tbproduct_supprice.Text)
                .Parameters.AddWithValue("@pmarkup", frmDashboard.tbproduct_markup.Text)
                .Parameters.AddWithValue("@psrp", frmDashboard.tbproduct_srp.Text)
                .Parameters.AddWithValue("@begqty", frmDashboard.txtbegStock.Text)
                .Parameters.AddWithValue("@preorder", frmDashboard.txtReorder.Text)
                result = .ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Error in adding new product!")
                Else
                    MsgBox("Successfully added new product !")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub
    Public Sub addproduct_inventory()
        userId = 2
        Try
            dbConnection()
            '(`prodcode`, `units`, `qtyin`, `supplierID`, `userID`) 
            'sql = "INSERT INTO product(`prodcode`, `prodname`, `prodcategory`, `uom`, `prodsupplier`, `prodsupprice`, `prodmarkup`, `prodsrp`) VALUES (@pCode, @pname, @pat, @puom, @psupp, @psprice, @pmarkup, @psrp);"
            sql = "INSERT INTO inventory_product (`prodcode`, `units`, `qtyin`, `supplierID`,`total`, `userID`, `entrydate`) VALUES " &
                "(@pCode, @unit, @qtyin, @supid, @total, @userid, @enDate);"

            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@pCode", frmDashboard.tbproduct_code.Text)
                .Parameters.AddWithValue("@unit", frmDashboard.cbo_product_uom.Text)
                .Parameters.AddWithValue("@supID", suppID)
                .Parameters.AddWithValue("@qtyin", frmDashboard.txtbegStock.Text)
                .Parameters.AddWithValue("@total", frmDashboard.txtbegStock.Text)
                .Parameters.AddWithValue("@userid", userId)
                .Parameters.AddWithValue("@enDate", frmDashboard.lblDateTime.Text)
                result = .ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Error in adding new product inventory!")
                Else
                    MsgBox("Successfully added new product inventory !")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try

    End Sub


End Module
