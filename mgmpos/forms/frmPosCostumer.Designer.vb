<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPosCostumer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcustName = New System.Windows.Forms.TextBox()
        Me.txtcustAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtamountdue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtobjid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcustorgname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTermUntil = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 80)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Charge to Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Costumer Name:"
        '
        'txtcustName
        '
        Me.txtcustName.Enabled = False
        Me.txtcustName.Location = New System.Drawing.Point(102, 169)
        Me.txtcustName.Name = "txtcustName"
        Me.txtcustName.Size = New System.Drawing.Size(267, 20)
        Me.txtcustName.TabIndex = 2
        '
        'txtcustAddress
        '
        Me.txtcustAddress.Enabled = False
        Me.txtcustAddress.Location = New System.Drawing.Point(102, 195)
        Me.txtcustAddress.Name = "txtcustAddress"
        Me.txtcustAddress.Size = New System.Drawing.Size(267, 20)
        Me.txtcustAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address:"
        '
        'txtcontact
        '
        Me.txtcontact.Enabled = False
        Me.txtcontact.Location = New System.Drawing.Point(102, 221)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(156, 20)
        Me.txtcontact.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contact No.:"
        '
        'txtamountdue
        '
        Me.txtamountdue.Enabled = False
        Me.txtamountdue.Location = New System.Drawing.Point(102, 274)
        Me.txtamountdue.Name = "txtamountdue"
        Me.txtamountdue.Size = New System.Drawing.Size(134, 20)
        Me.txtamountdue.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Amount Due:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Accept"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtobjid
        '
        Me.txtobjid.Enabled = False
        Me.txtobjid.Location = New System.Drawing.Point(102, 117)
        Me.txtobjid.Name = "txtobjid"
        Me.txtobjid.Size = New System.Drawing.Size(267, 20)
        Me.txtobjid.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Costumer Objid:"
        '
        'txtcustorgname
        '
        Me.txtcustorgname.Enabled = False
        Me.txtcustorgname.Location = New System.Drawing.Point(102, 143)
        Me.txtcustorgname.Name = "txtcustorgname"
        Me.txtcustorgname.Size = New System.Drawing.Size(267, 20)
        Me.txtcustorgname.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Org. Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Terms in months:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(102, 247)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(49, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(305, 86)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(64, 25)
        Me.cmdSearch.TabIndex = 17
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Term Due Date:"
        '
        'lblTermUntil
        '
        Me.lblTermUntil.AutoSize = True
        Me.lblTermUntil.Location = New System.Drawing.Point(246, 255)
        Me.lblTermUntil.Name = "lblTermUntil"
        Me.lblTermUntil.Size = New System.Drawing.Size(30, 13)
        Me.lblTermUntil.TabIndex = 19
        Me.lblTermUntil.Text = "Date"
        '
        'frmPosCostumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 355)
        Me.Controls.Add(Me.lblTermUntil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcustorgname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtobjid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtamountdue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcustAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcustName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPosCostumer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge to Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcustName As TextBox
    Friend WithEvents txtcustAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtamountdue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtobjid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcustorgname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmdSearch As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTermUntil As Label
End Class
