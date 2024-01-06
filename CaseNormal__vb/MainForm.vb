Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms




Public NotInheritable Class MainForm

    Private Shared Function prConvertSnakeCase(wd As String) As String
        Return String.Empty
    End Function


    Private Shared Function prConvertPascalCase(wd As String) As String
        Return String.Empty
    End Function


    Private Shared Function prConvertCamelCase(wd As String) As String
        If String.IsNullOrWhiteSpace(wd) Then
            Return String.Empty
        Else
            Dim tca() As Char = wd.ToCharArray()
            Dim l As Integer = tca.Length
            For i As Integer = 0 To l - 1
                Dim tc As Char = tca(i)
                If i = 0 Then
                    tc = Char.ToUpper(tc)
                Else
                    tc = Char.ToLower(tc)
                End If
                tca(i) = tc
            Next
            Dim rs As String = Convert.ToString(tca)
            Return rs
        End If
    End Function


    Private Shared Function prConvertModelCodes(wds As String, Optional dm As Char = "_"c) As String
        If String.IsNullOrWhiteSpace(wds) Then
            Return String.Empty
        Else
            Dim txa() As String = wds.Split({dm}, StringSplitOptions.RemoveEmptyEntries)
            If txa.Length > 0 Then
                Dim tsb As New StringBuilder()
                Dim bFirst As Boolean = True
                For Each tx As String In txa
                    If bFirst Then
                        tsb.Append(tx.ToLower())
                        bFirst = False
                    Else
                        Dim wd As String = prConvertCamelCase(tx)
                        tsb.Append(wd)
                    End If
                Next
                Return tsb.ToString()
            Else
                Return String.Empty
            End If
        End If
    End Function


    Private Shared Function prConvertCaseText(wds As String, Optional dm As Char = "_"c) As String
        If String.IsNullOrWhiteSpace(wds) Then
            Return String.Empty
        Else
            Dim txa() As String = wds.Split({dm}, StringSplitOptions.RemoveEmptyEntries)
            If txa.Length > 0 Then
                Dim tsb As New StringBuilder()
                For Each tx As String In txa
                    Dim wd As String = prConvertCamelCase(tx)
                    tsb.Append(wd)
                Next
                Return tsb.ToString()
            Else
                Return String.Empty
            End If
        End If
    End Function




    Public Sub New()
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
    End Sub



    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Text = [GetType]().Namespace

        '모니터다 듀얼 이상일때
        Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
        Dim tsb As Rectangle = tcs.WorkingArea
        Dim tlp As Point = New Point(tsb.Right, tsb.Bottom)
        Dim tws As Size = Size
        tlp.Offset(-(tws.Width + 40), -(tws.Height + 40))
        Location = tlp

        AddHandler _btn31.Click, AddressOf pr_btn31__Click
        AddHandler _btn51.Click, AddressOf pr_btn51__Click
        AddHandler _btn52.Click, AddressOf pr_btn52__Click

        _txb51.Text = CaseNormal__Data.Current.InputText
        _cbb51.DataSource = CaseNormal__Data.Current.SptsData
        _cbb51.SelectedItem = CaseNormal__Data.Current.Spt
    End Sub


    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)
        CaseNormal__Data.Current.InputText = _txb51.Text
        CaseNormal__Data.Current.Spt = _cbb51.SelectedItem.ToString()
        CaseNormal__Data.Current.Save()
    End Sub



    Private Sub pr_btn31__Click(sender As Object, e As EventArgs)
        Dim wds As String = _txb31.Text
        If Not String.IsNullOrWhiteSpace(wds) Then
            Clipboard.SetText(wds)
        End If
    End Sub


    Private Sub pr_btn51__Click(sender As Object, e As EventArgs)
        If Clipboard.ContainsText() Then
            Dim wds As String = Clipboard.GetText()
            _txb51.Text = wds
        End If
    End Sub


    Private Sub pr_btn52__Click(sender As Object, e As EventArgs)
        Dim lsa() As String = prGetInputText()
        If (Not lsa Is Nothing) AndAlso (lsa.Length > 0) Then
            Dim tsb As New StringBuilder()
            For Each ls As String In lsa
                Dim wd As String = prConvertModelCodes(ls.Trim())
                wd = $"private String {wd};"
                tsb.AppendLine(wd)
            Next
            _txb31.Text = tsb.ToString()
        End If
    End Sub


    Private Function prGetInputText() As String()
        Dim txt As String = _txb51.Text
        If Not String.IsNullOrWhiteSpace(txt) Then
            Dim tspt As String = _cbb51.SelectedItem.ToString()
            If tspt = "Tab" Then
                tspt = vbTab
            ElseIf tspt = "NewLine" Then
                tspt = vbNewLine
            ElseIf tspt = "Comma" Then
                tspt = ","
            End If
            Dim lsa() As String = txt.Split({tspt}, StringSplitOptions.RemoveEmptyEntries)
            Return lsa
        Else
            Return Nothing
        End If
    End Function


    Private Sub pr_btn71__Click(sender As Object, e As EventArgs) Handles _btn71.Click

    End Sub


    Private Sub pr_btn72__Click(sender As Object, e As EventArgs) Handles _btn72.Click

    End Sub


    ''' <summary>
    ''' 카멜 케이스 변환
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pr_btn73__Click(sender As Object, e As EventArgs) Handles _btn73.Click
        Dim lsa() As String = prGetInputText()
        If (Not lsa Is Nothing) AndAlso (lsa.Length > 0) Then
            Dim tsb As New StringBuilder()
            For Each ls As String In lsa
                Dim wd As String = prConvertCaseText(ls.Trim())
                tsb.AppendLine(wd)
            Next
            _txb31.Text = tsb.ToString()
        End If
    End Sub

End Class
