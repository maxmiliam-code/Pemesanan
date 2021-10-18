Public Class formMain
    Dim total, bayar, kembali As Integer
    Dim teh, total10 As Integer
    Dim soft, total9 As Integer
    Dim jus, total8 As Integer
    Dim ice, total7 As Integer
    Dim kopi, total6 As Integer
    Dim miku, total5 As Integer
    Dim seafood, total4 As Integer
    Dim migor, total3 As Integer
    Dim nasi, total2 As Integer
    Dim ayam, total1 As Integer


    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        pnlButtonFood.Height = btnFood.Height
        pnlButtonFood.Top = btnFood.Top
        pnlFood.Visible = True
        pnlDrink.Visible = False
        pnlTotal.Visible = False
    End Sub

    Private Sub btnDrink_Click(sender As Object, e As EventArgs) Handles btnDrink.Click
        pnlButtonDrink.Height = btnDrink.Height
        pnlButtonDrink.Top = btnDrink.Top
        pnlFood.Visible = False
        pnlDrink.Visible = True
        pnlTotal.Visible = False
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        pnlButtonTotal.Height = btnTotal.Height
        pnlButtonTotal.Top = btnTotal.Top
        pnlFood.Visible = False
        pnlDrink.Visible = False
        pnlTotal.Visible = True
    End Sub

    Private Sub bt_ayam_Click(sender As Object, e As EventArgs) Handles bt_ayam.Click

        ayam = 15000
        total1 = ayam * txtjumlah1.Text
    End Sub

    Private Sub bt_nasi_Click(sender As Object, e As EventArgs) Handles bt_nasi.Click

        nasi = 5000
        total2 = nasi * txtjumlah2.Text
    End Sub

    Private Sub bt_migor_Click(sender As Object, e As EventArgs) Handles bt_migor.Click
        migor = 12000
        total3 = migor * txtjumlah3.Text
    End Sub

    Private Sub bt_seafood_Click(sender As Object, e As EventArgs) Handles bt_seafood.Click

        seafood = 15000
        total4 = seafood * txtjumlah4.Text
    End Sub

    Private Sub bt_miku_Click(sender As Object, e As EventArgs) Handles bt_miku.Click

        miku = 15000
        total5 = miku * txtjumlah5.Text
    End Sub

    Private Sub bt_kopi_Click(sender As Object, e As EventArgs) Handles bt_kopi.Click

        kopi = 15000
        total6 = kopi * txtjumlah6.Text
    End Sub

    Private Sub bt_ice_Click(sender As Object, e As EventArgs) Handles bt_ice.Click

        ice = 15000
        total7 = ice * txtjumlah7.Text
    End Sub

    Private Sub bt_jus_Click(sender As Object, e As EventArgs) Handles bt_jus.Click

        jus = 15000
        total8 = jus * txtjumlah8.Text
    End Sub

    Private Sub bt_soft_Click(sender As Object, e As EventArgs) Handles bt_soft.Click

        soft = 15000
        total9 = soft * txtjumlah9.Text
    End Sub

    Private Sub bt_teh_Click(sender As Object, e As EventArgs) Handles bt_teh.Click

        teh = 15000
        total10 = teh * txtjumlah10.Text
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        total = total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8 + total9 + total10
        txttotal.Text = total
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class
