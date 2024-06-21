Public Class TenKey
    Private pForm As Form1
    Public Sub New(parent As Form1)
        InitializeComponent()
        pForm = parent
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        pForm.Label1.Text = pForm.Label1.Text & sender.Text
    End Sub

    Private Sub TenKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
