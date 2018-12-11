Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dbConnection()
            sql = "SELECT * FROM newpost_database.employees_database where username=@username and Password=@password;"
            cmd = New MySqlCommand
            cmd = New MySqlCommand(sql, conn)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@username", txtusername.Text)
                .Parameters.AddWithValue("@password", txtpassword.Text)
            End With
            dr = cmd.ExecuteReader
            If dr.Read Then
                userId = dr("Employee_ID")
                username = dr("Username")
                userlevel = dr("User_Level")
                userimageloc = dr("img_location")

            End If
            If dr.HasRows Then
                If userlevel = "Cashier" Then
                    frmPOS.Show()
                    Me.Visible = False
                ElseIf userlevel = "Administrator" Then
                    frmDashboard.Show()
                    Me.Visible = False
                End If
            Else
                MsgBox("Invalid Username or Password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Login Error")
                txtusername.Text = ""
                txtusername.Focus()
                txtpassword.Text = ""

            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        dr.Close()
        End Try
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress

    End Sub
End Class
