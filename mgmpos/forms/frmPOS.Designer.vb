<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltransno = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPOSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbldesignation = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtorigin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcashonhand = New System.Windows.Forms.TextBox()
        Me.coh = New System.Windows.Forms.Label()
        Me.lblchange2 = New System.Windows.Forms.Label()
        Me.lblcashtendered2 = New System.Windows.Forms.Label()
        Me.lbldate3 = New System.Windows.Forms.Label()
        Me.lblChequeAmount = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblcashtendered = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGrandtotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pbEmployeeImg = New System.Windows.Forms.PictureBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRemit = New System.Windows.Forms.Button()
        Me.btnReceiveCash = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmdRemit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdCharge = New System.Windows.Forms.Button()
        Me.cmdCheque = New System.Windows.Forms.Button()
        Me.cmdCash = New System.Windows.Forms.Button()
        Me.cmdVoid = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGProduct = New System.Windows.Forms.DataGridView()
        Me.prodcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbEmployeeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.lbltransno)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1360, 73)
        Me.Panel1.TabIndex = 0
        '
        'lbltransno
        '
        Me.lbltransno.AutoSize = True
        Me.lbltransno.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltransno.ForeColor = System.Drawing.Color.White
        Me.lbltransno.Location = New System.Drawing.Point(1191, 21)
        Me.lbltransno.Name = "lbltransno"
        Me.lbltransno.Size = New System.Drawing.Size(120, 32)
        Me.lbltransno.TabIndex = 35
        Me.lbltransno.Text = "0000000"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(976, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(214, 32)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Transaction No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(134, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Point of Sale"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mgmpos.My.Resources.Resources.MGGM
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtPOSearch
        '
        Me.txtPOSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPOSearch.Enabled = False
        Me.txtPOSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSearch.Location = New System.Drawing.Point(522, 20)
        Me.txtPOSearch.Name = "txtPOSearch"
        Me.txtPOSearch.Size = New System.Drawing.Size(363, 31)
        Me.txtPOSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(436, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.lbldesignation)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.pbEmployeeImg)
        Me.Panel2.Controls.Add(Me.lbluser)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(958, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 614)
        Me.Panel2.TabIndex = 1
        '
        'lbldesignation
        '
        Me.lbldesignation.AutoSize = True
        Me.lbldesignation.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesignation.ForeColor = System.Drawing.Color.White
        Me.lbldesignation.Location = New System.Drawing.Point(185, 566)
        Me.lbldesignation.Name = "lbldesignation"
        Me.lbldesignation.Size = New System.Drawing.Size(103, 32)
        Me.lbldesignation.TabIndex = 35
        Me.lbldesignation.Text = "cashier"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SeaGreen
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.lblchange2)
        Me.GroupBox3.Controls.Add(Me.lblcashtendered2)
        Me.GroupBox3.Controls.Add(Me.lbldate3)
        Me.GroupBox3.Controls.Add(Me.lblChequeAmount)
        Me.GroupBox3.Controls.Add(Me.lbldate)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblchange)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblcashtendered)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblGrandtotal)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblDiscount)
        Me.GroupBox3.Controls.Add(Me.lbltotalamount)
        Me.GroupBox3.Controls.Add(Me.lblVat)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 504)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtorigin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcashonhand)
        Me.GroupBox2.Controls.Add(Me.coh)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(15, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 121)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(102, 75)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(261, 22)
        Me.txtdate.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date:"
        '
        'txtorigin
        '
        Me.txtorigin.Location = New System.Drawing.Point(102, 47)
        Me.txtorigin.Name = "txtorigin"
        Me.txtorigin.Size = New System.Drawing.Size(261, 22)
        Me.txtorigin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Origin:"
        '
        'txtcashonhand
        '
        Me.txtcashonhand.Location = New System.Drawing.Point(102, 19)
        Me.txtcashonhand.Name = "txtcashonhand"
        Me.txtcashonhand.Size = New System.Drawing.Size(261, 22)
        Me.txtcashonhand.TabIndex = 1
        Me.txtcashonhand.Text = "0.00"
        '
        'coh
        '
        Me.coh.AutoSize = True
        Me.coh.Location = New System.Drawing.Point(6, 25)
        Me.coh.Name = "coh"
        Me.coh.Size = New System.Drawing.Size(96, 16)
        Me.coh.TabIndex = 0
        Me.coh.Text = "Cash on Hand:"
        '
        'lblchange2
        '
        Me.lblchange2.AutoSize = True
        Me.lblchange2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange2.ForeColor = System.Drawing.Color.White
        Me.lblchange2.Location = New System.Drawing.Point(181, 246)
        Me.lblchange2.Name = "lblchange2"
        Me.lblchange2.Size = New System.Drawing.Size(52, 24)
        Me.lblchange2.TabIndex = 39
        Me.lblchange2.Text = "0.00"
        Me.lblchange2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblcashtendered2
        '
        Me.lblcashtendered2.AutoSize = True
        Me.lblcashtendered2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashtendered2.ForeColor = System.Drawing.Color.White
        Me.lblcashtendered2.Location = New System.Drawing.Point(181, 176)
        Me.lblcashtendered2.Name = "lblcashtendered2"
        Me.lblcashtendered2.Size = New System.Drawing.Size(52, 24)
        Me.lblcashtendered2.TabIndex = 38
        Me.lblcashtendered2.Text = "0.00"
        Me.lblcashtendered2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lbldate3
        '
        Me.lbldate3.AutoSize = True
        Me.lbldate3.Location = New System.Drawing.Point(180, 485)
        Me.lbldate3.Name = "lbldate3"
        Me.lbldate3.Size = New System.Drawing.Size(35, 16)
        Me.lbldate3.TabIndex = 37
        Me.lbldate3.Text = "date"
        '
        'lblChequeAmount
        '
        Me.lblChequeAmount.AutoSize = True
        Me.lblChequeAmount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeAmount.ForeColor = System.Drawing.Color.White
        Me.lblChequeAmount.Location = New System.Drawing.Point(181, 212)
        Me.lblChequeAmount.Name = "lblChequeAmount"
        Me.lblChequeAmount.Size = New System.Drawing.Size(52, 24)
        Me.lblChequeAmount.TabIndex = 35
        Me.lblChequeAmount.Text = "0.00"
        Me.lblChequeAmount.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(15, 485)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(35, 16)
        Me.lbldate.TabIndex = 36
        Me.lbldate.Text = "date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 24)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Cheque Amount:"
        '
        'lblchange
        '
        Me.lblchange.AutoSize = True
        Me.lblchange.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.White
        Me.lblchange.Location = New System.Drawing.Point(181, 246)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(52, 24)
        Me.lblchange.TabIndex = 33
        Me.lblchange.Text = "0.00"
        Me.lblchange.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(81, 246)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 24)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Change:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(92, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 24)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "_____________"
        '
        'lblcashtendered
        '
        Me.lblcashtendered.AutoSize = True
        Me.lblcashtendered.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcashtendered.ForeColor = System.Drawing.Color.White
        Me.lblcashtendered.Location = New System.Drawing.Point(181, 176)
        Me.lblcashtendered.Name = "lblcashtendered"
        Me.lblcashtendered.Size = New System.Drawing.Size(52, 24)
        Me.lblcashtendered.TabIndex = 30
        Me.lblcashtendered.Text = "0.00"
        Me.lblcashtendered.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Cash Tendered:"
        '
        'lblGrandtotal
        '
        Me.lblGrandtotal.AutoSize = True
        Me.lblGrandtotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandtotal.ForeColor = System.Drawing.Color.White
        Me.lblGrandtotal.Location = New System.Drawing.Point(181, 115)
        Me.lblGrandtotal.Name = "lblGrandtotal"
        Me.lblGrandtotal.Size = New System.Drawing.Size(52, 24)
        Me.lblGrandtotal.TabIndex = 28
        Me.lblGrandtotal.Text = "0.00"
        Me.lblGrandtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(46, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 24)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Grand Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(128, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 24)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Vat:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.White
        Me.lblDiscount.Location = New System.Drawing.Point(181, 82)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(52, 24)
        Me.lblDiscount.TabIndex = 26
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lbltotalamount
        '
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.ForeColor = System.Drawing.Color.White
        Me.lbltotalamount.Location = New System.Drawing.Point(179, 15)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(52, 24)
        Me.lbltotalamount.TabIndex = 22
        Me.lbltotalamount.Text = "0.00"
        Me.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.White
        Me.lblVat.Location = New System.Drawing.Point(179, 47)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(52, 24)
        Me.lblVat.TabIndex = 24
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(23, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 24)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Less Discount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(113, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total:"
        '
        'pbEmployeeImg
        '
        Me.pbEmployeeImg.ErrorImage = Global.mgmpos.My.Resources.Resources.MGGM
        Me.pbEmployeeImg.Image = Global.mgmpos.My.Resources.Resources.MGGM
        Me.pbEmployeeImg.Location = New System.Drawing.Point(65, 516)
        Me.pbEmployeeImg.Name = "pbEmployeeImg"
        Me.pbEmployeeImg.Size = New System.Drawing.Size(112, 99)
        Me.pbEmployeeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmployeeImg.TabIndex = 3
        Me.pbEmployeeImg.TabStop = False
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.White
        Me.lbluser.Location = New System.Drawing.Point(185, 533)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(118, 32)
        Me.lbluser.TabIndex = 34
        Me.lbluser.Text = "cashier1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnRemit)
        Me.Panel3.Controls.Add(Me.btnReceiveCash)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.cmdRemit)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.cmdCharge)
        Me.Panel3.Controls.Add(Me.cmdCheque)
        Me.Panel3.Controls.Add(Me.cmdCash)
        Me.Panel3.Controls.Add(Me.cmdVoid)
        Me.Panel3.Controls.Add(Me.cmdNew)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.DGProduct)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(958, 614)
        Me.Panel3.TabIndex = 2
        '
        'btnRemit
        '
        Me.btnRemit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemit.BackgroundImage = Global.mgmpos.My.Resources.Resources.remit_handmoney
        Me.btnRemit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemit.Location = New System.Drawing.Point(801, 547)
        Me.btnRemit.Name = "btnRemit"
        Me.btnRemit.Size = New System.Drawing.Size(56, 45)
        Me.btnRemit.TabIndex = 12
        Me.btnRemit.UseVisualStyleBackColor = True
        '
        'btnReceiveCash
        '
        Me.btnReceiveCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReceiveCash.BackgroundImage = Global.mgmpos.My.Resources.Resources.remit
        Me.btnReceiveCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReceiveCash.Location = New System.Drawing.Point(739, 548)
        Me.btnReceiveCash.Name = "btnReceiveCash"
        Me.btnReceiveCash.Size = New System.Drawing.Size(56, 46)
        Me.btnReceiveCash.TabIndex = 11
        Me.btnReceiveCash.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.OrangeRed
        Me.Button4.Location = New System.Drawing.Point(13, 542)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 52)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Settings"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cmdRemit
        '
        Me.cmdRemit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cmdRemit.BackgroundImage = Global.mgmpos.My.Resources.Resources.reports
        Me.cmdRemit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRemit.Location = New System.Drawing.Point(863, 542)
        Me.cmdRemit.Name = "cmdRemit"
        Me.cmdRemit.Size = New System.Drawing.Size(82, 51)
        Me.cmdRemit.TabIndex = 9
        Me.cmdRemit.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.Location = New System.Drawing.Point(863, 542)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 52)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Function"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'cmdCharge
        '
        Me.cmdCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCharge.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdCharge.Location = New System.Drawing.Point(571, 542)
        Me.cmdCharge.Name = "cmdCharge"
        Me.cmdCharge.Size = New System.Drawing.Size(56, 52)
        Me.cmdCharge.TabIndex = 7
        Me.cmdCharge.Text = "F11 - Charge"
        Me.cmdCharge.UseVisualStyleBackColor = False
        '
        'cmdCheque
        '
        Me.cmdCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCheque.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdCheque.Location = New System.Drawing.Point(505, 542)
        Me.cmdCheque.Name = "cmdCheque"
        Me.cmdCheque.Size = New System.Drawing.Size(60, 52)
        Me.cmdCheque.TabIndex = 6
        Me.cmdCheque.Text = "F10 - Cheque"
        Me.cmdCheque.UseVisualStyleBackColor = False
        '
        'cmdCash
        '
        Me.cmdCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCash.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdCash.Location = New System.Drawing.Point(442, 542)
        Me.cmdCash.Name = "cmdCash"
        Me.cmdCash.Size = New System.Drawing.Size(57, 52)
        Me.cmdCash.TabIndex = 5
        Me.cmdCash.Text = "F9 - Cash"
        Me.cmdCash.UseVisualStyleBackColor = False
        '
        'cmdVoid
        '
        Me.cmdVoid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVoid.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmdVoid.Location = New System.Drawing.Point(352, 542)
        Me.cmdVoid.Name = "cmdVoid"
        Me.cmdVoid.Size = New System.Drawing.Size(56, 52)
        Me.cmdVoid.TabIndex = 4
        Me.cmdVoid.Text = "F6 - Void"
        Me.cmdVoid.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmdNew.Location = New System.Drawing.Point(289, 542)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(57, 52)
        Me.cmdNew.TabIndex = 3
        Me.cmdNew.Text = "F5 - New"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.Location = New System.Drawing.Point(182, 542)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 52)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "F2 - Costumer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DGProduct
        '
        Me.DGProduct.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.DGProduct.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGProduct.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        Me.DGProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodcode, Me.ProdName, Me.unit, Me.disc, Me.qty, Me.Amount})
        Me.DGProduct.Location = New System.Drawing.Point(0, 77)
        Me.DGProduct.Name = "DGProduct"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        Me.DGProduct.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGProduct.Size = New System.Drawing.Size(945, 459)
        Me.DGProduct.TabIndex = 1
        '
        'prodcode
        '
        Me.prodcode.HeaderText = "Product Code"
        Me.prodcode.Name = "prodcode"
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "Product Name"
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Width = 400
        '
        'unit
        '
        Me.unit.HeaderText = "Unit Price"
        Me.unit.Name = "unit"
        '
        'disc
        '
        Me.disc.HeaderText = "Discount"
        Me.disc.Name = "disc"
        '
        'qty
        '
        Me.qty.HeaderText = "QTY."
        Me.qty.Name = "qty"
        '
        'Amount
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.txtPOSearch)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.mgmpos.My.Resources.Resources._220px_UPC_A_036000291452_svg
        Me.PictureBox2.Location = New System.Drawing.Point(891, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Location = New System.Drawing.Point(118, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "F1 - Look Up"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 687)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Malinao Godrick General Merchandising"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbEmployeeImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPOSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGProduct As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdCharge As Button
    Friend WithEvents cmdCheque As Button
    Friend WithEvents cmdCash As Button
    Friend WithEvents cmdVoid As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblchange As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblcashtendered As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGrandtotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lbltotalamount As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbldesignation As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents pbEmployeeImg As PictureBox
    Friend WithEvents lbltransno As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblChequeAmount As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbldate3 As Label
    Friend WithEvents prodcode As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents disc As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents cmdRemit As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lblchange2 As Label
    Friend WithEvents lblcashtendered2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtorigin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcashonhand As TextBox
    Friend WithEvents coh As Label
    Friend WithEvents btnReceiveCash As Button
    Friend WithEvents btnRemit As Button
End Class
