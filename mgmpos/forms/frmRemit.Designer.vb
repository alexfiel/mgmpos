<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemit
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgCollections = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotalcash = New System.Windows.Forms.Label()
        Me.lbltotalcheque = New System.Windows.Forms.Label()
        Me.lbltotalterm = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.lbltotalcashonhand = New System.Windows.Forms.Label()
        Me.lbltotalsalesremittance = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgCollections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 59)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(674, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(501, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Remit Collections"
        '
        'dgCollections
        '
        Me.dgCollections.AllowUserToAddRows = False
        Me.dgCollections.AllowUserToDeleteRows = False
        Me.dgCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCollections.Location = New System.Drawing.Point(12, 65)
        Me.dgCollections.Name = "dgCollections"
        Me.dgCollections.Size = New System.Drawing.Size(744, 240)
        Me.dgCollections.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Cash:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Cheque:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Term:"
        '
        'lbltotalcash
        '
        Me.lbltotalcash.AutoSize = True
        Me.lbltotalcash.Location = New System.Drawing.Point(95, 316)
        Me.lbltotalcash.Name = "lbltotalcash"
        Me.lbltotalcash.Size = New System.Drawing.Size(28, 13)
        Me.lbltotalcash.TabIndex = 5
        Me.lbltotalcash.Text = "0.00"
        '
        'lbltotalcheque
        '
        Me.lbltotalcheque.AutoSize = True
        Me.lbltotalcheque.Location = New System.Drawing.Point(95, 340)
        Me.lbltotalcheque.Name = "lbltotalcheque"
        Me.lbltotalcheque.Size = New System.Drawing.Size(28, 13)
        Me.lbltotalcheque.TabIndex = 6
        Me.lbltotalcheque.Text = "0.00"
        '
        'lbltotalterm
        '
        Me.lbltotalterm.AutoSize = True
        Me.lbltotalterm.Location = New System.Drawing.Point(95, 366)
        Me.lbltotalterm.Name = "lbltotalterm"
        Me.lbltotalterm.Size = New System.Drawing.Size(28, 13)
        Me.lbltotalterm.TabIndex = 7
        Me.lbltotalterm.Text = "0.00"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(600, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Remit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(681, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 56)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Sales Remittance:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Cash on Hand:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Grand Total:"
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Location = New System.Drawing.Point(344, 366)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(28, 13)
        Me.lblgrandtotal.TabIndex = 15
        Me.lblgrandtotal.Text = "0.00"
        '
        'lbltotalcashonhand
        '
        Me.lbltotalcashonhand.AutoSize = True
        Me.lbltotalcashonhand.Location = New System.Drawing.Point(344, 340)
        Me.lbltotalcashonhand.Name = "lbltotalcashonhand"
        Me.lbltotalcashonhand.Size = New System.Drawing.Size(28, 13)
        Me.lbltotalcashonhand.TabIndex = 14
        Me.lbltotalcashonhand.Text = "0.00"
        '
        'lbltotalsalesremittance
        '
        Me.lbltotalsalesremittance.AutoSize = True
        Me.lbltotalsalesremittance.Location = New System.Drawing.Point(344, 316)
        Me.lbltotalsalesremittance.Name = "lbltotalsalesremittance"
        Me.lbltotalsalesremittance.Size = New System.Drawing.Size(28, 13)
        Me.lbltotalsalesremittance.TabIndex = 13
        Me.lbltotalsalesremittance.Text = "0.00"
        '
        'frmRemit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 388)
        Me.Controls.Add(Me.lblgrandtotal)
        Me.Controls.Add(Me.lbltotalcashonhand)
        Me.Controls.Add(Me.lbltotalsalesremittance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltotalterm)
        Me.Controls.Add(Me.lbltotalcheque)
        Me.Controls.Add(Me.lbltotalcash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgCollections)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmRemit"
        Me.Text = "frmRemit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgCollections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCollections As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotalcash As Label
    Friend WithEvents lbltotalcheque As Label
    Friend WithEvents lbltotalterm As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblgrandtotal As Label
    Friend WithEvents lbltotalcashonhand As Label
    Friend WithEvents lbltotalsalesremittance As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
