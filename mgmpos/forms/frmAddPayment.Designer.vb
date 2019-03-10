<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPayment
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
        Me.txtobjid = New System.Windows.Forms.TextBox()
        Me.txtcostumer = New System.Windows.Forms.TextBox()
        Me.txtbalancedue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPaymentTransNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamounttendered = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.transno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtobjid
        '
        Me.txtobjid.Enabled = False
        Me.txtobjid.Location = New System.Drawing.Point(109, 29)
        Me.txtobjid.Name = "txtobjid"
        Me.txtobjid.Size = New System.Drawing.Size(254, 20)
        Me.txtobjid.TabIndex = 0
        '
        'txtcostumer
        '
        Me.txtcostumer.Enabled = False
        Me.txtcostumer.Location = New System.Drawing.Point(109, 55)
        Me.txtcostumer.Name = "txtcostumer"
        Me.txtcostumer.Size = New System.Drawing.Size(254, 20)
        Me.txtcostumer.TabIndex = 1
        '
        'txtbalancedue
        '
        Me.txtbalancedue.Enabled = False
        Me.txtbalancedue.Location = New System.Drawing.Point(109, 106)
        Me.txtbalancedue.Name = "txtbalancedue"
        Me.txtbalancedue.Size = New System.Drawing.Size(254, 20)
        Me.txtbalancedue.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(75, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Objid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(55, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Costumer:"
        '
        'lblPaymentTransNo
        '
        Me.lblPaymentTransNo.AutoSize = True
        Me.lblPaymentTransNo.Location = New System.Drawing.Point(11, 9)
        Me.lblPaymentTransNo.Name = "lblPaymentTransNo"
        Me.lblPaymentTransNo.Size = New System.Drawing.Size(31, 13)
        Me.lblPaymentTransNo.TabIndex = 5
        Me.lblPaymentTransNo.Text = "0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(34, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Balance Due:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(11, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Amount Tendered:"
        '
        'txtamounttendered
        '
        Me.txtamounttendered.Location = New System.Drawing.Point(109, 132)
        Me.txtamounttendered.Name = "txtamounttendered"
        Me.txtamounttendered.Size = New System.Drawing.Size(254, 20)
        Me.txtamounttendered.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(59, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Change:"
        Me.Label6.Visible = False
        '
        'txtchange
        '
        Me.txtchange.Enabled = False
        Me.txtchange.Location = New System.Drawing.Point(109, 158)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(254, 20)
        Me.txtchange.TabIndex = 9
        Me.txtchange.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(58, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Address:"
        '
        'txtadd
        '
        Me.txtadd.Enabled = False
        Me.txtadd.Location = New System.Drawing.Point(109, 81)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(254, 20)
        Me.txtadd.TabIndex = 13
        '
        'transno
        '
        Me.transno.AutoSize = True
        Me.transno.Location = New System.Drawing.Point(341, 9)
        Me.transno.Name = "transno"
        Me.transno.Size = New System.Drawing.Size(31, 13)
        Me.transno.TabIndex = 15
        Me.transno.Text = "0000"
        Me.transno.Visible = False
        '
        'frmAddPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(384, 236)
        Me.Controls.Add(Me.transno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtamounttendered)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPaymentTransNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbalancedue)
        Me.Controls.Add(Me.txtcostumer)
        Me.Controls.Add(Me.txtobjid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtobjid As TextBox
    Friend WithEvents txtcostumer As TextBox
    Friend WithEvents txtbalancedue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPaymentTransNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtamounttendered As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtadd As TextBox
    Friend WithEvents transno As Label
End Class
