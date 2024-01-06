Imports System
Imports System.Text



''' <summary>
''' 케이스 문자열 변환기 (스네이크케이스, 파스칼케이스, 카멜케이스)
''' 2017/09/12 (heebumjung)
''' </summary>
Public NotInheritable Class CaseConverter
    Private Sub New()
    End Sub


    Public Shared ReadOnly LineGubun_Tab As String = vbTab
    Public Shared ReadOnly LineGubun_NewLine As String = vbNewLine
    Public Shared ReadOnly LineGubun_Comma As String = ","

    Public Shared ReadOnly InputGubun_UnderBar As String = "_"
    Public Shared ReadOnly InputGubun_Hyphen As String = "-"
    Public Shared ReadOnly InputGubun_Point As String = "."
    Public Shared ReadOnly InputGubun_Space As String = " "
    Public Shared ReadOnly InputGubun_Empty As String = String.Empty

    Public Shared ReadOnly OutputType_SnakeUpperCase As String = "SNAKE_CASE"
    Public Shared ReadOnly OutputType_SnakeLowerCase As String = "snake_case"
    Public Shared ReadOnly OutputType_PascalCase As String = "PascalCase"
    Public Shared ReadOnly OutputType_CamelCase As String = "camelCase"


    Private Shared Function _ConvertPascalCase(wd As String) As String
        If String.IsNullOrWhiteSpace(wd) Then
            Return String.Empty
        Else
            Dim tca() As Char = wd.ToCharArray()
            For i As Integer = 0 To tca.Length - 1
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


    Private Shared Sub _TrimWords(wds() As String)
        If (Not wds Is Nothing) AndAlso (wds.Length > 0) Then
            For i As Integer = 0 To wds.Length - 1
                wds(i) = wds(i).Trim()
            Next
        End If
    End Sub


    Private Shared Function _GetWordsExtract(ls As String, dm As String) As String()
        If String.IsNullOrWhiteSpace(ls) Then
            Return Nothing
        Else
            If Not String.IsNullOrEmpty(dm) Then
                Dim rva() As String = ls.Split(
                    {dm}, StringSplitOptions.RemoveEmptyEntries)
                Return rva
            Else
                Const dxc As Char = "|"c
                Dim tsb As New StringBuilder()
                Dim bFirst As Boolean = True
                For Each tc As Char In ls
                    If bFirst Then
                        tsb.Append(tc)
                        bFirst = False
                    Else
                        If Char.IsUpper(tc) Then
                            tsb.Append(dxc)
                            tsb.Append(tc)
                        Else
                            tsb.Append(tc)
                        End If
                    End If
                Next
                If tsb.Length > 0 Then
                    Dim txb As String = tsb.ToString()
                    Dim rva() As String = txb.Split(
                        {dxc}, StringSplitOptions.RemoveEmptyEntries)
                    Return rva
                Else
                    Return Nothing
                End If
            End If
        End If
    End Function


    Public Shared Function ConvertCaseText(ls As String, dm As String, ot As String) As String
        Dim wds() As String = _GetWordsExtract(ls, dm)
        If (wds Is Nothing) OrElse (wds.Length < 1) Then
            Return String.Empty
        Else
            _TrimWords(wds)
            Dim tsb As New StringBuilder()
            Dim bFirst As Boolean = True
            For Each wd As String In wds
                Select Case ot
                    Case OutputType_SnakeUpperCase
                        Dim ds As String
                        If bFirst Then
                            ds = wd.ToUpper()
                            tsb.Append(ds)
                            bFirst = False
                        Else
                            ds = InputGubun_UnderBar & wd.ToUpper()
                            tsb.Append(ds)
                        End If
                    Case OutputType_SnakeLowerCase
                        Dim ds As String
                        If bFirst Then
                            ds = wd.ToLower()
                            tsb.Append(ds)
                            bFirst = False
                        Else
                            ds = InputGubun_UnderBar & wd.ToLower()
                            tsb.Append(ds)
                        End If
                    Case OutputType_PascalCase
                        Dim ds As String = _ConvertPascalCase(wd)
                        tsb.Append(ds)
                    Case OutputType_CamelCase
                        Dim ds As String
                        If bFirst Then
                            ds = wd.ToLower()
                            tsb.Append(ds)
                            bFirst = False
                        Else
                            ds = _ConvertPascalCase(wd)
                            tsb.Append(ds)
                        End If
                End Select
            Next
            Return tsb.ToString()
        End If
    End Function
End Class
