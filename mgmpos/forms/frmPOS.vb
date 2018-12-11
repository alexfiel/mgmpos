Imports System
Public Class frmPOS
    Public newTrans As Boolean = False
    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub txtPOSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPOSearch.KeyDown
        If e.KeyValue = Keys.F1 Or Keys.F2 Or Keys.F3 Or Keys.F4 Or Keys.F5 Or Keys.F6 Or Keys.F7 Or Keys.F8 Or Keys.F9 Or Keys.F10 Or Keys.F11 Or Keys.F12 Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
        End If

        If e.KeyCode = Keys.Enter Then

            If txtPOSearch.Text = "" Then
                MsgBox("Please Input Barcode / Product Name")

            Else

                checkproductCode()
            End If
        End If
    End Sub

    Private Sub txtPOSearch_TextChanged(sender As Object, e As EventArgs) Handles txtPOSearch.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdCash.Click
        modepayment = "cash"
        'MsgBox(postotalamount)
        If lblGrandtotal.Text = "0.00" Then
            MsgBox("Cannot proceed!", vbInformation + vbOKOnly, "Cannot Proceed")

        Else
            frmCash.ShowDialog()
            frmCash.GroupBox1.Enabled = True
            frmCash.txtCashTendered.Text = ""
            frmCash.txtchange.Text = ""
        End If






    End Sub



    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        newTrans = True
        Dim transobjid As String = Guid.NewGuid().ToString("N")
        POStransobjid = transobjid
        DGProduct.Rows.Clear()
        lblcashtendered2.Text = "0.00"
        lblchange2.Text = "0.00"
        lblGrandtotal.Text = "0.00"
        lblDiscount.Text = "0.00"
        lblVat.Text = "0.00"
        lbltotalamount.Text = "0.00"
        lblChequeAmount.Text = "0.00"
        txtPOSearch.Enabled = True
        txtPOSearch.Text = ""
        txtPOSearch.Focus()
        retriveTransactionNo()
        postotalamount = 0
        postotal = 0

        generatTransID()
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtetoday As DateTime = Now
        DGProduct.Columns("Amount").DefaultCellStyle.Format = "N2"
        Dim xdate As Date = DateAndTime.Now()
        lbldate3.Text = dtetoday.ToString("yyyy-MM-dd")
        cmdCash.Enabled = False
        cmdCheque.Enabled = False
        cmdCharge.Enabled = False
        lbluser.Text = username
        lbldesignation.Text = userlevel
        pbEmployeeImg.ImageLocation = userimageloc
        retrieveCOH()

    End Sub

    Private Sub frmPOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub frmPOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.F1 Or Keys.F2 Or Keys.F3 Or Keys.F4 Or Keys.F5 Or Keys.F6 Or Keys.F7 Or Keys.F8 Or Keys.F9 Or Keys.F10 Or Keys.F11 Or Keys.F12 Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub


    Public Sub FuncKeysModule(ByVal value As Keys)
        'Check what function key is in a pressed state, and then perform the corresponding action.
        Select Case value
            Case Keys.F1
                'Add the code for the function key F1 here.
                productlookup.ShowDialog()
               ' MessageBox.Show("F1 pressed")
            Case Keys.F2
                'Add the code for the function key F2 here.
                MessageBox.Show("F2 pressed")
            Case Keys.F3
                'Add the code for the function key F3 here.
                MessageBox.Show("F3 pressed")
            Case Keys.F4
                'Add the code for the function key F4 here.
                MessageBox.Show("F4 pressed")
            Case Keys.F5
                'Add the code for the function key F5 here.

                DGProduct.Rows.Clear()
                lblcashtendered.Text = "0.00"
                lblchange.Text = "0.00"
                lblGrandtotal.Text = "0.00"
                lblDiscount.Text = "0.00"
                lblVat.Text = "0.00"
                lbltotalamount.Text = "0.00"
                lblChequeAmount.Text = "0.00"
                frmCash.GroupBox1.Enabled = True
                frmCash.txtCostumer.Text = ""
                frmCash.txtCashTendered.Text = ""
                txtPOSearch.Enabled = True
                txtPOSearch.Focus()
                retriveTransactionNo()
              '  MessageBox.Show("F5 pressed")
            Case Keys.F6
                'Add the code for the function key F6 here.
                MessageBox.Show("F6 pressed")
            Case Keys.F7
                'Add the code for the function key F7 here.
                MessageBox.Show("F7 pressed")
            Case Keys.F8
                'Add the code for the function key F8 here.
                MessageBox.Show("F8 pressed")
            Case Keys.F9
                'Add the code for the function key F9 here.
                modepayment = "cash"

                frmCash.ShowDialog()
                'frmCash.txtCostumer.Focus()
                frmCash.txtCashTendered.Text = ""
                frmCash.txtchange.Text = ""

                'MessageBox.Show("F9 pressed")
            Case Keys.F10
                modepayment = "cheque"
                frmCheque.ShowDialog()
                'Add the code for the function key F10 here.
                'MessageBox.Show("F10 pressed")
            Case Keys.F11
                'Add the code for the function key F11 here.
                MessageBox.Show("F11 pressed")
            Case Keys.F12
                'Add the code for the key F12 here
                MessageBox.Show("F12 pressed")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_KeyDown(sender As Object, e As KeyEventArgs) Handles Button3.KeyDown

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs)
        'When the function keys are pressed, FuncKeysModule is called. 
        If e.KeyValue = Keys.F1 Or Keys.F2 Or Keys.F3 Or Keys.F4 Or Keys.F5 Or Keys.F6 Or Keys.F7 Or Keys.F8 Or Keys.F9 Or Keys.F10 Or Keys.F11 Or Keys.F12 Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
        End If
    End Sub

    Private Sub cmdNew_KeyDown(sender As Object, e As KeyEventArgs) Handles cmdNew.KeyDown
        If e.KeyValue = Keys.F5 Then
            DGProduct.Rows.Clear()
            lblcashtendered.Text = "0.00"
            lblchange.Text = "0.00"
            lblGrandtotal.Text = "0.00"
            lblDiscount.Text = "0.00"
            lblVat.Text = "0.00"
            lbltotalamount.Text = "0.00"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        productlookup.ShowDialog()

    End Sub

    Private Sub cmdCheque_Click(sender As Object, e As EventArgs) Handles cmdCheque.Click
        modepayment = "cheque"
        If lblGrandtotal.Text = "0.00" Then
            MsgBox("Cannot proceed!", vbInformation + vbOKOnly, "Cannot Proceed")

        Else
            frmCheque.ShowDialog()

        End If


    End Sub

    Private Sub DGProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProduct.CellContentClick
        If e.RowIndex >= 0 Then

            cellevent = 1
            index = e.RowIndex
            row = DGProduct.Rows(index)
            Pprodcode = row.Cells(0).Value.ToString
            Pprodname = row.Cells(1).Value.ToString()
            Pamount = row.Cells(4).Value.ToString()
            cmdVoid.Enabled = True
        End If
    End Sub

    Private Sub cmdVoid_Click(sender As Object, e As EventArgs) Handles cmdVoid.Click
        Dim xpostotal As Double = CDbl(lbltotalamount.Text)
        Try
            If DGProduct.CurrentCell.Selected Then
                DGProduct.Rows.Remove(row)

                posvat = Pamount * vat
                xpostotal = Pamount - posvat
                lblGrandtotal.Text = Format((Double.Parse(lblGrandtotal.Text) - Pamount), "#,##0.00")
                lblVat.Text = Format((Double.Parse(lblVat.Text) - posvat), "#,##0.00")
                lbltotalamount.Text = Format((Double.Parse(lbltotalamount.Text) - xpostotal), "#,##0.00")
                ' lblGrandtotal.Text = Double.Parse(lblGrandtotal.Text) - postotal

                If DGProduct.RowCount = -1 Or DGProduct.RowCount = 0 Then
                    lblVat.Text = "0.00"
                    lbltotalamount.Text = "0.00"
                End If
                'cmdVoid.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Please try again!")
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub

    Private Sub cmdCharge_Click(sender As Object, e As EventArgs) Handles cmdCharge.Click
        modepayment = "term"
        If lblGrandtotal.Text = "0.00" Then
            MsgBox("Cannot proceed!", vbInformation + vbOKOnly, "Cannot Proceed")

        Else
            frmPosCostumer.ShowDialog()

        End If


    End Sub

    Private Sub cmdRemit_Click(sender As Object, e As EventArgs) Handles cmdRemit.Click
        frmReport_product.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If userlevel = "Cashier" Then
            MsgBox("User Account Not Allowed!", vbInformation + vbOKOnly, "User Account not Allowed")
        Else

            frmDashboard.Show()
            Me.Dispose()

        End If
    End Sub

    Private Sub frmPOS_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

    End Sub

    Private Sub btnReceiveCash_Click(sender As Object, e As EventArgs) Handles btnReceiveCash.Click
        Dim cshonhnd As String = Guid.NewGuid.ToString("N")
        cashonhandobjid = cshonhnd
        frmReceiveCash.txtcashier.Text = username
        frmReceiveCash.txtamount.Text = ""
        frmReceiveCash.dtDateCOH.Text = Date.Today
        frmReceiveCash.txtOrigin.Text = ""
        frmReceiveCash.txtDescription.Text = ""
        frmReceiveCash.ShowDialog()


    End Sub

    Private Sub btnRemit_Click(sender As Object, e As EventArgs) Handles btnRemit.Click
        getUnremitted()

    End Sub
End Class