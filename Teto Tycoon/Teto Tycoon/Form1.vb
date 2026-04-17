Public Class Form1
    Dim tiempo_Id As Integer = 0
    Dim munch As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        MikuDayo.SelectedIndex = 0
        GUMI.Text = "0"
        SrSeed.Text = "00:00"
    End Sub

    Private Sub SoldierTeto_Click(sender As Object, e As EventArgs) Handles SoldierTeto.Click
        If MikuDayo.Text = "Normal" Then
            munch += 1
        ElseIf MikuDayo.Text = "Crazy (x2)" Then
            munch += 2
        ElseIf MikuDayo.Text = "EXTREME (x3)" Then
            munch += 3
        End If

        GUMI.Text = munch
    End Sub

    Private Sub MikuDayo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MikuDayo.SelectedIndexChanged
        If MikuDayo.Text = "Normal" Then
            Baguettes.Visible = False
            MikuEatingTeto.Visible = False
        ElseIf MikuDayo.Text = "Crazy (x2)" Then
            Baguettes.Visible = True
            MikuEatingTeto.Visible = False
        ElseIf MikuDayo.Text = "EXTREME (x3)" Then
            Baguettes.Visible = False
            MikuEatingTeto.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo_Id += 1
        Dim tiempo As TimeSpan = TimeSpan.FromSeconds(tiempo_Id)
        SrSeed.Text = tiempo.ToString("mm\:ss")
    End Sub
End Class
