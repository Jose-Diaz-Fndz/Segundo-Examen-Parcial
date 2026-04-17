Public Class Form1
    Dim tiempo_Id As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MikuDayo.SelectedIndexChanged
        Dim click As String = MikuDayo.SelectedItem.ToString()
        Dim Teto1 As String = Teto.Text
        If click = "Normal" Then
            Teto1 += 1
        ElseIf click = "Crazy(x2)" Then
            Baguettes.Visible = True
            Teto1 += 2
        ElseIf click = "Extreme(x3)" Then
            MikuEatingTeto.Visible = True
            Teto1 += 3
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo_Id += 1

        Dim segundos As Integer = (tiempo_Id \ 100) Mod 60
        Dim minutos As Integer = (tiempo_Id \ 6000)

        Label1.Text = segundos.ToString("00")
        SrSeed.Text = minutos.ToString("00")
    End Sub
End Class
