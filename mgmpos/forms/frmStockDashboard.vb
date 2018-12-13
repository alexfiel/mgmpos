Imports System
Public Class frmStockDashboard
    Dim stockonhand As Double
    Dim stockreceived As Double
    Dim stocktotal As Double


    Dim Newproduct As New product
    Dim Pdate As String
    Dim transaction As Boolean = False



    Private Sub txtqtyreceived_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqtyreceived.KeyDown
        If e.KeyCode = Keys.Enter Then
            stockonhand = txtstockonhand.Text
            stockreceived = txtqtyreceived.Text
            'stocktotal = CDbl(txttotal.Text)
            stocktotal = stockonhand + stockreceived
            txttotal.Text = stocktotal
            DTPSreceived.Focus()

        End If
    End Sub

    Private Sub frmStockDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlStockIn.Dock = DockStyle.Fill
        pnlStockOut.Dock = DockStyle.Fill
        retrievelocationlist()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        Dim transcode As String = Guid.NewGuid().ToString("N")
        'Dim utc As String = GetNetTime.GetUTC
        '' add random alpha prefix to UNIX time stamp
        'Dim sPrefix As String = ""
        'Dim rdm As New Random()
        'For i As Integer = 1 To 3 ' if you need more than 3 alpah random charachters adjust i length
        '    sPrefix &= ChrW(rdm.Next(65, 90))
        'Next
        'lbltransaction.Text = sPrefix & utc + "-IN"
        '' MsgBox(userId)
        '' MsgBox(sPrefix & utc) ' OR MsgBox("ID" & sPrefix & utc)
        '' code here to use result
        If transaction = False Then
            If MsgBox("Do you want to create a new transaction?", vbYesNo + vbQuestion, "New") = vbYes Then
                transaction = True
                lbltransaction.Text = transcode
                txtqtyreceived.Text = "0"
                txtSdocNo.Text = ""
                txtSpcode.Text = ""

                txtSpname.Text = ""
                cbolocation.Text = ""
                txtqtyreceived.Text = "0"
                txtqtyremarks.Text = ""



            Else
                transaction = False
                txtSpcode.Text = ""
                txtSpname.Text = ""
                txtqtyreceived.Text = "0"
                txtstockonhand.Text = "0"
                txtqtyreceived.Text = "0"
                txttotal.Text = 0
                txtSpcode.Focus()

            End If
            'lbltransaction.Text = transcode
        End If
        txtSdocNo.Focus()

        cbolocation.Text = ""



    End Sub



    Private Sub txtSPin_TextChanged_2(sender As Object, e As EventArgs) Handles txtSPin.TextChanged

    End Sub

    Private Sub txtSPin_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSPin.KeyUp
        If e.KeyCode = Keys.Enter Then

            searchProductIN_txtbox()
        End If
    End Sub

    Private Sub txtqtyreceived_TextChanged_1(sender As Object, e As EventArgs) Handles txtqtyreceived.TextChanged

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If txtSdocNo.Text = "" Then
            MsgBox("Please input data!", vbInformation, "Input Data")
            txtSdocNo.Focus()
        ElseIf txtSpCategory.text = "" Then
            MsgBox("Please input category!", vbInformation, "Input Data")
            txtSpCategory.Focus()
        ElseIf txtSpcode.text = "" Then
            MsgBox("Please input product code!", vbInformation, "Input Data")
            txtSpcode.Focus()
        ElseIf txtqtyreceived.text = "" Then
            MsgBox("Please input data!", vbInformation, "Input Data")
            txtqtyreceived.Focus()
        Else
            Newproduct.TransCode = lbltransaction.Text
            Newproduct.ProdCode = txtSpcode.Text
            Newproduct.ProductName = txtSpname.Text
            Newproduct.ProductCategory = txtSpCategory.Text
            Newproduct.ProdLocation = locationid
            Newproduct.ProdDocNo = txtSdocNo.Text
            Newproduct.ProductDate = DTPSreceived.Text
            Newproduct.ProdRemarks = txtqtyremarks.Text
            Newproduct.ProductQty = txtstockonhand.Text
            Newproduct.ProdStockin = txtqtyreceived.Text
            Newproduct.ProductAvailable = txttotal.Text
            Newproduct.USERID = userId

            ' Newproduct.viewAvailableStock()

            'MsgBox(locationid)
            'MsgBox(DTPSreceived.Value)
            'MsgBox(userId)
            'MsgBox(Newproduct.viewAvailableStock)

            Newproduct.ReceiveProduct() ' insert data into invetory_in
            Newproduct.updateProductQTY() 'update data of product
            CLEAR()
            searchProductIn()
            txtSPin.Focus()
            transaction = False
        End If




    End Sub

    Private Sub cbolocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbolocation.SelectedIndexChanged

    End Sub
    Private Sub CLEAR()
        txtSPin.Text = ""
        txtSpcode.Text = ""
        ' txtSdocNo.Text = ""
        txtSpname.Text = ""
        txtqtyremarks.Text = ""
        txtqtyreceived.Text = "0"
        txtstockonhand.Text = "0"
        txtSpCategory.Text = ""

    End Sub

    Private Sub cmdStockIn_Click(sender As Object, e As EventArgs) Handles cmdStockIn.Click
        PnlStockIn.Visible = True
        pnlStockOut.Visible = False
        PnlStockIn.Dock = DockStyle.Fill

    End Sub

    Private Sub cmdStockOut_Click(sender As Object, e As EventArgs) Handles cmdStockOut.Click
        pnlStockOut.Visible = True
        PnlStockIn.Visible = False
        pnlStockOut.Dock = DockStyle.Fill

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs)
        Dim stockin As New frmStockInReport
        Dim prodview As New product

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
        frmDashboard.Show()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        frmPurchaseOrder.ShowDialog()

    End Sub

    Private Sub frmStockDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmDashboard.Show()
    End Sub
End Class