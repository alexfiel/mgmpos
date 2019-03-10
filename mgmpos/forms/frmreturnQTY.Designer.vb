<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreturnQTY
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
        Me.txtprodcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprodname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtprodcode
        '
        Me.txtprodcode.Enabled = False
        Me.txtprodcode.Location = New System.Drawing.Point(93, 12)
        Me.txtprodcode.Name = "txtprodcode"
        Me.txtprodcode.Size = New System.Drawing.Size(207, 20)
        Me.txtprodcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Name:"
        '
        'txtprodname
        '
        Me.txtprodname.Enabled = False
        Me.txtprodname.Location = New System.Drawing.Point(93, 38)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(207, 20)
        Me.txtprodname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Qty to return:"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(93, 118)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(93, 20)
        Me.txtqty.TabIndex = 4
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(93, 144)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(75, 23)
        Me.cmdok.TabIndex = 6
        Me.cmdok.Text = "Ok"
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'cmdcancel
        '
        Me.cmdcancel.Location = New System.Drawing.Point(174, 144)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdcancel.TabIndex = 7
        Me.cmdcancel.Text = "Cancel"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Unit Price:"
        '
        'txtunitprice
        '
        Me.txtunitprice.Enabled = False
        Me.txtunitprice.Location = New System.Drawing.Point(93, 64)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(93, 20)
        Me.txtunitprice.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 20)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(210, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 20)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Discount:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(93, 90)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(93, 20)
        Me.txtdiscount.TabIndex = 12
        '
        'frmreturnQTY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(312, 182)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprodcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmreturnQTY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Qty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtprodcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtprodname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents cmdok As Button
    Friend WithEvents cmdcancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdiscount As TextBox
End Class
