<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlEmployee = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdDeleteEmp = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtempid = New System.Windows.Forms.TextBox()
        Me.cmdNewEmployee = New System.Windows.Forms.Button()
        Me.cmdUpdateEmp = New System.Windows.Forms.Button()
        Me.cboDesignation = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSearchEmp = New System.Windows.Forms.TextBox()
        Me.cmdSaveEmp = New System.Windows.Forms.Button()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.pbEmp = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.panelSupplier = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtsupId = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSuppEmail = New System.Windows.Forms.TextBox()
        Me.cmdNewSupp = New System.Windows.Forms.Button()
        Me.cmdSuppDelete = New System.Windows.Forms.Button()
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.cmdupdateSupp = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSearchSupplier = New System.Windows.Forms.TextBox()
        Me.cmdAddSupp = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.pbSupp = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtsupptin = New System.Windows.Forms.TextBox()
        Me.txtsuppcontact = New System.Windows.Forms.TextBox()
        Me.txtsuppadd = New System.Windows.Forms.TextBox()
        Me.txtsupname = New System.Windows.Forms.TextBox()
        Me.panelProduct = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControlProduct = New System.Windows.Forms.TabControl()
        Me.tab_prod_category = New System.Windows.Forms.TabPage()
        Me.dt_prod_cat = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pcbtnNew = New System.Windows.Forms.Button()
        Me.tbproductcat_id = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnpcdelete = New System.Windows.Forms.Button()
        Me.btn_prod_cat_update = New System.Windows.Forms.Button()
        Me.btn_prod_cat_add = New System.Windows.Forms.Button()
        Me.tb_prod_cat_desc = New System.Windows.Forms.TextBox()
        Me.tb_prod_cat_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablocation = New System.Windows.Forms.TabPage()
        Me.dglocation = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tblocid = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnlocationNew = New System.Windows.Forms.Button()
        Me.btnlocationDelete = New System.Windows.Forms.Button()
        Me.btnlocationUpdate = New System.Windows.Forms.Button()
        Me.btnlocationAdd = New System.Windows.Forms.Button()
        Me.tblocdesc = New System.Windows.Forms.TextBox()
        Me.tblocationname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tab_product = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dg_product = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtReorder = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtbegStock = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtPdesc = New System.Windows.Forms.TextBox()
        Me.tbprodID = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnprodNew = New System.Windows.Forms.Button()
        Me.tbproduct_markup = New System.Windows.Forms.TextBox()
        Me.btnprodDelete = New System.Windows.Forms.Button()
        Me.btnprodEdit = New System.Windows.Forms.Button()
        Me.btnprodAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbproduct_srp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbproduct_supprice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboproduct_supplier = New System.Windows.Forms.ComboBox()
        Me.cbo_product_uom = New System.Windows.Forms.ComboBox()
        Me.cboproduct_category = New System.Windows.Forms.ComboBox()
        Me.tbprodname = New System.Windows.Forms.TextBox()
        Me.tbproduct_code = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblHEADER = New System.Windows.Forms.Label()
        Me.panelContextRegister = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmdRegisterEmp = New System.Windows.Forms.Button()
        Me.cmdRegSupplier = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdProduct = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PnlCustomer = New System.Windows.Forms.Panel()
        Me.lblobjid = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.cmdCustSearch = New System.Windows.Forms.Button()
        Me.txtcustSearch = New System.Windows.Forms.TextBox()
        Me.cmdCustDelete = New System.Windows.Forms.Button()
        Me.cmdCustSave = New System.Windows.Forms.Button()
        Me.cmdCustEdit = New System.Windows.Forms.Button()
        Me.cmdCusNew = New System.Windows.Forms.Button()
        Me.cmdCustBrowse = New System.Windows.Forms.Button()
        Me.PBCustomer = New System.Windows.Forms.PictureBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtCustEmail = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtCustContact = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtCustAdd = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtCustLname = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtCustFname = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtCustOrgName = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cboCustType = New System.Windows.Forms.ComboBox()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.homedgproduct = New System.Windows.Forms.DataGridView()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.btnRemittance = New System.Windows.Forms.Button()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.btnCostumerReport = New System.Windows.Forms.Button()
        Me.btnStockReport = New System.Windows.Forms.Button()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmployee.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSupplier.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelProduct.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControlProduct.SuspendLayout()
        Me.tab_prod_category.SuspendLayout()
        CType(Me.dt_prod_cat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tablocation.SuspendLayout()
        CType(Me.dglocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.tab_product.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.panelContextRegister.SuspendLayout()
        Me.PnlCustomer.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMain.SuspendLayout()
        CType(Me.homedgproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReports.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.panelMenu.Controls.Add(Me.PictureBox10)
        Me.panelMenu.Controls.Add(Me.Button5)
        Me.panelMenu.Controls.Add(Me.PictureBox9)
        Me.panelMenu.Controls.Add(Me.PictureBox8)
        Me.panelMenu.Controls.Add(Me.PictureBox7)
        Me.panelMenu.Controls.Add(Me.PictureBox3)
        Me.panelMenu.Controls.Add(Me.lblDateTime)
        Me.panelMenu.Controls.Add(Me.Button4)
        Me.panelMenu.Controls.Add(Me.Button3)
        Me.panelMenu.Controls.Add(Me.Button2)
        Me.panelMenu.Controls.Add(Me.Button1)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(259, 749)
        Me.panelMenu.TabIndex = 0
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(12, 166)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(75, 79)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 10
        Me.PictureBox10.TabStop = False
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(3, 157)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(253, 97)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Main"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.mgmpos.My.Resources.Resources.reports
        Me.PictureBox9.Location = New System.Drawing.Point(12, 589)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(89, 71)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 8
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.mgmpos.My.Resources.Resources._220px_UPC_A_036000291452_svg
        Me.PictureBox8.Location = New System.Drawing.Point(12, 480)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(89, 71)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.mgmpos.My.Resources.Resources.black_product_256
        Me.PictureBox7.Location = New System.Drawing.Point(12, 378)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(89, 71)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 4
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.mgmpos.My.Resources.Resources.return_icon
        Me.PictureBox3.Location = New System.Drawing.Point(12, 270)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(32, 672)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(125, 20)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "DATE and TIME"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 572)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(253, 97)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Reports"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(253, 97)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "P.O.S"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 97)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stock"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 261)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 97)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Register"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mgmpos.My.Resources.Resources.MGGM
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlEmployee
        '
        Me.pnlEmployee.BackColor = System.Drawing.Color.Green
        Me.pnlEmployee.Controls.Add(Me.GroupBox5)
        Me.pnlEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlEmployee.Location = New System.Drawing.Point(396, 79)
        Me.pnlEmployee.Name = "pnlEmployee"
        Me.pnlEmployee.Size = New System.Drawing.Size(974, 590)
        Me.pnlEmployee.TabIndex = 2
        Me.pnlEmployee.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdDeleteEmp)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtempid)
        Me.GroupBox5.Controls.Add(Me.cmdNewEmployee)
        Me.GroupBox5.Controls.Add(Me.cmdUpdateEmp)
        Me.GroupBox5.Controls.Add(Me.cboDesignation)
        Me.GroupBox5.Controls.Add(Me.PictureBox4)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtSearchEmp)
        Me.GroupBox5.Controls.Add(Me.cmdSaveEmp)
        Me.GroupBox5.Controls.Add(Me.cmdBrowse)
        Me.GroupBox5.Controls.Add(Me.pbEmp)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtpass)
        Me.GroupBox5.Controls.Add(Me.txtuser)
        Me.GroupBox5.Controls.Add(Me.txtlname)
        Me.GroupBox5.Controls.Add(Me.txtmname)
        Me.GroupBox5.Controls.Add(Me.txtfname)
        Me.GroupBox5.Location = New System.Drawing.Point(138, 61)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(931, 367)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Employee Settings"
        '
        'cmdDeleteEmp
        '
        Me.cmdDeleteEmp.BackColor = System.Drawing.Color.Red
        Me.cmdDeleteEmp.Enabled = False
        Me.cmdDeleteEmp.Location = New System.Drawing.Point(389, 289)
        Me.cmdDeleteEmp.Name = "cmdDeleteEmp"
        Me.cmdDeleteEmp.Size = New System.Drawing.Size(94, 57)
        Me.cmdDeleteEmp.TabIndex = 23
        Me.cmdDeleteEmp.Text = "Delete"
        Me.cmdDeleteEmp.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(104, 66)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 16)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Emp. ID"
        '
        'txtempid
        '
        Me.txtempid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtempid.Enabled = False
        Me.txtempid.Location = New System.Drawing.Point(192, 60)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Size = New System.Drawing.Size(54, 22)
        Me.txtempid.TabIndex = 21
        '
        'cmdNewEmployee
        '
        Me.cmdNewEmployee.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdNewEmployee.Location = New System.Drawing.Point(192, 288)
        Me.cmdNewEmployee.Name = "cmdNewEmployee"
        Me.cmdNewEmployee.Size = New System.Drawing.Size(94, 57)
        Me.cmdNewEmployee.TabIndex = 20
        Me.cmdNewEmployee.Text = "New"
        Me.cmdNewEmployee.UseVisualStyleBackColor = False
        '
        'cmdUpdateEmp
        '
        Me.cmdUpdateEmp.BackColor = System.Drawing.Color.GreenYellow
        Me.cmdUpdateEmp.Enabled = False
        Me.cmdUpdateEmp.Location = New System.Drawing.Point(292, 289)
        Me.cmdUpdateEmp.Name = "cmdUpdateEmp"
        Me.cmdUpdateEmp.Size = New System.Drawing.Size(94, 57)
        Me.cmdUpdateEmp.TabIndex = 19
        Me.cmdUpdateEmp.Text = "Update"
        Me.cmdUpdateEmp.UseVisualStyleBackColor = False
        '
        'cboDesignation
        '
        Me.cboDesignation.FormattingEnabled = True
        Me.cboDesignation.Items.AddRange(New Object() {"Admin", "Cashier", "Data Entry"})
        Me.cboDesignation.Location = New System.Drawing.Point(192, 259)
        Me.cboDesignation.Name = "cboDesignation"
        Me.cboDesignation.Size = New System.Drawing.Size(291, 24)
        Me.cboDesignation.TabIndex = 18
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(875, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(534, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(116, 16)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Search Employee"
        '
        'txtSearchEmp
        '
        Me.txtSearchEmp.Location = New System.Drawing.Point(677, 26)
        Me.txtSearchEmp.Name = "txtSearchEmp"
        Me.txtSearchEmp.Size = New System.Drawing.Size(192, 22)
        Me.txtSearchEmp.TabIndex = 15
        '
        'cmdSaveEmp
        '
        Me.cmdSaveEmp.BackColor = System.Drawing.Color.DarkGreen
        Me.cmdSaveEmp.Location = New System.Drawing.Point(192, 289)
        Me.cmdSaveEmp.Name = "cmdSaveEmp"
        Me.cmdSaveEmp.Size = New System.Drawing.Size(94, 57)
        Me.cmdSaveEmp.TabIndex = 14
        Me.cmdSaveEmp.Text = "Add"
        Me.cmdSaveEmp.UseVisualStyleBackColor = False
        Me.cmdSaveEmp.Visible = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.LawnGreen
        Me.cmdBrowse.Location = New System.Drawing.Point(603, 259)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(79, 30)
        Me.cmdBrowse.TabIndex = 13
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'pbEmp
        '
        Me.pbEmp.ErrorImage = CType(resources.GetObject("pbEmp.ErrorImage"), System.Drawing.Image)
        Me.pbEmp.Image = Global.mgmpos.My.Resources.Resources.employee
        Me.pbEmp.Location = New System.Drawing.Point(491, 89)
        Me.pbEmp.Name = "pbEmp"
        Me.pbEmp.Size = New System.Drawing.Size(191, 164)
        Me.pbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmp.TabIndex = 12
        Me.pbEmp.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(79, 262)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 16)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Designation"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(98, 229)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 16)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Password"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(90, 196)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 16)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "User Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(90, 163)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 16)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Last Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(71, 130)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Middle Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(86, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "First Name"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(192, 221)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(291, 22)
        Me.txtpass.TabIndex = 4
        '
        'txtuser
        '
        Me.txtuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuser.Location = New System.Drawing.Point(192, 188)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(291, 22)
        Me.txtuser.TabIndex = 3
        '
        'txtlname
        '
        Me.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname.Location = New System.Drawing.Point(192, 155)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(291, 22)
        Me.txtlname.TabIndex = 2
        '
        'txtmname
        '
        Me.txtmname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmname.Location = New System.Drawing.Point(192, 122)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(291, 22)
        Me.txtmname.TabIndex = 1
        '
        'txtfname
        '
        Me.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfname.Location = New System.Drawing.Point(192, 89)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(291, 22)
        Me.txtfname.TabIndex = 0
        '
        'panelSupplier
        '
        Me.panelSupplier.Controls.Add(Me.GroupBox6)
        Me.panelSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSupplier.Location = New System.Drawing.Point(329, 88)
        Me.panelSupplier.Name = "panelSupplier"
        Me.panelSupplier.Size = New System.Drawing.Size(983, 590)
        Me.panelSupplier.TabIndex = 3
        Me.panelSupplier.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.txtsupId)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.txtSuppEmail)
        Me.GroupBox6.Controls.Add(Me.cmdNewSupp)
        Me.GroupBox6.Controls.Add(Me.cmdSuppDelete)
        Me.GroupBox6.Controls.Add(Me.DGSupplier)
        Me.GroupBox6.Controls.Add(Me.cmdupdateSupp)
        Me.GroupBox6.Controls.Add(Me.PictureBox5)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtSearchSupplier)
        Me.GroupBox6.Controls.Add(Me.cmdAddSupp)
        Me.GroupBox6.Controls.Add(Me.Button11)
        Me.GroupBox6.Controls.Add(Me.pbSupp)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.txtsupptin)
        Me.GroupBox6.Controls.Add(Me.txtsuppcontact)
        Me.GroupBox6.Controls.Add(Me.txtsuppadd)
        Me.GroupBox6.Controls.Add(Me.txtsupname)
        Me.GroupBox6.Location = New System.Drawing.Point(31, 26)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(928, 367)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Supplier Settings"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(86, 44)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 20)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "ID:"
        '
        'txtsupId
        '
        Me.txtsupId.Enabled = False
        Me.txtsupId.Location = New System.Drawing.Point(122, 38)
        Me.txtsupId.Name = "txtsupId"
        Me.txtsupId.Size = New System.Drawing.Size(57, 26)
        Me.txtsupId.TabIndex = 25
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(31, 218)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 20)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Email Add:"
        '
        'txtSuppEmail
        '
        Me.txtSuppEmail.Location = New System.Drawing.Point(122, 212)
        Me.txtSuppEmail.Name = "txtSuppEmail"
        Me.txtSuppEmail.Size = New System.Drawing.Size(271, 26)
        Me.txtSuppEmail.TabIndex = 4
        '
        'cmdNewSupp
        '
        Me.cmdNewSupp.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdNewSupp.Location = New System.Drawing.Point(122, 291)
        Me.cmdNewSupp.Name = "cmdNewSupp"
        Me.cmdNewSupp.Size = New System.Drawing.Size(94, 57)
        Me.cmdNewSupp.TabIndex = 7
        Me.cmdNewSupp.Text = "New"
        Me.cmdNewSupp.UseVisualStyleBackColor = False
        '
        'cmdSuppDelete
        '
        Me.cmdSuppDelete.BackColor = System.Drawing.Color.Red
        Me.cmdSuppDelete.Location = New System.Drawing.Point(322, 292)
        Me.cmdSuppDelete.Name = "cmdSuppDelete"
        Me.cmdSuppDelete.Size = New System.Drawing.Size(94, 57)
        Me.cmdSuppDelete.TabIndex = 21
        Me.cmdSuppDelete.Text = "Delete"
        Me.cmdSuppDelete.UseVisualStyleBackColor = False
        '
        'DGSupplier
        '
        Me.DGSupplier.AllowUserToDeleteRows = False
        Me.DGSupplier.AllowUserToOrderColumns = True
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(567, 71)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(330, 278)
        Me.DGSupplier.TabIndex = 20
        '
        'cmdupdateSupp
        '
        Me.cmdupdateSupp.BackColor = System.Drawing.Color.GreenYellow
        Me.cmdupdateSupp.Location = New System.Drawing.Point(222, 292)
        Me.cmdupdateSupp.Name = "cmdupdateSupp"
        Me.cmdupdateSupp.Size = New System.Drawing.Size(94, 57)
        Me.cmdupdateSupp.TabIndex = 19
        Me.cmdupdateSupp.Text = "Update"
        Me.cmdupdateSupp.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(870, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(534, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(122, 20)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Search Supplier"
        '
        'txtSearchSupplier
        '
        Me.txtSearchSupplier.Location = New System.Drawing.Point(656, 28)
        Me.txtSearchSupplier.Name = "txtSearchSupplier"
        Me.txtSearchSupplier.Size = New System.Drawing.Size(192, 26)
        Me.txtSearchSupplier.TabIndex = 15
        '
        'cmdAddSupp
        '
        Me.cmdAddSupp.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdAddSupp.Location = New System.Drawing.Point(122, 292)
        Me.cmdAddSupp.Name = "cmdAddSupp"
        Me.cmdAddSupp.Size = New System.Drawing.Size(94, 57)
        Me.cmdAddSupp.TabIndex = 14
        Me.cmdAddSupp.Text = "Add"
        Me.cmdAddSupp.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LawnGreen
        Me.Button11.Location = New System.Drawing.Point(472, 198)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(79, 30)
        Me.Button11.TabIndex = 6
        Me.Button11.Text = "Browse"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'pbSupp
        '
        Me.pbSupp.ErrorImage = CType(resources.GetObject("pbSupp.ErrorImage"), System.Drawing.Image)
        Me.pbSupp.Image = Global.mgmpos.My.Resources.Resources.employee
        Me.pbSupp.Location = New System.Drawing.Point(408, 70)
        Me.pbSupp.Name = "pbSupp"
        Me.pbSupp.Size = New System.Drawing.Size(143, 120)
        Me.pbSupp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSupp.TabIndex = 12
        Me.pbSupp.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(82, 255)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 20)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "TIN:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(20, 183)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(97, 20)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Contact No.:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(45, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 20)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Address:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(62, 76)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 20)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Name:"
        '
        'txtsupptin
        '
        Me.txtsupptin.Location = New System.Drawing.Point(122, 249)
        Me.txtsupptin.Name = "txtsupptin"
        Me.txtsupptin.Size = New System.Drawing.Size(271, 26)
        Me.txtsupptin.TabIndex = 5
        '
        'txtsuppcontact
        '
        Me.txtsuppcontact.Location = New System.Drawing.Point(122, 177)
        Me.txtsuppcontact.Name = "txtsuppcontact"
        Me.txtsuppcontact.Size = New System.Drawing.Size(271, 26)
        Me.txtsuppcontact.TabIndex = 3
        '
        'txtsuppadd
        '
        Me.txtsuppadd.Location = New System.Drawing.Point(122, 103)
        Me.txtsuppadd.Multiline = True
        Me.txtsuppadd.Name = "txtsuppadd"
        Me.txtsuppadd.Size = New System.Drawing.Size(271, 68)
        Me.txtsuppadd.TabIndex = 2
        '
        'txtsupname
        '
        Me.txtsupname.Location = New System.Drawing.Point(122, 70)
        Me.txtsupname.Name = "txtsupname"
        Me.txtsupname.Size = New System.Drawing.Size(271, 26)
        Me.txtsupname.TabIndex = 1
        '
        'panelProduct
        '
        Me.panelProduct.BackColor = System.Drawing.Color.SeaGreen
        Me.panelProduct.Controls.Add(Me.GroupBox1)
        Me.panelProduct.Location = New System.Drawing.Point(272, 70)
        Me.panelProduct.Name = "panelProduct"
        Me.panelProduct.Size = New System.Drawing.Size(1091, 688)
        Me.panelProduct.TabIndex = 3
        Me.panelProduct.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TabControlProduct)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1088, 682)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TabControlProduct
        '
        Me.TabControlProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlProduct.Controls.Add(Me.tab_prod_category)
        Me.TabControlProduct.Controls.Add(Me.tablocation)
        Me.TabControlProduct.Controls.Add(Me.tab_product)
        Me.TabControlProduct.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlProduct.Location = New System.Drawing.Point(6, 19)
        Me.TabControlProduct.Name = "TabControlProduct"
        Me.TabControlProduct.SelectedIndex = 0
        Me.TabControlProduct.Size = New System.Drawing.Size(1076, 654)
        Me.TabControlProduct.TabIndex = 0
        '
        'tab_prod_category
        '
        Me.tab_prod_category.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tab_prod_category.Controls.Add(Me.dt_prod_cat)
        Me.tab_prod_category.Controls.Add(Me.GroupBox2)
        Me.tab_prod_category.Location = New System.Drawing.Point(4, 28)
        Me.tab_prod_category.Name = "tab_prod_category"
        Me.tab_prod_category.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_prod_category.Size = New System.Drawing.Size(1068, 622)
        Me.tab_prod_category.TabIndex = 0
        Me.tab_prod_category.Text = "Product Category"
        '
        'dt_prod_cat
        '
        Me.dt_prod_cat.AllowUserToAddRows = False
        Me.dt_prod_cat.AllowUserToDeleteRows = False
        Me.dt_prod_cat.AllowUserToOrderColumns = True
        Me.dt_prod_cat.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dt_prod_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_prod_cat.Location = New System.Drawing.Point(37, 279)
        Me.dt_prod_cat.Name = "dt_prod_cat"
        Me.dt_prod_cat.ReadOnly = True
        Me.dt_prod_cat.RowHeadersWidth = 30
        Me.dt_prod_cat.Size = New System.Drawing.Size(478, 258)
        Me.dt_prod_cat.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pcbtnNew)
        Me.GroupBox2.Controls.Add(Me.tbproductcat_id)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnpcdelete)
        Me.GroupBox2.Controls.Add(Me.btn_prod_cat_update)
        Me.GroupBox2.Controls.Add(Me.btn_prod_cat_add)
        Me.GroupBox2.Controls.Add(Me.tb_prod_cat_desc)
        Me.GroupBox2.Controls.Add(Me.tb_prod_cat_name)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(37, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 232)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Product Category"
        '
        'pcbtnNew
        '
        Me.pcbtnNew.ForeColor = System.Drawing.SystemColors.Desktop
        Me.pcbtnNew.Location = New System.Drawing.Point(775, 42)
        Me.pcbtnNew.Name = "pcbtnNew"
        Me.pcbtnNew.Size = New System.Drawing.Size(136, 52)
        Me.pcbtnNew.TabIndex = 9
        Me.pcbtnNew.Text = "&New"
        Me.pcbtnNew.UseVisualStyleBackColor = True
        '
        'tbproductcat_id
        '
        Me.tbproductcat_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbproductcat_id.Enabled = False
        Me.tbproductcat_id.Location = New System.Drawing.Point(245, 51)
        Me.tbproductcat_id.Name = "tbproductcat_id"
        Me.tbproductcat_id.Size = New System.Drawing.Size(112, 27)
        Me.tbproductcat_id.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(146, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 19)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Category ID"
        '
        'btnpcdelete
        '
        Me.btnpcdelete.Enabled = False
        Me.btnpcdelete.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnpcdelete.Location = New System.Drawing.Point(775, 158)
        Me.btnpcdelete.Name = "btnpcdelete"
        Me.btnpcdelete.Size = New System.Drawing.Size(136, 52)
        Me.btnpcdelete.TabIndex = 6
        Me.btnpcdelete.Text = "&Delete"
        Me.btnpcdelete.UseVisualStyleBackColor = True
        '
        'btn_prod_cat_update
        '
        Me.btn_prod_cat_update.Enabled = False
        Me.btn_prod_cat_update.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_prod_cat_update.Location = New System.Drawing.Point(775, 100)
        Me.btn_prod_cat_update.Name = "btn_prod_cat_update"
        Me.btn_prod_cat_update.Size = New System.Drawing.Size(136, 52)
        Me.btn_prod_cat_update.TabIndex = 5
        Me.btn_prod_cat_update.Text = "&Update"
        Me.btn_prod_cat_update.UseVisualStyleBackColor = True
        '
        'btn_prod_cat_add
        '
        Me.btn_prod_cat_add.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_prod_cat_add.Location = New System.Drawing.Point(775, 42)
        Me.btn_prod_cat_add.Name = "btn_prod_cat_add"
        Me.btn_prod_cat_add.Size = New System.Drawing.Size(136, 52)
        Me.btn_prod_cat_add.TabIndex = 4
        Me.btn_prod_cat_add.Text = "&Add"
        Me.btn_prod_cat_add.UseVisualStyleBackColor = True
        Me.btn_prod_cat_add.Visible = False
        '
        'tb_prod_cat_desc
        '
        Me.tb_prod_cat_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_prod_cat_desc.Location = New System.Drawing.Point(245, 122)
        Me.tb_prod_cat_desc.Multiline = True
        Me.tb_prod_cat_desc.Name = "tb_prod_cat_desc"
        Me.tb_prod_cat_desc.Size = New System.Drawing.Size(486, 88)
        Me.tb_prod_cat_desc.TabIndex = 3
        '
        'tb_prod_cat_name
        '
        Me.tb_prod_cat_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_prod_cat_name.Location = New System.Drawing.Point(245, 84)
        Me.tb_prod_cat_name.Name = "tb_prod_cat_name"
        Me.tb_prod_cat_name.Size = New System.Drawing.Size(486, 27)
        Me.tb_prod_cat_name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Name"
        '
        'tablocation
        '
        Me.tablocation.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tablocation.Controls.Add(Me.dglocation)
        Me.tablocation.Controls.Add(Me.GroupBox4)
        Me.tablocation.Location = New System.Drawing.Point(4, 28)
        Me.tablocation.Name = "tablocation"
        Me.tablocation.Size = New System.Drawing.Size(1068, 622)
        Me.tablocation.TabIndex = 2
        Me.tablocation.Text = "Location"
        '
        'dglocation
        '
        Me.dglocation.AllowUserToAddRows = False
        Me.dglocation.AllowUserToDeleteRows = False
        Me.dglocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglocation.Location = New System.Drawing.Point(38, 311)
        Me.dglocation.Name = "dglocation"
        Me.dglocation.ReadOnly = True
        Me.dglocation.Size = New System.Drawing.Size(545, 187)
        Me.dglocation.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tblocid)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.btnlocationNew)
        Me.GroupBox4.Controls.Add(Me.btnlocationDelete)
        Me.GroupBox4.Controls.Add(Me.btnlocationUpdate)
        Me.GroupBox4.Controls.Add(Me.btnlocationAdd)
        Me.GroupBox4.Controls.Add(Me.tblocdesc)
        Me.GroupBox4.Controls.Add(Me.tblocationname)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(38, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(984, 232)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "New Location"
        '
        'tblocid
        '
        Me.tblocid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tblocid.Enabled = False
        Me.tblocid.Location = New System.Drawing.Point(256, 33)
        Me.tblocid.Name = "tblocid"
        Me.tblocid.Size = New System.Drawing.Size(99, 27)
        Me.tblocid.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(144, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 19)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Location Id:"
        '
        'btnlocationNew
        '
        Me.btnlocationNew.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnlocationNew.Location = New System.Drawing.Point(775, 41)
        Me.btnlocationNew.Name = "btnlocationNew"
        Me.btnlocationNew.Size = New System.Drawing.Size(136, 52)
        Me.btnlocationNew.TabIndex = 10
        Me.btnlocationNew.Text = "&New"
        Me.btnlocationNew.UseVisualStyleBackColor = True
        '
        'btnlocationDelete
        '
        Me.btnlocationDelete.Enabled = False
        Me.btnlocationDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlocationDelete.Location = New System.Drawing.Point(775, 158)
        Me.btnlocationDelete.Name = "btnlocationDelete"
        Me.btnlocationDelete.Size = New System.Drawing.Size(136, 52)
        Me.btnlocationDelete.TabIndex = 6
        Me.btnlocationDelete.Text = "&Delete"
        Me.btnlocationDelete.UseVisualStyleBackColor = True
        '
        'btnlocationUpdate
        '
        Me.btnlocationUpdate.Enabled = False
        Me.btnlocationUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlocationUpdate.Location = New System.Drawing.Point(775, 100)
        Me.btnlocationUpdate.Name = "btnlocationUpdate"
        Me.btnlocationUpdate.Size = New System.Drawing.Size(136, 52)
        Me.btnlocationUpdate.TabIndex = 5
        Me.btnlocationUpdate.Text = "&Update"
        Me.btnlocationUpdate.UseVisualStyleBackColor = True
        '
        'btnlocationAdd
        '
        Me.btnlocationAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlocationAdd.Location = New System.Drawing.Point(775, 42)
        Me.btnlocationAdd.Name = "btnlocationAdd"
        Me.btnlocationAdd.Size = New System.Drawing.Size(136, 52)
        Me.btnlocationAdd.TabIndex = 4
        Me.btnlocationAdd.Text = "&Add"
        Me.btnlocationAdd.UseVisualStyleBackColor = True
        Me.btnlocationAdd.Visible = False
        '
        'tblocdesc
        '
        Me.tblocdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tblocdesc.Location = New System.Drawing.Point(256, 122)
        Me.tblocdesc.Multiline = True
        Me.tblocdesc.Name = "tblocdesc"
        Me.tblocdesc.Size = New System.Drawing.Size(486, 88)
        Me.tblocdesc.TabIndex = 3
        '
        'tblocationname
        '
        Me.tblocationname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tblocationname.Location = New System.Drawing.Point(256, 76)
        Me.tblocationname.Name = "tblocationname"
        Me.tblocationname.Size = New System.Drawing.Size(486, 27)
        Me.tblocationname.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Location Description"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(118, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Location Name"
        '
        'tab_product
        '
        Me.tab_product.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.tab_product.Controls.Add(Me.PictureBox2)
        Me.tab_product.Controls.Add(Me.tbSearch)
        Me.tab_product.Controls.Add(Me.Label14)
        Me.tab_product.Controls.Add(Me.dg_product)
        Me.tab_product.Controls.Add(Me.GroupBox3)
        Me.tab_product.Location = New System.Drawing.Point(4, 28)
        Me.tab_product.Name = "tab_product"
        Me.tab_product.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_product.Size = New System.Drawing.Size(1068, 622)
        Me.tab_product.TabIndex = 1
        Me.tab_product.Text = "Product"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1008, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'tbSearch
        '
        Me.tbSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSearch.Location = New System.Drawing.Point(777, 15)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(234, 27)
        Me.tbSearch.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(650, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 19)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Search Product"
        '
        'dg_product
        '
        Me.dg_product.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dg_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dg_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_product.GridColor = System.Drawing.Color.PaleGoldenrod
        Me.dg_product.Location = New System.Drawing.Point(10, 48)
        Me.dg_product.Name = "dg_product"
        Me.dg_product.Size = New System.Drawing.Size(1056, 223)
        Me.dg_product.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtReorder)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.txtbegStock)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.txtPdesc)
        Me.GroupBox3.Controls.Add(Me.tbprodID)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.btnprodNew)
        Me.GroupBox3.Controls.Add(Me.tbproduct_markup)
        Me.GroupBox3.Controls.Add(Me.btnprodDelete)
        Me.GroupBox3.Controls.Add(Me.btnprodEdit)
        Me.GroupBox3.Controls.Add(Me.btnprodAdd)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tbproduct_srp)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.tbproduct_supprice)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cboproduct_supplier)
        Me.GroupBox3.Controls.Add(Me.cbo_product_uom)
        Me.GroupBox3.Controls.Add(Me.cboproduct_category)
        Me.GroupBox3.Controls.Add(Me.tbprodname)
        Me.GroupBox3.Controls.Add(Me.tbproduct_code)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1056, 252)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'txtReorder
        '
        Me.txtReorder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReorder.Location = New System.Drawing.Point(581, 193)
        Me.txtReorder.Name = "txtReorder"
        Me.txtReorder.Size = New System.Drawing.Size(93, 27)
        Me.txtReorder.TabIndex = 15
        Me.txtReorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label34.Location = New System.Drawing.Point(425, 201)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(152, 19)
        Me.Label34.TabIndex = 28
        Me.Label34.Text = "Re-Order Qty Level:"
        '
        'txtbegStock
        '
        Me.txtbegStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbegStock.Location = New System.Drawing.Point(581, 160)
        Me.txtbegStock.Name = "txtbegStock"
        Me.txtbegStock.Size = New System.Drawing.Size(93, 27)
        Me.txtbegStock.TabIndex = 14
        Me.txtbegStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label33.Location = New System.Drawing.Point(455, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(119, 19)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "Begining Stock:"
        '
        'txtPdesc
        '
        Me.txtPdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPdesc.Location = New System.Drawing.Point(161, 127)
        Me.txtPdesc.Multiline = True
        Me.txtPdesc.Name = "txtPdesc"
        Me.txtPdesc.Size = New System.Drawing.Size(234, 48)
        Me.txtPdesc.TabIndex = 7
        '
        'tbprodID
        '
        Me.tbprodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbprodID.Enabled = False
        Me.tbprodID.Location = New System.Drawing.Point(161, 27)
        Me.tbprodID.Name = "tbprodID"
        Me.tbprodID.Size = New System.Drawing.Size(234, 27)
        Me.tbprodID.TabIndex = 22
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label32.Location = New System.Drawing.Point(59, 127)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 19)
        Me.Label32.TabIndex = 23
        Me.Label32.Text = "Description:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(45, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 19)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Product ID:"
        '
        'btnprodNew
        '
        Me.btnprodNew.BackColor = System.Drawing.Color.ForestGreen
        Me.btnprodNew.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnprodNew.Location = New System.Drawing.Point(753, 19)
        Me.btnprodNew.Name = "btnprodNew"
        Me.btnprodNew.Size = New System.Drawing.Size(170, 60)
        Me.btnprodNew.TabIndex = 20
        Me.btnprodNew.Text = "&New"
        Me.btnprodNew.UseVisualStyleBackColor = False
        '
        'tbproduct_markup
        '
        Me.tbproduct_markup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbproduct_markup.Location = New System.Drawing.Point(581, 94)
        Me.tbproduct_markup.Name = "tbproduct_markup"
        Me.tbproduct_markup.Size = New System.Drawing.Size(93, 27)
        Me.tbproduct_markup.TabIndex = 12
        Me.tbproduct_markup.Text = "0"
        Me.tbproduct_markup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnprodDelete
        '
        Me.btnprodDelete.BackColor = System.Drawing.Color.OrangeRed
        Me.btnprodDelete.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnprodDelete.Location = New System.Drawing.Point(753, 138)
        Me.btnprodDelete.Name = "btnprodDelete"
        Me.btnprodDelete.Size = New System.Drawing.Size(170, 54)
        Me.btnprodDelete.TabIndex = 18
        Me.btnprodDelete.Text = "&Delete"
        Me.btnprodDelete.UseVisualStyleBackColor = False
        '
        'btnprodEdit
        '
        Me.btnprodEdit.BackColor = System.Drawing.Color.Yellow
        Me.btnprodEdit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnprodEdit.Location = New System.Drawing.Point(753, 78)
        Me.btnprodEdit.Name = "btnprodEdit"
        Me.btnprodEdit.Size = New System.Drawing.Size(170, 60)
        Me.btnprodEdit.TabIndex = 17
        Me.btnprodEdit.Text = "&Edit"
        Me.btnprodEdit.UseVisualStyleBackColor = False
        '
        'btnprodAdd
        '
        Me.btnprodAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnprodAdd.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnprodAdd.Location = New System.Drawing.Point(753, 19)
        Me.btnprodAdd.Name = "btnprodAdd"
        Me.btnprodAdd.Size = New System.Drawing.Size(170, 60)
        Me.btnprodAdd.TabIndex = 16
        Me.btnprodAdd.Text = "&Add"
        Me.btnprodAdd.UseVisualStyleBackColor = False
        Me.btnprodAdd.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(494, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "% Markup:"
        '
        'tbproduct_srp
        '
        Me.tbproduct_srp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbproduct_srp.Location = New System.Drawing.Point(581, 127)
        Me.tbproduct_srp.Name = "tbproduct_srp"
        Me.tbproduct_srp.Size = New System.Drawing.Size(93, 27)
        Me.tbproduct_srp.TabIndex = 13
        Me.tbproduct_srp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(401, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Suggested Retail Price:"
        '
        'tbproduct_supprice
        '
        Me.tbproduct_supprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbproduct_supprice.Location = New System.Drawing.Point(581, 61)
        Me.tbproduct_supprice.Name = "tbproduct_supprice"
        Me.tbproduct_supprice.Size = New System.Drawing.Size(100, 27)
        Me.tbproduct_supprice.TabIndex = 11
        Me.tbproduct_supprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(459, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Supplier Price:"
        '
        'cboproduct_supplier
        '
        Me.cboproduct_supplier.FormattingEnabled = True
        Me.cboproduct_supplier.Location = New System.Drawing.Point(161, 216)
        Me.cboproduct_supplier.Name = "cboproduct_supplier"
        Me.cboproduct_supplier.Size = New System.Drawing.Size(234, 27)
        Me.cboproduct_supplier.TabIndex = 9
        '
        'cbo_product_uom
        '
        Me.cbo_product_uom.FormattingEnabled = True
        Me.cbo_product_uom.Items.AddRange(New Object() {"piece", "box", "pack", "meter", "centi meter", "kilo gram", "gram", "ounce", "ton", "liter", "ml"})
        Me.cbo_product_uom.Location = New System.Drawing.Point(581, 27)
        Me.cbo_product_uom.Name = "cbo_product_uom"
        Me.cbo_product_uom.Size = New System.Drawing.Size(129, 27)
        Me.cbo_product_uom.TabIndex = 10
        '
        'cboproduct_category
        '
        Me.cboproduct_category.FormattingEnabled = True
        Me.cboproduct_category.Location = New System.Drawing.Point(161, 181)
        Me.cboproduct_category.Name = "cboproduct_category"
        Me.cboproduct_category.Size = New System.Drawing.Size(234, 27)
        Me.cboproduct_category.TabIndex = 8
        '
        'tbprodname
        '
        Me.tbprodname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbprodname.Location = New System.Drawing.Point(161, 93)
        Me.tbprodname.Name = "tbprodname"
        Me.tbprodname.Size = New System.Drawing.Size(234, 27)
        Me.tbprodname.TabIndex = 6
        '
        'tbproduct_code
        '
        Me.tbproduct_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbproduct_code.Location = New System.Drawing.Point(161, 60)
        Me.tbproduct_code.Name = "tbproduct_code"
        Me.tbproduct_code.Size = New System.Drawing.Size(234, 27)
        Me.tbproduct_code.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(81, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Supplier:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(411, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Unit of Measurement :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(17, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Product Category:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(39, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(45, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product Code:"
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.panelHeader.Controls.Add(Me.lblHEADER)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(259, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1091, 61)
        Me.panelHeader.TabIndex = 1
        '
        'lblHEADER
        '
        Me.lblHEADER.AutoSize = True
        Me.lblHEADER.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHEADER.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHEADER.Location = New System.Drawing.Point(6, 0)
        Me.lblHEADER.Name = "lblHEADER"
        Me.lblHEADER.Size = New System.Drawing.Size(291, 55)
        Me.lblHEADER.TabIndex = 3
        Me.lblHEADER.Text = "REGISTER "
        '
        'panelContextRegister
        '
        Me.panelContextRegister.Controls.Add(Me.Label38)
        Me.panelContextRegister.Controls.Add(Me.Label37)
        Me.panelContextRegister.Controls.Add(Me.Label36)
        Me.panelContextRegister.Controls.Add(Me.Label35)
        Me.panelContextRegister.Controls.Add(Me.cmdRegisterEmp)
        Me.panelContextRegister.Controls.Add(Me.cmdRegSupplier)
        Me.panelContextRegister.Controls.Add(Me.cmdCustomer)
        Me.panelContextRegister.Controls.Add(Me.cmdProduct)
        Me.panelContextRegister.Location = New System.Drawing.Point(272, 108)
        Me.panelContextRegister.Name = "panelContextRegister"
        Me.panelContextRegister.Size = New System.Drawing.Size(790, 625)
        Me.panelContextRegister.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(474, 557)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(53, 13)
        Me.Label38.TabIndex = 7
        Me.Label38.Text = "Employee"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(197, 557)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(45, 13)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "Supplier"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(474, 320)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 13)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "Customer"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(197, 321)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 13)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Product"
        '
        'cmdRegisterEmp
        '
        Me.cmdRegisterEmp.BackgroundImage = Global.mgmpos.My.Resources.Resources.employee
        Me.cmdRegisterEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRegisterEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegisterEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegisterEmp.Location = New System.Drawing.Point(374, 353)
        Me.cmdRegisterEmp.Name = "cmdRegisterEmp"
        Me.cmdRegisterEmp.Size = New System.Drawing.Size(272, 201)
        Me.cmdRegisterEmp.TabIndex = 3
        Me.cmdRegisterEmp.UseVisualStyleBackColor = True
        '
        'cmdRegSupplier
        '
        Me.cmdRegSupplier.BackgroundImage = CType(resources.GetObject("cmdRegSupplier.BackgroundImage"), System.Drawing.Image)
        Me.cmdRegSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRegSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRegSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegSupplier.Location = New System.Drawing.Point(91, 353)
        Me.cmdRegSupplier.Name = "cmdRegSupplier"
        Me.cmdRegSupplier.Size = New System.Drawing.Size(260, 201)
        Me.cmdRegSupplier.TabIndex = 2
        Me.cmdRegSupplier.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.BackgroundImage = Global.mgmpos.My.Resources.Resources.costumer
        Me.cmdCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.Location = New System.Drawing.Point(370, 76)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(272, 237)
        Me.cmdCustomer.TabIndex = 1
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdProduct
        '
        Me.cmdProduct.BackgroundImage = Global.mgmpos.My.Resources.Resources.download1
        Me.cmdProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProduct.Location = New System.Drawing.Point(92, 76)
        Me.cmdProduct.Name = "cmdProduct"
        Me.cmdProduct.Size = New System.Drawing.Size(259, 237)
        Me.cmdProduct.TabIndex = 0
        Me.cmdProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdProduct.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PnlCustomer
        '
        Me.PnlCustomer.Controls.Add(Me.lblobjid)
        Me.PnlCustomer.Controls.Add(Me.PictureBox6)
        Me.PnlCustomer.Controls.Add(Me.cmdCustSearch)
        Me.PnlCustomer.Controls.Add(Me.txtcustSearch)
        Me.PnlCustomer.Controls.Add(Me.cmdCustDelete)
        Me.PnlCustomer.Controls.Add(Me.cmdCustSave)
        Me.PnlCustomer.Controls.Add(Me.cmdCustEdit)
        Me.PnlCustomer.Controls.Add(Me.cmdCusNew)
        Me.PnlCustomer.Controls.Add(Me.cmdCustBrowse)
        Me.PnlCustomer.Controls.Add(Me.PBCustomer)
        Me.PnlCustomer.Controls.Add(Me.Label45)
        Me.PnlCustomer.Controls.Add(Me.txtCustEmail)
        Me.PnlCustomer.Controls.Add(Me.Label44)
        Me.PnlCustomer.Controls.Add(Me.txtCustContact)
        Me.PnlCustomer.Controls.Add(Me.Label43)
        Me.PnlCustomer.Controls.Add(Me.txtCustAdd)
        Me.PnlCustomer.Controls.Add(Me.Label42)
        Me.PnlCustomer.Controls.Add(Me.txtCustLname)
        Me.PnlCustomer.Controls.Add(Me.Label41)
        Me.PnlCustomer.Controls.Add(Me.txtCustFname)
        Me.PnlCustomer.Controls.Add(Me.Label40)
        Me.PnlCustomer.Controls.Add(Me.txtCustOrgName)
        Me.PnlCustomer.Controls.Add(Me.Label39)
        Me.PnlCustomer.Controls.Add(Me.cboCustType)
        Me.PnlCustomer.Location = New System.Drawing.Point(699, 67)
        Me.PnlCustomer.Name = "PnlCustomer"
        Me.PnlCustomer.Size = New System.Drawing.Size(790, 625)
        Me.PnlCustomer.TabIndex = 3
        Me.PnlCustomer.Visible = False
        '
        'lblobjid
        '
        Me.lblobjid.AutoSize = True
        Me.lblobjid.Location = New System.Drawing.Point(121, 49)
        Me.lblobjid.Name = "lblobjid"
        Me.lblobjid.Size = New System.Drawing.Size(29, 13)
        Me.lblobjid.TabIndex = 26
        Me.lblobjid.Text = "objid"
        Me.lblobjid.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.mgmpos.My.Resources.Resources._698627_icon_111_search_512
        Me.PictureBox6.Location = New System.Drawing.Point(729, 12)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(34, 23)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'cmdCustSearch
        '
        Me.cmdCustSearch.Location = New System.Drawing.Point(421, 12)
        Me.cmdCustSearch.Name = "cmdCustSearch"
        Me.cmdCustSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdCustSearch.TabIndex = 24
        Me.cmdCustSearch.Text = "&Search"
        Me.cmdCustSearch.UseVisualStyleBackColor = True
        '
        'txtcustSearch
        '
        Me.txtcustSearch.Location = New System.Drawing.Point(502, 15)
        Me.txtcustSearch.Name = "txtcustSearch"
        Me.txtcustSearch.Size = New System.Drawing.Size(221, 20)
        Me.txtcustSearch.TabIndex = 23
        '
        'cmdCustDelete
        '
        Me.cmdCustDelete.Location = New System.Drawing.Point(693, 357)
        Me.cmdCustDelete.Name = "cmdCustDelete"
        Me.cmdCustDelete.Size = New System.Drawing.Size(74, 42)
        Me.cmdCustDelete.TabIndex = 21
        Me.cmdCustDelete.Text = "&Delete"
        Me.cmdCustDelete.UseVisualStyleBackColor = True
        '
        'cmdCustSave
        '
        Me.cmdCustSave.Location = New System.Drawing.Point(615, 357)
        Me.cmdCustSave.Name = "cmdCustSave"
        Me.cmdCustSave.Size = New System.Drawing.Size(74, 42)
        Me.cmdCustSave.TabIndex = 20
        Me.cmdCustSave.Text = "&Save"
        Me.cmdCustSave.UseVisualStyleBackColor = True
        '
        'cmdCustEdit
        '
        Me.cmdCustEdit.Location = New System.Drawing.Point(539, 357)
        Me.cmdCustEdit.Name = "cmdCustEdit"
        Me.cmdCustEdit.Size = New System.Drawing.Size(74, 42)
        Me.cmdCustEdit.TabIndex = 19
        Me.cmdCustEdit.Text = "&Update"
        Me.cmdCustEdit.UseVisualStyleBackColor = True
        '
        'cmdCusNew
        '
        Me.cmdCusNew.Location = New System.Drawing.Point(459, 357)
        Me.cmdCusNew.Name = "cmdCusNew"
        Me.cmdCusNew.Size = New System.Drawing.Size(74, 42)
        Me.cmdCusNew.TabIndex = 18
        Me.cmdCusNew.Text = "&New"
        Me.cmdCusNew.UseVisualStyleBackColor = True
        '
        'cmdCustBrowse
        '
        Me.cmdCustBrowse.Location = New System.Drawing.Point(694, 311)
        Me.cmdCustBrowse.Name = "cmdCustBrowse"
        Me.cmdCustBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdCustBrowse.TabIndex = 17
        Me.cmdCustBrowse.Text = "Browse"
        Me.cmdCustBrowse.UseVisualStyleBackColor = True
        '
        'PBCustomer
        '
        Me.PBCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBCustomer.ErrorImage = Global.mgmpos.My.Resources.Resources.MGGM
        Me.PBCustomer.Image = Global.mgmpos.My.Resources.Resources.MGGM
        Me.PBCustomer.InitialImage = CType(resources.GetObject("PBCustomer.InitialImage"), System.Drawing.Image)
        Me.PBCustomer.Location = New System.Drawing.Point(470, 72)
        Me.PBCustomer.Name = "PBCustomer"
        Me.PBCustomer.Size = New System.Drawing.Size(299, 233)
        Me.PBCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCustomer.TabIndex = 16
        Me.PBCustomer.TabStop = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(79, 302)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(35, 13)
        Me.Label45.TabIndex = 15
        Me.Label45.Text = "Email:"
        '
        'txtCustEmail
        '
        Me.txtCustEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCustEmail.Location = New System.Drawing.Point(124, 294)
        Me.txtCustEmail.Name = "txtCustEmail"
        Me.txtCustEmail.Size = New System.Drawing.Size(279, 20)
        Me.txtCustEmail.TabIndex = 14
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(67, 278)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 13)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Contact:"
        '
        'txtCustContact
        '
        Me.txtCustContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustContact.Location = New System.Drawing.Point(124, 269)
        Me.txtCustContact.Name = "txtCustContact"
        Me.txtCustContact.Size = New System.Drawing.Size(279, 20)
        Me.txtCustContact.TabIndex = 12
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(67, 187)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(48, 13)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Address:"
        '
        'txtCustAdd
        '
        Me.txtCustAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustAdd.Location = New System.Drawing.Point(124, 178)
        Me.txtCustAdd.Multiline = True
        Me.txtCustAdd.Name = "txtCustAdd"
        Me.txtCustAdd.Size = New System.Drawing.Size(279, 85)
        Me.txtCustAdd.TabIndex = 10
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(57, 159)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(61, 13)
        Me.Label42.TabIndex = 9
        Me.Label42.Text = "Last Name:"
        '
        'txtCustLname
        '
        Me.txtCustLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustLname.Location = New System.Drawing.Point(124, 152)
        Me.txtCustLname.Name = "txtCustLname"
        Me.txtCustLname.Size = New System.Drawing.Size(279, 20)
        Me.txtCustLname.TabIndex = 8
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(58, 132)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(60, 13)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "First Name:"
        '
        'txtCustFname
        '
        Me.txtCustFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustFname.Location = New System.Drawing.Point(124, 125)
        Me.txtCustFname.Name = "txtCustFname"
        Me.txtCustFname.Size = New System.Drawing.Size(279, 20)
        Me.txtCustFname.TabIndex = 6
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(18, 106)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(100, 13)
        Me.Label40.TabIndex = 5
        Me.Label40.Text = "Organization Name:"
        '
        'txtCustOrgName
        '
        Me.txtCustOrgName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustOrgName.Location = New System.Drawing.Point(124, 99)
        Me.txtCustOrgName.Name = "txtCustOrgName"
        Me.txtCustOrgName.Size = New System.Drawing.Size(279, 20)
        Me.txtCustOrgName.TabIndex = 4
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(37, 80)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(81, 13)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Customer Type:"
        '
        'cboCustType
        '
        Me.cboCustType.FormattingEnabled = True
        Me.cboCustType.Items.AddRange(New Object() {"Individual", "Juridical", "Organization"})
        Me.cboCustType.Location = New System.Drawing.Point(124, 72)
        Me.cboCustType.Name = "cboCustType"
        Me.cboCustType.Size = New System.Drawing.Size(170, 21)
        Me.cboCustType.TabIndex = 2
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.Label49)
        Me.PnlMain.Controls.Add(Me.homedgproduct)
        Me.PnlMain.Controls.Add(Me.Chart3)
        Me.PnlMain.Controls.Add(Me.Label48)
        Me.PnlMain.Controls.Add(Me.Chart2)
        Me.PnlMain.Controls.Add(Me.Label47)
        Me.PnlMain.Controls.Add(Me.Chart1)
        Me.PnlMain.Controls.Add(Me.Label46)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(259, 61)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1091, 688)
        Me.PnlMain.TabIndex = 4
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(702, 325)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(194, 25)
        Me.Label49.TabIndex = 8
        Me.Label49.Text = "Sales Performance"
        '
        'homedgproduct
        '
        Me.homedgproduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.homedgproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.homedgproduct.Location = New System.Drawing.Point(26, 353)
        Me.homedgproduct.Name = "homedgproduct"
        Me.homedgproduct.Size = New System.Drawing.Size(478, 275)
        Me.homedgproduct.TabIndex = 7
        '
        'Chart3
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend1)
        Me.Chart3.Location = New System.Drawing.Point(523, 353)
        Me.Chart3.Name = "Chart3"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Collections"
        Me.Chart3.Series.Add(Series1)
        Me.Chart3.Size = New System.Drawing.Size(545, 285)
        Me.Chart3.TabIndex = 6
        Me.Chart3.Text = "Chart3"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(107, 325)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(270, 25)
        Me.Label48.TabIndex = 5
        Me.Label48.Text = "Products with Critical Items"
        '
        'Chart2
        '
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(609, 50)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series2.Legend = "Legend1"
        Series2.Name = "Product Category"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(458, 272)
        Me.Chart2.TabIndex = 4
        Me.Chart2.Text = "Chart2"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(682, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(316, 25)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "Sales Performance by Category"
        '
        'Chart1
        '
        ChartArea3.AxisX.Interval = 1.0R
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Angle = -45
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(56, 50)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100
        Series3.Legend = "Legend1"
        Series3.Name = "Cash"
        Series3.YValuesPerPoint = 4
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100
        Series4.Legend = "Legend1"
        Series4.Name = "Cheque"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100
        Series5.Legend = "Legend1"
        Series5.Name = "Terms"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(534, 278)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(140, 19)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(190, 25)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "Remittance Report"
        '
        'pnlReports
        '
        Me.pnlReports.Controls.Add(Me.PictureBox16)
        Me.pnlReports.Controls.Add(Me.Button7)
        Me.pnlReports.Controls.Add(Me.PictureBox15)
        Me.pnlReports.Controls.Add(Me.btnRemittance)
        Me.pnlReports.Controls.Add(Me.PictureBox14)
        Me.pnlReports.Controls.Add(Me.Button6)
        Me.pnlReports.Controls.Add(Me.PictureBox13)
        Me.pnlReports.Controls.Add(Me.PictureBox12)
        Me.pnlReports.Controls.Add(Me.PictureBox11)
        Me.pnlReports.Controls.Add(Me.btnCostumerReport)
        Me.pnlReports.Controls.Add(Me.btnStockReport)
        Me.pnlReports.Controls.Add(Me.btnSalesReport)
        Me.pnlReports.Location = New System.Drawing.Point(274, 64)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(1076, 691)
        Me.pnlReports.TabIndex = 4
        Me.pnlReports.Visible = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.mgmpos.My.Resources.Resources.download
        Me.PictureBox16.Location = New System.Drawing.Point(379, 178)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(115, 97)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 13
        Me.PictureBox16.TabStop = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(366, 167)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(335, 114)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Stock In Report"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.mgmpos.My.Resources.Resources.remit_handmoney
        Me.PictureBox15.Location = New System.Drawing.Point(16, 173)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(108, 98)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 11
        Me.PictureBox15.TabStop = False
        '
        'btnRemittance
        '
        Me.btnRemittance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemittance.Location = New System.Drawing.Point(10, 167)
        Me.btnRemittance.Name = "btnRemittance"
        Me.btnRemittance.Size = New System.Drawing.Size(340, 114)
        Me.btnRemittance.TabIndex = 10
        Me.btnRemittance.Text = "Remittance Report"
        Me.btnRemittance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemittance.UseVisualStyleBackColor = True
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(379, 309)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(109, 90)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 9
        Me.PictureBox14.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(366, 298)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(333, 114)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "View All Product "
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.mgmpos.My.Resources.Resources.costumer
        Me.PictureBox13.Location = New System.Drawing.Point(721, 35)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(98, 97)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 7
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.mgmpos.My.Resources.Resources.black_product_256
        Me.PictureBox12.Location = New System.Drawing.Point(379, 35)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(115, 97)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 6
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.mgmpos.My.Resources.Resources.chart_increase
        Me.PictureBox11.Location = New System.Drawing.Point(16, 35)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(108, 98)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 5
        Me.PictureBox11.TabStop = False
        '
        'btnCostumerReport
        '
        Me.btnCostumerReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCostumerReport.Location = New System.Drawing.Point(713, 28)
        Me.btnCostumerReport.Name = "btnCostumerReport"
        Me.btnCostumerReport.Size = New System.Drawing.Size(315, 114)
        Me.btnCostumerReport.TabIndex = 2
        Me.btnCostumerReport.Text = "Costumer's Report"
        Me.btnCostumerReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCostumerReport.UseVisualStyleBackColor = True
        '
        'btnStockReport
        '
        Me.btnStockReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockReport.Location = New System.Drawing.Point(364, 28)
        Me.btnStockReport.Name = "btnStockReport"
        Me.btnStockReport.Size = New System.Drawing.Size(335, 114)
        Me.btnStockReport.TabIndex = 1
        Me.btnStockReport.Text = "Stock Out Report"
        Me.btnStockReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStockReport.UseVisualStyleBackColor = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.Location = New System.Drawing.Point(10, 28)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(340, 114)
        Me.btnSalesReport.TabIndex = 0
        Me.btnSalesReport.Text = "Sales Report"
        Me.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 749)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.pnlReports)
        Me.Controls.Add(Me.panelProduct)
        Me.Controls.Add(Me.panelSupplier)
        Me.Controls.Add(Me.pnlEmployee)
        Me.Controls.Add(Me.PnlCustomer)
        Me.Controls.Add(Me.panelContextRegister)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelMenu)
        Me.Name = "frmDashboard"
        Me.Text = "CasianoPos v 0.1 Alpha"
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmployee.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSupplier.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelProduct.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControlProduct.ResumeLayout(False)
        Me.tab_prod_category.ResumeLayout(False)
        CType(Me.dt_prod_cat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tablocation.ResumeLayout(False)
        CType(Me.dglocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tab_product.ResumeLayout(False)
        Me.tab_product.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelContextRegister.ResumeLayout(False)
        Me.panelContextRegister.PerformLayout()
        Me.PnlCustomer.ResumeLayout(False)
        Me.PnlCustomer.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMain.ResumeLayout(False)
        Me.PnlMain.PerformLayout()
        CType(Me.homedgproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReports.ResumeLayout(False)
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelContextRegister As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdRegSupplier As Button
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents cmdProduct As Button
    Friend WithEvents lblHEADER As Label
    Friend WithEvents panelProduct As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControlProduct As TabControl
    Friend WithEvents tab_prod_category As TabPage
    Friend WithEvents tab_product As TabPage
    Friend WithEvents dt_prod_cat As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnpcdelete As Button
    Friend WithEvents btn_prod_cat_update As Button
    Friend WithEvents btn_prod_cat_add As Button
    Friend WithEvents tb_prod_cat_desc As TextBox
    Friend WithEvents tb_prod_cat_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbproduct_srp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbproduct_supprice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboproduct_supplier As ComboBox
    Friend WithEvents cbo_product_uom As ComboBox
    Friend WithEvents cboproduct_category As ComboBox
    Friend WithEvents tbprodname As TextBox
    Friend WithEvents tbproduct_code As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dg_product As DataGridView
    Friend WithEvents tablocation As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnlocationDelete As Button
    Friend WithEvents btnlocationUpdate As Button
    Friend WithEvents btnlocationAdd As Button
    Friend WithEvents tblocdesc As TextBox
    Friend WithEvents tblocationname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dglocation As DataGridView
    Friend WithEvents btnprodDelete As Button
    Friend WithEvents btnprodEdit As Button
    Friend WithEvents btnprodAdd As Button
    Friend WithEvents tbproduct_markup As TextBox
    Friend WithEvents tbproductcat_id As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pcbtnNew As Button
    Friend WithEvents tblocid As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnlocationNew As Button
    Friend WithEvents btnprodNew As Button
    Friend WithEvents tbprodID As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmdRegisterEmp As Button
    Friend WithEvents pnlEmployee As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdUpdateEmp As Button
    Friend WithEvents cboDesignation As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtSearchEmp As TextBox
    Friend WithEvents cmdSaveEmp As Button
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents pbEmp As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelSupplier As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGSupplier As DataGridView
    Friend WithEvents cmdupdateSupp As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSearchSupplier As TextBox
    Friend WithEvents cmdAddSupp As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents pbSupp As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtsupptin As TextBox
    Friend WithEvents txtsuppcontact As TextBox
    Friend WithEvents txtsuppadd As TextBox
    Friend WithEvents txtsupname As TextBox
    Friend WithEvents cmdNewEmployee As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents txtempid As TextBox
    Friend WithEvents cmdDeleteEmp As Button
    Friend WithEvents cmdSuppDelete As Button
    Friend WithEvents cmdNewSupp As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents txtSuppEmail As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtsupId As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtReorder As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtbegStock As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtPdesc As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents PnlCustomer As Panel
    Friend WithEvents cmdCustSearch As Button
    Friend WithEvents txtcustSearch As TextBox
    Friend WithEvents cmdCustDelete As Button
    Friend WithEvents cmdCustSave As Button
    Friend WithEvents cmdCustEdit As Button
    Friend WithEvents cmdCusNew As Button
    Friend WithEvents cmdCustBrowse As Button
    Friend WithEvents PBCustomer As PictureBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txtCustEmail As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents txtCustContact As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtCustAdd As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtCustLname As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtCustFname As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtCustOrgName As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cboCustType As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblobjid As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PnlMain As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label47 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents homedgproduct As DataGridView
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Label48 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents pnlReports As Panel
    Friend WithEvents btnCostumerReport As Button
    Friend WithEvents btnStockReport As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents btnRemittance As Button
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Button7 As Button
End Class
