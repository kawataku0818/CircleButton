Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundButton
    Inherits Button

    Private isMouseOver As Boolean = False
    Private isMouseDown As Boolean = False

    Public Sub New()
        SetStyle(ControlStyles.Selectable, False)                   'フォーカスを受け取らないようにする。
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim brushColor As Color
        Dim penColor As Color

        If isMouseDown Then
            brushColor = Color.FromArgb(204, 228, 247)
            penColor = Color.FromArgb(0, 84, 153)
        ElseIf isMouseOver Then
            brushColor = Color.FromArgb(229, 241, 251)
            penColor = Color.FromArgb(0, 120, 215)
        Else
            brushColor = Me.BackColor
            penColor = Color.FromArgb(173, 173, 173)
        End If


        ' 背景の描画
        Using brushR As New SolidBrush(SystemColors.Control)
            e.Graphics.FillRectangle(brushR, 0, 0, Me.Width, Me.Height)
        End Using

        ' ボタンの背景の描画
        ' グラデーション
        'Using brush As New LinearGradientBrush(Me.ClientRectangle, brushColor, Color.Blue, 90.0F)
        '    e.Graphics.FillEllipse(brush, 0, 0, Me.Width, Me.Height)
        'End Using
        'Using brush As New LinearGradientBrush(Me.ClientRectangle, brushColor, SystemColors.Control, 90.0F)
        '    e.Graphics.FillEllipse(brush, 0, 0, Me.Width, Me.Height)
        'End Using
        ' ノーマル
        Using brush As New SolidBrush(brushColor)
            e.Graphics.FillEllipse(brush, 0, 0, Me.Width, Me.Height)
        End Using

        ' ボタンの枠線の描画
        Using pen As New Pen(penColor, 1)
            ' 四角形の左上隅の座標，幅と高さ
            e.Graphics.DrawEllipse(pen, 1, 1, Me.Width - 2, Me.Height - 2)
        End Using

        ' ボタンのテキストの描画
        Using sf As New StringFormat()
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), Me.ClientRectangle, sf)
        End Using
    End Sub


    Protected Overrides Sub OnMouseMove(mevent As MouseEventArgs)
        Dim mousePos As Point = mevent.Location
        Dim wasMouseOver As Boolean = isMouseOver
        isMouseOver = IsPointInCircle(mousePos)

        If isMouseOver <> wasMouseOver Then
            Me.Invalidate()
        End If

        ' ボタンの外にドラッグした場合にフラグをリセット
        If Not isMouseOver AndAlso isMouseDown Then
            isMouseDown = False
            Me.Invalidate()
        End If

        MyBase.OnMouseMove(mevent)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        isMouseOver = False
        Me.Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        If IsPointInCircle(mevent.Location) Then
            If mevent.Button = MouseButtons.Left Then
                isMouseDown = True
                Me.Invalidate()
            End If
            MyBase.OnMouseDown(mevent)
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        If IsPointInCircle(mevent.Location) Then
            If mevent.Button = MouseButtons.Left Then
                isMouseDown = False
                Me.Invalidate()
            End If
            MyBase.OnMouseUp(mevent)
        End If
    End Sub

    Protected Overrides Sub OnMouseClick(mevent As MouseEventArgs)
        If IsPointInCircle(mevent.Location) Then
            MyBase.OnMouseClick(mevent)
        End If
    End Sub

    Private Function IsPointInCircle(point As Point) As Boolean
        Dim radius As Double = Math.Min(Me.Width, Me.Height) / 2
        Dim center As New Point(Me.Width / 2, Me.Height / 2)
        Return (Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2) <= Math.Pow(radius, 2))
    End Function
End Class
