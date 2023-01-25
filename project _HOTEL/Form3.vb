Public Class Form3
    Private Sub bt_checkin_Click(sender As Object, e As EventArgs)

        pnl_checkin.Visible = True
        pnl_rooms.Visible = False
        pnl_rooms.Visible = False
        pnl_hg.Visible = False
        pnl_mg.Visible = False
        pnl_bg.Visible = False
    End Sub



    Private Sub bt_rooms_Click(sender As Object, e As EventArgs) Handles bt_rooms.Click

        pnl_checkin.Visible = False
        pnl_rooms.Visible = True
        pnl_hg.Visible = False
        pnl_mg.Visible = False
        pnl_bg.Visible = False
    End Sub

    Private Sub bt_logout_Click(sender As Object, e As EventArgs) Handles bt_logout.Click
        Me.Close()
        Form2.Close()
        Form1.Close()
    End Sub

    Private Sub bt_hg_Click(sender As Object, e As EventArgs) Handles bt_hg.Click

        pnl_checkin.Visible = False
        pnl_rooms.Visible = False
        pnl_hg.Visible = True
        pnl_mg.Visible = False
        pnl_bg.Visible = False
    End Sub

    Private Sub bt_mg_Click(sender As Object, e As EventArgs) Handles bt_mg.Click

        pnl_checkin.Visible = False
        pnl_rooms.Visible = False
        pnl_hg.Visible = False
        pnl_mg.Visible = True
        pnl_bg.Visible = False
    End Sub

    Private Sub bt_bg_Click(sender As Object, e As EventArgs) Handles bt_bg.Click

        pnl_checkin.Visible = False
        pnl_rooms.Visible = False
        pnl_hg.Visible = False
        pnl_mg.Visible = False
        pnl_bg.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        Form2.Close()
        Form1.Close()
    End Sub

    Private Sub bt_checkinbg_Click(sender As Object, e As EventArgs) Handles bt_checkinbg.Click
        pnl_checkin.Visible = True
    End Sub
    Private Sub bt_checkinhg_Click(sender As Object, e As EventArgs) Handles bt_checkinhg.Click
        pnl_checkin.Visible = True
    End Sub
    Private Sub bt_checkinmg_Click(sender As Object, e As EventArgs) Handles bt_checkinmg.Click
        pnl_checkin.Visible = True
    End Sub

    Private Sub lbl_Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt1 As DateTime = Convert.ToDateTime(txt_checkindate.Text)

        Dim dt2 As DateTime = Convert.ToDateTime(txt_checkoutdate.Text)

        Dim ts As TimeSpan = dt2.Subtract(dt1)

        lbl_numberofdays.Text = Convert.ToInt32(ts.Days)
        lbl_total.Text = lbl_numberofdays.Text * lbl_
    End Sub
End Class