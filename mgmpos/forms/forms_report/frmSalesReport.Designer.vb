<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        Me.gbSales = New System.Windows.Forms.GroupBox()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.btnView = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GBRemittance = New System.Windows.Forms.GroupBox()
        Me.btnRemitView = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtRemitTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtRemitFrom = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.gbSales.SuspendLayout()
        Me.GBRemittance.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.GBRemittance)
        Me.Panel1.Controls.Add(Me.gbSales)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Report"
        '
        'gbSales
        '
        Me.gbSales.Controls.Add(Me.btnView)
        Me.gbSales.Controls.Add(Me.Label3)
        Me.gbSales.Controls.Add(Me.dtTo)
        Me.gbSales.Controls.Add(Me.Label2)
        Me.gbSales.Controls.Add(Me.dtFrom)
        Me.gbSales.Location = New System.Drawing.Point(499, 12)
        Me.gbSales.Name = "gbSales"
        Me.gbSales.Size = New System.Drawing.Size(417, 69)
        Me.gbSales.TabIndex = 1
        Me.gbSales.TabStop = False
        Me.gbSales.Text = "Enter Date Range"
        '
        'dtFrom
        '
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(45, 26)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(97, 20)
        Me.dtFrom.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To:"
        '
        'dtTo
        '
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(170, 25)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(97, 20)
        Me.dtTo.TabIndex = 2
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(273, 19)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(139, 32)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 100)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(928, 451)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'GBRemittance
        '
        Me.GBRemittance.Controls.Add(Me.btnRemitView)
        Me.GBRemittance.Controls.Add(Me.Label4)
        Me.GBRemittance.Controls.Add(Me.dtRemitTo)
        Me.GBRemittance.Controls.Add(Me.Label5)
        Me.GBRemittance.Controls.Add(Me.dtRemitFrom)
        Me.GBRemittance.Location = New System.Drawing.Point(493, 12)
        Me.GBRemittance.Name = "GBRemittance"
        Me.GBRemittance.Size = New System.Drawing.Size(417, 69)
        Me.GBRemittance.TabIndex = 2
        Me.GBRemittance.TabStop = False
        Me.GBRemittance.Text = "Enter Date Range"
        '
        'btnRemitView
        '
        Me.btnRemitView.Location = New System.Drawing.Point(273, 19)
        Me.btnRemitView.Name = "btnRemitView"
        Me.btnRemitView.Size = New System.Drawing.Size(139, 32)
        Me.btnRemitView.TabIndex = 4
        Me.btnRemitView.Text = "View"
        Me.btnRemitView.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "To:"
        '
        'dtRemitTo
        '
        Me.dtRemitTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRemitTo.Location = New System.Drawing.Point(170, 25)
        Me.dtRemitTo.Name = "dtRemitTo"
        Me.dtRemitTo.Size = New System.Drawing.Size(97, 20)
        Me.dtRemitTo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "From:"
        '
        'dtRemitFrom
        '
        Me.dtRemitFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRemitFrom.Location = New System.Drawing.Point(45, 26)
        Me.dtRemitFrom.Name = "dtRemitFrom"
        Me.dtRemitFrom.Size = New System.Drawing.Size(97, 20)
        Me.dtRemitFrom.TabIndex = 0
        '
        'frmSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 551)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSalesReport"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbSales.ResumeLayout(False)
        Me.gbSales.PerformLayout()
        Me.GBRemittance.ResumeLayout(False)
        Me.GBRemittance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbSales As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GBRemittance As GroupBox
    Friend WithEvents btnRemitView As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtRemitTo As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtRemitFrom As DateTimePicker
End Class
