<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollection
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TBal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TotalPayment = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.totalCollectibles = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpfrm = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCostId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.dgledger = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcomp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgledger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Olive
        Me.Panel1.Controls.Add(Me.cmdView)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TBal)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TotalPayment)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.totalCollectibles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblCostId)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtcontact)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.dgledger)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtcomp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 394)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(826, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 38)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Add Payment"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TBal
        '
        Me.TBal.AutoSize = True
        Me.TBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBal.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TBal.Location = New System.Drawing.Point(853, 80)
        Me.TBal.Name = "TBal"
        Me.TBal.Size = New System.Drawing.Size(40, 20)
        Me.TBal.TabIndex = 23
        Me.TBal.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Location = New System.Drawing.Point(776, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Balance:"
        '
        'TotalPayment
        '
        Me.TotalPayment.AutoSize = True
        Me.TotalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPayment.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TotalPayment.Location = New System.Drawing.Point(853, 54)
        Me.TotalPayment.Name = "TotalPayment"
        Me.TotalPayment.Size = New System.Drawing.Size(40, 20)
        Me.TotalPayment.TabIndex = 21
        Me.TotalPayment.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(733, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total Payment:"
        '
        'totalCollectibles
        '
        Me.totalCollectibles.AutoSize = True
        Me.totalCollectibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCollectibles.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.totalCollectibles.Location = New System.Drawing.Point(853, 34)
        Me.totalCollectibles.Name = "totalCollectibles"
        Me.totalCollectibles.Size = New System.Drawing.Size(40, 20)
        Me.totalCollectibles.TabIndex = 19
        Me.totalCollectibles.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(715, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total Collectibles:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpfrm)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 44)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        Me.GroupBox1.Visible = False
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(748, 112)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(72, 38)
        Me.cmdView.TabIndex = 4
        Me.cmdView.Text = "Print "
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(179, 16)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(150, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "To:"
        '
        'dtpfrm
        '
        Me.dtpfrm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrm.Location = New System.Drawing.Point(45, 16)
        Me.dtpfrm.Name = "dtpfrm"
        Me.dtpfrm.Size = New System.Drawing.Size(99, 20)
        Me.dtpfrm.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "From:"
        '
        'lblCostId
        '
        Me.lblCostId.AutoSize = True
        Me.lblCostId.ForeColor = System.Drawing.Color.Cornsilk
        Me.lblCostId.Location = New System.Drawing.Point(97, 12)
        Me.lblCostId.Name = "lblCostId"
        Me.lblCostId.Size = New System.Drawing.Size(0, 13)
        Me.lblCostId.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(415, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "E-Mail"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(457, 88)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(245, 20)
        Me.txtemail.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(407, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Contact"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(457, 62)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(245, 20)
        Me.txtcontact.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(21, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Address:"
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(75, 69)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(245, 81)
        Me.txtadd.TabIndex = 10
        '
        'dgledger
        '
        Me.dgledger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgledger.Location = New System.Drawing.Point(12, 164)
        Me.dgledger.Name = "dgledger"
        Me.dgledger.Size = New System.Drawing.Size(963, 218)
        Me.dgledger.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(330, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Organization / Company"
        '
        'txtcomp
        '
        Me.txtcomp.Location = New System.Drawing.Point(457, 36)
        Me.txtcomp.Name = "txtcomp"
        Me.txtcomp.Size = New System.Drawing.Size(245, 20)
        Me.txtcomp.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(75, 37)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(245, 20)
        Me.txtfname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costumer Id:"
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 394)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collect Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgledger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCostId As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtadd As TextBox
    Friend WithEvents dgledger As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcomp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdView As Button
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpfrm As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TBal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TotalPayment As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents totalCollectibles As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
