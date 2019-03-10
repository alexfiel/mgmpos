<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txttransnoSearch = New System.Windows.Forms.TextBox()
        Me.dgtransaction = New System.Windows.Forms.DataGridView()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttransno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcostumer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttransdate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtamountdue = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtreason = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtReturnTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtReturnDiscount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtReturnVat = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtReturnSubTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtprodcode_ret = New System.Windows.Forms.TextBox()
        Me.dgReturnItems = New System.Windows.Forms.DataGridView()
        Me.colPCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgtransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgReturnItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txttransnoSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1333, 64)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = Global.mgmpos.My.Resources.Resources._698627_icon_111_search_512
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(645, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 24)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(419, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Enter Transaction No."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.BackgroundImage = Global.mgmpos.My.Resources.Resources.close_window
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txttransnoSearch
        '
        Me.txttransnoSearch.Location = New System.Drawing.Point(419, 32)
        Me.txttransnoSearch.Name = "txttransnoSearch"
        Me.txttransnoSearch.Size = New System.Drawing.Size(223, 20)
        Me.txttransnoSearch.TabIndex = 0
        '
        'dgtransaction
        '
        Me.dgtransaction.AllowUserToAddRows = False
        Me.dgtransaction.AllowUserToDeleteRows = False
        Me.dgtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtransaction.Location = New System.Drawing.Point(12, 285)
        Me.dgtransaction.Name = "dgtransaction"
        Me.dgtransaction.Size = New System.Drawing.Size(656, 198)
        Me.dgtransaction.TabIndex = 1
        '
        'cmdReturn
        '
        Me.cmdReturn.Location = New System.Drawing.Point(6, 271)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(90, 42)
        Me.cmdReturn.TabIndex = 2
        Me.cmdReturn.Text = "Void"
        Me.cmdReturn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Transaction No."
        '
        'txttransno
        '
        Me.txttransno.Enabled = False
        Me.txttransno.Location = New System.Drawing.Point(140, 70)
        Me.txttransno.Name = "txttransno"
        Me.txttransno.Size = New System.Drawing.Size(220, 20)
        Me.txttransno.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Costumer:"
        '
        'txtcostumer
        '
        Me.txtcostumer.Enabled = False
        Me.txtcostumer.Location = New System.Drawing.Point(140, 96)
        Me.txtcostumer.Name = "txtcostumer"
        Me.txtcostumer.Size = New System.Drawing.Size(319, 20)
        Me.txtcostumer.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Address:"
        '
        'txtaddress
        '
        Me.txtaddress.Enabled = False
        Me.txtaddress.Location = New System.Drawing.Point(140, 122)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(319, 43)
        Me.txtaddress.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(509, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Date"
        '
        'txttransdate
        '
        Me.txttransdate.Enabled = False
        Me.txttransdate.Location = New System.Drawing.Point(559, 72)
        Me.txttransdate.Name = "txttransdate"
        Me.txttransdate.Size = New System.Drawing.Size(112, 20)
        Me.txttransdate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sub Total:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Location = New System.Drawing.Point(140, 171)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(172, 20)
        Me.txtsubtotal.TabIndex = 11
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(95, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Vat:"
        '
        'txtvat
        '
        Me.txtvat.Enabled = False
        Me.txtvat.Location = New System.Drawing.Point(140, 197)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.Size = New System.Drawing.Size(172, 20)
        Me.txtvat.TabIndex = 13
        Me.txtvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Discount:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Enabled = False
        Me.txtdiscount.Location = New System.Drawing.Point(140, 223)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(172, 20)
        Me.txtdiscount.TabIndex = 15
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Amount:"
        '
        'txtamountdue
        '
        Me.txtamountdue.Enabled = False
        Me.txtamountdue.Location = New System.Drawing.Point(140, 249)
        Me.txtamountdue.Name = "txtamountdue"
        Me.txtamountdue.Size = New System.Drawing.Size(172, 20)
        Me.txtamountdue.TabIndex = 17
        Me.txtamountdue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(351, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Reasons"
        '
        'txtreason
        '
        Me.txtreason.Enabled = False
        Me.txtreason.Location = New System.Drawing.Point(355, 194)
        Me.txtreason.Multiline = True
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(316, 75)
        Me.txtreason.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtReturnTotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtReturnDiscount)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtReturnVat)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtReturnSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtprodcode_ret)
        Me.GroupBox1.Controls.Add(Me.dgReturnItems)
        Me.GroupBox1.Controls.Add(Me.cmdReturn)
        Me.GroupBox1.Location = New System.Drawing.Point(677, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 419)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(362, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Total Amount:"
        '
        'txtReturnTotalAmount
        '
        Me.txtReturnTotalAmount.Enabled = False
        Me.txtReturnTotalAmount.Location = New System.Drawing.Point(472, 345)
        Me.txtReturnTotalAmount.Name = "txtReturnTotalAmount"
        Me.txtReturnTotalAmount.Size = New System.Drawing.Size(172, 20)
        Me.txtReturnTotalAmount.TabIndex = 30
        Me.txtReturnTotalAmount.Text = "0"
        Me.txtReturnTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(390, 319)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 20)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Discount:"
        '
        'txtReturnDiscount
        '
        Me.txtReturnDiscount.Enabled = False
        Me.txtReturnDiscount.Location = New System.Drawing.Point(472, 319)
        Me.txtReturnDiscount.Name = "txtReturnDiscount"
        Me.txtReturnDiscount.Size = New System.Drawing.Size(172, 20)
        Me.txtReturnDiscount.TabIndex = 28
        Me.txtReturnDiscount.Text = "0"
        Me.txtReturnDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(427, 293)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 20)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Vat:"
        '
        'txtReturnVat
        '
        Me.txtReturnVat.Enabled = False
        Me.txtReturnVat.Location = New System.Drawing.Point(472, 293)
        Me.txtReturnVat.Name = "txtReturnVat"
        Me.txtReturnVat.Size = New System.Drawing.Size(172, 20)
        Me.txtReturnVat.TabIndex = 26
        Me.txtReturnVat.Text = "0"
        Me.txtReturnVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(384, 267)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 20)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Sub Total:"
        '
        'txtReturnSubTotal
        '
        Me.txtReturnSubTotal.Enabled = False
        Me.txtReturnSubTotal.Location = New System.Drawing.Point(472, 267)
        Me.txtReturnSubTotal.Name = "txtReturnSubTotal"
        Me.txtReturnSubTotal.Size = New System.Drawing.Size(172, 20)
        Me.txtReturnSubTotal.TabIndex = 24
        Me.txtReturnSubTotal.Text = "0"
        Me.txtReturnSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(244, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Product Code"
        '
        'txtprodcode_ret
        '
        Me.txtprodcode_ret.Location = New System.Drawing.Point(356, 19)
        Me.txtprodcode_ret.Name = "txtprodcode_ret"
        Me.txtprodcode_ret.Size = New System.Drawing.Size(294, 20)
        Me.txtprodcode_ret.TabIndex = 1
        '
        'dgReturnItems
        '
        Me.dgReturnItems.AllowUserToAddRows = False
        Me.dgReturnItems.AllowUserToDeleteRows = False
        Me.dgReturnItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReturnItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPCode, Me.colPName, Me.colUnitPrice, Me.colQty, Me.colDiscount, Me.colAmount})
        Me.dgReturnItems.Location = New System.Drawing.Point(6, 52)
        Me.dgReturnItems.Name = "dgReturnItems"
        Me.dgReturnItems.ReadOnly = True
        Me.dgReturnItems.Size = New System.Drawing.Size(644, 209)
        Me.dgReturnItems.TabIndex = 0
        '
        'colPCode
        '
        Me.colPCode.HeaderText = "PCode"
        Me.colPCode.Name = "colPCode"
        '
        'colPName
        '
        Me.colPName.HeaderText = "Product Name"
        Me.colPName.Name = "colPName"
        Me.colPName.Width = 150
        '
        'colUnitPrice
        '
        Me.colUnitPrice.HeaderText = "Unit Price"
        Me.colUnitPrice.Name = "colUnitPrice"
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 50
        '
        'colDiscount
        '
        Me.colDiscount.HeaderText = "Discount"
        Me.colDiscount.Name = "colDiscount"
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        '
        'frmReturnItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1333, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtamountdue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttransdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcostumer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttransno)
        Me.Controls.Add(Me.dgtransaction)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturnItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgtransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgReturnItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txttransnoSearch As TextBox
    Friend WithEvents dgtransaction As DataGridView
    Friend WithEvents cmdReturn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txttransno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcostumer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttransdate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtamountdue As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtreason As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtprodcode_ret As TextBox
    Friend WithEvents dgReturnItems As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txtReturnTotalAmount As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtReturnDiscount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtReturnVat As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtReturnSubTotal As TextBox
    Friend WithEvents colPCode As DataGridViewTextBoxColumn
    Friend WithEvents colPName As DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
End Class
