Imports MySql.Data.MySqlClient

Module updates

    'Private m_FRMDASHBOARD As frmDashboard
    'Public ReadOnly Property frmDashboard As frmDashboard
    '    Get
    '        If IsNothing(m_FRMDASHBOARD) Then m_FRMDASHBOARD = New frmDashboard
    '        Return m_FRMDASHBOARD
    '    End Get
    'End Property

    'Private m_frmstockdashboard As frmStockDashboard
    'Public ReadOnly Property frmStockDashboard As frmStockDashboard
    '    Get
    '        If IsNothing(m_frmstockdashboard) Then m_frmstockdashboard = New frmStockDashboard
    '        Return m_frmstockdashboard
    '    End Get
    'End Property

    Public Sub updateqtyin()
        Try
            dbConnection()
            sql = "UPDATE `inventory_product` SET  `refno_in`=@docno, `qtyin`=@qtyin', `date`=@date', `total`=@total, `locationId`=@locid, `userID`=@userID WHERE `prodcode`=@prodcode;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@prodcode", frmStockDashboard.txtSpcode.Text)
                .Parameters.AddWithValue("@qtyin", frmStockDashboard.txtqtyreceived.Text)
                .Parameters.AddWithValue("@docno", frmStockDashboard.txtSdocNo.Text)
                .Parameters.AddWithValue("@date", frmStockDashboard.DTPSreceived.Text)
                .Parameters.AddWithValue("@locid", locationid)
                .Parameters.AddWithValue("@total", frmStockDashboard.txttotal.Text)
                .Parameters.AddWithValue("@userID", userId)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating Stock IN !")
                Else
                    MsgBox("Successfully updated the selected Stock !")
                End If
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub
    Public Sub updateSupplier()
        Try
            dbConnection()
            sql = "UPDATE `suppliers_database` SET `Name`=@uName, `Address`=@uAdd, `Contact_Number`=@uContact, `emailadd`=@uemail, `TIN`=@uTin, `imgloc`=@uimgLoc WHERE `Supplier_ID`=@uSupID;"
            'sql = "UPDATE suppliers_database SET `Name`=@uName, `Address`=@uAdd, `Contact_Number`=@uContact, `emailadd`=@uemail, `TIN`=@uTin, 'imgloc' =@uimgloc  WHERE `Supplier_ID`=@uSupId;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@uName", frmDashboard.txtsupname.Text)
                .Parameters.AddWithValue("@uAdd", frmDashboard.txtsuppadd.Text)
                .Parameters.AddWithValue("@uContact", frmDashboard.txtsuppcontact.Text)
                .Parameters.AddWithValue("@uemail", frmDashboard.txtSuppEmail.Text)
                .Parameters.AddWithValue("@uTin", frmDashboard.txtsupptin.Text)
                .Parameters.AddWithValue("@uimgLoc", frmDashboard.pbSupp.ImageLocation)
                .Parameters.AddWithValue("@uSupId", frmDashboard.txtsupId.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating Supplier !")
                Else
                    MsgBox("Successfully updated the selected Supplier !")
                End If
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub

    Public Sub updateproducts()
        Try
            dbConnection()
            ' sql="UPDATE product SET `prodcode`=@pCode, `prodname`='U-BOX', `prod_description`='RED', `prodcategory`='PLUMBING', `uom`='piece', `prodsupplier`='ABC', `prodsupprice`='23', `prodmarkup`='10', `prodsrp`='25', `prod_begin_qty`='25', `prod_reorder_qty`='11' WHERE `idproduct`='2' and`prodcode`='345345';"
            sql = "UPDATE product SET `prodcode`=@pCode, `prodname`=@pName, `prod_description`=@pDesc, `prodcategory`=@pCat, `uom`=@pUom, `prodsupplier`=@pSup, `prodsupprice`=@pSprice, `prodmarkup`=@pMarkup, `prodsrp`=@pSrp, `prod_begin_qty`=@begQty, `prod_reorder_qty`=@reorder WHERE `idproduct`=@pID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@pID", frmDashboard.tbprodID.Text)
                .Parameters.AddWithValue("@pCode", frmDashboard.tbproduct_code.Text)
                .Parameters.AddWithValue("@pName", frmDashboard.tbprodname.Text)
                .Parameters.AddWithValue("@pDesc", frmDashboard.txtPdesc.Text)
                .Parameters.AddWithValue("@pCat", frmDashboard.cboproduct_category.Text)
                .Parameters.AddWithValue("@pUom", frmDashboard.cbo_product_uom.Text)
                .Parameters.AddWithValue("@pSup", frmDashboard.cboproduct_supplier.Text)
                .Parameters.AddWithValue("@pSprice", frmDashboard.tbproduct_supprice.Text)
                .Parameters.AddWithValue("@pMarkup", frmDashboard.tbproduct_markup.Text)
                .Parameters.AddWithValue("@pSrp", frmDashboard.tbproduct_srp.Text)
                .Parameters.AddWithValue("@begQty", frmDashboard.txtbegStock.Text)
                .Parameters.AddWithValue("@reorder", frmDashboard.txtReorder.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating product !")
                Else
                    MsgBox("Successfully updated the selected product !")
                End If
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            frmDashboard.tbproductcat_id.Text = ""
        End Try
    End Sub
    Public Sub updatecategoryproducts()
        Try
            dbConnection()
            sql = "UPDATE category_database SET Name = @Name, description = @catDesc WHERE Category_ID = @CategoryID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", frmDashboard.tb_prod_cat_name.Text)
                .Parameters.AddWithValue("@catDesc", frmDashboard.tb_prod_cat_desc.Text)
                .Parameters.AddWithValue("@CategoryID", frmDashboard.tbproductcat_id.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating product category!")
                Else
                    MsgBox("Successfully updated the selected product category!")
                End If
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            frmDashboard.tbprodID.Text = ""
        End Try
    End Sub
    Public Sub updatelocation()
        Try
            dbConnection()
            sql = "UPDATE location SET locationname = @locName, locationdesc = @locDesc WHERE locationId = @locID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@locName", frmDashboard.tblocationname.Text)
                .Parameters.AddWithValue("@locDesc", frmDashboard.tblocdesc.Text)
                .Parameters.AddWithValue("@locID", frmDashboard.tblocid.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating Location!")
                Else
                    MsgBox("Successfully updated Location!")
                End If
            End With
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            frmDashboard.tblocid.Text = ""
        End Try
    End Sub
    Public Sub updateCostumer()
        Try
            dbConnection()
            sql = "UPDATE customer SET `costumerType`=@costumerType,`orgName`=@orgName, `firstname`=@firstname, `lastname`=@lastname, `address`=@address, `contact`=@contact, `email`=@email, `imgLocation`=@imglocation WHERE `objid`=@objid;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@objid", frmDashboard.lblobjid.Text)
                .Parameters.AddWithValue("@orgName", frmDashboard.txtCustOrgName.Text)
                .Parameters.AddWithValue("@costumerType", frmDashboard.cboCustType.Text)
                .Parameters.AddWithValue("@firstname", frmDashboard.txtCustFname.Text)
                .Parameters.AddWithValue("@lastname", frmDashboard.txtCustLname.Text)
                .Parameters.AddWithValue("@address", frmDashboard.txtCustAdd.Text)
                .Parameters.AddWithValue("@contact", frmDashboard.txtCustContact.Text)
                .Parameters.AddWithValue("@email", frmDashboard.txtCustEmail.Text)
                .Parameters.AddWithValue("@imglocation", frmDashboard.PBCustomer.ImageLocation)
                result = .ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Error in updating Costumer!")
                Else
                    MsgBox("Successfully updated Costumer!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub xupdateEmployee()
        Try
            dbConnection()
            sql = "UPDATE employees_database SET `First_Name`= @Fname, `Middle_Name`=@Mname, `Last_Name`=@Lname, `Username`=@Uname, `Password`=@Pss, `User_Level`=@Ulevel, `img_location`=@imgloc WHERE `Employee_ID`=@EmId;"
            ' sql = "UPDATE employees_database SET 'First_Name' = @Fname, 'Middle_Name' = @Mname, 'Last_Name' = @Lname, 'Username'= @Uname, 'Password' = @Pass, 'User_Level' = @Ulevel, 'img_location' = @imgloc WHERE Employee_ID = @EmID;"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@EmID", frmDashboard.txtempid.Text)
                .Parameters.AddWithValue("@Fname", frmDashboard.txtfname.Text)
                .Parameters.AddWithValue("@Mname", frmDashboard.txtmname.Text)
                .Parameters.AddWithValue("@Lname", frmDashboard.txtlname.Text)
                .Parameters.AddWithValue("@Uname", frmDashboard.txtuser.Text)
                .Parameters.AddWithValue("@Pss", frmDashboard.txtpass.Text)
                .Parameters.AddWithValue("@Ulevel", frmDashboard.cboDesignation.Text)
                .Parameters.AddWithValue("@imgloc", frmDashboard.pbEmp.ImageLocation)

                result = .ExecuteNonQuery

                If result = 0 Then
                    MsgBox("Error in updating Employee!")
                Else
                    MsgBox("Successfully updated employee!")
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
