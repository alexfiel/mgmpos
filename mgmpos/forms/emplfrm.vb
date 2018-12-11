Public Class emplfrm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New cEmployee
        x.fname = TextBox1.Text
        x.lname = TextBox2.Text
        x.mname = TextBox3.Text
        x.user = TextBox4.Text
        x.pass = TextBox5.Text
        x.designation = TextBox6.Text
        x.imageloc = PictureBox1.Tag

        x.addEmployee()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y As New cEmployee
        y.xSearch = txtsearch.Text
        TextBox1.Text = y.fname
        TextBox2.Text = y.lname
        TextBox3.Text = y.mname
        TextBox4.Text = y.user
        TextBox5.Text = y.pass
        TextBox6.Text = y.designation
        PictureBox1.ImageLocation = y.imageloc
        y.searchEmployee()
        TextBox1.Text = y.fname
        TextBox2.Text = y.lname
        TextBox3.Text = y.mname
        TextBox4.Text = y.user
        TextBox5.Text = y.pass
        TextBox6.Text = y.designation
        PictureBox1.ImageLocation = y.imageloc
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.InitialDirectory = "C:\temp"
        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.PictureBox1.ImageLocation = fdlg.FileName
            Me.PictureBox1.Tag = fdlg.FileName
        End If
    End Sub
End Class