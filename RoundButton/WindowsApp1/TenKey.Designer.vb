Imports CircleButton

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TenKey
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn7 = New RoundButton()
        Me.btn8 = New RoundButton()
        Me.btn9 = New RoundButton()
        Me.btn4 = New RoundButton()
        Me.btn5 = New RoundButton()
        Me.btn6 = New RoundButton()
        Me.btn1 = New RoundButton()
        Me.btn2 = New RoundButton()
        Me.btn3 = New RoundButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn6, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn5, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn9, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn7, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(319, 318)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn7.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn7.Location = New System.Drawing.Point(3, 3)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(100, 100)
        Me.btn7.TabIndex = 0
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn8.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn8.Location = New System.Drawing.Point(109, 3)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(100, 100)
        Me.btn8.TabIndex = 1
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn9.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn9.Location = New System.Drawing.Point(215, 3)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(100, 100)
        Me.btn9.TabIndex = 2
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn4.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn4.Location = New System.Drawing.Point(3, 109)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(100, 100)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn5.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn5.Location = New System.Drawing.Point(109, 109)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(100, 100)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn6.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn6.Location = New System.Drawing.Point(215, 109)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(100, 100)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn1.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1.Location = New System.Drawing.Point(3, 215)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 100)
        Me.btn1.TabIndex = 6
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn2.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn2.Location = New System.Drawing.Point(109, 215)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(100, 100)
        Me.btn2.TabIndex = 7
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn3.Font = New System.Drawing.Font("ＭＳ ゴシック", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn3.Location = New System.Drawing.Point(215, 215)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(100, 100)
        Me.btn3.TabIndex = 8
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'TenKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "TenKey"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn3 As RoundButton
    Friend WithEvents btn2 As RoundButton
    Friend WithEvents btn1 As RoundButton
    Friend WithEvents btn6 As RoundButton
    Friend WithEvents btn5 As RoundButton
    Friend WithEvents btn4 As RoundButton
    Friend WithEvents btn9 As RoundButton
    Friend WithEvents btn8 As RoundButton
    Friend WithEvents btn7 As RoundButton
End Class
