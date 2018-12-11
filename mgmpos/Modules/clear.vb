Module clear
    'Private m_FRMDASHBOARD As frmDashboard
    'Public ReadOnly Property frmDashboard As frmDashboard
    '    Get
    '        If IsNothing(m_FRMDASHBOARD) Then m_FRMDASHBOARD = New frmDashboard
    '        Return m_FRMDASHBOARD
    '    End Get
    'End Property
    Public Sub clearproducts()
        frmDashboard.tb_prod_cat_name.Text = ""
        frmDashboard.tb_prod_cat_desc.Text = ""
    End Sub
    Public Sub clearlocation()
        frmDashboard.tblocationname.Text = ""
        frmDashboard.tblocdesc.Text = ""

    End Sub
    Public Sub clearProducto()
        frmDashboard.tbprodID.Text = ""
        frmDashboard.tbprodname.Text = ""
        frmDashboard.txtPdesc.Text = ""
        frmDashboard.tbproduct_code.Text = ""
        frmDashboard.tbproduct_markup.Text = 0
        frmDashboard.tbproduct_srp.Text = 0
        frmDashboard.tbproduct_supprice.Text = 0
        frmDashboard.cboproduct_category.Text = ""
        frmDashboard.cboproduct_supplier.Text = ""
        frmDashboard.cbo_product_uom.Text = ""
        frmDashboard.txtbegStock.Text = ""
        frmDashboard.txtReorder.Text = ""

    End Sub
    Public Sub clearSupplier()
        frmDashboard.txtsupId.Text = ""
        frmDashboard.txtsupname.Text = ""
        frmDashboard.txtsuppadd.Text = ""
        frmDashboard.txtsuppcontact.Text = ""
        frmDashboard.txtSuppEmail.Text = ""
        frmDashboard.txtsupptin.Text = ""
        frmDashboard.pbSupp.ImageLocation = "C:\Users\alexfieljr\Pictures\asgardPIX\profile.png"
    End Sub
End Module
