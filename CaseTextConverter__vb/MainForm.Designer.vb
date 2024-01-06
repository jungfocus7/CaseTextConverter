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
        Me.m_txb31 = New System.Windows.Forms.TextBox()
        Me.m_txb51 = New System.Windows.Forms.TextBox()
        Me.m_btn31 = New System.Windows.Forms.Button()
        Me.m_btn51 = New System.Windows.Forms.Button()
        Me.m_btn71 = New System.Windows.Forms.Button()
        Me.m_cbb71 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.m_cbb72 = New System.Windows.Forms.ComboBox()
        Me.m_cbb73 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'm_txb31
        '
        Me.m_txb31.Location = New System.Drawing.Point(12, 12)
        Me.m_txb31.Multiline = True
        Me.m_txb31.Name = "m_txb31"
        Me.m_txb31.ReadOnly = True
        Me.m_txb31.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.m_txb31.Size = New System.Drawing.Size(476, 180)
        Me.m_txb31.TabIndex = 5
        Me.m_txb31.WordWrap = False
        '
        'm_txb51
        '
        Me.m_txb51.Location = New System.Drawing.Point(12, 237)
        Me.m_txb51.Multiline = True
        Me.m_txb51.Name = "m_txb51"
        Me.m_txb51.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.m_txb51.Size = New System.Drawing.Size(476, 180)
        Me.m_txb51.TabIndex = 0
        Me.m_txb51.WordWrap = False
        '
        'm_btn31
        '
        Me.m_btn31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn31.Location = New System.Drawing.Point(12, 198)
        Me.m_btn31.Name = "m_btn31"
        Me.m_btn31.Size = New System.Drawing.Size(120, 23)
        Me.m_btn31.TabIndex = 6
        Me.m_btn31.Text = "클립보드 복사"
        Me.m_btn31.UseVisualStyleBackColor = True
        '
        'm_btn51
        '
        Me.m_btn51.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn51.Location = New System.Drawing.Point(12, 423)
        Me.m_btn51.Name = "m_btn51"
        Me.m_btn51.Size = New System.Drawing.Size(120, 23)
        Me.m_btn51.TabIndex = 7
        Me.m_btn51.Text = "클립보드 넣기"
        Me.m_btn51.UseVisualStyleBackColor = True
        '
        'm_btn71
        '
        Me.m_btn71.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_btn71.Location = New System.Drawing.Point(348, 432)
        Me.m_btn71.Name = "m_btn71"
        Me.m_btn71.Size = New System.Drawing.Size(140, 84)
        Me.m_btn71.TabIndex = 4
        Me.m_btn71.Text = "케이스 텍스트 변환"
        Me.m_btn71.UseVisualStyleBackColor = True
        '
        'm_cbb71
        '
        Me.m_cbb71.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_cbb71.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.m_cbb71.FormattingEnabled = True
        Me.m_cbb71.Location = New System.Drawing.Point(232, 433)
        Me.m_cbb71.Name = "m_cbb71"
        Me.m_cbb71.Size = New System.Drawing.Size(110, 23)
        Me.m_cbb71.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 438)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "라인 구분 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "입력 구분 :"
        '
        'm_cbb72
        '
        Me.m_cbb72.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_cbb72.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.m_cbb72.FormattingEnabled = True
        Me.m_cbb72.Location = New System.Drawing.Point(232, 462)
        Me.m_cbb72.Name = "m_cbb72"
        Me.m_cbb72.Size = New System.Drawing.Size(110, 23)
        Me.m_cbb72.TabIndex = 2
        '
        'm_cbb73
        '
        Me.m_cbb73.Cursor = System.Windows.Forms.Cursors.Hand
        Me.m_cbb73.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.m_cbb73.FormattingEnabled = True
        Me.m_cbb73.Location = New System.Drawing.Point(232, 491)
        Me.m_cbb73.Name = "m_cbb73"
        Me.m_cbb73.Size = New System.Drawing.Size(110, 23)
        Me.m_cbb73.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "출력 타입 :"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(500, 540)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.m_cbb73)
        Me.Controls.Add(Me.m_cbb72)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.m_cbb71)
        Me.Controls.Add(Me.m_btn71)
        Me.Controls.Add(Me.m_btn51)
        Me.Controls.Add(Me.m_btn31)
        Me.Controls.Add(Me.m_txb51)
        Me.Controls.Add(Me.m_txb31)
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
    Friend WithEvents m_txb31 As System.Windows.Forms.TextBox
    Friend WithEvents m_txb51 As System.Windows.Forms.TextBox
    Friend WithEvents m_btn31 As System.Windows.Forms.Button
    Friend WithEvents m_btn51 As System.Windows.Forms.Button
    Friend WithEvents m_btn71 As System.Windows.Forms.Button
    Friend WithEvents m_cbb71 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents m_cbb72 As System.Windows.Forms.ComboBox
    Friend WithEvents m_cbb73 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
