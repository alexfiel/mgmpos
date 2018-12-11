Public Class samplePrint
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objRpt As New sales
        Dim prd As New System.Drawing.Printing.PrintDocument
        objRpt.PrintOptions.PrinterName = prd.PrinterSettings.PrinterName
        objRpt.PrintOptions.PaperSize = prd.PrinterSettings.DefaultPageSettings.PaperSize.RawKind
        objRpt.PrintToPrinter(1, False, 0, 0)
    End Sub
End Class