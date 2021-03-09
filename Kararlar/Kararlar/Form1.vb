Public Class Form1
    Private Sub ButtonKontrol1_Click(sender As Object, e As EventArgs) Handles ButtonKontrol1.Click
        Dim Sayi As Integer
        Sayi = SayiTextBox.Text
        SonucTextBox.Text = ""
        If Sayi Mod 2 = 1 Then
            SonucTextBox.Text = "Girilen sayı tek sayıdır."
        End If
    End Sub

    Private Sub ButtonKontrol2_Click(sender As Object, e As EventArgs) Handles ButtonKontrol2.Click
        If IsNumeric(SayiTextBox.Text) Then
            Dim Sayi As Integer = SayiTextBox.Text
            Dim Kalan As Byte
            Kalan = Sayi Mod 2
            If Kalan = 1 Then
                SonucTextBox.Text = Sayi & "sayısı tek sayıdır."
            Else
                SonucTextBox.Text = Sayi & "sayısı çift sayıdır."
            End If
        End If
    End Sub
End Class
