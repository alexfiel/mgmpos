Public Class frmCollection
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newYear As String
        Dim transobjid As String = Guid.NewGuid().ToString("N")
        POStransobjid = transobjid

        Dim dateAndTime As Date
        dateAndTime = Now

        newYear = Format(dateAndTime, "yyyy").ToString
        newNumber = getNewTransNo_Collection()
        frmAddPayment.lblPaymentTransNo.Text = newNumber + newYear

        frmAddPayment.txtobjid.Text = lblCostId.Text
        frmAddPayment.txtcostumer.Text = txtfname.Text
        frmAddPayment.txtadd.Text = txtadd.Text
        frmAddPayment.txtbalancedue.Text = TBal.Text
        frmAddPayment.transno.Text = getNewTransNo_Collection()
        frmAddPayment.ShowDialog()

    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        retrieveCostLedger()
        frmReport.ShowDialog()

    End Sub
End Class