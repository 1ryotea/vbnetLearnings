Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDOTS_Click(sender As Object, e As EventArgs) Handles btnDOTS.Click
        txtOutput.Text &= btnDOTS.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtOutput.Text &= btn1.Text
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtOutput.Text &= btn0.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtOutput.Text &= btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtOutput.Text &= btn3.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtOutput.Text &= btn7.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtOutput.Text &= btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtOutput.Text &= btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtOutput.Text &= btn6.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtOutput.Text &= btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtOutput.Text &= btn9.Text
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        txtOutput.Text &= btnPlus.Text

    End Sub

    Private Sub btnJWB_Click(sender As Object, e As EventArgs) Handles btnJWB.Click
        Try
            Dim table As New DataTable()
            Dim result As Object = table.Compute(txtOutput.Text, String.Empty)
            txtOutput.Text = result.ToString()
        Catch ex As Exception
            txtOutput.Text = "Error"
        End Try
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        txtOutput.Text &= btnBagi.Text
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        txtOutput.Text &= btnMinus.Text
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        txtOutput.Text &= "*"
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtOutput.Text.Length > 0 Then
            txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1)
        End If
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        If txtOutput.Text.Length > 0 Then
            txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length = 0)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPercents.Click
        txtOutput.Text &= btnPercents.Text
    End Sub
End Class
'JUST NOTE
'1. Handles adalah Perintah yang digunakan untuk mengaktifkan event.
'Contohnya Handles Btn1.Click = event akan dijalankan ketika btn1 diklik(btn1.click)

'2. Dim adalah Declare in memory (Deklarasi dalam memori), biasa digunakan di belakang variabel
'Contohnya Dim Nomor as integer = 1, jadi... Deklarasi(Dim) NamaVariabel(Nomor) sebagai(as) TipeData(Integer) = isiVariable(1)

'3. DataTable adalah sebuah kelas yang digunakan untuk menyimpan data dalam bentuk tabel.
'Kelas ini menyediakan berbagai metode untuk mengelola data dalam tabel, seperti menghitung, mengurutkan, dan mencari data.
'Untuk sekarang, Aku cuma pakai Compute() untuk menghitung hasil dari inputan user pada txtOutput.Text
