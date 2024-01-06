<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me._txb31 = New System.Windows.Forms.TextBox()
        Me._txb51 = New System.Windows.Forms.TextBox()
        Me._btn31 = New System.Windows.Forms.Button()
        Me._btn51 = New System.Windows.Forms.Button()
        Me._btn52 = New System.Windows.Forms.Button()
        Me._cbb51 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._btn71 = New System.Windows.Forms.Button()
        Me._btn72 = New System.Windows.Forms.Button()
        Me._btn73 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '_txb31
        '
        Me._txb31.Location = New System.Drawing.Point(12, 12)
        Me._txb31.Multiline = True
        Me._txb31.Name = "_txb31"
        Me._txb31.ReadOnly = True
        Me._txb31.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb31.Size = New System.Drawing.Size(476, 200)
        Me._txb31.TabIndex = 1
        Me._txb31.WordWrap = False
        '
        '_txb51
        '
        Me._txb51.Location = New System.Drawing.Point(12, 260)
        Me._txb51.Multiline = True
        Me._txb51.Name = "_txb51"
        Me._txb51.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb51.Size = New System.Drawing.Size(476, 200)
        Me._txb51.TabIndex = 2
        Me._txb51.WordWrap = False
        '
        '_btn31
        '
        Me._btn31.Cursor = System.Windows.Forms.Cursors.Hand
        Me._btn31.Location = New System.Drawing.Point(12, 218)
        Me._btn31.Name = "_btn31"
        Me._btn31.Size = New System.Drawing.Size(120, 23)
        Me._btn31.TabIndex = 3
        Me._btn31.Text = "클립보드 복사"
        Me._btn31.UseVisualStyleBackColor = True
        '
        '_btn51
        '
        Me._btn51.Cursor = System.Windows.Forms.Cursors.Hand
        Me._btn51.Location = New System.Drawing.Point(12, 466)
        Me._btn51.Name = "_btn51"
        Me._btn51.Size = New System.Drawing.Size(120, 23)
        Me._btn51.TabIndex = 4
        Me._btn51.Text = "클립보드 넣기"
        Me._btn51.UseVisualStyleBackColor = True
        '
        '_btn52
        '
        Me._btn52.Cursor = System.Windows.Forms.Cursors.Hand
        Me._btn52.Location = New System.Drawing.Point(358, 466)
        Me._btn52.Name = "_btn52"
        Me._btn52.Size = New System.Drawing.Size(130, 23)
        Me._btn52.TabIndex = 5
        Me._btn52.Text = "코드 케이스 생성"
        Me._btn52.UseVisualStyleBackColor = True
        '
        '_cbb51
        '
        Me._cbb51.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cbb51.FormattingEnabled = True
        Me._cbb51.Location = New System.Drawing.Point(252, 467)
        Me._cbb51.Name = "_cbb51"
        Me._cbb51.Size = New System.Drawing.Size(100, 23)
        Me._cbb51.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "단어 구분자 :"
        '
        '_btn71
        '
        Me._btn71.Cursor = System.Windows.Forms.Cursors.Hand
        Me._btn71.Location = New System.Drawing.Point(252, 500)
        Me._btn71.Name = "_btn71"
        Me._btn71.Size = New System.Drawing.Size(241, 23)
        Me._btn71.TabIndex = 8
        Me._btn71.Text = "스네이크 케이스 (Snake Case) 변환"
        Me._btn71.UseVisualStyleBackColor = True
        '
        '_btn72
        '
        Me._btn72.Cursor = System.Windows.Forms.Cursors.Hand
        Me._btn72.Location = New System.Drawing.Point(252, 529)
        Me._btn72.Name = "_btn72"
        Me._btn72.Size = New System.Drawing.Size(241, 23)
        Me._btn72.TabIndex = 9
        Me._btn72.Text = "파스칼 케이스 (Pascal Case) 변환"
        Me._btn72.UseVisualStyleBackColor = True
        '
        '_btn73
        '
        Me._btn73.Cursor = System.Windows.Forms.Cursors.Hand
        Me._btn73.Location = New System.Drawing.Point(252, 558)
        Me._btn73.Name = "_btn73"
        Me._btn73.Size = New System.Drawing.Size(241, 23)
        Me._btn73.TabIndex = 10
        Me._btn73.Text = "카멜 케이스 (Camel Case) 변환"
        Me._btn73.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(500, 600)
        Me.Controls.Add(Me._btn73)
        Me.Controls.Add(Me._btn72)
        Me.Controls.Add(Me._btn71)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._cbb51)
        Me.Controls.Add(Me._btn52)
        Me.Controls.Add(Me._btn51)
        Me.Controls.Add(Me._btn31)
        Me.Controls.Add(Me._txb51)
        Me.Controls.Add(Me._txb31)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(100, 40)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _txb31 As System.Windows.Forms.TextBox
    Friend WithEvents _txb51 As System.Windows.Forms.TextBox
    Friend WithEvents _btn31 As System.Windows.Forms.Button
    Friend WithEvents _btn51 As System.Windows.Forms.Button
    Friend WithEvents _btn52 As System.Windows.Forms.Button
    Friend WithEvents _cbb51 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _btn71 As System.Windows.Forms.Button
    Friend WithEvents _btn72 As System.Windows.Forms.Button
    Friend WithEvents _btn73 As System.Windows.Forms.Button
End Class
