Imports Guna.UI2.WinForms
Imports Guna.UI2.WinForms.Helpers
Imports Guna.UI2.WinForms.Suite

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a = New Guna2ShadowForm
        a.TargetForm = Me

        Guna2Transition1.HideSync(Guna2GradientPanel1)

        Guna2Transition1.ShowSync(Guna2GradientPanel1)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guna2CircleProgressBar1.Value += 5
        Guna2ProgressBar1.Value += 5
        Guna2RadialGauge1.Value += 5
    End Sub

    Private Sub Guna2ProgressBar1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click

    End Sub

    Private Sub Guna2HtmlToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles Guna2HtmlToolTip1.Popup

    End Sub

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ImageCheckBox1.CheckedChanged

    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2TrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar1.Scroll
        Guna2CircleProgressBar1.Value = e.NewValue
        Guna2ProgressBar1.Value = e.NewValue
        Guna2RadialGauge1.Value = e.NewValue
        Guna2VProgressBar1.Value = e.NewValue
        Guna2HScrollBar1.Value = e.NewValue
        Guna2VScrollBar1.Value = e.NewValue
        Guna2VTrackBar1.Value = e.NewValue

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Facturación1.BringToFront()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Guna2Panel2.BringToFront()
    End Sub
End Class
