Imports System
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms




Public NotInheritable Class MainForm
#Region "~~~~~~~~~~ 01) 객체 초기화 부분"
    Public Sub New()
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.
    End Sub


    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)


        Text = $"({[GetType]().Namespace})  v1.07"

        '모니터다 듀얼 이상일때
        Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
        Dim tsb As Rectangle = tcs.WorkingArea
        Dim tlp As Point = New Point(tsb.Right, tsb.Bottom)
        Dim tws As Size = Size
        tlp.Offset(-(tws.Width + 40), -(tws.Height + 40))
        Location = tlp


        CaseDataRoll.Load()

        m_txb51.Text = CaseDataRoll.InputText
        m_cbb71.DisplayMember = "Display"
        m_cbb71.ValueMember = "Value"
        m_cbb71.DataSource = CaseDataRoll.GetLineGubunArr()
        m_cbb71.SelectedValue = CaseDataRoll.LineGubun
        m_cbb72.DisplayMember = "Display"
        m_cbb72.ValueMember = "Value"
        m_cbb72.DataSource = CaseDataRoll.GetInputGubunArr()
        m_cbb72.SelectedValue = CaseDataRoll.InputGubun
        m_cbb73.DisplayMember = "Display"
        m_cbb73.ValueMember = "Value"
        m_cbb73.DataSource = CaseDataRoll.GetOutputTypeArr()
        m_cbb73.SelectedValue = CaseDataRoll.OutputType
    End Sub


    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)

        CaseDataRoll.InputText = m_txb51.Text
        CaseDataRoll.LineGubun = Convert.ToString(m_cbb71.SelectedValue)
        CaseDataRoll.InputGubun = Convert.ToString(m_cbb72.SelectedValue)
        CaseDataRoll.OutputType = Convert.ToString(m_cbb73.SelectedValue)
        CaseDataRoll.Save()
    End Sub
#End Region



#Region "~~~~~~~~~~ 02) 객체 본문"
    ''' <summary>
    ''' 메세지 출력
    ''' </summary>
    Private Sub _MsgLog(msg As String)
        m_txb31.Text = msg
        Beep()
    End Sub


    ''' <summary>
    ''' 입력 텍스트 가져오기
    ''' </summary>
    ''' <returns></returns>
    Private Function _GetInputText() As String()
        Dim txt As String = m_txb51.Text
        If Not String.IsNullOrWhiteSpace(txt) Then
            Dim lga As String() = {Convert.ToString(m_cbb71.SelectedValue)}
            Dim lsa() As String = txt.Split(lga, StringSplitOptions.RemoveEmptyEntries)
            Return lsa
        Else
            Return Nothing
        End If
    End Function



    ''' <summary>
    ''' 출력 클립보드 복사
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _btn31__Click(sender As Object, e As EventArgs) Handles m_btn31.Click
        Dim wds As String = m_txb31.Text
        If Not String.IsNullOrWhiteSpace(wds) Then
            Clipboard.SetText(wds)
        End If
    End Sub


    ''' <summary>
    ''' 입력 클립보드 붙여넣기
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _btn51__Click(sender As Object, e As EventArgs) Handles m_btn51.Click
        If Clipboard.ContainsText() Then
            Dim wds As String = Clipboard.GetText()
            m_txb51.Text = wds
        End If
    End Sub




    ''' <summary>
    ''' 카멜 케이스 변환
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _btn71__Click(sender As Object, e As EventArgs) Handles m_btn71.Click
        Dim lsa() As String = _GetInputText()
        If (Not lsa Is Nothing) AndAlso (lsa.Length > 0) Then
            Dim dm As String = Convert.ToString(m_cbb72.SelectedValue)
            Dim ot As String = Convert.ToString(m_cbb73.SelectedValue)
            Dim tsb As New StringBuilder()
            For Each ls As String In lsa
                Dim wd As String = CaseConverter.ConvertCaseText(ls.Trim(), dm, ot)
                tsb.AppendLine(wd)
            Next
            m_txb31.Text = tsb.ToString()
        End If
    End Sub
#End Region

End Class

