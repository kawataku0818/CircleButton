Public Class Form1
    Private tenKey As TenKey

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        If tenKey Is Nothing OrElse tenKey.IsDisposed Then
            tenKey = New TenKey(Me)

            ' フォームプロパティの設定
            tenKey.FormBorderStyle = FormBorderStyle.FixedSingle
            tenKey.MaximizeBox = False
            tenKey.MinimizeBox = False
            tenKey.StartPosition = FormStartPosition.Manual
            tenKey.WindowState = FormWindowState.Normal

            ' スクリーンのワーキングエリアサイズを取得
            Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
            Dim screenWidth As Integer = workingArea.Width
            Dim screenHeight As Integer = workingArea.Height
            Dim keybordWidth As Integer = tenKey.Width
            Dim keybordHeight As Integer = tenKey.Height

            ' 中央に配置し、スクリーンのワーキングエリアの下からキー入力フォームの高さ分上に配置
            Dim x As Integer = workingArea.Left + (screenWidth - keybordWidth) / 2
            Dim y As Integer = workingArea.Top + screenHeight - keybordHeight

            tenKey.Location = New Point(x, y)
            tenKey.Show()
        Else
            tenKey.BringToFront()
        End If
    End Sub
End Class
