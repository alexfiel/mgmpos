Imports MySql.Data.MySqlClient

Module delete
    'Private m_FRMDASHBOARD As frmDashboard
    'Public ReadOnly Property frmDashboard As frmDashboard
    '    Get
    '        If IsNothing(m_FRMDASHBOARD) Then m_FRMDASHBOARD = New frmDashboard
    '        Return m_FRMDASHBOARD
    '    End Get
    'End Property
    Public Sub delproduct()
        frmDashboard.btnprodDelete.Text = MessageBox.Show("Deleting this product will also delete the inventory! Are you sure you want to proceed?", "WARNING: DELETION OF PRODUCT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If frmDashboard.btnprodDelete.Text = DialogResult.Yes Then
            frmDashboard.btnprodDelete.Text = "Delete"
            Try
                dbConnection()
                ' delete FROM `newpost_database`.`product` WHERE `idproduct`='9' and`prodcode`='89098979097';
                'delete inventory_product, product from inventory_product inner join product On inventory_product.prodcode = product.prodcode where inventory_product.prodcode ='1234567890';
                sql = "DELETE inventory_product, product from inventory_product inner join product On inventory_product.prodcode = product.prodcode where inventory_product.prodcode =@pcode;"
                ' sql = "DELETE from product WHERE `idproduct`=@pId"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@pcode", frmDashboard.tbproduct_code.Text)
                    result = .ExecuteNonQuery
                    If result = 0 Then
                        MsgBox("Error in deleting product!")
                    Else
                        MsgBox("Successfully deleted the selected product!")
                    End If
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                frmDashboard.tbprodID.Text = ""
            End Try
        Else
            frmDashboard.btnprodDelete.Text = "DELETE"
        End If
    End Sub
    Public Sub delprodcat()
        frmDashboard.btnpcdelete.Text = MessageBox.Show("Are you sure you want to delete the selected product category?", "WARNING: DELETION OF PRODUCT CATEGORY!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If frmDashboard.btnpcdelete.Text = DialogResult.Yes Then
            frmDashboard.btnpcdelete.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM category_database WHERE Category_ID = @CategoryID;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@CategoryID", frmDashboard.tbproductcat_id.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting product category!")
                    Else
                        MsgBox("Successfully deleted the selected product category!")
                    End If
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                frmDashboard.tbproductcat_id.Text = ""
            End Try
        Else
            frmDashboard.btnpcdelete.Text = "DELETE"

        End If
    End Sub
    Public Sub delLocation()
        frmDashboard.btnlocationDelete.Text = MessageBox.Show("Are you sure you want to delete the selected product category?", "WARNING: DELETION OF LOCATION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If frmDashboard.btnlocationDelete.Text = DialogResult.Yes Then
            frmDashboard.btnlocationDelete.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM location WHERE locationId = @locID;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@locID", frmDashboard.tblocid.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting location!")
                    Else
                        MsgBox("Successfully deleted the selected location !")
                    End If
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                frmDashboard.tbproductcat_id.Text = ""
            End Try
        Else
            frmDashboard.btnlocationDelete.Text = "Delete"
        End If
    End Sub
    Public Sub delEmployee()
        frmDashboard.cmdDeleteEmp.Text = MessageBox.Show("Are you sure you want to delete the selected product category?", "WARNING: DELETION OF EMPLOYEE!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If frmDashboard.cmdDeleteEmp.Text = DialogResult.Yes Then
            frmDashboard.cmdDeleteEmp.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM employees_database WHERE Employee_ID = @EmpID;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@EmpID", frmDashboard.txtempid.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting employee!")
                    Else
                        MsgBox("Successfully deleted the selected Employee !")
                    End If
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()

            End Try
        Else
            frmDashboard.cmdDeleteEmp.Text = "Delete"



        End If
    End Sub
    Public Sub deleteSupplier()
        frmDashboard.cmdSuppDelete.Text = MessageBox.Show("Are you sure you want to delete the selected Supplier?", "WARNING: DELETION OF SUPPLIER!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If frmDashboard.cmdSuppDelete.Text = DialogResult.Yes Then
            frmDashboard.cmdSuppDelete.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM suppliers_database WHERE `Supplier_ID`=@suppID;"
                ' sql = "DELETE FROM suppliers_database WHERE Supplier_ID = @SupId;"
                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@suppID", frmDashboard.txtsupId.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting Supplier!")
                    Else
                        MsgBox("Successfully deleted the selected Supplier !")
                    End If
                End With
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()

            End Try
        Else
            frmDashboard.cmdSuppDelete.Text = "Delete"



        End If
    End Sub

End Module
