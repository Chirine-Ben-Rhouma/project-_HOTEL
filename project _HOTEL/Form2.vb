Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_login.Text = "CHOUCHOU" And txt_password.Text = "123" Then
            Form3.Show()
            Me.Hide()
        Else
            Label3.Visible = True
        End If
    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        Form3.Close()
        Form1.Close()
    End Sub


End Class