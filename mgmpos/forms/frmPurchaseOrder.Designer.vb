<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Me.btnAllProducts = New System.Windows.Forms.Button()
        Me.btnViewCritical = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgChooseItems = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgSelectedItems = New System.Windows.Forms.DataGridView()
        Me.colProdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNewPO = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblpono = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgChooseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgSelectedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNewPO)
        Me.Panel1.Controls.Add(Me.btnAllProducts)
        Me.Panel1.Controls.Add(Me.btnViewCritical)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 79)
        Me.Panel1.TabIndex = 0
        '
        'btnAllProducts
        '
        Me.btnAllProducts.Location = New System.Drawing.Point(93, 12)
        Me.btnAllProducts.Name = "btnAllProducts"
        Me.btnAllProducts.Size = New System.Drawing.Size(75, 51)
        Me.btnAllProducts.TabIndex = 4
        Me.btnAllProducts.Text = "View All Products"
        Me.btnAllProducts.UseVisualStyleBackColor = True
        '
        'btnViewCritical
        '
        Me.btnViewCritical.Location = New System.Drawing.Point(12, 12)
        Me.btnViewCritical.Name = "btnViewCritical"
        Me.btnViewCritical.Size = New System.Drawing.Size(75, 51)
        Me.btnViewCritical.TabIndex = 3
        Me.btnViewCritical.Text = "View All Critical Items"
        Me.btnViewCritical.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dgChooseItems)
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 395)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Choose Items"
        '
        'dgChooseItems
        '
        Me.dgChooseItems.AllowUserToAddRows = False
        Me.dgChooseItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgChooseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgChooseItems.Location = New System.Drawing.Point(3, 26)
        Me.dgChooseItems.Name = "dgChooseItems"
        Me.dgChooseItems.Size = New System.Drawing.Size(451, 366)
        Me.dgChooseItems.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.lblpono)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dgSelectedItems)
        Me.Panel3.Location = New System.Drawing.Point(463, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(454, 395)
        Me.Panel3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Selected Items"
        '
        'dgSelectedItems
        '
        Me.dgSelectedItems.AllowUserToAddRows = False
        Me.dgSelectedItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSelectedItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProdCode, Me.colName, Me.coldDesc, Me.colQty})
        Me.dgSelectedItems.Location = New System.Drawing.Point(3, 26)
        Me.dgSelectedItems.Name = "dgSelectedItems"
        Me.dgSelectedItems.Size = New System.Drawing.Size(451, 366)
        Me.dgSelectedItems.TabIndex = 1
        '
        'colProdCode
        '
        Me.colProdCode.HeaderText = "Product Code"
        Me.colProdCode.Name = "colProdCode"
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        '
        'coldDesc
        '
        Me.coldDesc.HeaderText = "Description"
        Me.coldDesc.Name = "coldDesc"
        '
        'colQty
        '
        Me.colQty.HeaderText = "Purchase Qty"
        Me.colQty.Name = "colQty"
        '
        'btnNewPO
        '
        Me.btnNewPO.Location = New System.Drawing.Point(746, 12)
        Me.btnNewPO.Name = "btnNewPO"
        Me.btnNewPO.Size = New System.Drawing.Size(75, 51)
        Me.btnNewPO.TabIndex = 5
        Me.btnNewPO.Text = "New P.O"
        Me.btnNewPO.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(830, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 51)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(324, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "P.O No.:"
        '
        'lblpono
        '
        Me.lblpono.AutoSize = True
        Me.lblpono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpono.ForeColor = System.Drawing.Color.Black
        Me.lblpono.Location = New System.Drawing.Point(397, 3)
        Me.lblpono.Name = "lblpono"
        Me.lblpono.Size = New System.Drawing.Size(45, 20)
        Me.lblpono.TabIndex = 4
        Me.lblpono.Text = "0000"
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 474)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPurchaseOrder"
        Me.ShowIcon = False
        Me.Text = "Create Purchase Order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgChooseItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgSelectedItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAllProducts As Button
    Friend WithEvents btnViewCritical As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dgChooseItems As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dgSelectedItems As DataGridView
    Friend WithEvents colProdCode As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents coldDesc As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNewPO As Button
    Friend WithEvents lblpono As Label
    Friend WithEvents Label1 As Label
End Class
